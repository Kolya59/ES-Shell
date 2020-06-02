using System;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using ES.ESForm;
using ES.Models;

namespace ES
{
    public partial class MainForm : Form
    {
        private KnowledgeBase _kBase;
        public InferenceEngine inferenceEngine;

        private bool _kBaseChanged;
        private string _fileName;
        
        public MainForm()
        {
            InitializeComponent();
            BackColor = SystemColors.ControlLightLight;
            SplittersConstruct();
            textBoxQuestion.BackColor = menuStrip1.BackColor;
            foreach(ColumnHeader c in listViewDomains.Columns)
            {
                c.Width = listViewDomains.Width;
            }
            listViewVars.Columns[0].Width = (int)(listViewVars.Width * 0.2);
            listViewVars.Columns[1].Width = (int)(listViewVars.Width * 0.4);
            listViewVars.Columns[2].Width = listViewVars.Width - (listViewVars.Columns[0].Width + listViewVars.Columns[1].Width);

            var buttonBorder = Color.Silver;
            buttonAddDomain.FlatStyle = FlatStyle.Flat;
            buttonAddDomain.FlatAppearance.BorderColor = buttonBorder;
            buttonAddDomain.BackColor = SystemColors.ControlLightLight;

            buttonEditDomain.FlatStyle = FlatStyle.Flat;
            buttonEditDomain.Enabled = false;
            buttonEditDomain.FlatAppearance.BorderColor = buttonBorder;
            buttonEditDomain.BackColor = SystemColors.ControlLightLight;

            buttonDeleteDomain.FlatStyle = FlatStyle.Flat;
            buttonDeleteDomain.Enabled = false;
            buttonDeleteDomain.FlatAppearance.BorderColor = buttonBorder;
            buttonDeleteDomain.BackColor = SystemColors.ControlLightLight;

            buttonAddVar.FlatStyle = FlatStyle.Flat;
            buttonAddVar.FlatAppearance.BorderColor = buttonBorder;
            buttonAddVar.BackColor = SystemColors.ControlLightLight;

            buttonEditVar.FlatStyle = FlatStyle.Flat;
            buttonEditVar.FlatAppearance.BorderColor = buttonBorder;
            buttonEditVar.Enabled = false;
            buttonEditVar.BackColor = SystemColors.ControlLightLight;

            buttonDeleteVar.FlatStyle = FlatStyle.Flat;
            buttonDeleteVar.FlatAppearance.BorderColor = buttonBorder;
            buttonDeleteVar.Enabled = false;
            buttonDeleteVar.BackColor = SystemColors.ControlLightLight;

            buttonAddRule.FlatStyle = FlatStyle.Flat;
            buttonAddRule.FlatAppearance.BorderColor = buttonBorder;
            buttonAddRule.BackColor = SystemColors.ControlLightLight;

            buttonEditRule.FlatStyle = FlatStyle.Flat;
            buttonEditRule.Enabled = false;
            buttonEditRule.FlatAppearance.BorderColor = buttonBorder;
            buttonEditRule.BackColor = SystemColors.ControlLightLight;

            buttonDeleteRule.FlatStyle = FlatStyle.Flat;
            buttonDeleteRule.Enabled = false;
            buttonDeleteRule.FlatAppearance.BorderColor = buttonBorder;
            buttonDeleteRule.BackColor = SystemColors.ControlLightLight;
            _kBase = new KnowledgeBase();
            _kBaseChanged = false;
        }

        public sealed override Color BackColor
        {
            get => base.BackColor;
            set => base.BackColor = value;
        }

        private void SplittersConstruct()
        {
            if (Width < 230) return;
            splitContainerDomains.SplitterDistance = Width - 230;
            splitContainerRules.SplitterDistance = Width - 230;
            splitContainerVars.SplitterDistance = Width - 230;
        }

        private void Save()
        {
            try
            {
                File.WriteAllText(_fileName, JsonSerializer.Serialize(_kBase));
                _kBaseChanged = false;
                MessageBox.Show($@"{_fileName} файл сохранен!", "Сохранение");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении файла:\n", ex.Message);
            }
        }

        private void SaveAs()
        {
            var path = Directory.GetCurrentDirectory();
            var dialog = new SaveFileDialog {InitialDirectory = path, Filter = "JSON (*.json)|*.json"};
            if (dialog.ShowDialog() != DialogResult.OK) return;
            _fileName = dialog.FileName;
            Save();
        }

        #region Fill Form
        private void FillDomains()
        {
            listViewDomains.Items.Clear();
            foreach (var d in _kBase.Domains)
                listViewDomains.Items.Add(new ListViewItem(d.Name));
        }
        private void FillVars()
        {
            listViewVars.Items.Clear();
            foreach (var v in _kBase.Vars)
            {
                var item = new ListViewItem(v.Name);
                switch (v.Type)
                {
                    case VariableType.query:
                        item.SubItems.Add("запрашиваемая");
                        break;
                    case VariableType.queryConclusion:
                        item.SubItems.Add("запрашиваемо-выводимая");
                        break;
                    case VariableType.conclusion:
                        item.SubItems.Add("выводимая");
                        break;
                }
                item.SubItems.Add(v.Domain.Name);
                item.SubItems.Add(v.Type.ToString());
                listViewVars.Items.Add(item);
            }
        }

        private void FillRules()
        {
            listViewRules.Items.Clear();
            foreach(var r in _kBase.Rules)
            {
                var item = new ListViewItem(r.Name);
                item.SubItems.Add(r.ToString());
                listViewRules.Items.Add(item);
            }
        }

        #endregion

        #region Domains
        private void buttonAddDomain_Click(object sender, EventArgs e)
        {
            var idx = listViewDomains.SelectedIndices.Count > 0 ? listViewDomains.SelectedIndices[0] : 0;
            var f = new FormAddDomain(idx, FormAddDomain.Modes.add, _kBase);
            if (f.ShowDialog() != DialogResult.OK) return;
            FillDomains();
            listViewDomains.SelectedIndices.Clear();
            listViewDomains.SelectedIndices.Add(listViewDomains.Items.Count - 1);
            _kBaseChanged = true;
        }

        private void buttonEditDomain_Click(object sender, EventArgs e)
        {
            var index = listViewDomains.SelectedIndices[0];
            var f = new FormAddDomain(FormAddDomain.Modes.edit, _kBase, index);
            if (f.ShowDialog() != DialogResult.OK) return;
            FillDomains();
            listViewDomains.SelectedIndices.Clear();
            listViewDomains.SelectedIndices.Add(index);
            _kBaseChanged = true;

        }

        private void buttonDeleteDomain_Click(object sender, EventArgs e)
        {
            var index = listViewDomains.SelectedIndices[0];
            _kBase.DeleteDomain(index);
            listViewDomains.SelectedIndices.Add(listViewDomains.Items.Count - 1);
            FillDomains();
            _kBaseChanged = true;
        }

        private void listViewDomains_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonDeleteDomain.Enabled = listViewDomains.SelectedIndices.Count > 0;
            buttonEditDomain.Enabled = listViewDomains.SelectedIndices.Count > 0;
            listBoxDomainValues.Items.Clear();
            if (listViewDomains.SelectedIndices.Count <= 0 ||
                listViewDomains.SelectedIndices[0] >= _kBase.Domains.Count) return;
            foreach(var v in _kBase.Domains[listViewDomains.SelectedIndices[0]].Values)
            {
                listBoxDomainValues.Items.Add(v.Value);
            }
        }
        #endregion

        #region Vars
        private void buttonAddVar_Click(object sender, EventArgs e)
        {
            var f = new FormAddVar(FormAddVar.Modes.add, _kBase);
            if (f.ShowDialog() != DialogResult.OK) return;
            FillVars();
            FillDomains();
            listViewVars.SelectedIndices.Clear();
            listViewVars.SelectedIndices.Add(listViewVars.Items.Count - 1);
            _kBaseChanged = true;
        }

        private void buttonEditVar_Click(object sender, EventArgs e)
        {
            if (_kBase.IsVarUsed(_kBase.Vars[listViewVars.SelectedIndices[0]].Name))
            {
                MessageBox.Show("Эта переменная используется");
                return;
            }
            var index = listViewVars.SelectedIndices[0];
            var f = new FormAddVar(FormAddVar.Modes.edit, _kBase, index);
            if (f.ShowDialog() != DialogResult.OK) return;
            FillVars();
            FillDomains();
            listViewVars.SelectedIndices.Clear();
            listViewVars.SelectedIndices.Add(index);
            _kBaseChanged = true;
        }

        private void buttonDeleteVar_Click(object sender, EventArgs e)
        {
            if (_kBase.IsVarUsed(_kBase.Vars[listViewVars.SelectedIndices[0]].Name))
            {
                MessageBox.Show("Эта переменная используется");
                return;
            }
            var index = listViewVars.SelectedIndices[0];
            _kBase.DeleteVar(index);
            listViewVars.SelectedIndices.Add(listViewVars.Items.Count - 1);
            FillVars();
            _kBaseChanged = true;
        }

        private void listViewVars_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonDeleteVar.Enabled = listViewVars.SelectedIndices.Count > 0;
            buttonEditVar.Enabled = listViewVars.SelectedIndices.Count > 0;
            if (listViewVars.SelectedIndices.Count <= 0 || listViewVars.SelectedIndices[0] >= _kBase.Vars.Count) return;
            if (_kBase.Vars[listViewVars.SelectedIndices[0]].Type != VariableType.conclusion)
            {
                textBoxQuestion.Text = _kBase.Vars[listViewVars.SelectedIndices[0]].Question;
                textBoxQuestion.Show();
                groupBoxQuestion.Show();
            }
            else
            {
                textBoxQuestion.Hide();
                groupBoxQuestion.Hide();
            }
            listBoxDomainValuesForVar.Items.Clear();
            foreach (var v in _kBase.Vars[listViewVars.SelectedIndices[0]].Domain.Values)
                listBoxDomainValuesForVar.Items.Add(v.Value);
        }
        #endregion

        #region Rules
        private void buttonAddRule_Click(object sender, EventArgs e)
        {
            var insertAfter = listViewRules.SelectedIndices.Count > 0 ? listViewRules.SelectedIndices[0]: 0;
            var f = new FormAddRule(insertAfter, FormAddRule.Modes.add, _kBase);
            if (f.ShowDialog() != DialogResult.OK) return;
            FillRules();
            FillVars();
            FillDomains();
            listViewRules.SelectedIndices.Clear();
            listViewRules.SelectedIndices.Add(listViewRules.Items.Count - 1);
            _kBaseChanged = true;
        }

        private void buttonEditRule_Click(object sender, EventArgs e)
        {
            var index = listViewRules.SelectedIndices[0];
            var f = new FormAddRule(FormAddRule.Modes.edit, _kBase, index);
            if (f.ShowDialog() != DialogResult.OK) return;
            FillRules();
            FillVars();
            FillDomains();
            listViewRules.SelectedIndices.Clear();
            listViewRules.SelectedIndices.Add(index);
            _kBaseChanged = true;
        }

        private void buttonDeleteRule_Click(object sender, EventArgs e)
        {
            var index = listViewRules.SelectedIndices[0];
            _kBase.DeleteRule(index);
            listViewRules.SelectedIndices.Clear();
            listViewRules.SelectedIndices.Add(listViewRules.Items.Count - 1);
            FillRules();
            _kBaseChanged = true;
        }

        private void listViewRules_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonDeleteRule.Enabled = listViewRules.SelectedIndices.Count > 0;
            buttonEditRule.Enabled = listViewRules.SelectedIndices.Count > 0;
            if (listViewRules.SelectedIndices.Count <= 0 ||
                listViewRules.SelectedIndices[0] >= _kBase.Rules.Count) return;
            textBoxZakl.Text = _kBase.Rules[listViewRules.SelectedIndices[0]].PrintConclusion();
            textBoxPosilka.Text = _kBase.Rules[listViewRules.SelectedIndices[0]].PrintPremise();
        }
        #endregion

        #region Consult
        #endregion

        #region File
        private void menuFile_New_Click(object sender, EventArgs e)
        {
            if (_kBaseChanged && MessageBox.Show("База знаний была изменена, хотите сохранить ее?", "Сохранить?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (_fileName == "")
                {
                    SaveAs();
                }
                else
                {
                    Save();   
                }
            }
            _kBase = new KnowledgeBase();
            FillDomains();
            FillRules();
            FillVars();
            _kBaseChanged = false;
        }
        #endregion

        private void menuFile_Open_Click(object sender, EventArgs e)
        {
            var path = Directory.GetCurrentDirectory();
            var dialog = new OpenFileDialog {InitialDirectory = path, Filter = "JSON (*.json)|*.json"};
            if (dialog.ShowDialog() != DialogResult.OK) return;
            _fileName = dialog.FileName;
            var reader = new StreamReader(_fileName);
            try
            {
                _kBase = JsonSerializer.Deserialize<KnowledgeBase>(reader.ReadToEnd());
                FillVars();
                FillDomains();
                FillRules();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка десериализации файла: " + err.Message);
            }
            finally
            {
                reader.Close();
            }
        }

        private void menuFile_SaveAs_Click(object sender, EventArgs e) => SaveAs();

        // The LVItem being dragged
        private ListViewItem _itemDnD;
        private void listViewRules_MouseDown(object sender, MouseEventArgs e)
        {
            _itemDnD = listViewRules.GetItemAt(e.X, e.Y);
        }

        private void listViewRules_MouseUp(object sender, MouseEventArgs e)
        {

            if (_itemDnD == null) return;
            var itemOver = listViewRules.GetItemAt(0, e.Y);

            if (itemOver == null || itemOver == _itemDnD)
            {
                Cursor = Cursors.Default;
                return;
            }
            var r = _kBase.Rules[_itemDnD.Index];
            _kBase.Rules.RemoveAt(_itemDnD.Index);
            _kBase.Rules.Insert(itemOver.Index, r);
            listViewRules.Items.Remove(_itemDnD);
            listViewRules.Items.Insert(itemOver.Index, _itemDnD);
            
            Cursor = Cursors.Default;
            _kBase.IsChanged = true;
        }

        private void listViewRules_MouseMove(object sender, MouseEventArgs e)
        {
            if (_itemDnD == null) return;
            Cursor = Cursors.Hand;
        }

        private void listViewVars_MouseDown(object sender, MouseEventArgs e)
        {
            _itemDnD = listViewVars.GetItemAt(e.X, e.Y);
        }

        private void listViewVars_MouseMove(object sender, MouseEventArgs e)
        {
            if (_itemDnD == null) return;
            Cursor = Cursors.Hand;
        }

        private void listViewVars_MouseUp(object sender, MouseEventArgs e)
        {
            if (_itemDnD == null) return;
            var itemOver = listViewVars.GetItemAt(0, e.Y);

            if (itemOver == null || itemOver == _itemDnD)
            {
                Cursor = Cursors.Default;
                return;
            }
            var r = _kBase.Vars[_itemDnD.Index];
            _kBase.Vars.RemoveAt(_itemDnD.Index);
            _kBase.Vars.Insert(itemOver.Index, r);
            listViewVars.Items.Remove(_itemDnD);
            listViewVars.Items.Insert(itemOver.Index, _itemDnD);
      
            Cursor = Cursors.Default;
            _kBase.IsChanged = true;
        }

        private void menuFile_Save_Click(object sender, EventArgs e)
        {
            if (_fileName == "")
            {
                SaveAs(); 
                return;
            }
            Save();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            SplittersConstruct();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!_kBaseChanged ||
                MessageBox.Show("База знаний была изменена, хотите сохранить ее?", "Сохранить?",
                    MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            if (_fileName == "")
            {
                SaveAs();
            }
            else
            {
                Save();
            }
        }

        private void начатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var goals = _kBase.GetGoals();
            if (goals.Count == 0)
            {
                MessageBox.Show("Для консультации необходимо наличие выводимых или выводимо-запрашиваемых переменных");
                return;
            }
            inferenceEngine = new InferenceEngine(_kBase);
            var f = new ChooseGoalForm(goals);
            if (f.ShowDialog() != DialogResult.OK) return;
            var result = inferenceEngine.Start();
            if (result == null)
            {
                MessageBox.Show("Не удалось вывести цель");
                return;
            }
            //MessageBox.Show(result.ToString(), "Результат");
            var formResult = new FormResultConsult(inferenceEngine, result.ToString());
            formResult.ShowDialog();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            SplittersConstruct();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_kBaseChanged &&
                MessageBox.Show("База знаний была изменена, хотите сохранить ее?",
                    "Сохранить?",
                    MessageBoxButtons.YesNo) !=
                DialogResult.Yes)
                return;
            if (_fileName == "")
            {
                SaveAs();
            }
            else
            {
                Save();   
            }
        }

        private void menuReasoning_Click(object sender, EventArgs e)
        {
            if (inferenceEngine == null || inferenceEngine.ExplainTree == null)
            {
                MessageBox.Show("Сначала пройдите консультацию");
                return;
            }
            var f = new FormExplain(inferenceEngine.ExplainTree, inferenceEngine.userAskLogs, inferenceEngine.KnownFacts);
            f.ShowDialog();
        }
    }
}
