using System.ComponentModel;
using System.Windows.Forms;
using ES.FormComponent;

namespace ES.ESForm
{
    partial class FormExplain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.treeViewExplain = new System.Windows.Forms.TreeView();
            this.okButton = new ES.FormComponent.OkButton(this.components);
            this.listBoxKnownFacts = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageVars = new System.Windows.Forms.TabPage();
            this.tabPageUserAskLogs = new System.Windows.Forms.TabPage();
            this.readOnlyLogs = new ES.FormComponent.ReadOnlyTextBox(this.components);
            this.buttonExpandTree = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageVars.SuspendLayout();
            this.tabPageUserAskLogs.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewExplain
            // 
            this.treeViewExplain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeViewExplain.Location = new System.Drawing.Point(12, 51);
            this.treeViewExplain.Name = "treeViewExplain";
            this.treeViewExplain.Size = new System.Drawing.Size(703, 555);
            this.treeViewExplain.TabIndex = 0;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(250)))), ((int)(((byte)(235)))));
            this.okButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(225)))), ((int)(((byte)(132)))));
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Font = new System.Drawing.Font("Tahoma", 9F);
            this.okButton.Location = new System.Drawing.Point(960, 573);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(95, 38);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // listBoxKnownFacts
            // 
            this.listBoxKnownFacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxKnownFacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxKnownFacts.FormattingEnabled = true;
            this.listBoxKnownFacts.ItemHeight = 22;
            this.listBoxKnownFacts.Location = new System.Drawing.Point(3, 3);
            this.listBoxKnownFacts.Name = "listBoxKnownFacts";
            this.listBoxKnownFacts.Size = new System.Drawing.Size(320, 505);
            this.listBoxKnownFacts.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageVars);
            this.tabControl1.Controls.Add(this.tabPageUserAskLogs);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(721, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(334, 542);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPageVars
            // 
            this.tabPageVars.Controls.Add(this.listBoxKnownFacts);
            this.tabPageVars.Location = new System.Drawing.Point(4, 27);
            this.tabPageVars.Name = "tabPageVars";
            this.tabPageVars.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVars.Size = new System.Drawing.Size(326, 511);
            this.tabPageVars.TabIndex = 0;
            this.tabPageVars.Text = "Переменные";
            this.tabPageVars.UseVisualStyleBackColor = true;
            // 
            // tabPageUserAskLogs
            // 
            this.tabPageUserAskLogs.Controls.Add(this.readOnlyLogs);
            this.tabPageUserAskLogs.Location = new System.Drawing.Point(4, 27);
            this.tabPageUserAskLogs.Name = "tabPageUserAskLogs";
            this.tabPageUserAskLogs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUserAskLogs.Size = new System.Drawing.Size(326, 511);
            this.tabPageUserAskLogs.TabIndex = 1;
            this.tabPageUserAskLogs.Text = "Ответы пользователя";
            this.tabPageUserAskLogs.UseVisualStyleBackColor = true;
            // 
            // readOnlyLogs
            // 
            this.readOnlyLogs.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.readOnlyLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyLogs.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.readOnlyLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.readOnlyLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.readOnlyLogs.Location = new System.Drawing.Point(3, 3);
            this.readOnlyLogs.Multiline = true;
            this.readOnlyLogs.Name = "readOnlyLogs";
            this.readOnlyLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.readOnlyLogs.Size = new System.Drawing.Size(320, 505);
            this.readOnlyLogs.TabIndex = 0;
            // 
            // buttonExpandTree
            // 
            this.buttonExpandTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExpandTree.Location = new System.Drawing.Point(12, 12);
            this.buttonExpandTree.Name = "buttonExpandTree";
            this.buttonExpandTree.Size = new System.Drawing.Size(703, 33);
            this.buttonExpandTree.TabIndex = 4;
            this.buttonExpandTree.Text = "Раскрыть дерево полностью";
            this.buttonExpandTree.UseVisualStyleBackColor = true;
            this.buttonExpandTree.Click += new System.EventHandler(this.buttonExpandTree_Click);
            // 
            // FormExplain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 618);
            this.Controls.Add(this.buttonExpandTree);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.treeViewExplain);
            this.Name = "FormExplain";
            this.Text = "Объяснение";
            this.tabControl1.ResumeLayout(false);
            this.tabPageVars.ResumeLayout(false);
            this.tabPageUserAskLogs.ResumeLayout(false);
            this.tabPageUserAskLogs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TreeView treeViewExplain;
        private OkButton okButton;
        private ListBox listBoxKnownFacts;
        private TabControl tabControl1;
        private TabPage tabPageVars;
        private TabPage tabPageUserAskLogs;
        private ReadOnlyTextBox readOnlyLogs;
        private Button buttonExpandTree;
    }
}