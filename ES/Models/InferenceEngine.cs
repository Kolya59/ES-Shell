using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ES.ESForm;

namespace ES.Models
{
    public class InferenceEngine
    {
        private readonly KnowledgeBase _kBase;
        private Variable PrimaryGoal { get; set; }
        private Stack<Variable> _goals;
        private List<Rule> _firedRules;
        private List<Rule> _wrongRules;
        private List<ExplainNode> _explainNodes;

        public ExplainNode ExplainTree { get; set; }
        public List<UserAskLog> userAskLogs;
        public List<Statement> KnownFacts { get; set; }
        public InferenceEngine(KnowledgeBase kBase)
        {
            _kBase = kBase;
        }
        
        public void SetPrimaryGoal(Variable primaryGoal)
        {
            PrimaryGoal = primaryGoal;
        }
        
        public Statement Start()
        {
            if (PrimaryGoal == null)
                throw new Exception("primary goal does not set");

            _goals = new Stack<Variable>();
            KnownFacts = new List<Statement>();
            _firedRules = new List<Rule>();
            _wrongRules = new List<Rule>();
            userAskLogs = new List<UserAskLog>();
            _explainNodes = new List<ExplainNode>();
            _goals.Push(PrimaryGoal);
            while(_goals.Count > 0)
            {
                var currentGoal = _goals.Peek();
                //если уже известна, то удалить
                if (KnownFacts.Find(x => x.Variable.Name == currentGoal.Name) != null)
                {
                    _goals.Pop();
                    continue;
                }
                //если запрашиваемая, то запросить значение
                if (currentGoal.Type == VariableType.query)
                {
                    var fact = new Statement();
                    fact.Variable = currentGoal;
                    var f = new FormAsk(fact);
                    if (DialogResult.OK != f.ShowDialog()) return null;
                    _goals.Pop();
                    KnownFacts.Add(fact);
                    userAskLogs.Add(new UserAskLog(fact.Variable.Question, fact.Value));
                    AddNewExplainNodeAsked(fact);
                    continue;
                }

                //если нет, то 
                //искать среди правил, где эта переменная в заключении
                var r = _kBase.Rules.Find(x => 
                                    x.Conclusion.Find(c => 
                                    c.Variable.Name == currentGoal.Name) != null &&
                                    !_firedRules.Contains(x) &&
                                    !_wrongRules.Contains(x));

                //если найдено, то
                if (r != null)
                {
                    //проверить, есть ли все известные факты
                    var f = true;
                    var good = true;
                    foreach (var condition in r.Condition)
                    {
                        var known = KnownFacts.Find(x => x.Variable.Name == condition.Variable.Name);
                        if (known == null || known.Value != condition.Value) good = false;
                        if (known != null) continue;
                        _goals.Push(condition.Variable);
                        f = false;
                    }

                    if (!f) continue;
                    if (good)
                    {
                        _firedRules.Add(r);
                        Statement goalStatement = null;
                        foreach (var c in r.Conclusion)
                        {
                            KnownFacts.Add(c);
                            if (c.Variable.Name == currentGoal.Name)
                                goalStatement = c;
                        }
                        AddNewExplainNode(r, goalStatement);
                        _goals.Pop();
                    }
                    else
                    {
                        _wrongRules.Add(r);
                    }
                    //иначе добавить все предпосылки в стек
                }
                //иначе 
                else
                {
                    //если это выводимо-запрашиваемая, но не ГЛАВНАЯ ЦЕЛЬ, то запросить
                    if (currentGoal.Type == VariableType.queryConclusion)
                    {
                        var statement = new Statement();
                        statement.Variable = currentGoal;
                        var f = new FormAsk(statement);
                        if (DialogResult.OK == f.ShowDialog())
                        {
                            _goals.Pop();
                            KnownFacts.Add(statement);
                            userAskLogs.Add(new UserAskLog(statement.Variable.Question, statement.Value));
                            AddNewExplainNodeAsked(statement);
                        }
                        else
                        {
                            return null;
                        }
                    }
                    else
                    {
                        //иначе не удалось вывести значение
                        return null;
                    }
                }
            }
            var res = KnownFacts.Find(x => x.Variable.Name == PrimaryGoal.Name);
            if (res == null) return null;
            {
                ExplainTree = _explainNodes.Find(x => x.Goal.Variable.Name == PrimaryGoal.Name);
                return res;
            }
        }

        private void AddNewExplainNode(Rule firedRule, Statement knownStatementGoal)
        {
            var node = new ExplainNode(knownStatementGoal, firedRule);
            
            foreach (var child in firedRule.Condition.Select(f =>
                _explainNodes.Find(x => x.Goal.Variable.Name == f.Variable.Name)))
            {
                node.SubGoals.Add(child);
            }
            _explainNodes.Add(node);
        }

        private void AddNewExplainNodeAsked(Statement knownStatementGoal)
        {
            _explainNodes.Add(new ExplainNode(knownStatementGoal));
        }     
    }
}
