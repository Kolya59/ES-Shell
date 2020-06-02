using System;

namespace ES.Models
{
    public enum FactType {
        premise,
        conclusion}

    [Serializable]
    public class Statement
    {
        public Variable Variable { get; set; }
        public string Value { get; set; }
         public Statement() {}
        public Statement(Variable variable, string value)
        {
            Variable = variable;
            Value = value;
        }

        public override string ToString()
        {
            return Variable.Name + " = " + Value;
        }
    }
}
