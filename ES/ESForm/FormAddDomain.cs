using System;
using System.Drawing;
using System.Windows.Forms;
using ES.Models;

namespace ES.ESForm
{
    public partial class FormAddDomain : Form
    {
        public enum Modes { add, edit}
        KnowledgeBase _kBase;
        Modes _mode;
        int _domainIndex = -1;
        Domain _domain;
        int _insertAfterIdx;
        //добавление
        public FormAddDomain(int insertAfterIdx, Modes mode, KnowledgeBase kBase)
        {
            InitializeComponent();       
            _mode = mode;
            _kBase = kBase;
            _domain = new Domain();
            esTextBoxDomainName.Text = $"Domain{kBase.Domains.Count}";
            SetStyle();
            _insertAfterIdx = insertAfterIdx;
        }

        //изменение
        public FormAddDomain(Modes mode, KnowledgeBase kBase, int domainIndex)
        {
            InitializeComponent();
            _mode = mode;
            _kBase = kBase;
            _domainIndex = domainIndex;
            _domain = kBase.Domains[domainIndex].Copy();
            SetStyle();
            FillForm();
        }

        void SetStyle()
        {
            Text = "Домен";
            BackColor = SystemColors.ControlLightLight;
            buttonDeleteDomainValue.Enabled = false;
            buttonEditDomainValue.Enabled = false;

            var buttonBorder = Color.Silver;
            buttonAddDomainValue.FlatStyle = FlatStyle.Flat;
            buttonAddDomainValue.FlatAppearance.BorderColor = buttonBorder;
            buttonAddDomainValue.BackColor = SystemColors.ControlLightLight;

            buttonDeleteDomainValue.FlatStyle = FlatStyle.Flat;
            buttonDeleteDomainValue.FlatAppearance.BorderColor = buttonBorder;
            buttonDeleteDomainValue.BackColor = SystemColors.ControlLightLight;

            buttonEditDomainValue.FlatStyle = FlatStyle.Flat;
            buttonEditDomainValue.FlatAppearance.BorderColor = buttonBorder;
            buttonEditDomainValue.BackColor = SystemColors.ControlLightLight;

            CenterToScreen();
        }

        void FillForm()
        {
            FillList();
            if (_domain.Name != "")
            {
                esTextBoxDomainName.Text = _domain.Name;
            }
        }

        private void FillList()
        {
            listBoxDomainValues.Items.Clear();
            foreach (var v in _domain.Values)
                listBoxDomainValues.Items.Add(v.Value);
        }
        private void buttonAddDomainValue_Click(object sender, EventArgs e)
        {
            if (esTextBoxDomainValue.Text == "")
            {
                EmptyDomainValue();
                return;
            }
            if (!_domain.AddValue(esTextBoxDomainValue.Text.Trim()))
            {
                DomainValueAlreadyExists();
                return;
            }
            FillList();
            listBoxDomainValues.SelectedIndex = _domain.Values.Count-1;
        }

        private void listBoxDomainValues_DragDrop(object sender, DragEventArgs e)
        {
            
        }

        private void buttonEditDomainValue_Click(object sender, EventArgs e)
        {
            var index = listBoxDomainValues.SelectedIndex;
            if (esTextBoxDomainValue.Text == "")
            {
                EmptyDomainValue();
                return;
            }
            if (_kBase.IsDomainValueUsed(_domain, _domain.Values[index].Value.Trim()))
            {
                DomainValueUsed();
                return;
            }

            if (!_domain.EditValue(index, esTextBoxDomainValue.Text))
            {
                DomainValueAlreadyExists();
                return;
            }
            FillList();
            listBoxDomainValues.SelectedIndex = index;
        }

        private void buttonDeleteDomainValue_Click(object sender, EventArgs e)
        {
            if (_kBase.IsDomainValueUsed(_domain, _domain.Values[listBoxDomainValues.SelectedIndex].Value.Trim()))
            {
                DomainValueUsed();
                return;
            }
            if (!_domain.DeleteValue(listBoxDomainValues.SelectedIndex))
            {
                UnknownError();
                return;
            }
            FillList();
            listBoxDomainValues.SelectedIndex = _domain.Values.Count - 1;
        }

        private void cancelButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void okButton1_Click(object sender, EventArgs e)
        {
            if (esTextBoxDomainName.Text == "")
            {
                EmptyDomainName();
                return;
            }
            _domain.Name = esTextBoxDomainName.Text;
            if(_mode == Modes.add)
            {
                if (!_kBase.AddDomain(_insertAfterIdx, _domain))
                    return;
            }
            else
            {
                if (!_kBase.EditDomain(_domain, _domainIndex))
                    return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void UnknownError()
        {
            MessageBox.Show("Возникла ошибка");
        }

        private void EmptyDomainValue()
        {
            MessageBox.Show("Значение домена не может быть пустым");
        }

        private void DomainValueAlreadyExists()
        {
            MessageBox.Show("Такое значение домена уже существует");
        }

        private void EmptyDomainName()
        {
            MessageBox.Show("Имя домена не может быть пустым");
        }

        private void DomainValueUsed()
        {
            MessageBox.Show("Это значение домена уже используется");
        }

        private void listBoxDomainValues_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonEditDomainValue.Enabled = listBoxDomainValues.SelectedIndex >= 0;
            buttonDeleteDomainValue.Enabled = listBoxDomainValues.SelectedIndex >= 0;
            esTextBoxDomainValue.Text = _domain.Values[listBoxDomainValues.SelectedIndex].Value;
        }

        private void esTextBoxDomainValue_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var s = esTextBoxDomainName.Text;
                if(esTextBoxDomainValue.Text == "")
                {
                    EmptyDomainValue();
                    e.Handled = true;
                    return;
                }
                buttonAddDomainValue_Click(sender, e);
                esTextBoxDomainValue.Text = "";
                esTextBoxDomainName.Text = s;
                e.Handled = true;
            }
          
        }
    }
}
