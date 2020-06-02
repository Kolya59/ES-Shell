using System;
using System.Drawing;
using System.Windows.Forms;
using ES.Models;

namespace ES.ESForm
{
    public partial class FormAddRule : Form
    {
        public enum Modes { add, edit }
        Modes _mode;
        KnowledgeBase _kBase;
        Rule _rule;
        int _ruleIndex;
        int _insertAfterIdx;
        //добавление
        public FormAddRule(int insertAfterIdx, Modes mode, KnowledgeBase kBase)
        {
            InitializeComponent();
            _mode = mode;
            _kBase = kBase;
            _rule = new Rule();
            SetStyle();
            textBoxRuleName.Text = $"Rule{kBase.Rules.Count}";
            _insertAfterIdx = insertAfterIdx;
        }

        //изменение
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
            switch (_mode)
            {
                case Modes.add:
                    Text = "Добавление правила";
                    break;
                case Modes.edit:
                    Text = "Редактирование правила";
                    break;
            }
            BackColor = SystemColors.ControlLightLight;
            buttonEditPremise.Enabled = false; 
            buttonDeletePremise.Enabled = false;
            buttonEditConclusion.Enabled = false;
            buttonDeleteConclusion.Enabled = false;
            var buttonBorder = Color.Silver;
            buttonAddPremise.FlatStyle = FlatStyle.Flat;
            buttonAddPremise.FlatAppearance.BorderColor = buttonBorder;
            buttonAddPremise.BackColor = SystemColors.ControlLightLight;

            buttonDeletePremise.FlatStyle = FlatStyle.Flat;
            buttonDeletePremise.FlatAppearance.BorderColor = buttonBorder;
            buttonDeletePremise.BackColor = SystemColors.ControlLightLight;

            buttonEditPremise.FlatStyle = FlatStyle.Flat;
            buttonEditPremise.FlatAppearance.BorderColor = buttonBorder;
            buttonEditPremise.BackColor = SystemColors.ControlLightLight;

            buttonAddConclusion.FlatStyle = FlatStyle.Flat;
            buttonAddConclusion.FlatAppearance.BorderColor = buttonBorder;
            buttonAddConclusion.BackColor = SystemColors.ControlLightLight;

            buttonDeleteConclusion.FlatStyle = FlatStyle.Flat;
            buttonDeleteConclusion.FlatAppearance.BorderColor = buttonBorder;
            buttonDeleteConclusion.BackColor = SystemColors.ControlLightLight;

            buttonEditConclusion.FlatStyle = FlatStyle.Flat;
            buttonEditConclusion.FlatAppearance.BorderColor = buttonBorder;
            buttonEditConclusion.BackColor = SystemColors.ControlLightLight;
            CenterToScreen();
        }

        private void FillForm()
        {
            textBoxRuleName.Text = _rule.Name;
            FillList();
            textBoxReason.Text = _rule.Reason;
        }

        public void FillList()
        {
            listBoxPremises.Items.Clear();
            foreach (var p in _rule.Condition)
                listBoxPremises.Items.Add(p.ToString());
            if (listBoxPremises.Items.Count > 0)
                listBoxPremises.SelectedIndex = 0;
            listBoxConclusion.Items.Clear();
            foreach (var p in _rule.Conclusion)
                listBoxConclusion.Items.Add(p.ToString());
            if (listBoxConclusion.Items.Count > 0)
                listBoxConclusion.SelectedIndex = 0;
        }

        private void esTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void okButton1_Click(object sender, EventArgs e)
        {
            if(textBoxRuleName.Text == "")
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
            _rule.Name = textBoxRuleName.Text;
            _rule.Reason = textBoxReason.Text;
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

        private void cancelButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAddPremise_Click(object sender, EventArgs e)
        {
            var f = new FormAddFact(FormAddFact.Modes.add, FactType.premise, _kBase, _rule);
            if (f.ShowDialog() == DialogResult.OK)
            {
                FillList();
                listBoxPremises.SelectedIndex = listBoxPremises.Items.Count  - 1;
            }
        }
        
        private void buttonAddConclusion_Click(object sender, EventArgs e)
        {
            var f = new FormAddFact(FormAddFact.Modes.add, FactType.conclusion, _kBase, _rule);
            if (f.ShowDialog() == DialogResult.OK)
            {
                FillList();
                listBoxConclusion.SelectedIndex = listBoxConclusion.Items.Count - 1;
            }
        }

        private void listBoxPremises_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonDeletePremise.Enabled = listBoxPremises.SelectedIndex >= 0;
            buttonEditPremise.Enabled = listBoxPremises.SelectedIndex >= 0;
        }

        private void listBoxConclusion_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonDeleteConclusion.Enabled = listBoxConclusion.SelectedIndex >= 0;
            buttonEditConclusion.Enabled = listBoxConclusion.SelectedIndex >= 0;
        }

        private void buttonEditPremise_Click(object sender, EventArgs e)
        {
            var f = new FormAddFact(FormAddFact.Modes.edit, FactType.premise, _kBase, _rule, listBoxPremises.SelectedIndex);
            if (f.ShowDialog() == DialogResult.OK)
            {
                FillList();
                listBoxPremises.SelectedIndex = listBoxPremises.Items.Count - 1;
            }
        }


        private void buttonEditConclusion_Click(object sender, EventArgs e)
        {
            var f = new FormAddFact(FormAddFact.Modes.edit, FactType.conclusion, _kBase, _rule, listBoxPremises.SelectedIndex);
            if (f.ShowDialog() == DialogResult.OK)
            {
                FillList();
                listBoxConclusion.SelectedIndex = listBoxConclusion.Items.Count - 1;
            }
        }

        private void buttonDeletePremise_Click(object sender, EventArgs e)
        {
            _rule.DeletePremiseFact(listBoxPremises.SelectedIndex);
            FillList();
            listBoxPremises.SelectedIndex = _rule.Condition.Count - 1;
        }

        private void buttonDeleteConclusion_Click(object sender, EventArgs e)
        {
            _rule.DeleteConclusionFact(listBoxConclusion.SelectedIndex);
            FillList();
            listBoxConclusion.SelectedIndex = _rule.Conclusion.Count - 1;
        }

        private void EmptyName()
        {
            MessageBox.Show("Имя правила не может быть пустым");
        }
        
        private void EmptyPremise()
        {
            MessageBox.Show("Посылка не может быть пустой");
        }

        private void EmptyConclusion()
        {
            MessageBox.Show("Заключение не может быть пустым");
        }
    }
}
