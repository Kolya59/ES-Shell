using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ES
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFile_New = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFile_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFile_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFile_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultation = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExplanation = new System.Windows.Forms.ToolStripMenuItem();
            this.cbGoal = new System.Windows.Forms.ToolStripComboBox();
            this.goalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpRules = new System.Windows.Forms.TabPage();
            this.splitContainerRules = new System.Windows.Forms.SplitContainer();
            this.lvRules = new System.Windows.Forms.ListView();
            this.cName = new System.Windows.Forms.ColumnHeader();
            this.cDescription = new System.Windows.Forms.ColumnHeader();
            this.gbConclusion = new System.Windows.Forms.GroupBox();
            this.tbConclusion = new System.Windows.Forms.TextBox();
            this.gbActions = new System.Windows.Forms.GroupBox();
            this.btDeleteRule = new System.Windows.Forms.Button();
            this.btEditRule = new System.Windows.Forms.Button();
            this.buttonAddRule = new System.Windows.Forms.Button();
            this.gbCondition = new System.Windows.Forms.GroupBox();
            this.tbCondition = new System.Windows.Forms.TextBox();
            this.tpVariables = new System.Windows.Forms.TabPage();
            this.splitContainerVars = new System.Windows.Forms.SplitContainer();
            this.lvVars = new System.Windows.Forms.ListView();
            this.chName = new System.Windows.Forms.ColumnHeader();
            this.chKind = new System.Windows.Forms.ColumnHeader();
            this.chDomain = new System.Windows.Forms.ColumnHeader();
            this.gbDomainValues = new System.Windows.Forms.GroupBox();
            this.lbDomainValuesForVar = new System.Windows.Forms.ListBox();
            this.gbQuestion = new System.Windows.Forms.GroupBox();
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btDeleteVar = new System.Windows.Forms.Button();
            this.btEditVar = new System.Windows.Forms.Button();
            this.buttonAddVar = new System.Windows.Forms.Button();
            this.tpDomains = new System.Windows.Forms.TabPage();
            this.splitContainerDomains = new System.Windows.Forms.SplitContainer();
            this.lvDomains = new System.Windows.Forms.ListView();
            this.chDomainName = new System.Windows.Forms.ColumnHeader();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBoxDomainValues = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btDeleteDomain = new System.Windows.Forms.Button();
            this.btEditDomain = new System.Windows.Forms.Button();
            this.buttonAddDomain = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tpRules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.splitContainerRules)).BeginInit();
            this.splitContainerRules.Panel1.SuspendLayout();
            this.splitContainerRules.Panel2.SuspendLayout();
            this.splitContainerRules.SuspendLayout();
            this.gbConclusion.SuspendLayout();
            this.gbActions.SuspendLayout();
            this.gbCondition.SuspendLayout();
            this.tpVariables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.splitContainerVars)).BeginInit();
            this.splitContainerVars.Panel1.SuspendLayout();
            this.splitContainerVars.Panel2.SuspendLayout();
            this.splitContainerVars.SuspendLayout();
            this.gbDomainValues.SuspendLayout();
            this.gbQuestion.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tpDomains.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.splitContainerDomains)).BeginInit();
            this.splitContainerDomains.Panel1.SuspendLayout();
            this.splitContainerDomains.Panel2.SuspendLayout();
            this.splitContainerDomains.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.menuFile, this.menuConsultation, this.menuExplanation, this.cbGoal, this.goalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(784, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.menuFile_New, this.menuFile_Open, this.menuFile_Save, this.menuFile_SaveAs});
            this.menuFile.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(43, 24);
            this.menuFile.Text = "Main";
            // 
            // menuFile_New
            // 
            this.menuFile_New.Name = "menuFile_New";
            this.menuFile_New.Size = new System.Drawing.Size(115, 22);
            this.menuFile_New.Text = "New";
            this.menuFile_New.Click += new System.EventHandler(this.menuFile_New_Click);
            // 
            // menuFile_Open
            // 
            this.menuFile_Open.Name = "menuFile_Open";
            this.menuFile_Open.Size = new System.Drawing.Size(115, 22);
            this.menuFile_Open.Text = "Open";
            this.menuFile_Open.Click += new System.EventHandler(this.menuFile_Open_Click);
            // 
            // menuFile_Save
            // 
            this.menuFile_Save.Name = "menuFile_Save";
            this.menuFile_Save.Size = new System.Drawing.Size(115, 22);
            this.menuFile_Save.Text = "Save";
            this.menuFile_Save.Click += new System.EventHandler(this.menuFile_Save_Click);
            // 
            // menuFile_SaveAs
            // 
            this.menuFile_SaveAs.Name = "menuFile_SaveAs";
            this.menuFile_SaveAs.Size = new System.Drawing.Size(115, 22);
            this.menuFile_SaveAs.Text = "Save as";
            this.menuFile_SaveAs.Click += new System.EventHandler(this.menuFile_SaveAs_Click);
            // 
            // menuConsultation
            // 
            this.menuConsultation.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.menuConsultation.Name = "menuConsultation";
            this.menuConsultation.Size = new System.Drawing.Size(86, 24);
            this.menuConsultation.Text = "Consultation";
            this.menuConsultation.Click += new System.EventHandler(this.menuConsultation_Click);
            // 
            // menuExplanation
            // 
            this.menuExplanation.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.menuExplanation.Name = "menuExplanation";
            this.menuExplanation.Size = new System.Drawing.Size(81, 24);
            this.menuExplanation.Text = "Explanation";
            this.menuExplanation.Click += new System.EventHandler(this.menuExplanation_Click);
            // 
            // cbGoal
            // 
            this.cbGoal.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cbGoal.AutoSize = false;
            this.cbGoal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbGoal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGoal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbGoal.Name = "cbGoal";
            this.cbGoal.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cbGoal.Size = new System.Drawing.Size(0, 24);
            this.cbGoal.SelectedIndexChanged += new System.EventHandler(this.cbGoal_SelectedIndexChanged);
            // 
            // goalToolStripMenuItem
            // 
            this.goalToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.goalToolStripMenuItem.Checked = true;
            this.goalToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.goalToolStripMenuItem.Enabled = false;
            this.goalToolStripMenuItem.Name = "goalToolStripMenuItem";
            this.goalToolStripMenuItem.Size = new System.Drawing.Size(43, 24);
            this.goalToolStripMenuItem.Text = "Goal";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpRules);
            this.tabControl.Controls.Add(this.tpVariables);
            this.tabControl.Controls.Add(this.tpDomains);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.tabControl.Location = new System.Drawing.Point(0, 28);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(15, 5);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(784, 533);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tpRules
            // 
            this.tpRules.Controls.Add(this.splitContainerRules);
            this.tpRules.Location = new System.Drawing.Point(4, 26);
            this.tpRules.Margin = new System.Windows.Forms.Padding(2);
            this.tpRules.Name = "tpRules";
            this.tpRules.Padding = new System.Windows.Forms.Padding(2);
            this.tpRules.Size = new System.Drawing.Size(776, 503);
            this.tpRules.TabIndex = 0;
            this.tpRules.Text = "Rules";
            this.tpRules.UseVisualStyleBackColor = true;
            // 
            // splitContainerRules
            // 
            this.splitContainerRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerRules.Location = new System.Drawing.Point(2, 2);
            this.splitContainerRules.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainerRules.Name = "splitContainerRules";
            // 
            // splitContainerRules.Panel1
            // 
            this.splitContainerRules.Panel1.Controls.Add(this.lvRules);
            // 
            // splitContainerRules.Panel2
            // 
            this.splitContainerRules.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainerRules.Panel2.Controls.Add(this.gbConclusion);
            this.splitContainerRules.Panel2.Controls.Add(this.gbActions);
            this.splitContainerRules.Panel2.Controls.Add(this.gbCondition);
            this.splitContainerRules.Size = new System.Drawing.Size(772, 499);
            this.splitContainerRules.SplitterDistance = 557;
            this.splitContainerRules.SplitterWidth = 3;
            this.splitContainerRules.TabIndex = 0;
            // 
            // lvRules
            // 
            this.lvRules.AllowDrop = true;
            this.lvRules.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lvRules.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {this.cName, this.cDescription});
            this.lvRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvRules.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.lvRules.FullRowSelect = true;
            this.lvRules.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvRules.HideSelection = false;
            this.lvRules.Location = new System.Drawing.Point(0, 0);
            this.lvRules.Margin = new System.Windows.Forms.Padding(2);
            this.lvRules.MultiSelect = false;
            this.lvRules.Name = "lvRules";
            this.lvRules.Size = new System.Drawing.Size(557, 499);
            this.lvRules.TabIndex = 0;
            this.lvRules.UseCompatibleStateImageBehavior = false;
            this.lvRules.View = System.Windows.Forms.View.Details;
            this.lvRules.SelectedIndexChanged += new System.EventHandler(this.listViewRules_SelectedIndexChanged);
            this.lvRules.Leave += new System.EventHandler(this.lvRules_Leave);
            this.lvRules.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewRules_MouseDown);
            this.lvRules.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listViewRules_MouseMove);
            this.lvRules.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listViewRules_MouseUp);
            // 
            // cName
            // 
            this.cName.Text = "Name";
            this.cName.Width = 81;
            // 
            // cDescription
            // 
            this.cDescription.Text = "Description";
            this.cDescription.Width = 591;
            // 
            // gbConclusion
            // 
            this.gbConclusion.Controls.Add(this.tbConclusion);
            this.gbConclusion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbConclusion.Location = new System.Drawing.Point(10, 286);
            this.gbConclusion.Margin = new System.Windows.Forms.Padding(2);
            this.gbConclusion.Name = "gbConclusion";
            this.gbConclusion.Padding = new System.Windows.Forms.Padding(2);
            this.gbConclusion.Size = new System.Drawing.Size(184, 211);
            this.gbConclusion.TabIndex = 4;
            this.gbConclusion.TabStop = false;
            this.gbConclusion.Text = "Conclusions";
            // 
            // tbConclusion
            // 
            this.tbConclusion.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tbConclusion.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbConclusion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbConclusion.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbConclusion.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.tbConclusion.Location = new System.Drawing.Point(4, 15);
            this.tbConclusion.Margin = new System.Windows.Forms.Padding(2);
            this.tbConclusion.Multiline = true;
            this.tbConclusion.Name = "tbConclusion";
            this.tbConclusion.ReadOnly = true;
            this.tbConclusion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbConclusion.Size = new System.Drawing.Size(180, 187);
            this.tbConclusion.TabIndex = 0;
            // 
            // gbActions
            // 
            this.gbActions.Controls.Add(this.btDeleteRule);
            this.gbActions.Controls.Add(this.btEditRule);
            this.gbActions.Controls.Add(this.buttonAddRule);
            this.gbActions.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbActions.Location = new System.Drawing.Point(10, 12);
            this.gbActions.Margin = new System.Windows.Forms.Padding(2);
            this.gbActions.Name = "gbActions";
            this.gbActions.Padding = new System.Windows.Forms.Padding(2);
            this.gbActions.Size = new System.Drawing.Size(188, 56);
            this.gbActions.TabIndex = 0;
            this.gbActions.TabStop = false;
            this.gbActions.Text = "Actions";
            // 
            // btDeleteRule
            // 
            this.btDeleteRule.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (128)))));
            this.btDeleteRule.Enabled = false;
            this.btDeleteRule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeleteRule.ForeColor = System.Drawing.Color.Black;
            this.btDeleteRule.Image = ((System.Drawing.Image) (resources.GetObject("btDeleteRule.Image")));
            this.btDeleteRule.Location = new System.Drawing.Point(126, 18);
            this.btDeleteRule.Margin = new System.Windows.Forms.Padding(2);
            this.btDeleteRule.Name = "btDeleteRule";
            this.btDeleteRule.Size = new System.Drawing.Size(60, 27);
            this.btDeleteRule.TabIndex = 3;
            this.btDeleteRule.UseVisualStyleBackColor = false;
            this.btDeleteRule.Click += new System.EventHandler(this.buttonDeleteRule_Click);
            // 
            // btEditRule
            // 
            this.btEditRule.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (255)))), ((int) (((byte) (128)))));
            this.btEditRule.Enabled = false;
            this.btEditRule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditRule.ForeColor = System.Drawing.Color.Black;
            this.btEditRule.Image = ((System.Drawing.Image) (resources.GetObject("btEditRule.Image")));
            this.btEditRule.Location = new System.Drawing.Point(64, 18);
            this.btEditRule.Margin = new System.Windows.Forms.Padding(2);
            this.btEditRule.Name = "btEditRule";
            this.btEditRule.Size = new System.Drawing.Size(60, 27);
            this.btEditRule.TabIndex = 2;
            this.btEditRule.UseVisualStyleBackColor = false;
            this.btEditRule.Click += new System.EventHandler(this.buttonEditRule_Click);
            // 
            // buttonAddRule
            // 
            this.buttonAddRule.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.buttonAddRule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddRule.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAddRule.Image = ((System.Drawing.Image) (resources.GetObject("buttonAddRule.Image")));
            this.buttonAddRule.Location = new System.Drawing.Point(2, 18);
            this.buttonAddRule.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddRule.Name = "buttonAddRule";
            this.buttonAddRule.Size = new System.Drawing.Size(60, 27);
            this.buttonAddRule.TabIndex = 1;
            this.buttonAddRule.UseVisualStyleBackColor = false;
            this.buttonAddRule.Click += new System.EventHandler(this.buttonAddRule_Click);
            // 
            // gbCondition
            // 
            this.gbCondition.Controls.Add(this.tbCondition);
            this.gbCondition.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbCondition.Location = new System.Drawing.Point(10, 71);
            this.gbCondition.Margin = new System.Windows.Forms.Padding(2);
            this.gbCondition.Name = "gbCondition";
            this.gbCondition.Padding = new System.Windows.Forms.Padding(2);
            this.gbCondition.Size = new System.Drawing.Size(188, 211);
            this.gbCondition.TabIndex = 3;
            this.gbCondition.TabStop = false;
            this.gbCondition.Text = "Conditions";
            // 
            // tbCondition
            // 
            this.tbCondition.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCondition.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbCondition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCondition.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbCondition.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.tbCondition.Location = new System.Drawing.Point(4, 15);
            this.tbCondition.Margin = new System.Windows.Forms.Padding(2);
            this.tbCondition.Multiline = true;
            this.tbCondition.Name = "tbCondition";
            this.tbCondition.ReadOnly = true;
            this.tbCondition.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbCondition.Size = new System.Drawing.Size(180, 187);
            this.tbCondition.TabIndex = 0;
            // 
            // tpVariables
            // 
            this.tpVariables.Controls.Add(this.splitContainerVars);
            this.tpVariables.Location = new System.Drawing.Point(4, 26);
            this.tpVariables.Margin = new System.Windows.Forms.Padding(2);
            this.tpVariables.Name = "tpVariables";
            this.tpVariables.Padding = new System.Windows.Forms.Padding(2);
            this.tpVariables.Size = new System.Drawing.Size(776, 504);
            this.tpVariables.TabIndex = 1;
            this.tpVariables.Text = "Variables";
            this.tpVariables.UseVisualStyleBackColor = true;
            // 
            // splitContainerVars
            // 
            this.splitContainerVars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerVars.Location = new System.Drawing.Point(2, 2);
            this.splitContainerVars.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainerVars.Name = "splitContainerVars";
            // 
            // splitContainerVars.Panel1
            // 
            this.splitContainerVars.Panel1.Controls.Add(this.lvVars);
            // 
            // splitContainerVars.Panel2
            // 
            this.splitContainerVars.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainerVars.Panel2.Controls.Add(this.gbDomainValues);
            this.splitContainerVars.Panel2.Controls.Add(this.gbQuestion);
            this.splitContainerVars.Panel2.Controls.Add(this.groupBox2);
            this.splitContainerVars.Size = new System.Drawing.Size(772, 500);
            this.splitContainerVars.SplitterDistance = 562;
            this.splitContainerVars.SplitterWidth = 3;
            this.splitContainerVars.TabIndex = 0;
            // 
            // lvVars
            // 
            this.lvVars.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lvVars.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {this.chName, this.chKind, this.chDomain});
            this.lvVars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvVars.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.lvVars.FullRowSelect = true;
            this.lvVars.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvVars.HideSelection = false;
            this.lvVars.Location = new System.Drawing.Point(0, 0);
            this.lvVars.Margin = new System.Windows.Forms.Padding(2);
            this.lvVars.MultiSelect = false;
            this.lvVars.Name = "lvVars";
            this.lvVars.Size = new System.Drawing.Size(562, 500);
            this.lvVars.TabIndex = 0;
            this.lvVars.UseCompatibleStateImageBehavior = false;
            this.lvVars.View = System.Windows.Forms.View.Details;
            this.lvVars.SelectedIndexChanged += new System.EventHandler(this.listViewVars_SelectedIndexChanged);
            this.lvVars.Leave += new System.EventHandler(this.lvVars_Leave);
            this.lvVars.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewVars_MouseDown);
            this.lvVars.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listViewVars_MouseMove);
            this.lvVars.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listViewVars_MouseUp);
            // 
            // chName
            // 
            this.chName.Text = "Name";
            // 
            // chKind
            // 
            this.chKind.Text = "Kind";
            // 
            // chDomain
            // 
            this.chDomain.Text = "Domain";
            // 
            // gbDomainValues
            // 
            this.gbDomainValues.Controls.Add(this.lbDomainValuesForVar);
            this.gbDomainValues.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbDomainValues.Location = new System.Drawing.Point(12, 282);
            this.gbDomainValues.Margin = new System.Windows.Forms.Padding(2);
            this.gbDomainValues.Name = "gbDomainValues";
            this.gbDomainValues.Padding = new System.Windows.Forms.Padding(2);
            this.gbDomainValues.Size = new System.Drawing.Size(184, 209);
            this.gbDomainValues.TabIndex = 4;
            this.gbDomainValues.TabStop = false;
            this.gbDomainValues.Text = "Domain Values";
            // 
            // lbDomainValuesForVar
            // 
            this.lbDomainValuesForVar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbDomainValuesForVar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDomainValuesForVar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.lbDomainValuesForVar.FormattingEnabled = true;
            this.lbDomainValuesForVar.ItemHeight = 17;
            this.lbDomainValuesForVar.Location = new System.Drawing.Point(4, 20);
            this.lbDomainValuesForVar.Margin = new System.Windows.Forms.Padding(2);
            this.lbDomainValuesForVar.Name = "lbDomainValuesForVar";
            this.lbDomainValuesForVar.Size = new System.Drawing.Size(176, 189);
            this.lbDomainValuesForVar.TabIndex = 0;
            // 
            // gbQuestion
            // 
            this.gbQuestion.Controls.Add(this.tbQuestion);
            this.gbQuestion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbQuestion.Location = new System.Drawing.Point(10, 87);
            this.gbQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.gbQuestion.Name = "gbQuestion";
            this.gbQuestion.Padding = new System.Windows.Forms.Padding(2);
            this.gbQuestion.Size = new System.Drawing.Size(188, 191);
            this.gbQuestion.TabIndex = 2;
            this.gbQuestion.TabStop = false;
            this.gbQuestion.Text = "Question Text";
            // 
            // tbQuestion
            // 
            this.tbQuestion.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbQuestion.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbQuestion.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.tbQuestion.Location = new System.Drawing.Point(4, 20);
            this.tbQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.tbQuestion.Multiline = true;
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.ReadOnly = true;
            this.tbQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbQuestion.Size = new System.Drawing.Size(180, 167);
            this.tbQuestion.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btDeleteVar);
            this.groupBox2.Controls.Add(this.btEditVar);
            this.groupBox2.Controls.Add(this.buttonAddVar);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(10, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(188, 55);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            // 
            // btDeleteVar
            // 
            this.btDeleteVar.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (128)))));
            this.btDeleteVar.Enabled = false;
            this.btDeleteVar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeleteVar.Image = ((System.Drawing.Image) (resources.GetObject("btDeleteVar.Image")));
            this.btDeleteVar.Location = new System.Drawing.Point(126, 18);
            this.btDeleteVar.Margin = new System.Windows.Forms.Padding(2);
            this.btDeleteVar.Name = "btDeleteVar";
            this.btDeleteVar.Size = new System.Drawing.Size(60, 27);
            this.btDeleteVar.TabIndex = 3;
            this.btDeleteVar.UseVisualStyleBackColor = false;
            this.btDeleteVar.Click += new System.EventHandler(this.buttonDeleteVar_Click);
            // 
            // btEditVar
            // 
            this.btEditVar.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (255)))), ((int) (((byte) (128)))));
            this.btEditVar.Enabled = false;
            this.btEditVar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditVar.Image = ((System.Drawing.Image) (resources.GetObject("btEditVar.Image")));
            this.btEditVar.Location = new System.Drawing.Point(64, 18);
            this.btEditVar.Margin = new System.Windows.Forms.Padding(2);
            this.btEditVar.Name = "btEditVar";
            this.btEditVar.Size = new System.Drawing.Size(60, 27);
            this.btEditVar.TabIndex = 2;
            this.btEditVar.UseVisualStyleBackColor = false;
            this.btEditVar.Click += new System.EventHandler(this.buttonEditVar_Click);
            // 
            // buttonAddVar
            // 
            this.buttonAddVar.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.buttonAddVar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddVar.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.buttonAddVar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAddVar.Image = ((System.Drawing.Image) (resources.GetObject("buttonAddVar.Image")));
            this.buttonAddVar.Location = new System.Drawing.Point(2, 18);
            this.buttonAddVar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddVar.Name = "buttonAddVar";
            this.buttonAddVar.Size = new System.Drawing.Size(60, 27);
            this.buttonAddVar.TabIndex = 1;
            this.buttonAddVar.UseVisualStyleBackColor = false;
            this.buttonAddVar.Click += new System.EventHandler(this.buttonAddVar_Click);
            // 
            // tpDomains
            // 
            this.tpDomains.Controls.Add(this.splitContainerDomains);
            this.tpDomains.Location = new System.Drawing.Point(4, 26);
            this.tpDomains.Margin = new System.Windows.Forms.Padding(2);
            this.tpDomains.Name = "tpDomains";
            this.tpDomains.Size = new System.Drawing.Size(776, 504);
            this.tpDomains.TabIndex = 2;
            this.tpDomains.Text = "Domains";
            this.tpDomains.UseVisualStyleBackColor = true;
            // 
            // splitContainerDomains
            // 
            this.splitContainerDomains.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerDomains.Location = new System.Drawing.Point(0, 0);
            this.splitContainerDomains.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainerDomains.Name = "splitContainerDomains";
            // 
            // splitContainerDomains.Panel1
            // 
            this.splitContainerDomains.Panel1.Controls.Add(this.lvDomains);
            // 
            // splitContainerDomains.Panel2
            // 
            this.splitContainerDomains.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainerDomains.Panel2.Controls.Add(this.groupBox4);
            this.splitContainerDomains.Panel2.Controls.Add(this.groupBox3);
            this.splitContainerDomains.Size = new System.Drawing.Size(776, 504);
            this.splitContainerDomains.SplitterDistance = 574;
            this.splitContainerDomains.SplitterWidth = 3;
            this.splitContainerDomains.TabIndex = 0;
            // 
            // lvDomains
            // 
            this.lvDomains.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lvDomains.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {this.chDomainName});
            this.lvDomains.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDomains.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.lvDomains.FullRowSelect = true;
            this.lvDomains.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvDomains.HideSelection = false;
            this.lvDomains.Location = new System.Drawing.Point(0, 0);
            this.lvDomains.Margin = new System.Windows.Forms.Padding(2);
            this.lvDomains.MultiSelect = false;
            this.lvDomains.Name = "lvDomains";
            this.lvDomains.Size = new System.Drawing.Size(574, 504);
            this.lvDomains.TabIndex = 0;
            this.lvDomains.UseCompatibleStateImageBehavior = false;
            this.lvDomains.View = System.Windows.Forms.View.Details;
            this.lvDomains.SelectedIndexChanged += new System.EventHandler(this.listViewDomains_SelectedIndexChanged);
            this.lvDomains.Leave += new System.EventHandler(this.lvDomains_Leave);
            // 
            // chDomainName
            // 
            this.chDomainName.Text = "Name";
            this.chDomainName.Width = 326;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBoxDomainValues);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox4.Location = new System.Drawing.Point(10, 72);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(186, 398);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Domain Values";
            // 
            // listBoxDomainValues
            // 
            this.listBoxDomainValues.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listBoxDomainValues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxDomainValues.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.listBoxDomainValues.FormattingEnabled = true;
            this.listBoxDomainValues.ItemHeight = 17;
            this.listBoxDomainValues.Location = new System.Drawing.Point(4, 20);
            this.listBoxDomainValues.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxDomainValues.Name = "listBoxDomainValues";
            this.listBoxDomainValues.Size = new System.Drawing.Size(178, 359);
            this.listBoxDomainValues.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btDeleteDomain);
            this.groupBox3.Controls.Add(this.btEditDomain);
            this.groupBox3.Controls.Add(this.buttonAddDomain);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Location = new System.Drawing.Point(10, 12);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(188, 54);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Actions";
            // 
            // btDeleteDomain
            // 
            this.btDeleteDomain.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (128)))));
            this.btDeleteDomain.Enabled = false;
            this.btDeleteDomain.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btDeleteDomain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeleteDomain.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btDeleteDomain.Image = ((System.Drawing.Image) (resources.GetObject("btDeleteDomain.Image")));
            this.btDeleteDomain.Location = new System.Drawing.Point(126, 18);
            this.btDeleteDomain.Margin = new System.Windows.Forms.Padding(2);
            this.btDeleteDomain.Name = "btDeleteDomain";
            this.btDeleteDomain.Size = new System.Drawing.Size(60, 27);
            this.btDeleteDomain.TabIndex = 3;
            this.btDeleteDomain.UseVisualStyleBackColor = false;
            this.btDeleteDomain.Click += new System.EventHandler(this.buttonDeleteDomain_Click);
            // 
            // btEditDomain
            // 
            this.btEditDomain.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (255)))), ((int) (((byte) (128)))));
            this.btEditDomain.Enabled = false;
            this.btEditDomain.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btEditDomain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditDomain.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btEditDomain.Image = ((System.Drawing.Image) (resources.GetObject("btEditDomain.Image")));
            this.btEditDomain.Location = new System.Drawing.Point(64, 18);
            this.btEditDomain.Margin = new System.Windows.Forms.Padding(2);
            this.btEditDomain.Name = "btEditDomain";
            this.btEditDomain.Size = new System.Drawing.Size(60, 27);
            this.btEditDomain.TabIndex = 2;
            this.btEditDomain.UseVisualStyleBackColor = false;
            this.btEditDomain.Click += new System.EventHandler(this.buttonEditDomain_Click);
            // 
            // buttonAddDomain
            // 
            this.buttonAddDomain.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.buttonAddDomain.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAddDomain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddDomain.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAddDomain.Image = ((System.Drawing.Image) (resources.GetObject("buttonAddDomain.Image")));
            this.buttonAddDomain.Location = new System.Drawing.Point(2, 18);
            this.buttonAddDomain.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddDomain.Name = "buttonAddDomain";
            this.buttonAddDomain.Size = new System.Drawing.Size(60, 27);
            this.buttonAddDomain.TabIndex = 1;
            this.buttonAddDomain.UseVisualStyleBackColor = false;
            this.buttonAddDomain.Click += new System.EventHandler(this.buttonAddDomain_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.Text = "ES";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tpRules.ResumeLayout(false);
            this.splitContainerRules.Panel1.ResumeLayout(false);
            this.splitContainerRules.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.splitContainerRules)).EndInit();
            this.splitContainerRules.ResumeLayout(false);
            this.gbConclusion.ResumeLayout(false);
            this.gbConclusion.PerformLayout();
            this.gbActions.ResumeLayout(false);
            this.gbCondition.ResumeLayout(false);
            this.gbCondition.PerformLayout();
            this.tpVariables.ResumeLayout(false);
            this.splitContainerVars.Panel1.ResumeLayout(false);
            this.splitContainerVars.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.splitContainerVars)).EndInit();
            this.splitContainerVars.ResumeLayout(false);
            this.gbDomainValues.ResumeLayout(false);
            this.gbQuestion.ResumeLayout(false);
            this.gbQuestion.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tpDomains.ResumeLayout(false);
            this.splitContainerDomains.Panel1.ResumeLayout(false);
            this.splitContainerDomains.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.splitContainerDomains)).EndInit();
            this.splitContainerDomains.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btDeleteDomain;
        private System.Windows.Forms.Button btDeleteRule;
        private System.Windows.Forms.Button btDeleteVar;
        private System.Windows.Forms.Button btEditDomain;
        private System.Windows.Forms.Button btEditRule;
        private System.Windows.Forms.Button btEditVar;
        private System.Windows.Forms.Button buttonAddDomain;
        private System.Windows.Forms.Button buttonAddRule;
        private System.Windows.Forms.Button buttonAddVar;
        private System.Windows.Forms.ToolStripComboBox cbGoal;
        private System.Windows.Forms.ColumnHeader cDescription;
        private System.Windows.Forms.ColumnHeader chDomain;
        private System.Windows.Forms.ColumnHeader chDomainName;
        private System.Windows.Forms.ColumnHeader chKind;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader cName;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox gbActions;
        private System.Windows.Forms.GroupBox gbConclusion;
        private System.Windows.Forms.GroupBox gbCondition;
        private System.Windows.Forms.GroupBox gbDomainValues;
        private System.Windows.Forms.GroupBox gbQuestion;
        private System.Windows.Forms.ToolStripMenuItem goalToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lbDomainValuesForVar;
        private System.Windows.Forms.ListBox listBoxDomainValues;
        private System.Windows.Forms.ListView lvDomains;
        private System.Windows.Forms.ListView lvRules;
        private System.Windows.Forms.ListView lvVars;
        private System.Windows.Forms.ToolStripMenuItem menuConsultation;
        private System.Windows.Forms.ToolStripMenuItem menuExplanation;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFile_New;
        private System.Windows.Forms.ToolStripMenuItem menuFile_Open;
        private System.Windows.Forms.ToolStripMenuItem menuFile_Save;
        private System.Windows.Forms.ToolStripMenuItem menuFile_SaveAs;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SplitContainer splitContainerDomains;
        private System.Windows.Forms.SplitContainer splitContainerRules;
        private System.Windows.Forms.SplitContainer splitContainerVars;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TextBox tbConclusion;
        private System.Windows.Forms.TextBox tbCondition;
        private System.Windows.Forms.TextBox tbQuestion;
        private System.Windows.Forms.TabPage tpDomains;
        private System.Windows.Forms.TabPage tpRules;
        private System.Windows.Forms.TabPage tpVariables;

        #endregion
    }
}

