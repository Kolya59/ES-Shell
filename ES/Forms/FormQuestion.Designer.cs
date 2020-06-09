using System.ComponentModel;

namespace ES.Forms
{
    partial class FormAsk
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.gbAnswers = new System.Windows.Forms.GroupBox();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tbQuestion);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox5.Location = new System.Drawing.Point(9, 20);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(310, 93);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Question";
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
            this.tbQuestion.Size = new System.Drawing.Size(302, 68);
            this.tbQuestion.TabIndex = 0;
            // 
            // gbAnswers
            // 
            this.gbAnswers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbAnswers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbAnswers.Location = new System.Drawing.Point(9, 118);
            this.gbAnswers.Margin = new System.Windows.Forms.Padding(2);
            this.gbAnswers.Name = "gbAnswers";
            this.gbAnswers.Padding = new System.Windows.Forms.Padding(2);
            this.gbAnswers.Size = new System.Drawing.Size(310, 145);
            this.gbAnswers.TabIndex = 4;
            this.gbAnswers.TabStop = false;
            this.gbAnswers.Text = "Choose right one";
            // 
            // FormAsk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(328, 270);
            this.Controls.Add(this.gbAnswers);
            this.Controls.Add(this.groupBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAsk";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox gbAnswers;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tbQuestion;

        #endregion
    }
}