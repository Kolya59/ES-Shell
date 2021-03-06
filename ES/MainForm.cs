﻿using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using ES.Forms;
using ES.Models;

namespace ES
{
    public partial class MainForm : Form
    {
        private KnowledgeBase _knowledgeBase;
        private InferenceEngine _inferenceEngine;

        private bool _kBaseChanged;
        private string _fileName;
        private Variable _goal;
        
        public MainForm()
        {
            InitializeComponent();
            BackColor = SystemColors.ControlLightLight;
            SplittersConstruct();
            tbQuestion.BackColor = menuStrip1.BackColor;
            foreach(ColumnHeader c in lvDomains.Columns)
            {
                c.Width = lvDomains.Width;
            }
            lvVars.Columns[0].Width = (int)(lvVars.Width * 0.2);
            lvVars.Columns[1].Width = (int)(lvVars.Width * 0.2);
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

            Text = @$"ES {_fileName}";
            cbGoal.Width = 230;
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
            lvRules.Columns[1].Width = lvRules.Width - lvRules.Columns[0].Width;
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
            Text = @$"ES {_fileName}";
        }

        #region Fill Form
        private void FillDomains()
        {
            lvDomains.Items.Clear();
            foreach (var d in _knowledgeBase.Domains)
                lvDomains.Items.Add(new ListViewItem(d.Name));
            CheckDomainControls();
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

            cbGoal.Items.Clear();
            var candidates = _knowledgeBase.Vars.Where(v => v.Type != VariableType.queried).ToList();
            foreach (var variable in candidates)
            {
                cbGoal.Items.Add(variable.Name);
            }

            if (candidates.ToList().Exists(v => v == _goal))
            {
                cbGoal.SelectedIndex = candidates.ToList().FindIndex(v => v == _goal);
            }
            else
            {
                cbGoal.SelectedIndex = -1;
                _goal = null;
            }
            CheckVariableControls();
        }

        private void FillRules()
        {
            lvRules.Items.Clear();
            foreach(var r in _knowledgeBase.Rules)
            {
                var item = new ListViewItem(r.Name);
                item.SubItems.Add(r.Description);
                lvRules.Items.Add(item);
            }
            CheckRuleControls();
        }

        #endregion

        #region Domains
        private void buttonAddDomain_Click(object sender, EventArgs e)
        {
            var idx = lvDomains.SelectedIndices.Count > 0 ? lvDomains.SelectedIndices[0] : _knowledgeBase.Domains.Count - 1;
            var f = new FormDomain(idx, FormDomain.Modes.add, _knowledgeBase);
            if (f.ShowDialog() != DialogResult.OK) return;
            FillDomains();
            _kBaseChanged = true;
            CheckDomainControls();
        }

        private void buttonEditDomain_Click(object sender, EventArgs e)
        {
            var index = lvDomains.SelectedIndices[0];
            var f = new FormDomain(FormDomain.Modes.edit, _knowledgeBase, index);
            if (f.ShowDialog() != DialogResult.OK) return;
            FillDomains();
            lvDomains.SelectedIndices.Clear();
            lvDomains.SelectedIndices.Add(index);
            _kBaseChanged = true;
            CheckDomainControls();
        }

        private void buttonDeleteDomain_Click(object sender, EventArgs e)
        {
            var index = lvDomains.SelectedIndices[0];
            if (_knowledgeBase.IsDomainUsed(_knowledgeBase.Domains[index]))
            {
                MessageBox.Show("This domain is used", "Error");
                return;
            }
            _knowledgeBase.DeleteDomain(index);
            FillDomains();
            _kBaseChanged = true;
            lvDomains.SelectedIndices.Clear();
            listBoxDomainValues.Items.Clear();
            CheckDomainControls();
        }

        private void listViewDomains_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckDomainControls();
            listBoxDomainValues.Items.Clear();
            if (lvDomains.SelectedIndices.Count <= 0 ||
                lvDomains.SelectedIndices[0] >= _knowledgeBase.Domains.Count) return;
            foreach(var v in _knowledgeBase.Domains[lvDomains.SelectedIndices[0]].Values)
            {
                listBoxDomainValues.Items.Add(v.Value);
            }
        }

        private void CheckDomainControls()
        {
            btDeleteDomain.Enabled = lvDomains.SelectedIndices.Count > 0;
            btEditDomain.Enabled = lvDomains.SelectedIndices.Count > 0;
            if (lvDomains.SelectedItems.Count == 0)
            {
                listBoxDomainValues.Items.Clear();
            }
        }
        #endregion

        #region Vars
        private void buttonAddVar_Click(object sender, EventArgs e)
        {
            var f = lvVars.SelectedIndices.Count != 0
                ? new FormVar(FormVar.Modes.add,
                    _knowledgeBase,
                    lvVars.SelectedIndices[0] + 1)
                : new FormVar(FormVar.Modes.add,
                    _knowledgeBase);
            if (f.ShowDialog() != DialogResult.OK) return;
            FillVars();
            FillDomains();
            lvVars.SelectedIndices.Clear();
            CheckVariableControls();
            _kBaseChanged = true;
        }

        private void buttonEditVar_Click(object sender, EventArgs e)
        {
            if (_knowledgeBase.IsVarUsed(_knowledgeBase.Vars[lvVars.SelectedIndices[0]].Name))
            {
                MessageBox.Show("This variable is used", "Error");
                return;
            }
            var index = lvVars.SelectedIndices[0];
            var f = new FormVar(FormVar.Modes.edit, _knowledgeBase, index);
            if (f.ShowDialog() != DialogResult.OK) return;
            FillVars();
            FillDomains();
            lvVars.SelectedIndices.Clear();
            lvVars.SelectedIndices.Add(index);
            _kBaseChanged = true;
            CheckVariableControls();
        }

        private void buttonDeleteVar_Click(object sender, EventArgs e)
        {
            if (_knowledgeBase.IsVarUsed(_knowledgeBase.Vars[lvVars.SelectedIndices[0]].Name))
            {
                MessageBox.Show("This variable is used", "Error");
                return;
            }
            var index = lvVars.SelectedIndices[0];
            _knowledgeBase.DeleteVar(index);
            FillVars();
            _kBaseChanged = true;
            CheckVariableControls();
        }

        private void listViewVars_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckVariableControls();
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

        private void CheckVariableControls()
        {
            btDeleteVar.Enabled = lvVars.SelectedIndices.Count > 0;
            btEditVar.Enabled = lvVars.SelectedIndices.Count > 0;
            if (lbDomainValuesForVar.SelectedItems.Count != 0) return;
            tbQuestion.Text = "";
            lbDomainValuesForVar.Items.Clear();
        }
        #endregion

        #region Rules
        private void buttonAddRule_Click(object sender, EventArgs e)
        {
            var insertAfter = lvRules.SelectedIndices.Count > 0 ? lvRules.SelectedIndices[0] + 1: _knowledgeBase.Rules.Count;
            var f = new FormRule(insertAfter, FormRule.Modes.add, _knowledgeBase);
            if (f.ShowDialog() != DialogResult.OK) return;
            FillRules();
            FillVars();
            FillDomains();
            lvRules.SelectedIndices.Clear();
            _kBaseChanged = true;
            CheckRuleControls();
        }

        private void buttonEditRule_Click(object sender, EventArgs e)
        {
            var index = lvRules.SelectedIndices[0];
            var f = new FormRule(FormRule.Modes.edit, _knowledgeBase, index);
            if (f.ShowDialog() != DialogResult.OK) return;
            FillRules();
            FillVars();
            FillDomains();
            lvRules.SelectedIndices.Clear();
            lvRules.SelectedIndices.Add(index);
            _kBaseChanged = true;
            CheckRuleControls();
        }

        private void buttonDeleteRule_Click(object sender, EventArgs e)
        {
            var index = lvRules.SelectedIndices[0];
            _knowledgeBase.DeleteRule(index);
            lvRules.SelectedIndices.Clear();
            FillRules();
            _kBaseChanged = true;
            CheckRuleControls();
        }

        private void listViewRules_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckRuleControls();
            if (lvRules.SelectedIndices.Count <= 0 ||
                lvRules.SelectedIndices[0] >= _knowledgeBase.Rules.Count) return;
            tbConclusion.Text = _knowledgeBase.Rules[lvRules.SelectedIndices[0]].PrintConclusion();
            tbCondition.Text = _knowledgeBase.Rules[lvRules.SelectedIndices[0]].PrintCondition();
        }

        private void CheckRuleControls()
        {
            btDeleteRule.Enabled = lvRules.SelectedIndices.Count > 0;
            btEditRule.Enabled = lvRules.SelectedIndices.Count > 0;
            tbCondition.Text = lvRules.SelectedItems.Count == 0 ? "" : tbCondition.Text;
            tbConclusion.Text = lvRules.SelectedItems.Count == 0 ? "" : tbConclusion.Text;
        }
        
        #endregion

        #region Consult
        #endregion

        #region File
        private void menuFile_New_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to save results?", "Save?", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
            _fileName = "";
            Text = @$"ES {_fileName}";
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
                MessageBox.Show($"Failed to load file: {err.Message}", "Error");
            }
            finally
            {
                reader.Close();
            }
            Text = @$"ES {_fileName}";
        }

        private void menuFile_SaveAs_Click(object sender, EventArgs e) => SaveAs();

        // The LVItem being dragged
        private ListViewItem _dropped;
        private void listViewRules_MouseDown(object sender, MouseEventArgs e)
        {
            _dropped = lvRules.GetItemAt(e.X, e.Y);
        }

        private void listViewRules_MouseUp(object sender, MouseEventArgs e)
        {

            if (_dropped == null) return;
            var itemOver = lvRules.GetItemAt(0, e.Y);

            if (itemOver == null || itemOver == _dropped)
            {
                Cursor = Cursors.Default;
                return;
            }
            var r = _knowledgeBase.Rules[_dropped.Index];
            if (itemOver.Index > _dropped.Index)
            {
                _knowledgeBase.Rules.RemoveAt(_dropped.Index);
                _knowledgeBase.Rules.Insert(itemOver.Index, r);
                lvRules.Items.Remove(_dropped);
                lvRules.Items.Insert(itemOver.Index + 1, _dropped);
            }
            else
            {
                _knowledgeBase.Rules.RemoveAt(_dropped.Index);
                _knowledgeBase.Rules.Insert(itemOver.Index, r);
                lvRules.Items.Remove(_dropped);
                lvRules.Items.Insert(itemOver.Index, _dropped);
            }

            Cursor = Cursors.Default;
            _knowledgeBase.IsChanged = true;
        }

        private void listViewRules_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dropped == null) return;
            Cursor = Cursors.Hand;
        }

        private void listViewVars_MouseDown(object sender, MouseEventArgs e)
        {
            _dropped = lvVars.GetItemAt(e.X, e.Y);
        }

        private void listViewVars_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dropped == null) return;
            Cursor = Cursors.Hand;
        }

        private void listViewVars_MouseUp(object sender, MouseEventArgs e)
        {
            if (_dropped == null) return;
            var itemOver = lvVars.GetItemAt(0, e.Y);

            if (itemOver == null || itemOver == _dropped)
            {
                Cursor = Cursors.Default;
                return;
            }
            var v = _knowledgeBase.Vars[_dropped.Index];
            if (itemOver.Index > _dropped.Index)
            {
                _knowledgeBase.Vars.RemoveAt(_dropped.Index);
                _knowledgeBase.Vars.Insert(itemOver.Index, v);
                lvVars.Items.Remove(_dropped);
                lvVars.Items.Insert(itemOver.Index + 1, _dropped);
            }
            else
            {
                _knowledgeBase.Vars.RemoveAt(_dropped.Index);
                _knowledgeBase.Vars.Insert(itemOver.Index, v);
                lvVars.Items.Remove(_dropped);
                lvVars.Items.Insert(itemOver.Index, _dropped);
            }
      
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
            if (_knowledgeBase.Vars.Count == 0)
            {
                MessageBox.Show("There are no variables", "Error");
                return;
            }

            if (_goal == null)
            {
                MessageBox.Show("Goal is not choosen", "Error");
                return;
            }
            _inferenceEngine = new InferenceEngine(_knowledgeBase);
            _inferenceEngine.SetPrimaryGoal(_goal);
            try
            {
                var result = _inferenceEngine.Start();
                if (result == null)
                {
                    MessageBox.Show("Failed to deduce goal", "Error");
                    return;
                }
                var formResult = new FormResultConsult(_inferenceEngine, result.ToString());
                formResult.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Goal is not reached", "Error");
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            SplittersConstruct();
            FillVars();
            FillDomains();
            FillRules();
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

            if (MessageBox.Show("Do you want to save results?",
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

        private void menuExplanation_Click(object sender, EventArgs e)
        {
            // TODO: Check invalid goal
            if (_inferenceEngine?.ExplainTree == null)
            {
                MessageBox.Show("Consultation is not finished", "Error");
                return;
            }
            var f = new FormExplain(_inferenceEngine.ExplainTree, _inferenceEngine.log, _inferenceEngine.WorkingMemory);
            f.ShowDialog();
        }

        private void cbGoal_SelectedIndexChanged(object sender, EventArgs e)
        {
            _goal = _knowledgeBase.Vars.Find(v => v.Name == (string) ((ToolStripComboBox) sender).SelectedItem);
        }

        private void lvRules_Leave(object sender, EventArgs e)
        {
            //lvRules.Select();
        }
        
        private void lvVars_Leave(object sender, EventArgs e)
        {
            //lvVars.Select();
        }
        
        private void lvDomains_Leave(object sender, EventArgs e)
        {
            //lvDomains.Select();
        }
    }
}
