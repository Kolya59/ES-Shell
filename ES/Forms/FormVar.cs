using System;
using System.Drawing;
using System.Windows.Forms;
using ES.Models;

namespace ES.Forms
{
    public partial class FormAddVar : Form
    {
        public enum Modes { add, edit}

        private readonly Modes _mode;
        private readonly KnowledgeBase _kBase;
        private readonly Variable _var;
        private readonly int _indexVar;
        private bool _customQuestionText;

        public FormAddVar(Modes mode, KnowledgeBase kBase)
        {
            InitializeComponent();
            _mode = mode;
            _kBase = kBase;
            _var = new Variable();
            _indexVar = _kBase.Vars.Count + 1;
            SetStyle();
            FillList();
            tbVarName.Text = $@"Var {kBase.Vars.Count}";
        }

        public FormAddVar(Modes mode, KnowledgeBase kBase, int indexVar)
        {
            InitializeComponent();
            _mode = mode;
            _kBase = kBase;
            if (mode == Modes.add)
            {
                _var = new Variable();
                _indexVar = indexVar + 1;
                SetStyle();
                FillList();
                tbVarName.Text = $@"Var {kBase.Vars.Count}";
            }
            else
            {
                _var = kBase.Vars[indexVar].Copy();
                _indexVar = indexVar;
                SetStyle();
                FillForm();
                if (_var.Question != _var.Name + "?")
                    _customQuestionText = true;
                comboBoxDomain.SelectedIndex = kBase.Domains.FindIndex(x => _var.Domain.Name == x.Name);
            }
        }

        private void SetStyle()
        {

            Text = "Variable";
            switch (_mode)
            {
                case Modes.add:
                    rbQueried.Checked = true;
                    break;
                case Modes.edit:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            CenterToScreen();
        }

        private void FillForm()
        {
            tbQuestion.Text = _var.Question;
            tbVarName.Text = _var.Name;
            FillList();
            switch (_var.Type)
            {
                case VariableType.queried:
                    rbQueried.Checked = true;
                    break;
                case VariableType.queryDeduced:
                    rbQueryDeducted.Checked = true;
                    break;
                case VariableType.deduced:
                    rbDeducted.Checked = true;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        private void FillList()
        {
            comboBoxDomain.Items.Clear();
            foreach (var d in _kBase.Domains)
                comboBoxDomain.Items.Add(d.Name);
            if (_kBase.Domains.Count > 0)
                comboBoxDomain.SelectedIndex = 0;

        }
        private void addPlusButton_Click(object sender, EventArgs e)
        {
            var f = new FormAddDomain(_kBase.LastDomainNumber - 1, FormAddDomain.Modes.add, _kBase);
            if (f.ShowDialog() != DialogResult.OK) return;
            FillList();
            comboBoxDomain.SelectedIndex = comboBoxDomain.Items.Count - 1;
        }
        private void esTextBoxVarName_TextChanged(object sender, EventArgs e)
        {
            if(!_customQuestionText && tbVarName.Text != "")
            {
                tbQuestion.Text = $"{tbVarName.Text}?";
            }
        }

        private void tbQuestion_TextChanged(object sender, EventArgs e)
        {
            if (tbQuestion.Text != "" && tbQuestion.Text != $"{tbVarName.Text}?")
            {
                _customQuestionText = true;
            }
            else
            {
                _customQuestionText = false;
                tbQuestion.Text = $"{tbVarName.Text}?";
            }
        }

        private static void EmptyVarName()
        {
            MessageBox.Show("Empty name", "Error");
        }

        private static void NoDomainError()
        {
            MessageBox.Show("Domain not chosen", "Error");
        }

        private void rbDeducted_CheckedChanged(object sender, EventArgs e)
        {
             tbQuestion.Enabled = !rbDeducted.Checked;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (tbVarName.Text == "")
            {
                EmptyVarName();
                return;
            }
            if(comboBoxDomain.SelectedIndex < 0)
            {
                NoDomainError();
                return;
            }
            _var.Name = tbVarName.Text;
            if (!rbDeducted.Checked)
            {
                _var.Question = tbQuestion.Text;
            }
            if (rbDeducted.Checked)
                _var.Type = VariableType.deduced;
            if (rbQueryDeducted.Checked)
                _var.Type = VariableType.queryDeduced;
            if (rbQueried.Checked)
                _var.Type = VariableType.queried;
            _var.Domain = _kBase.Domains[comboBoxDomain.SelectedIndex];
            if (_mode == Modes.add)
            {
                if (!_kBase.AddVar(_var, _indexVar))
                    return;
            }
            else
            {
                if (!_kBase.EditVar(_var, _indexVar))
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
