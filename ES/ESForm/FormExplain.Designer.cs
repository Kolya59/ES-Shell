﻿using System.ComponentModel;
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
            this.readOnlyLogs = new System.Windows.Forms.TextBox();
            this.buttonExpandTree = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageVars.SuspendLayout();
            this.tabPageUserAskLogs.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewExplain
            // 
            this.treeViewExplain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.treeViewExplain.Location = new System.Drawing.Point(9, 41);
            this.treeViewExplain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.treeViewExplain.Name = "treeViewExplain";
            this.treeViewExplain.Size = new System.Drawing.Size(528, 452);
            this.treeViewExplain.TabIndex = 0;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (235)))), ((int) (((byte) (250)))), ((int) (((byte) (235)))));
            this.okButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (132)))), ((int) (((byte) (225)))), ((int) (((byte) (132)))));
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Font = new System.Drawing.Font("Tahoma", 9F);
            this.okButton.Location = new System.Drawing.Point(720, 466);
            this.okButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(71, 31);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // listBoxKnownFacts
            // 
            this.listBoxKnownFacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxKnownFacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.listBoxKnownFacts.FormattingEnabled = true;
            this.listBoxKnownFacts.ItemHeight = 17;
            this.listBoxKnownFacts.Location = new System.Drawing.Point(2, 2);
            this.listBoxKnownFacts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxKnownFacts.Name = "listBoxKnownFacts";
            this.listBoxKnownFacts.Size = new System.Drawing.Size(238, 408);
            this.listBoxKnownFacts.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageVars);
            this.tabControl1.Controls.Add(this.tabPageUserAskLogs);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.tabControl1.Location = new System.Drawing.Point(541, 20);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(250, 440);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPageVars
            // 
            this.tabPageVars.Controls.Add(this.listBoxKnownFacts);
            this.tabPageVars.Location = new System.Drawing.Point(4, 24);
            this.tabPageVars.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageVars.Name = "tabPageVars";
            this.tabPageVars.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageVars.Size = new System.Drawing.Size(242, 412);
            this.tabPageVars.TabIndex = 0;
            this.tabPageVars.Text = "Переменные";
            this.tabPageVars.UseVisualStyleBackColor = true;
            // 
            // tabPageUserAskLogs
            // 
            this.tabPageUserAskLogs.Controls.Add(this.readOnlyLogs);
            this.tabPageUserAskLogs.Location = new System.Drawing.Point(4, 24);
            this.tabPageUserAskLogs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageUserAskLogs.Name = "tabPageUserAskLogs";
            this.tabPageUserAskLogs.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageUserAskLogs.Size = new System.Drawing.Size(242, 412);
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
            this.readOnlyLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.readOnlyLogs.Location = new System.Drawing.Point(2, 2);
            this.readOnlyLogs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.readOnlyLogs.Multiline = true;
            this.readOnlyLogs.Name = "readOnlyLogs";
            this.readOnlyLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.readOnlyLogs.Size = new System.Drawing.Size(238, 408);
            this.readOnlyLogs.TabIndex = 0;
            // 
            // buttonExpandTree
            // 
            this.buttonExpandTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.buttonExpandTree.Location = new System.Drawing.Point(9, 10);
            this.buttonExpandTree.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonExpandTree.Name = "buttonExpandTree";
            this.buttonExpandTree.Size = new System.Drawing.Size(527, 27);
            this.buttonExpandTree.TabIndex = 4;
            this.buttonExpandTree.Text = "Раскрыть дерево полностью";
            this.buttonExpandTree.UseVisualStyleBackColor = true;
            this.buttonExpandTree.Click += new System.EventHandler(this.buttonExpandTree_Click);
            // 
            // FormExplain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 502);
            this.Controls.Add(this.buttonExpandTree);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.treeViewExplain);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormExplain";
            this.Text = "Объяснение";
            this.tabControl1.ResumeLayout(false);
            this.tabPageVars.ResumeLayout(false);
            this.tabPageUserAskLogs.ResumeLayout(false);
            this.tabPageUserAskLogs.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button buttonExpandTree;
        private System.Windows.Forms.ListBox listBoxKnownFacts;
        private ES.FormComponent.OkButton okButton;
        private System.Windows.Forms.TextBox readOnlyLogs;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageUserAskLogs;
        private System.Windows.Forms.TabPage tabPageVars;
        private System.Windows.Forms.TreeView treeViewExplain;

        #endregion
    }
}