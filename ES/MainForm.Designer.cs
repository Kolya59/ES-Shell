using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ES.FormComponent;

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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFile_New = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFile_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFile_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFile_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultation = new System.Windows.Forms.ToolStripMenuItem();
            this.начатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReasoning = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainerRules = new System.Windows.Forms.SplitContainer();
            this.listViewRules = new System.Windows.Forms.ListView();
            this.Имя = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBoxZakl = new ES.FormComponent.ReadOnlyTextBox(this.components);
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBoxPosilka = new ES.FormComponent.ReadOnlyTextBox(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDeleteRule = new System.Windows.Forms.Button();
            this.buttonEditRule = new System.Windows.Forms.Button();
            this.buttonAddRule = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainerVars = new System.Windows.Forms.SplitContainer();
            this.listViewVars = new System.Windows.Forms.ListView();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.listBoxDomainValuesForVar = new System.Windows.Forms.ListBox();
            this.groupBoxQuestion = new System.Windows.Forms.GroupBox();
            this.textBoxQuestion = new ES.FormComponent.ReadOnlyTextBox(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonDeleteVar = new System.Windows.Forms.Button();
            this.buttonEditVar = new System.Windows.Forms.Button();
            this.buttonAddVar = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainerDomains = new System.Windows.Forms.SplitContainer();
            this.listViewDomains = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBoxDomainValues = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonDeleteDomain = new System.Windows.Forms.Button();
            this.buttonEditDomain = new System.Windows.Forms.Button();
            this.buttonAddDomain = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.splitContainerRules)).BeginInit();
            this.splitContainerRules.Panel1.SuspendLayout();
            this.splitContainerRules.Panel2.SuspendLayout();
            this.splitContainerRules.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.splitContainerVars)).BeginInit();
            this.splitContainerVars.Panel1.SuspendLayout();
            this.splitContainerVars.Panel2.SuspendLayout();
            this.splitContainerVars.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBoxQuestion.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
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
            this.menuStrip1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.menuFile, this.menuConsultation, this.menuReasoning});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(838, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.menuFile_New, this.menuFile_Open, this.menuFile_Save, this.menuFile_SaveAs});
            this.menuFile.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(49, 20);
            this.menuFile.Text = "Файл";
            // 
            // menuFile_New
            // 
            this.menuFile_New.Name = "menuFile_New";
            this.menuFile_New.Size = new System.Drawing.Size(167, 22);
            this.menuFile_New.Text = "Новый";
            this.menuFile_New.Click += new System.EventHandler(this.menuFile_New_Click);
            // 
            // menuFile_Open
            // 
            this.menuFile_Open.Name = "menuFile_Open";
            this.menuFile_Open.Size = new System.Drawing.Size(167, 22);
            this.menuFile_Open.Text = "Открыть";
            this.menuFile_Open.Click += new System.EventHandler(this.menuFile_Open_Click);
            // 
            // menuFile_Save
            // 
            this.menuFile_Save.Name = "menuFile_Save";
            this.menuFile_Save.Size = new System.Drawing.Size(167, 22);
            this.menuFile_Save.Text = "Сохранить";
            this.menuFile_Save.Click += new System.EventHandler(this.menuFile_Save_Click);
            // 
            // menuFile_SaveAs
            // 
            this.menuFile_SaveAs.Name = "menuFile_SaveAs";
            this.menuFile_SaveAs.Size = new System.Drawing.Size(167, 22);
            this.menuFile_SaveAs.Text = "Сохранить как...";
            this.menuFile_SaveAs.Click += new System.EventHandler(this.menuFile_SaveAs_Click);
            // 
            // menuConsultation
            // 
            this.menuConsultation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.начатьToolStripMenuItem});
            this.menuConsultation.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.menuConsultation.Name = "menuConsultation";
            this.menuConsultation.Size = new System.Drawing.Size(98, 20);
            this.menuConsultation.Text = "Консультация";
            // 
            // начатьToolStripMenuItem
            // 
            this.начатьToolStripMenuItem.Name = "начатьToolStripMenuItem";
            this.начатьToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.начатьToolStripMenuItem.Text = "Начать";
            this.начатьToolStripMenuItem.Click += new System.EventHandler(this.начатьToolStripMenuItem_Click);
            // 
            // menuReasoning
            // 
            this.menuReasoning.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.menuReasoning.Name = "menuReasoning";
            this.menuReasoning.Size = new System.Drawing.Size(90, 20);
            this.menuReasoning.Text = "Объяснение";
            this.menuReasoning.Click += new System.EventHandler(this.menuReasoning_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(15, 5);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(838, 555);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainerRules);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(830, 525);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Правила";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.splitContainerRules.Panel1.Controls.Add(this.listViewRules);
            // 
            // splitContainerRules.Panel2
            // 
            this.splitContainerRules.Panel2.Controls.Add(this.groupBox7);
            this.splitContainerRules.Panel2.Controls.Add(this.groupBox6);
            this.splitContainerRules.Panel2.Controls.Add(this.groupBox1);
            this.splitContainerRules.Size = new System.Drawing.Size(826, 521);
            this.splitContainerRules.SplitterDistance = 597;
            this.splitContainerRules.SplitterWidth = 3;
            this.splitContainerRules.TabIndex = 0;
            // 
            // listViewRules
            // 
            this.listViewRules.AllowDrop = true;
            this.listViewRules.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {this.Имя, this.columnHeader5});
            this.listViewRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewRules.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.listViewRules.FullRowSelect = true;
            this.listViewRules.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewRules.Location = new System.Drawing.Point(0, 0);
            this.listViewRules.Margin = new System.Windows.Forms.Padding(2);
            this.listViewRules.MultiSelect = false;
            this.listViewRules.Name = "listViewRules";
            this.listViewRules.Size = new System.Drawing.Size(597, 521);
            this.listViewRules.TabIndex = 0;
            this.listViewRules.UseCompatibleStateImageBehavior = false;
            this.listViewRules.View = System.Windows.Forms.View.Details;
            this.listViewRules.SelectedIndexChanged += new System.EventHandler(this.listViewRules_SelectedIndexChanged);
            this.listViewRules.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewRules_MouseDown);
            this.listViewRules.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listViewRules_MouseMove);
            this.listViewRules.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listViewRules_MouseUp);
            // 
            // Имя
            // 
            this.Имя.Text = "Имя";
            this.Имя.Width = 81;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Описание";
            this.columnHeader5.Width = 591;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBoxZakl);
            this.groupBox7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox7.Location = new System.Drawing.Point(18, 413);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox7.Size = new System.Drawing.Size(166, 85);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Заключение";
            // 
            // textBoxZakl
            // 
            this.textBoxZakl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxZakl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxZakl.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxZakl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.textBoxZakl.Location = new System.Drawing.Point(4, 15);
            this.textBoxZakl.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxZakl.Multiline = true;
            this.textBoxZakl.Name = "textBoxZakl";
            this.textBoxZakl.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxZakl.Size = new System.Drawing.Size(158, 66);
            this.textBoxZakl.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBoxPosilka);
            this.groupBox6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox6.Location = new System.Drawing.Point(18, 187);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(166, 211);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Посылка";
            // 
            // textBoxPosilka
            // 
            this.textBoxPosilka.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxPosilka.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPosilka.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxPosilka.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.textBoxPosilka.Location = new System.Drawing.Point(4, 20);
            this.textBoxPosilka.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPosilka.Multiline = true;
            this.textBoxPosilka.Name = "textBoxPosilka";
            this.textBoxPosilka.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPosilka.Size = new System.Drawing.Size(158, 179);
            this.textBoxPosilka.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDeleteRule);
            this.groupBox1.Controls.Add(this.buttonEditRule);
            this.groupBox1.Controls.Add(this.buttonAddRule);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(18, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(161, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Редактирование";
            // 
            // buttonDeleteRule
            // 
            this.buttonDeleteRule.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDeleteRule.ForeColor = System.Drawing.Color.Black;
            this.buttonDeleteRule.Location = new System.Drawing.Point(18, 91);
            this.buttonDeleteRule.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeleteRule.Name = "buttonDeleteRule";
            this.buttonDeleteRule.Size = new System.Drawing.Size(131, 26);
            this.buttonDeleteRule.TabIndex = 3;
            this.buttonDeleteRule.Text = "Удалить";
            this.buttonDeleteRule.UseVisualStyleBackColor = false;
            this.buttonDeleteRule.Click += new System.EventHandler(this.buttonDeleteRule_Click);
            // 
            // buttonEditRule
            // 
            this.buttonEditRule.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEditRule.ForeColor = System.Drawing.Color.Black;
            this.buttonEditRule.Location = new System.Drawing.Point(18, 59);
            this.buttonEditRule.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEditRule.Name = "buttonEditRule";
            this.buttonEditRule.Size = new System.Drawing.Size(131, 27);
            this.buttonEditRule.TabIndex = 2;
            this.buttonEditRule.Text = "Изменить";
            this.buttonEditRule.UseVisualStyleBackColor = false;
            this.buttonEditRule.Click += new System.EventHandler(this.buttonEditRule_Click);
            // 
            // buttonAddRule
            // 
            this.buttonAddRule.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAddRule.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAddRule.Location = new System.Drawing.Point(18, 28);
            this.buttonAddRule.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddRule.Name = "buttonAddRule";
            this.buttonAddRule.Size = new System.Drawing.Size(131, 27);
            this.buttonAddRule.TabIndex = 1;
            this.buttonAddRule.Text = "Добавить";
            this.buttonAddRule.UseVisualStyleBackColor = false;
            this.buttonAddRule.Click += new System.EventHandler(this.buttonAddRule_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainerVars);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(830, 525);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Переменные";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.splitContainerVars.Panel1.Controls.Add(this.listViewVars);
            // 
            // splitContainerVars.Panel2
            // 
            this.splitContainerVars.Panel2.Controls.Add(this.groupBox8);
            this.splitContainerVars.Panel2.Controls.Add(this.groupBoxQuestion);
            this.splitContainerVars.Panel2.Controls.Add(this.groupBox2);
            this.splitContainerVars.Size = new System.Drawing.Size(826, 521);
            this.splitContainerVars.SplitterDistance = 602;
            this.splitContainerVars.SplitterWidth = 3;
            this.splitContainerVars.TabIndex = 0;
            // 
            // listViewVars
            // 
            this.listViewVars.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {this.columnHeader2, this.columnHeader3, this.columnHeader4});
            this.listViewVars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewVars.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.listViewVars.FullRowSelect = true;
            this.listViewVars.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewVars.Location = new System.Drawing.Point(0, 0);
            this.listViewVars.Margin = new System.Windows.Forms.Padding(2);
            this.listViewVars.MultiSelect = false;
            this.listViewVars.Name = "listViewVars";
            this.listViewVars.Size = new System.Drawing.Size(602, 521);
            this.listViewVars.TabIndex = 0;
            this.listViewVars.UseCompatibleStateImageBehavior = false;
            this.listViewVars.View = System.Windows.Forms.View.Details;
            this.listViewVars.SelectedIndexChanged += new System.EventHandler(this.listViewVars_SelectedIndexChanged);
            this.listViewVars.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewVars_MouseDown);
            this.listViewVars.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listViewVars_MouseMove);
            this.listViewVars.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listViewVars_MouseUp);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Имя";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Тип";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Домен";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.listBoxDomainValuesForVar);
            this.groupBox8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox8.Location = new System.Drawing.Point(18, 313);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox8.Size = new System.Drawing.Size(166, 178);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Значения домена";
            // 
            // listBoxDomainValuesForVar
            // 
            this.listBoxDomainValuesForVar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxDomainValuesForVar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.listBoxDomainValuesForVar.FormattingEnabled = true;
            this.listBoxDomainValuesForVar.ItemHeight = 17;
            this.listBoxDomainValuesForVar.Location = new System.Drawing.Point(4, 20);
            this.listBoxDomainValuesForVar.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxDomainValuesForVar.Name = "listBoxDomainValuesForVar";
            this.listBoxDomainValuesForVar.Size = new System.Drawing.Size(158, 136);
            this.listBoxDomainValuesForVar.TabIndex = 0;
            // 
            // groupBoxQuestion
            // 
            this.groupBoxQuestion.Controls.Add(this.textBoxQuestion);
            this.groupBoxQuestion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBoxQuestion.Location = new System.Drawing.Point(18, 171);
            this.groupBoxQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxQuestion.Name = "groupBoxQuestion";
            this.groupBoxQuestion.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxQuestion.Size = new System.Drawing.Size(166, 116);
            this.groupBoxQuestion.TabIndex = 2;
            this.groupBoxQuestion.TabStop = false;
            this.groupBoxQuestion.Text = "Текст вопроса";
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxQuestion.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxQuestion.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.textBoxQuestion.Location = new System.Drawing.Point(4, 20);
            this.textBoxQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxQuestion.Multiline = true;
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxQuestion.Size = new System.Drawing.Size(158, 92);
            this.textBoxQuestion.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonDeleteVar);
            this.groupBox2.Controls.Add(this.buttonEditVar);
            this.groupBox2.Controls.Add(this.buttonAddVar);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(18, 28);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(166, 128);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Редактирование";
            // 
            // buttonDeleteVar
            // 
            this.buttonDeleteVar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDeleteVar.Location = new System.Drawing.Point(18, 91);
            this.buttonDeleteVar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeleteVar.Name = "buttonDeleteVar";
            this.buttonDeleteVar.Size = new System.Drawing.Size(131, 26);
            this.buttonDeleteVar.TabIndex = 3;
            this.buttonDeleteVar.Text = "Удалить";
            this.buttonDeleteVar.UseVisualStyleBackColor = false;
            this.buttonDeleteVar.Click += new System.EventHandler(this.buttonDeleteVar_Click);
            // 
            // buttonEditVar
            // 
            this.buttonEditVar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEditVar.Location = new System.Drawing.Point(18, 59);
            this.buttonEditVar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEditVar.Name = "buttonEditVar";
            this.buttonEditVar.Size = new System.Drawing.Size(131, 27);
            this.buttonEditVar.TabIndex = 2;
            this.buttonEditVar.Text = "Изменить";
            this.buttonEditVar.UseVisualStyleBackColor = false;
            this.buttonEditVar.Click += new System.EventHandler(this.buttonEditVar_Click);
            // 
            // buttonAddVar
            // 
            this.buttonAddVar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAddVar.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.buttonAddVar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAddVar.Location = new System.Drawing.Point(18, 28);
            this.buttonAddVar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddVar.Name = "buttonAddVar";
            this.buttonAddVar.Size = new System.Drawing.Size(131, 27);
            this.buttonAddVar.TabIndex = 1;
            this.buttonAddVar.Text = "Добавить";
            this.buttonAddVar.UseVisualStyleBackColor = false;
            this.buttonAddVar.Click += new System.EventHandler(this.buttonAddVar_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainerDomains);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(830, 525);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Домены";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            this.splitContainerDomains.Panel1.Controls.Add(this.listViewDomains);
            // 
            // splitContainerDomains.Panel2
            // 
            this.splitContainerDomains.Panel2.Controls.Add(this.groupBox4);
            this.splitContainerDomains.Panel2.Controls.Add(this.groupBox3);
            this.splitContainerDomains.Size = new System.Drawing.Size(830, 525);
            this.splitContainerDomains.SplitterDistance = 614;
            this.splitContainerDomains.SplitterWidth = 3;
            this.splitContainerDomains.TabIndex = 0;
            // 
            // listViewDomains
            // 
            this.listViewDomains.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {this.columnHeader1});
            this.listViewDomains.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewDomains.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.listViewDomains.FullRowSelect = true;
            this.listViewDomains.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewDomains.Location = new System.Drawing.Point(0, 0);
            this.listViewDomains.Margin = new System.Windows.Forms.Padding(2);
            this.listViewDomains.MultiSelect = false;
            this.listViewDomains.Name = "listViewDomains";
            this.listViewDomains.Size = new System.Drawing.Size(614, 525);
            this.listViewDomains.TabIndex = 0;
            this.listViewDomains.UseCompatibleStateImageBehavior = false;
            this.listViewDomains.View = System.Windows.Forms.View.Details;
            this.listViewDomains.SelectedIndexChanged += new System.EventHandler(this.listViewDomains_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Имя";
            this.columnHeader1.Width = 326;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBoxDomainValues);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox4.Location = new System.Drawing.Point(14, 197);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(166, 273);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Значения домена";
            // 
            // listBoxDomainValues
            // 
            this.listBoxDomainValues.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxDomainValues.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.listBoxDomainValues.FormattingEnabled = true;
            this.listBoxDomainValues.ItemHeight = 17;
            this.listBoxDomainValues.Location = new System.Drawing.Point(4, 20);
            this.listBoxDomainValues.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxDomainValues.Name = "listBoxDomainValues";
            this.listBoxDomainValues.Size = new System.Drawing.Size(158, 238);
            this.listBoxDomainValues.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonDeleteDomain);
            this.groupBox3.Controls.Add(this.buttonEditDomain);
            this.groupBox3.Controls.Add(this.buttonAddDomain);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Location = new System.Drawing.Point(14, 42);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(166, 128);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Редактирование";
            // 
            // buttonDeleteDomain
            // 
            this.buttonDeleteDomain.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDeleteDomain.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDeleteDomain.Location = new System.Drawing.Point(18, 91);
            this.buttonDeleteDomain.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeleteDomain.Name = "buttonDeleteDomain";
            this.buttonDeleteDomain.Size = new System.Drawing.Size(131, 26);
            this.buttonDeleteDomain.TabIndex = 3;
            this.buttonDeleteDomain.Text = "Удалить";
            this.buttonDeleteDomain.UseVisualStyleBackColor = false;
            this.buttonDeleteDomain.Click += new System.EventHandler(this.buttonDeleteDomain_Click);
            // 
            // buttonEditDomain
            // 
            this.buttonEditDomain.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEditDomain.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEditDomain.Location = new System.Drawing.Point(18, 59);
            this.buttonEditDomain.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEditDomain.Name = "buttonEditDomain";
            this.buttonEditDomain.Size = new System.Drawing.Size(131, 27);
            this.buttonEditDomain.TabIndex = 2;
            this.buttonEditDomain.Text = "Изменить";
            this.buttonEditDomain.UseVisualStyleBackColor = false;
            this.buttonEditDomain.Click += new System.EventHandler(this.buttonEditDomain_Click);
            // 
            // buttonAddDomain
            // 
            this.buttonAddDomain.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddDomain.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonAddDomain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddDomain.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAddDomain.Location = new System.Drawing.Point(18, 28);
            this.buttonAddDomain.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddDomain.Name = "buttonAddDomain";
            this.buttonAddDomain.Size = new System.Drawing.Size(131, 27);
            this.buttonAddDomain.TabIndex = 1;
            this.buttonAddDomain.Text = "Добавить";
            this.buttonAddDomain.UseVisualStyleBackColor = false;
            this.buttonAddDomain.Click += new System.EventHandler(this.buttonAddDomain_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 579);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "ES";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainerRules.Panel1.ResumeLayout(false);
            this.splitContainerRules.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.splitContainerRules)).EndInit();
            this.splitContainerRules.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainerVars.Panel1.ResumeLayout(false);
            this.splitContainerVars.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.splitContainerVars)).EndInit();
            this.splitContainerVars.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBoxQuestion.ResumeLayout(false);
            this.groupBoxQuestion.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.splitContainerDomains.Panel1.ResumeLayout(false);
            this.splitContainerDomains.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.splitContainerDomains)).EndInit();
            this.splitContainerDomains.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button buttonAddDomain;
        private System.Windows.Forms.Button buttonAddRule;
        private System.Windows.Forms.Button buttonAddVar;
        private System.Windows.Forms.Button buttonDeleteDomain;
        private System.Windows.Forms.Button buttonDeleteRule;
        private System.Windows.Forms.Button buttonDeleteVar;
        private System.Windows.Forms.Button buttonEditDomain;
        private System.Windows.Forms.Button buttonEditRule;
        private System.Windows.Forms.Button buttonEditVar;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBoxQuestion;
        private System.Windows.Forms.ListBox listBoxDomainValues;
        private System.Windows.Forms.ListBox listBoxDomainValuesForVar;
        private System.Windows.Forms.ListView listViewDomains;
        private System.Windows.Forms.ListView listViewRules;
        private System.Windows.Forms.ListView listViewVars;
        private System.Windows.Forms.ToolStripMenuItem menuConsultation;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFile_New;
        private System.Windows.Forms.ToolStripMenuItem menuFile_Open;
        private System.Windows.Forms.ToolStripMenuItem menuFile_Save;
        private System.Windows.Forms.ToolStripMenuItem menuFile_SaveAs;
        private System.Windows.Forms.ToolStripMenuItem menuReasoning;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SplitContainer splitContainerDomains;
        private System.Windows.Forms.SplitContainer splitContainerRules;
        private System.Windows.Forms.SplitContainer splitContainerVars;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private ES.FormComponent.ReadOnlyTextBox textBoxPosilka;
        private ES.FormComponent.ReadOnlyTextBox textBoxQuestion;
        private ES.FormComponent.ReadOnlyTextBox textBoxZakl;
        private System.Windows.Forms.ColumnHeader Имя;
        private System.Windows.Forms.ToolStripMenuItem начатьToolStripMenuItem;

        #endregion
    }
}

