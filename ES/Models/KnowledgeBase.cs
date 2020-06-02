using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ES.Models
{
    [Serializable]
    public class KnowledgeBase
    {
        public List<Domain> Domains { get; set; }
        public List<Variable> Vars { get; set; }
        public List<Rule> Rules { get; set; }
        public int LastRuleNumber { get; set; }
        public int LastVarNumber { get; set; }
        public int LastDomainNumber { get; set; }
        public bool IsChanged { get; set; }
        public KnowledgeBase ()
        {
            Domains = new List<Domain>();
            Vars = new List<Variable>();
            Rules = new List<Rule>();
            IsChanged = false;
        }

        #region Domains
        public bool AddDomain(int indexInsertAfter, Domain domain)
        {
            if(Domains.Exists(x => x.Name == domain.Name))
            {
                AlreadyExistsError("Домен");
                return false;
            }
            if(domain.Values.Count == 0)
            {
                DomainCantBeEmptyError();
                return false;
            }
            Domains.Insert(indexInsertAfter, domain);
            IsChanged = true;
            LastDomainNumber++;
            return true;
        }

        public bool EditDomain(Domain domain, int indexDomain)
        {
            if(Domains.Find(x => x.Name == domain.Name) != null && 
               Domains.FindIndex(x => x.Name == domain.Name) != indexDomain)
            {
                AlreadyExistsError("Домен");
                return false;
            }
            if (domain.Values.Count == 0)
            {
                DomainCantBeEmptyError();
                return false;
            }
            Domains[indexDomain] = domain;
            IsChanged = true;
            return true;
        }

        public bool DeleteDomain(int indexDomain)
        {
            Domains.RemoveAt(indexDomain);
            IsChanged = true;
            return true;
        }

        public bool IsDomainValueUsed(Domain domain, string value)
        {
            var notUsed = true;
            for (var i=0; i<Rules.Count && notUsed; i++)
            {
                for (var j=0; j< Rules[i].Condition.Count && notUsed; j++)
                {
                    notUsed = !(Rules[i].Condition[j].Variable.Domain.Name == domain.Name && 
                        (Rules[i].Condition[j].Value.Trim() == value));
                }
                for (var j = 0; j < Rules[i].Conclusion.Count && notUsed; j++)
                {
                    notUsed = !(Rules[i].Conclusion[j].Variable.Domain.Name == domain.Name &&
                        (Rules[i].Conclusion[j].Value.Trim() == value));
                }

            }
            return !notUsed;
        }
        #endregion

        #region Vars
        public bool AddVar(Variable var)
        {
            if (Vars.Exists(x => x.Name == var.Name))
            {
                AlreadyExistsError("Переменная");
                return false;
            }
            if (var.Domain == null)
            {
                DomainCantBeEmptyError();
                return false;
            }
            Vars.Insert(0, var);
            IsChanged = true;
            LastVarNumber++;
            return true;
        }
        public bool EditVar(Variable var, int indexVar)
        {
            if (Vars.Find(x => x.Name == var.Name) != null &&
                Vars.FindIndex(x => x.Name == var.Name) != indexVar)
            {
                AlreadyExistsError("Переменная");
                return false;
            }
            if (var.Domain == null)
            {
                DomainCantBeEmptyError();
                return false;
            }
            Vars[indexVar] = var;
            IsChanged = true;
            return true;
        }

        public bool DeleteVar(int indexVar)
        {
            Vars.RemoveAt(indexVar);
            IsChanged = true;
            return true;
        }

        public Variable GetVarByName(string varName) => Vars.Find(x => x.Name == varName);

        public bool IsVarUsed(string var)
        {
            var notUsed = true;
            for (var i = 0; i < Rules.Count && notUsed; i++)
            {
                for (var j = 0; j < Rules[i].Condition.Count && notUsed; j++)
                {
                    notUsed = Rules[i].Condition[j].Variable.Name != var;
                }
                for (var j = 0; j < Rules[i].Conclusion.Count && notUsed; j++)
                {
                    notUsed = Rules[i].Conclusion[j].Variable.Name != var;
                }

            }
            return !notUsed;
        }

        public List<Variable> GetGoals() => Vars.Where(v => v.Type != VariableType.query).ToList();

        #endregion

        #region Rules
        public bool AddRule(int insertAfterIdx, Rule var)
        {
            if (Rules.Exists(x => x.Name == var.Name))
            {
                AlreadyExistsError("Правило");
                return false;
            }
       
            Rules.Insert(insertAfterIdx, var);
            IsChanged = true;
            LastRuleNumber++;
            return true;
        }

        public bool EditRule(Rule rule, int indexVar)
        {
            if (Rules.Find(x => x.Name == rule.Name) != null &&
                Rules.FindIndex(x => x.Name == rule.Name) != indexVar)
            {
                AlreadyExistsError("Правило");
                return false;
            }
            Rules[indexVar] = rule;
            IsChanged = true;
            return true;
        }

        public bool DeleteRule(int indexRule)
        {
            Rules.RemoveAt(indexRule);
            IsChanged = true;
            return true;
        }
        #endregion

        #region Errors

        private void AlreadyExistsError(string obj)
        {
            MessageBox.Show($@"{obj} с таким именем уже существует");
        }

        private void DomainCantBeEmptyError()
        {
            MessageBox.Show("Множество значений домена не может быть пустым");
        }

        #endregion
    }
}
