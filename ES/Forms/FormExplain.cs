using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ES.Models;

namespace ES.Forms
{
    public partial class FormExplain : Form
    {
        private readonly ExplainNode _explainTree;
        private readonly List<Log> _logs;
        private readonly List<Statement> _knownFacts;

        public FormExplain(ExplainNode explainTree, List<Log> logs, List<Statement> knownFacts)
        {
            InitializeComponent();
            _explainTree = explainTree;
            _logs = logs;
            _knownFacts = knownFacts;
            FillForm();
            CenterToScreen();
        }

        private void FillForm()
        {
            foreach(var log in _logs)
            {
                readOnlyLogs.Text += log.ToString();
            }

            foreach(var fact in _knownFacts)
            {
                listBoxKnownFacts.Items.Add(fact.ToString());
            }

            treeViewExplain.BeginUpdate();
            var node = new TreeNode();
            AddNodesToTreeView(node, _explainTree);
            treeViewExplain.Nodes.Add(node.Nodes[0]);
            treeViewExplain.EndUpdate();
        }

        private static void AddNodesToTreeView(TreeNode tree, ExplainNode node)
        {
            if (node.Asked)
            {
                tree.Nodes.Add($"Goal: {node.Goal} (queried)");
            }
            else
            {
                tree.Nodes.Add($"Goal: {node.Goal} (deducted)");
                tree.Nodes[tree.Nodes.Count - 1].Nodes.Add($"IF {node.FiredRule.PrintCondition()}");
                tree.Nodes[tree.Nodes.Count - 1].Nodes.Add($"THEN {node.FiredRule.PrintConclusion()}");
                foreach(var child in node.SubGoals)
                {
                    AddNodesToTreeView(tree.Nodes[tree.Nodes.Count - 1], child);
                }
            }
        }

        private static void ExpandTreeView(TreeNode tree)
        {
            tree.Expand();
            foreach (TreeNode node in tree.Nodes)
                ExpandTreeView(node);
        }

        private static void CollapseTreeView(TreeNode tree)
        {
            tree.Collapse();
        }

        private void btExpandTree_Click(object sender, EventArgs e)
        {
            ExpandTreeView(treeViewExplain.Nodes[0]);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btCollapse_Click(object sender, EventArgs e)
        {
            CollapseTreeView(treeViewExplain.Nodes[0]);
        }
    }
}
