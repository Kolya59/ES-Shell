using System;
using System.Windows.Forms;
using ES.Models;

namespace ES.Forms
{
    public partial class FormDomain : Form
    {
        public enum Modes { add, edit}

        private readonly KnowledgeBase _kBase;
        private readonly Modes _mode;
        private readonly int _domainIndex = -1;
        private readonly Domain _domain;
        private readonly int _insertAfterIdx;
        
        // Add domain
        public FormDomain(int insertAfterIdx, Modes mode, KnowledgeBase kBase)
        {
            InitializeComponent();       
            _mode = mode;
            _kBase = kBase;
            _domain = new Domain();
            tbDomainName.Text = $@"Domain {kBase.Domains.Count}";
            CenterToScreen();
            _insertAfterIdx = insertAfterIdx + 1;
            CheckControls();
        }

        // Edit domain
        public FormDomain(Modes mode, KnowledgeBase kBase, int domainIndex)
        {
            InitializeComponent();
            _mode = mode;
            _kBase = kBase;
            _domainIndex = domainIndex;
            _domain = kBase.Domains[domainIndex].Copy();
            CenterToScreen();
            FillForm();
            CheckControls();
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

        private void CheckControls()
        {
            buttonEditDomainValue.Enabled = listBoxDomainValues.Items.Count != 0 &&
                                            listBoxDomainValues.SelectedItems.Count != 0 &&
                                            (string) listBoxDomainValues.SelectedItem != tbDomainValue.Text;
            buttonDeleteDomainValue.Enabled = listBoxDomainValues.Items.Count != 0 &&
                                              listBoxDomainValues.SelectedItems.Count != 0;
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
            CheckControls();
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
            CheckControls();
        }

        private void buttonDeleteDomainValue_Click(object sender, EventArgs e)
        {
            if (_domain.Values.Count == 0)
            {
                return;
            }
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
            CheckControls();
        }

        private static void UnknownError()
        {
            MessageBox.Show("Unknown error", "Error");
        }

        private static void EmptyDomainValue()
        {
            MessageBox.Show("Empty domain value", "Error");
        }

        private static void DomainValueAlreadyExists()
        {
            MessageBox.Show("Value already exists", "Error");
        }

        private static void EmptyDomainName()
        {
            MessageBox.Show("Empty domain name", "Error");
        }

        private static void DomainValueUsed()
        {
            MessageBox.Show("Value already used", "Error");
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

        private void tbDomainValue_TextChanged(object sender, EventArgs e)
        {
            CheckControls();
        }
    }
}
