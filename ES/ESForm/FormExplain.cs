using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ES.Models;

namespace ES.ESForm
{
    public partial class FormExplain : Form
    {
        ExplainNode _explainTree;
        List<UserAskLog> _logs;
        List<Statement> _knownFacts;

        public FormExplain(ExplainNode explainTree, List<UserAskLog> logs, List<Statement> knownFacts)
        {
            InitializeComponent();
            SetStyle();
            _explainTree = explainTree;
            _logs = logs;
            _knownFacts = knownFacts;
            FillForm();
            CenterToScreen();
        }

        void FillForm()
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

        void AddNodesToTreeView(TreeNode tree, ExplainNode node)
        {
            if (node.Asked)
            {
                tree.Nodes.Add("Цель: " + node.Goal + " (запрошено)");
            }
            else
            {
                tree.Nodes.Add("Цель: " + node.Goal + " (выведено)");
                tree.Nodes[tree.Nodes.Count - 1].Nodes.Add("ЕСЛИ " + node.FiredRule.PrintPremise());
                tree.Nodes[tree.Nodes.Count - 1].Nodes.Add("ТОГДА " + node.FiredRule.PrintConclusion());
                foreach(var potomok in node.SubGoals)
                {
                    AddNodesToTreeView(tree.Nodes[tree.Nodes.Count - 1], potomok);
                }
            }
        }

        void ExpandTreeView(TreeNode tree)
        {
            tree.Expand();
            foreach (TreeNode node in tree.Nodes)
                ExpandTreeView(node);
        }

        private void SetStyle()
        {
            BackColor = SystemColors.ControlLightLight;
            var buttonBorder = Color.Silver;
            buttonExpandTree.FlatStyle = FlatStyle.Flat;
            buttonExpandTree.FlatAppearance.BorderColor = buttonBorder;
            buttonExpandTree.BackColor = SystemColors.ControlLightLight;
        }

        private void buttonExpandTree_Click(object sender, EventArgs e)
        {
            ExpandTreeView(treeViewExplain.Nodes[0]);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
