
using System;

namespace ES.Models
{
    public class UserAskLog
    {
        private string Question { get; }
        private string Answer { get; }

        public UserAskLog(string question, string answer)
        {
            Question = question;
            Answer = answer;
        }

        public override string ToString() => $"> {Question}: {Answer}{Environment.NewLine}";
    }
}
