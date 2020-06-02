using System;
using System.Drawing;
using System.Windows.Forms;
using ES.Models;

namespace ES.ESForm
{
    public partial class FormAddVar : Form
    {
        public enum Modes { add, edit}
        Modes _mode;
        KnowledgeBase _kBase;
        Variable _var;
        int _indexVar = -1;
        bool _customQuestionText;

        //добавление
        public FormAddVar(Modes mode, KnowledgeBase kBase)
        {
            InitializeComponent();
            _mode = mode;
            _kBase = kBase;
            _var = new Variable();
            SetStyle();
            FillList();
            esTextBoxVarName.Text = $"Var{kBase.Vars.Count}";
        }

        //изменение
        public FormAddVar(Modes mode, KnowledgeBase kBase, int indexVar)
        {
            InitializeComponent();
            _mode = mode;
            _kBase = kBase;
            _var = kBase.Vars[indexVar].Copy();
            _indexVar = indexVar;
            SetStyle();
            FillForm();
            if (_var.Question != _var.Name + "?")
                _customQuestionText = true;
            comboBoxDomain.SelectedIndex = kBase.Domains.FindIndex(x => _var.Domain.Name == x.Name);
        }

        private void SetStyle()
        {

            Text = "Переменная";
            switch (_mode)
            {
                case Modes.add:
                    radioButtonZaprshivaemaya.Checked = true;
                    break;
                case Modes.edit:
                    break;
            }
            BackColor = SystemColors.ControlLightLight;
            CenterToScreen();
        }

        private void FillForm()
        {
            textBoxQuestion.Text = _var.Question;
            esTextBoxVarName.Text = _var.Name;
            FillList();
            switch (_var.Type)
            {
                case VariableType.query:
                    radioButtonZaprshivaemaya.Checked = true;
                    break;
                case VariableType.queryConclusion:
                    radioButtonVivodZapr.Checked = true;
                    break;
                case VariableType.conclusion:
                    radioButtonVivodymaya.Checked = true;
                    break;
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
            var f = new FormAddDomain(0, FormAddDomain.Modes.add, _kBase);
            if (f.ShowDialog() == DialogResult.OK)
            {
                FillList();
                comboBoxDomain.SelectedIndex = 0;
            }
        }

        private void cancelButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void esTextBoxVarName_TextChanged(object sender, EventArgs e)
        {
            if(!_customQuestionText && !(esTextBoxVarName.Text == ""))
            {
                textBoxQuestion.Text = esTextBoxVarName.Text + "?";
            }
        }

        private void textBoxQuestion_TextChanged(object sender, EventArgs e)
        {
            if (textBoxQuestion.Text != "" && textBoxQuestion.Text != esTextBoxVarName.Text + "?")
            {
                _customQuestionText = true;
            }
            else
            {
                _customQuestionText = false;
                textBoxQuestion.Text = esTextBoxVarName.Text + "?";
            }
        }

        private void okButton1_Click(object sender, EventArgs e)
        {
            if (esTextBoxVarName.Text == "")
            {
                EmptyVarName();
                return;
            }
            if(comboBoxDomain.SelectedIndex < 0)
            {
                NoDomainError();
                return;
            }
            _var.Name = esTextBoxVarName.Text;
            if (!radioButtonVivodymaya.Checked)
            {
                _var.Question = textBoxQuestion.Text;
            }
            if (radioButtonVivodymaya.Checked)
                _var.Type = VariableType.conclusion;
            if (radioButtonVivodZapr.Checked)
                _var.Type = VariableType.queryConclusion;
            if (radioButtonZaprshivaemaya.Checked)
                _var.Type = VariableType.query;
            _var.Domain = _kBase.Domains[comboBoxDomain.SelectedIndex];
            if (_mode == Modes.add)
            {
                if (!_kBase.AddVar(_var))
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

        private void EmptyVarName()
        {
            MessageBox.Show("Имя переменной не может быть пустым");
        }

        private void NoDomainError()
        {
            MessageBox.Show("Не выбран домен для переменной.\nВыберите существующий домен или создайте новый");
        }

        private void radioButtonVivodymaya_CheckedChanged(object sender, EventArgs e)
        {
             textBoxQuestion.Enabled = !radioButtonVivodymaya.Checked;
        }
    }
}
