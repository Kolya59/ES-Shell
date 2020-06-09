using System;
using System.Windows.Forms;
using ES.Models;

namespace ES.Forms
{
    public partial class FormRule : Form
    {
        public enum Modes { add, edit }

        private readonly Modes _mode;
        private readonly KnowledgeBase _kBase;
        private readonly Rule _rule;
        private readonly int _ruleIndex;
        private readonly int _insertAfterIdx;
        // Add rule
        public FormRule(int insertAfterIdx, Modes mode, KnowledgeBase kBase)
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
        public FormRule(Modes mode, KnowledgeBase kBase, int ruleIndex)
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
            btConditionUp.Enabled = false;
            btConditionDown.Enabled = false;
            btConclusionUp.Enabled = false;
            btConclusionDown.Enabled = false;
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
            lbConditions.Items.Clear();
            foreach (var p in _rule.Condition)
                lbConditions.Items.Add(p.ToString());
            if (lbConditions.Items.Count > 0)
                lbConditions.SelectedIndex = 0;
            lbConclusion.Items.Clear();
            foreach (var p in _rule.Conclusion)
                lbConclusion.Items.Add(p.ToString());
            if (lbConclusion.Items.Count > 0)
                lbConclusion.SelectedIndex = 0;
        }

        private void buttonAddPremise_Click(object sender, EventArgs e)
        {
            var f = new FormStatement(FormStatement.Modes.add, FactType.premise, _kBase, _rule);
            if (f.ShowDialog() != DialogResult.OK) return;
            FillList();
            lbConditions.SelectedIndex = lbConditions.Items.Count  - 1;
        }
        
        private void buttonAddConclusion_Click(object sender, EventArgs e)
        {
            var f = new FormStatement(FormStatement.Modes.add, FactType.conclusion, _kBase, _rule);
            if (f.ShowDialog() != DialogResult.OK) return;
            FillList();
            lbConclusion.SelectedIndex = lbConclusion.Items.Count - 1;
        }

        private void listBoxPremises_SelectedIndexChanged(object sender, EventArgs e)
        {
            btDeletePremise.Enabled = lbConditions.SelectedIndex >= 0;
            btEditPremise.Enabled = lbConditions.SelectedIndex >= 0;
            btConditionUp.Enabled = lbConditions.SelectedIndex >= 1 && lbConditions.Items.Count > 1;
            btConditionDown.Enabled = lbConditions.SelectedIndex < lbConditions.Items.Count - 1 && lbConditions.Items.Count > 1;
        }

        private void listBoxConclusion_SelectedIndexChanged(object sender, EventArgs e)
        {
            btDeleteConclusion.Enabled = lbConclusion.SelectedIndex >= 0;
            btEditConclusion.Enabled = lbConclusion.SelectedIndex >= 0;
            btConclusionUp.Enabled = lbConclusion.SelectedIndex >= 1 && lbConclusion.Items.Count > 1;
            btConclusionDown.Enabled = lbConclusion.SelectedIndex < lbConclusion.Items.Count - 1 && lbConclusion.Items.Count > 1;
        }

        private void buttonEditPremise_Click(object sender, EventArgs e)
        {
            var f = new FormStatement(FormStatement.Modes.edit, FactType.premise, _kBase, _rule, lbConditions.SelectedIndex);
            if (f.ShowDialog() != DialogResult.OK) return;
            FillList();
            lbConditions.SelectedIndex = lbConditions.Items.Count - 1;
        }


        private void buttonEditConclusion_Click(object sender, EventArgs e)
        {
            var f = new FormStatement(FormStatement.Modes.edit, FactType.conclusion, _kBase, _rule, lbConditions.SelectedIndex);
            if (f.ShowDialog() != DialogResult.OK) return;
            FillList();
            lbConclusion.SelectedIndex = lbConclusion.Items.Count - 1;
        }

        private void buttonDeletePremise_Click(object sender, EventArgs e)
        {
            _rule.DeletePremiseFact(lbConditions.SelectedIndex);
            FillList();
            lbConditions.SelectedIndex = _rule.Condition.Count - 1;
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

        private void btConditionUp_Click(object sender, EventArgs e)
        {
            var oldId = lbConditions.SelectedIndex;
            var old = _rule.Condition[oldId];
            lbConditions.Items.RemoveAt(oldId);
            lbConditions.Items.Insert(oldId-1, old.ToString());
            _rule.Condition[oldId] = _rule.Condition[oldId - 1];
            _rule.Condition[oldId - 1] = old;
        }

        private void btConditionDown_Click(object sender, EventArgs e)
        {
            var oldId = lbConditions.SelectedIndex;
            var old = _rule.Condition[oldId];
            lbConditions.Items.RemoveAt(oldId);
            lbConditions.Items.Insert(oldId+1, old.ToString());
            _rule.Condition[oldId] = _rule.Condition[oldId + 1];
            _rule.Condition[oldId + 1] = old;
        }
        
        private void btConclusionUp_Click(object sender, EventArgs e)
        {
            var oldId = lbConclusion.SelectedIndex;
            var old = _rule.Conclusion[oldId];
            lbConclusion.Items.RemoveAt(oldId);
            lbConclusion.Items.Insert(oldId-1, old.ToString());
            _rule.Conclusion[oldId] = _rule.Conclusion[oldId - 1];
            _rule.Conclusion[oldId - 1] = old;
        }

        private void btConclusionDown_Click(object sender, EventArgs e)
        {
            var oldId = lbConclusion.SelectedIndex;
            var old = _rule.Conclusion[oldId];
            lbConclusion.Items.RemoveAt(oldId);
            lbConclusion.Items.Insert(oldId+1, old.ToString());
            _rule.Conclusion[oldId] = _rule.Conclusion[oldId + 1];
            _rule.Conclusion[oldId + 1] = old;
        }
    }
}
