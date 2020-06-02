using System;

namespace ES.Models
{
    public enum VariableType { query, queryConclusion, conclusion}
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
    }
}
