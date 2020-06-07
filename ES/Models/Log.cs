
using System;

namespace ES.Models
{
    public class Log
    {
        private string Question { get; }
        private string Answer { get; }

        public Log(string question, string answer)
        {
            Question = question;
            Answer = answer;
        }

        public override string ToString() => $"> {Question}: {Answer}{Environment.NewLine}";
    }
}
