using System;
using System.Collections.Generic;

namespace ES.Models
{
    [Serializable]
    public class Domain
    {
        public string Name { get; set; }
        public List<DomainValue> Values { get; set; }
        public Domain()
        {
            Values = new List<DomainValue>();
        }
        public Domain(string name)
        {
            Name = name;
            Values = new List<DomainValue>();
        }
        public bool AddValue(string value)
        {
            if (GetValue(value) != null)
                return false;
            Values.Add(new DomainValue(value));
            return true;
        }
        public bool DeleteValue(int index)
        {   
             Values.RemoveAt(index);
            return true;
        }
        public bool ChangeValueOrder(int newOrder, string value)
        {
            var x = GetValue(value);
            return x != null;
        }

        public bool EditValue(int indexValue, string newValue)
        {
            var v = GetValue(newValue);
            if (v != null &&  v != Values[indexValue])
                return false;
            Values[indexValue].Value = newValue;
            return true;
        }

        public Domain Copy()
        {
            var d = new Domain(Name);
            foreach (var v in Values)
            {
                d.Values.Add(v);
            }
            return d;
        }

        DomainValue GetValue(string value)
        {
            return Values.Find(t => t.Value == value);
        }
    }
}
