﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ES.Forms;

namespace ES.Models
{
    public class InferenceEngine
    {
        private readonly KnowledgeBase _kBase;
        private Variable PrimaryGoal { get; set; }
        private Stack<Variable> _goals;
        private List<Rule> _executedRules;
        private List<Rule> _wrongRules;
        private List<ExplainNode> _explainNodes;

        public ExplainNode ExplainTree { get; private set; }
        public List<Log> log;
        public List<Statement> WorkingMemory { get; private set; }
        public InferenceEngine(KnowledgeBase kBase)
        {
            _kBase = kBase;
        }
        
        public void SetPrimaryGoal(Variable primaryGoal)
        {
            PrimaryGoal = primaryGoal;
        }

        // TODO: Разорбрать
        public Statement Start()
        {
            if (PrimaryGoal == null) { throw new Exception("primary goal does not set"); }

            _goals = new Stack<Variable>();
            WorkingMemory = new List<Statement>();
            _executedRules = new List<Rule>();
            _wrongRules = new List<Rule>();
            log = new List<Log>();
            _explainNodes = new List<ExplainNode>();
            _goals.Push(PrimaryGoal);
            var counter = 1;
            var hGoals = 0;
            var hWorkingMemory = 0;
            var hExecutedRules = 0;
            var hWrongRules = 0;
            // Пока не означены все целевые переменные
            while(_goals.Count > 0)
            {
                if (hGoals == _goals.GetHashCode() && hWorkingMemory == WorkingMemory.GetHashCode() &&
                    hExecutedRules == _executedRules.GetHashCode() && hWrongRules == _wrongRules.GetHashCode())
                {
                    throw new Exception("Goal is not reached");
                }
                // Получаем очередную цель
                var currentGoal = _goals.Peek();
                // Если целевая переменная означена - переходим к следующей
                if (WorkingMemory.Find(x => x.Variable.Name == currentGoal.Name) != null)
                {
                    _goals.Pop();
                    continue;
                }
                // Если целевая переменная запрашиваемая - запрашиваем
                if (currentGoal.Type == VariableType.queried)
                {
                    var statement = new Statement {Variable = currentGoal};
                    if (DialogResult.OK != new FormAsk(statement, counter).ShowDialog()) return null;
                    counter++;
                    _goals.Pop();
                    WorkingMemory.Add(statement);
                    log.Add(new Log(statement.Variable.Question, statement.Value));
                    AddNewExplainNodeAsked(statement);
                    continue;
                }

                // Поиск несработавшего правила с целевой переменной в заключении
                var r = _kBase.Rules.Except(_executedRules)
                    .Except(_wrongRules)
                    .FirstOrDefault(rule => rule.Conclusion.Exists(c => c.Variable.Name == currentGoal.Name));
                if (r != null)
                {
                    var foundNewGoal = false;
                    var isWrong = false;
                    // Для каждого утверждения в послыке
                    foreach (var condition in r.Condition)
                    {
                        // Если переменная означена, то сверяем значение с утверждением
                        var known = WorkingMemory.Find(x => x.Variable.Name == condition.Variable.Name);
                        if (known == null || known.Value != condition.Value) isWrong = true;
                        if (known != null) continue;
                        _goals.Push(condition.Variable);
                        foundNewGoal = true;
                    }

                    if (foundNewGoal) continue;

                    if (isWrong)
                    {
                        _wrongRules.Add(r);
                        continue;
                    }
                    
                    // Помечаем правило как сработавшее
                    _executedRules.Add(r);
                    
                    // Запоминаем значения всех переменных из посылки
                    foreach (var c in r.Conclusion) { WorkingMemory.Add(new Statement {Variable = c.Variable, Value = c.Value}); }
                    
                    // Добавляем запись о результате в лог
                    AddNewExplainNode(r, r.Conclusion.Find(c => c.Variable.Name == currentGoal.Name));
                    // Извлекаем переменную из целей
                    _goals.Pop();
                }
                else
                {
                    // Если это выводимо-запрашиваемая, но не ГЛАВНАЯ ЦЕЛЬ, то запросить
                    if (currentGoal.Type != VariableType.queryDeduced)
                    {
                        throw new Exception("Goal is not reached");
                    }

                    var statement = new Statement {Variable = currentGoal};
                    var f = new FormAsk(statement, counter);
                    counter++;
                    if (DialogResult.OK != f.ShowDialog())
                    {
                        return null;
                    }

                    _goals.Pop();
                    WorkingMemory.Add(statement);
                    log.Add(new Log(statement.Variable.Question, statement.Value));
                    AddNewExplainNodeAsked(statement);
                }
            }

            var res = WorkingMemory.Find(x => x.Variable.Name == PrimaryGoal.Name);
            if (res != null)
            {
                ExplainTree = _explainNodes.Find(x => x.Goal.Variable.Name == PrimaryGoal.Name);

            }
            return res;
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
