using System;
using System.Drawing;
using System.Windows.Forms;
using ES.Models;

namespace ES.ESForm
{
    public partial class FormAddFact : Form
    {
        public enum Modes { add, edit }
        Modes _mode;
        FactType _factType;
        KnowledgeBase _kBase;
        Statement _statement;
        Rule _rule;
        int _factIndex;
        //добавление факта
        public FormAddFact(Modes mode, FactType factType, KnowledgeBase kBase, Rule rule)
        {
            InitializeComponent();
            _mode = mode;
            _factType = factType;
            _kBase = kBase;
            _rule = rule;
            SetStyle();
            FillListVar();
            _statement = new Statement();
        }

        //изменение факта 
        public FormAddFact(Modes mode, FactType factType, KnowledgeBase kBase, Rule rule, int factIndex)
        {
            InitializeComponent();
            _mode = mode;
            _factType = factType;
            _kBase = kBase;
            _rule = rule;
            SetStyle();
            FillListVar();
            _statement = FactType.premise == factType? 
                rule.Condition[factIndex]:
                rule.Conclusion[factIndex];
            _factIndex = factIndex;
            for (var i = 0; i < comboBoxVar.Items.Count; i++)
                if (comboBoxVar.Items[i].ToString() == _statement.Variable.Name)
                    comboBoxVar.SelectedIndex = i;
        }

      
        private void SetStyle()
        {
            Text = "Факт";
            switch (_factType)
            {
                case FactType.premise:
                    Text += " посылки";
                    break;
                case FactType.conclusion:
                    Text += " заключения";
                    break;
            }
            BackColor = SystemColors.ControlLightLight;
            CenterToScreen();
        }

        private void FillListVar()
        { 
            comboBoxVar.Items.Clear();
             foreach (var var in _kBase.Vars)
            {
                if (_factType == FactType.premise)
                {
                    comboBoxVar.Items.Add(var.Name);
                } else
                {
                    if (var.Type == VariableType.conclusion ||
                        var.Type == VariableType.queryConclusion)
                        comboBoxVar.Items.Add(var.Name);
                }
            }
            if (comboBoxVar.Items.Count > 0)
                comboBoxVar.SelectedIndex = 0;
        }

        private void addPlusVarButton_Click(object sender, EventArgs e)
        {
            var f = new FormAddVar(FormAddVar.Modes.add, _kBase);
            if (f.ShowDialog() == DialogResult.OK)
            {
                FillListVar();
                comboBoxVar.SelectedIndex = 0;
            }
        }

        private void comboBoxVar_SelectedIndexChanged(object sender, EventArgs e)
        {
            var var = _kBase.GetVarByName(comboBoxVar.Text);
            comboBoxDomain.Items.Clear();
            foreach (var v in var.Domain.Values)
                comboBoxDomain.Items.Add(v.Value);
            comboBoxDomain.SelectedIndex = 0;
        }

        private void okButton1_Click(object sender, EventArgs e)
        {
            if (comboBoxVar.SelectedIndex < 0 || 
                comboBoxDomain.SelectedIndex < 0)
            {
                NotSelectedError();
                return;
            }
            _statement.Variable = _kBase.GetVarByName(comboBoxVar.Text);
            _statement.Value = comboBoxDomain.Text;

            switch (_factType)
            {
                case FactType.premise:
                    if (_mode == Modes.add)
                    {
                       if (!_rule.AddPremiseFact(_statement))
                            return;
                    }
                    else
                    {
                        if (!_rule.EditPremiseFact(_factIndex, _statement))
                            return;
                    }
                    break;
                case FactType.conclusion:
                    if (_mode == Modes.add)
                    {
                        if (!_rule.AddConclusionFact(_statement))
                            return;
                    }
                    else
                    {
                        if (!_rule.EditConclusionFact(_factIndex, _statement))
                            return;
                    }
                    break;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void NotSelectedError()
        {
            MessageBox.Show("Выберите переменную и ее значение");
        }

        private void cancelButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
