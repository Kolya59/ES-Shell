using System;
using System.Windows.Forms;
using ES.Models;

namespace ES.Forms
{
    public partial class FormAddRule : Form
    {
        public enum Modes { add, edit }

        private readonly Modes _mode;
        private readonly KnowledgeBase _kBase;
        private readonly Rule _rule;
        private readonly int _ruleIndex;

        private readonly int _insertAfterIdx;
        // Add rule
        public FormAddRule(int insertAfterIdx, Modes mode, KnowledgeBase kBase)
        {
            InitializeComponent();
            _mode = mode;
            _kBase = kBase;
            _rule = new Rule();
            SetStyle();
            tbRuleName.Text = $"Rule {kBase.Rules.Count}";
            _insertAfterIdx = insertAfterIdx;
        }

        // Edit Rule
        public FormAddRule(Modes mode, KnowledgeBase kBase, int ruleIndex)
        {
            InitializeComponent();
            _mode = mode;
            _kBase = kBase;
            SetStyle();
            _rule = kBase.Rules[ruleIndex].Copy();
            _ruleIndex = ruleIndex;
            FillForm();
        }

        private void SetStyle()
        {
            Text = _mode switch
            {
                Modes.add => "Rule adding",
                Modes.edit => "Rule editing",
                _ => Text
            };
            btEditPremise.Enabled = false; 
            btDeletePremise.Enabled = false;
            btEditConclusion.Enabled = false;
            btDeleteConclusion.Enabled = false;
            CenterToScreen();
        }

        private void FillForm()
        {
            tbRuleName.Text = _rule.Name;
            FillList();
            tbReason.Text = _rule.Description;
        }

        private void FillList()
        {
            lbPremises.Items.Clear();
            foreach (var p in _rule.Condition)
                lbPremises.Items.Add(p.ToString());
            if (lbPremises.Items.Count > 0)
                lbPremises.SelectedIndex = 0;
            lbConclusion.Items.Clear();
            foreach (var p in _rule.Conclusion)
                lbConclusion.Items.Add(p.ToString());
            if (lbConclusion.Items.Count > 0)
                lbConclusion.SelectedIndex = 0;
        }

        private void buttonAddPremise_Click(object sender, EventArgs e)
        {
            var f = new FormAddStatement(FormAddStatement.Modes.add, FactType.premise, _kBase, _rule);
            if (f.ShowDialog() != DialogResult.OK) return;
            FillList();
            lbPremises.SelectedIndex = lbPremises.Items.Count  - 1;
        }
        
        private void buttonAddConclusion_Click(object sender, EventArgs e)
        {
            var f = new FormAddStatement(FormAddStatement.Modes.add, FactType.conclusion, _kBase, _rule);
            if (f.ShowDialog() != DialogResult.OK) return;
            FillList();
            lbConclusion.SelectedIndex = lbConclusion.Items.Count - 1;
        }

        private void listBoxPremises_SelectedIndexChanged(object sender, EventArgs e)
        {
            btDeletePremise.Enabled = lbPremises.SelectedIndex >= 0;
            btEditPremise.Enabled = lbPremises.SelectedIndex >= 0;
        }

        private void listBoxConclusion_SelectedIndexChanged(object sender, EventArgs e)
        {
            btDeleteConclusion.Enabled = lbConclusion.SelectedIndex >= 0;
            btEditConclusion.Enabled = lbConclusion.SelectedIndex >= 0;
        }

        private void buttonEditPremise_Click(object sender, EventArgs e)
        {
            var f = new FormAddStatement(FormAddStatement.Modes.edit, FactType.premise, _kBase, _rule, lbPremises.SelectedIndex);
            if (f.ShowDialog() != DialogResult.OK) return;
            FillList();
            lbPremises.SelectedIndex = lbPremises.Items.Count - 1;
        }


        private void buttonEditConclusion_Click(object sender, EventArgs e)
        {
            var f = new FormAddStatement(FormAddStatement.Modes.edit, FactType.conclusion, _kBase, _rule, lbPremises.SelectedIndex);
            if (f.ShowDialog() != DialogResult.OK) return;
            FillList();
            lbConclusion.SelectedIndex = lbConclusion.Items.Count - 1;
        }

        private void buttonDeletePremise_Click(object sender, EventArgs e)
        {
            _rule.DeletePremiseFact(lbPremises.SelectedIndex);
            FillList();
            lbPremises.SelectedIndex = _rule.Condition.Count - 1;
        }

        private void buttonDeleteConclusion_Click(object sender, EventArgs e)
        {
            _rule.DeleteConclusionFact(lbConclusion.SelectedIndex);
            FillList();
            lbConclusion.SelectedIndex = _rule.Conclusion.Count - 1;
        }

        private static void EmptyName()
        {
            MessageBox.Show("Empty rule name", "Error");
        }
        
        private static void EmptyPremise()
        {
            MessageBox.Show("Empty condition", "Error");
        }

        private static void EmptyConclusion()
        {
            MessageBox.Show("Empty conclusion", "Error");
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if(tbRuleName.Text == "")
            {
                EmptyName();
                return;
            }

            if (_rule.Condition.Count == 0)
            {
                EmptyPremise();
                return;
            }

            if (_rule.Conclusion.Count == 0)
            {
                EmptyConclusion();
                return;
            }
            _rule.Name = tbRuleName.Text;
            _rule.Description = tbReason.Text;
            if (_mode == Modes.add)
            {
                if (!_kBase.AddRule(_insertAfterIdx, _rule))
                    return;
            }
            else
            {
                if (!_kBase.EditRule(_rule, _ruleIndex))
                    return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
