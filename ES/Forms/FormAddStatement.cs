using System;
using System.Drawing;
using System.Windows.Forms;
using ES.Models;

namespace ES.Forms
{
    public partial class FormAddStatement : Form
    {
        public enum Modes { add, edit }

        private readonly Modes _mode;
        private readonly FactType _factType;
        private readonly KnowledgeBase _kBase;
        private readonly Statement _statement;
        private readonly Rule _rule;

        private readonly int _factIndex;
        // Add Statement 
        public FormAddStatement(Modes mode, FactType factType, KnowledgeBase kBase, Rule rule)
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

        // Edit statement
        public FormAddStatement(Modes mode, FactType factType, KnowledgeBase kBase, Rule rule, int factIndex)
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
            Text = "Statement";
            Text += _factType switch
            {
                FactType.premise => " conditions",
                FactType.conclusion => " conclusions",
                _ => throw new ArgumentOutOfRangeException()
            };
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
                    if (var.Type == VariableType.deduced ||
                        var.Type == VariableType.queryDeduced)
                        comboBoxVar.Items.Add(var.Name);
                }
            }
            if (comboBoxVar.Items.Count > 0)
                comboBoxVar.SelectedIndex = 0;
        }

        private void addPlusVarButton_Click(object sender, EventArgs e)
        {
            var f = new FormAddVar(FormAddVar.Modes.add, _kBase);
            if (f.ShowDialog() != DialogResult.OK) return;
            FillListVar();
            comboBoxVar.SelectedIndex = 0;
        }

        private void comboBoxVar_SelectedIndexChanged(object sender, EventArgs e)
        {
            var var = _kBase.GetVarByName(comboBoxVar.Text);
            comboBoxDomain.Items.Clear();
            foreach (var v in var.Domain.Values)
                comboBoxDomain.Items.Add(v.Value);
            comboBoxDomain.SelectedIndex = 0;
        }

        private void NotSelectedError()
        {
            MessageBox.Show("Выберите переменную и ее значение");
        }

        private void cancelButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btOk_Click(object sender, EventArgs e)
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
                default:
                    throw new ArgumentOutOfRangeException();
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
