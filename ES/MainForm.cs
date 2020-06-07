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
        private KnowledgeBase _knowledgeBase;
        public InferenceEngine inferenceEngine;

        private bool _kBaseChanged;
        private string _fileName;
        
        public MainForm()
        {
            InitializeComponent();
            BackColor = SystemColors.ControlLightLight;
            SplittersConstruct();
            tbQuestion.BackColor = menuStrip1.BackColor;
            foreach(ColumnHeader c in listViewDomains.Columns)
            {
                c.Width = listViewDomains.Width;
            }
            lvVars.Columns[0].Width = (int)(lvVars.Width * 0.2);
            lvVars.Columns[1].Width = (int)(lvVars.Width * 0.4);
            lvVars.Columns[2].Width = lvVars.Width - (lvVars.Columns[0].Width + lvVars.Columns[1].Width);

            try
            {
                var prev = File.ReadAllText(".tmp");
                var reader = new StreamReader(prev);
                try
                {
                    _knowledgeBase = JsonSerializer.Deserialize<KnowledgeBase>(reader.ReadToEnd());
                    FillVars();
                    FillDomains();
                    FillRules();
                    _fileName = prev;
                }
                catch (Exception)
                {
                    throw new Exception();
                }
                finally
                {
                    reader.Close();
                }
                
            }
            catch (Exception)
            {
                _knowledgeBase = new KnowledgeBase();
                _kBaseChanged = false;
            }
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
                File.WriteAllText(_fileName, JsonSerializer.Serialize(_knowledgeBase));
                _kBaseChanged = false;
                MessageBox.Show($@"{_fileName} was saved!", "Saving");
            }
            catch (Exception ex)
            {
                MessageBox.Show($@"Failed to save file: {ex.Message}", "Error");
            }
        }

        private void SaveAs()
        {
            var path = Directory.GetCurrentDirectory();
            var dialog = new SaveFileDialog {InitialDirectory = path, Filter = "JSON (*.json)|*.json"};
            if (dialog.ShowDialog() != DialogResult.OK) return;
            _fileName = $@"{dialog.FileName}";
            Save();
        }

        #region Fill Form
        private void FillDomains()
        {
            listViewDomains.Items.Clear();
            foreach (var d in _knowledgeBase.Domains)
                listViewDomains.Items.Add(new ListViewItem(d.Name));
        }
        private void FillVars()
        {
            lvVars.Items.Clear();
            foreach (var v in _knowledgeBase.Vars)
            {
                var item = new ListViewItem(v.Name);
                switch (v.Type)
                {
                    case VariableType.queried:
                        item.SubItems.Add("queried");
                        break;
                    case VariableType.queryDeduced:
                        item.SubItems.Add("query-deducted");
                        break;
                    case VariableType.deduced:
                        item.SubItems.Add("deducted");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                item.SubItems.Add(v.Domain.Name);
                item.SubItems.Add(v.Type.ToString());
                lvVars.Items.Add(item);
            }
        }

        private void FillRules()
        {
            lvRules.Items.Clear();
            foreach(var r in _knowledgeBase.Rules)
            {
                var item = new ListViewItem(r.Name);
                item.SubItems.Add(r.ToString());
                lvRules.Items.Add(item);
            }
        }

        #endregion

        #region Domains
        private void buttonAddDomain_Click(object sender, EventArgs e)
        {
            var idx = listViewDomains.SelectedIndices.Count > 0 ? listViewDomains.SelectedIndices[0] : 0;
            var f = new FormAddDomain(idx, FormAddDomain.Modes.add, _knowledgeBase);
            if (f.ShowDialog() != DialogResult.OK) return;
            FillDomains();
            listViewDomains.SelectedIndices.Clear();
            listViewDomains.SelectedIndices.Add(listViewDomains.Items.Count - 1);
            _kBaseChanged = true;
        }

        private void buttonEditDomain_Click(object sender, EventArgs e)
        {
            var index = listViewDomains.SelectedIndices[0];
            var f = new FormAddDomain(FormAddDomain.Modes.edit, _knowledgeBase, index);
            if (f.ShowDialog() != DialogResult.OK) return;
            FillDomains();
            listViewDomains.SelectedIndices.Clear();
            listViewDomains.SelectedIndices.Add(index);
            _kBaseChanged = true;

        }

        private void buttonDeleteDomain_Click(object sender, EventArgs e)
        {
            var index = listViewDomains.SelectedIndices[0];
            _knowledgeBase.DeleteDomain(index);
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
                listViewDomains.SelectedIndices[0] >= _knowledgeBase.Domains.Count) return;
            foreach(var v in _knowledgeBase.Domains[listViewDomains.SelectedIndices[0]].Values)
            {
                listBoxDomainValues.Items.Add(v.Value);
            }
        }
        #endregion

        #region Vars
        private void buttonAddVar_Click(object sender, EventArgs e)
        {
            var f = new FormAddVar(FormAddVar.Modes.add, _knowledgeBase);
            if (f.ShowDialog() != DialogResult.OK) return;
            FillVars();
            FillDomains();
            lvVars.SelectedIndices.Clear();
            lvVars.SelectedIndices.Add(lvVars.Items.Count - 1);
            _kBaseChanged = true;
        }

        private void buttonEditVar_Click(object sender, EventArgs e)
        {
            if (_knowledgeBase.IsVarUsed(_knowledgeBase.Vars[lvVars.SelectedIndices[0]].Name))
            {
                MessageBox.Show("This variable is used");
                return;
            }
            var index = lvVars.SelectedIndices[0];
            var f = new FormAddVar(FormAddVar.Modes.edit, _knowledgeBase, index);
            if (f.ShowDialog() != DialogResult.OK) return;
            FillVars();
            FillDomains();
            lvVars.SelectedIndices.Clear();
            lvVars.SelectedIndices.Add(index);
            _kBaseChanged = true;
        }

        private void buttonDeleteVar_Click(object sender, EventArgs e)
        {
            if (_knowledgeBase.IsVarUsed(_knowledgeBase.Vars[lvVars.SelectedIndices[0]].Name))
            {
                MessageBox.Show("This variable is used");
                return;
            }
            var index = lvVars.SelectedIndices[0];
            _knowledgeBase.DeleteVar(index);
            lvVars.SelectedIndices.Add(lvVars.Items.Count - 1);
            FillVars();
            _kBaseChanged = true;
        }

        private void listViewVars_SelectedIndexChanged(object sender, EventArgs e)
        {
            btDeleteVar.Enabled = lvVars.SelectedIndices.Count > 0;
            btEditVar.Enabled = lvVars.SelectedIndices.Count > 0;
            if (lvVars.SelectedIndices.Count <= 0 || lvVars.SelectedIndices[0] >= _knowledgeBase.Vars.Count) return;
            if (_knowledgeBase.Vars[lvVars.SelectedIndices[0]].Type != VariableType.deduced)
            {
                tbQuestion.Text = _knowledgeBase.Vars[lvVars.SelectedIndices[0]].Question;
                tbQuestion.Show();
                gbQuestion.Show();
            }
            else
            {
                tbQuestion.Hide();
                gbQuestion.Hide();
            }
            lbDomainValuesForVar.Items.Clear();
            foreach (var v in _knowledgeBase.Vars[lvVars.SelectedIndices[0]].Domain.Values)
                lbDomainValuesForVar.Items.Add(v.Value);
        }
        #endregion

        #region Rules
        private void buttonAddRule_Click(object sender, EventArgs e)
        {
            var insertAfter = lvRules.SelectedIndices.Count > 0 ? lvRules.SelectedIndices[0]: 0;
            var f = new FormAddRule(insertAfter, FormAddRule.Modes.add, _knowledgeBase);
            if (f.ShowDialog() != DialogResult.OK) return;
            FillRules();
            FillVars();
            FillDomains();
            lvRules.SelectedIndices.Clear();
            lvRules.SelectedIndices.Add(lvRules.Items.Count - 1);
            _kBaseChanged = true;
        }

        private void buttonEditRule_Click(object sender, EventArgs e)
        {
            var index = lvRules.SelectedIndices[0];
            var f = new FormAddRule(FormAddRule.Modes.edit, _knowledgeBase, index);
            if (f.ShowDialog() != DialogResult.OK) return;
            FillRules();
            FillVars();
            FillDomains();
            lvRules.SelectedIndices.Clear();
            lvRules.SelectedIndices.Add(index);
            _kBaseChanged = true;
        }

        private void buttonDeleteRule_Click(object sender, EventArgs e)
        {
            var index = lvRules.SelectedIndices[0];
            _knowledgeBase.DeleteRule(index);
            lvRules.SelectedIndices.Clear();
            lvRules.SelectedIndices.Add(lvRules.Items.Count - 1);
            FillRules();
            _kBaseChanged = true;
        }

        private void listViewRules_SelectedIndexChanged(object sender, EventArgs e)
        {
            btDeleteRule.Enabled = lvRules.SelectedIndices.Count > 0;
            btEditRule.Enabled = lvRules.SelectedIndices.Count > 0;
            if (lvRules.SelectedIndices.Count <= 0 ||
                lvRules.SelectedIndices[0] >= _knowledgeBase.Rules.Count) return;
            tbConclusion.Text = _knowledgeBase.Rules[lvRules.SelectedIndices[0]].PrintConclusion();
            tbCondition.Text = _knowledgeBase.Rules[lvRules.SelectedIndices[0]].PrintPremise();
        }
        #endregion

        #region Consult
        #endregion

        #region File
        private void menuFile_New_Click(object sender, EventArgs e)
        {
            if (_kBaseChanged && MessageBox.Show("Do you want to save results?", "Save?", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
            _knowledgeBase = new KnowledgeBase();
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
                _knowledgeBase = JsonSerializer.Deserialize<KnowledgeBase>(reader.ReadToEnd());
                FillVars();
                FillDomains();
                FillRules();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Failed to load file: {err.Message}");
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
            _itemDnD = lvRules.GetItemAt(e.X, e.Y);
        }

        private void listViewRules_MouseUp(object sender, MouseEventArgs e)
        {

            if (_itemDnD == null) return;
            var itemOver = lvRules.GetItemAt(0, e.Y);

            if (itemOver == null || itemOver == _itemDnD)
            {
                Cursor = Cursors.Default;
                return;
            }
            var r = _knowledgeBase.Rules[_itemDnD.Index];
            _knowledgeBase.Rules.RemoveAt(_itemDnD.Index);
            _knowledgeBase.Rules.Insert(itemOver.Index, r);
            lvRules.Items.Remove(_itemDnD);
            lvRules.Items.Insert(itemOver.Index, _itemDnD);
            
            Cursor = Cursors.Default;
            _knowledgeBase.IsChanged = true;
        }

        private void listViewRules_MouseMove(object sender, MouseEventArgs e)
        {
            if (_itemDnD == null) return;
            Cursor = Cursors.Hand;
        }

        private void listViewVars_MouseDown(object sender, MouseEventArgs e)
        {
            _itemDnD = lvVars.GetItemAt(e.X, e.Y);
        }

        private void listViewVars_MouseMove(object sender, MouseEventArgs e)
        {
            if (_itemDnD == null) return;
            Cursor = Cursors.Hand;
        }

        private void listViewVars_MouseUp(object sender, MouseEventArgs e)
        {
            if (_itemDnD == null) return;
            var itemOver = lvVars.GetItemAt(0, e.Y);

            if (itemOver == null || itemOver == _itemDnD)
            {
                Cursor = Cursors.Default;
                return;
            }
            var r = _knowledgeBase.Vars[_itemDnD.Index];
            _knowledgeBase.Vars.RemoveAt(_itemDnD.Index);
            _knowledgeBase.Vars.Insert(itemOver.Index, r);
            lvVars.Items.Remove(_itemDnD);
            lvVars.Items.Insert(itemOver.Index, _itemDnD);
      
            Cursor = Cursors.Default;
            _knowledgeBase.IsChanged = true;
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
                MessageBox.Show("Do you want to save results?",
                    "Save?",
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
        
        private void menuConsultation_Click(object sender, EventArgs e)
        {
            var goals = _knowledgeBase.GetGoals();
            if (goals.Count == 0)
            {
                MessageBox.Show("There are no deducted or query-deducted variables");
                return;
            }
            inferenceEngine = new InferenceEngine(_knowledgeBase);
            var f = new ChooseGoalForm(goals);
            if (f.ShowDialog() != DialogResult.OK) return;
            var result = inferenceEngine.Start();
            if (result == null)
            {
                MessageBox.Show("Failed to deduce goal");
                return;
            }
            var formResult = new FormResultConsult(inferenceEngine, result.ToString());
            formResult.ShowDialog();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            SplittersConstruct();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                File.WriteAllText(".tmp", _fileName);
            }
            catch
            {
                // ignored
            }

            if (!_kBaseChanged &&
                MessageBox.Show("Do you want to save results?",
                    "Save?",
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
            if (inferenceEngine?.ExplainTree == null)
            {
                MessageBox.Show("Consultation is not finished");
                return;
            }
            var f = new FormExplain(inferenceEngine.ExplainTree, inferenceEngine.log, inferenceEngine.Statements);
            f.ShowDialog();
        }
    }
}
