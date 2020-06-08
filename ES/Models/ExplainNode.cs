using System.Collections.Generic;

namespace ES.Models
{
    public class ExplainNode
    {
        public Statement Goal { get; }
        public Rule FiredRule { get; }
        public bool Asked { get; }
        public List <ExplainNode> SubGoals { get; }

        // Value was asked
        public ExplainNode(Statement goal)
        {
            SubGoals = new List<ExplainNode>();
            Asked = true;
            Goal = goal;
        }

        // Value was deducted
        public ExplainNode(Statement goal, Rule firedRule)
        {
            Asked = false;
            Goal = goal;
            FiredRule = firedRule;
            SubGoals = new List<ExplainNode>();
        }
    }
}
