using System;
using System.Drawing;
using System.Windows.Forms;
using ES.Models;

namespace ES.Forms
{
    public partial class FormAddDomain : Form
    {
        public enum Modes { add, edit}

        private readonly KnowledgeBase _kBase;
        private readonly Modes _mode;
        private readonly int _domainIndex = -1;
        private readonly Domain _domain;
        private readonly int _insertAfterIdx;
        
        // Add domain
        public FormAddDomain(int insertAfterIdx, Modes mode, KnowledgeBase kBase)
        {
            InitializeComponent();       
            _mode = mode;
            _kBase = kBase;
            _domain = new Domain();
            tbDomainName.Text = $@"Domain {kBase.Domains.Count}";
            SetStyle();
            _insertAfterIdx = insertAfterIdx;
        }

        // Edit domain
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

        private void SetStyle()
        {
            Text = "Domain";
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

        private void FillForm()
        {
            FillList();
            if (_domain.Name != "")
            {
                tbDomainName.Text = _domain.Name;
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
            if (tbDomainValue.Text == "")
            {
                EmptyDomainValue();
                return;
            }
            if (!_domain.AddValue(tbDomainValue.Text.Trim()))
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
            if (tbDomainValue.Text == "")
            {
                EmptyDomainValue();
                return;
            }
            if (_kBase.IsDomainValueUsed(_domain, _domain.Values[index].Value.Trim()))
            {
                DomainValueUsed();
                return;
            }

            if (!_domain.EditValue(index, tbDomainValue.Text))
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

        private static void UnknownError()
        {
            MessageBox.Show("Unknown error");
        }

        private static void EmptyDomainValue()
        {
            MessageBox.Show("Empty domain value");
        }

        private static void DomainValueAlreadyExists()
        {
            MessageBox.Show("Value already exists");
        }

        private static void EmptyDomainName()
        {
            MessageBox.Show("Empty domain name");
        }

        private static void DomainValueUsed()
        {
            MessageBox.Show("Value already used");
        }

        private void listBoxDomainValues_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonEditDomainValue.Enabled = listBoxDomainValues.SelectedIndex >= 0;
            buttonDeleteDomainValue.Enabled = listBoxDomainValues.SelectedIndex >= 0;
            tbDomainValue.Text = _domain.Values[listBoxDomainValues.SelectedIndex].Value;
        }

        private void esTextBoxDomainValue_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            var s = tbDomainName.Text;
            if(tbDomainValue.Text == "")
            {
                EmptyDomainValue();
                e.Handled = true;
                return;
            }
            buttonAddDomainValue_Click(sender, e);
            tbDomainValue.Text = "";
            tbDomainName.Text = s;
            e.Handled = true;

        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (tbDomainName.Text == "")
            {
                EmptyDomainName();
                return;
            }
            _domain.Name = tbDomainName.Text;
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

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
