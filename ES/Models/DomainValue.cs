using System;

namespace ES.Models
{
   [Serializable]
   public class DomainValue
    {
        public string Value { get; set; }
        public DomainValue() { }
        public DomainValue(string value)
        {
            Value = value;
        }

    }
}
