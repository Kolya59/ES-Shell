using System;
using System.Collections.Generic;

namespace ES.Models
{
    public enum VariableType { queried, queryDeduced, deduced}
    [Serializable]
    public class Variable
    {
        public string Name { get; set; }
        public Domain Domain { get; set; }
        public string Question { get; set; }
        public VariableType Type { get; set; }
        public Variable(string name, string domainName, string question, VariableType type)
        {
            Name = name;
            Domain = new Domain(domainName);
            Type = type;
            Question = question;
        }
        public Variable(string name, Domain domain, string question, VariableType type)
        {
            Name = name;
            Domain = domain;
            Type = type;
            Question = question;
        }
        public Variable() { }

        public Variable Copy()
        {
            return new Variable(Name, Domain, Question, Type);
        }

        private sealed class VariableEqualityComparer : IEqualityComparer<Variable>
        {
            public bool Equals(Variable x, Variable y)
            {
                return x.Name == y.Name;
            }

            public int GetHashCode(Variable obj)
            {
                return obj.Name.GetHashCode();
            }
        }

        public static IEqualityComparer<Variable> VariableComparer { get; } = new VariableEqualityComparer();
    }
}
