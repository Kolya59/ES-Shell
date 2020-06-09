using System.ComponentModel;
using System.Windows.Forms;

namespace ES.Forms
{
    partial class ChooseGoalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseGoalForm));
            this.label1 = new System.Windows.Forms.Label();
            this.cbGoals = new System.Windows.Forms.ComboBox();
            this.btOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose consultation goal";
            // 
            // cbGoals
            // 
            this.cbGoals.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGoals.FormattingEnabled = true;
            this.cbGoals.Location = new System.Drawing.Point(9, 62);
            this.cbGoals.Margin = new System.Windows.Forms.Padding(2);
            this.cbGoals.Name = "cbGoals";
            this.cbGoals.Size = new System.Drawing.Size(248, 21);
            this.cbGoals.TabIndex = 1;
            // 
            // btOk
            // 
            this.btOk.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.btOk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (132)))), ((int) (((byte) (225)))), ((int) (((byte) (132)))));
            this.btOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOk.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btOk.Image = ((System.Drawing.Image) (resources.GetObject("btOk.Image")));
            this.btOk.Location = new System.Drawing.Point(11, 98);
            this.btOk.Margin = new System.Windows.Forms.Padding(2);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(245, 32);
            this.btOk.TabIndex = 2;
            this.btOk.UseVisualStyleBackColor = false;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // ChooseGoalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(275, 150);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.cbGoals);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(281, 179);
            this.MinimumSize = new System.Drawing.Size(281, 179);
            this.Name = "ChooseGoalForm";
            this.Text = "Consultation";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.ComboBox cbGoals;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}