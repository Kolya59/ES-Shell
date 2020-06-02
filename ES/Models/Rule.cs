using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ES.Models
{
    [Serializable]
    public class Rule
    {
        public string Name { get; set; }
        public List<Statement> Condition { get; set; }
        public List<Statement> Conclusion { get; set; }
        public string Reason { get; set; }
        public Rule(string name, List<Statement> premise, List<Statement> conclusion, string reason)
        {
            Condition = new List<Statement>();
            foreach (var f in premise)
                Condition.Add(f);
            Conclusion = new List<Statement>();
            foreach (var f in conclusion)
                Conclusion.Add(f);
            Reason = reason;
            Name = name;
        }

        public Rule()
        {
            Condition = new List<Statement>();
            Conclusion = new List<Statement>();
        }
        public Rule Copy()
        {
            return new Rule(Name, Condition, Conclusion, Reason);
        }

        public override string ToString()
        {
            var r = "ЕСЛИ " +  PrintPremise();
            r += " ТОГДА " + PrintConclusion();
            return r;
        }

        public bool AddPremiseFact(Statement f)
        {
            if (Condition.Exists(x => x.Variable == f.Variable))
            {
                FactAlreadyExistsError();
                return false;
            }
            Condition.Add(f);
            return true;
        }

        public bool EditPremiseFact(int indexFact, Statement f)
        {
            if (Condition.Exists(x => x.Variable == f.Variable) && Condition.FindIndex(x => x.Variable == f.Variable) != indexFact)
            {
                FactAlreadyExistsError();
                return false;
            }
            Condition[indexFact] = f;
            return true;
        }

        public bool DeletePremiseFact(int indexFact)
        {
             Condition.RemoveAt(indexFact);
            return true;
        }

        public bool AddConclusionFact(Statement f)
        {
            if (Conclusion.Exists(x => x.Variable == f.Variable))
            {
                FactAlreadyExistsError();
                return false;
            }
            Conclusion.Add(f);
            return true;
        }

        public bool EditConclusionFact(int indexFact, Statement f)
        {
            if (Conclusion.Exists(x => x.Variable == f.Variable) && 
                Conclusion.FindIndex(x => x.Variable == f.Variable) != indexFact)
            {
                FactAlreadyExistsError();
                return false;
            }
            Conclusion[indexFact] = f;
            return true;
        }

        public bool DeleteConclusionFact(int indexFact)
        {
            Conclusion.RemoveAt(indexFact);
            return true;
        }

        public string PrintPremise()
        {
            var r = "";
            for (var i = 0; i < Condition.Count; i++)
            {
                r += Condition[i].ToString();
                if (i < Condition.Count - 1)
                    r += " И ";
            }
            return r;
        }

        public string PrintConclusion()
        {
            var r = "";
            for (var i = 0; i < Conclusion.Count; i++)
            {
                r += Conclusion[i].ToString();
                if (i < Conclusion.Count - 1)
                    r += " И ";
            }
            return r;
        }

        private void FactAlreadyExistsError()
        {
            MessageBox.Show("Факт с этой переменной уже существует в правиле");
        }
    }
}
