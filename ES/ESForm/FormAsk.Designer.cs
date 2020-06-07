using System.ComponentModel;
using System.Windows.Forms;
using ES.FormComponent;

namespace ES.ESForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.groupBoxAnswers = new System.Windows.Forms.GroupBox();
            this.okButton = new ES.FormComponent.OkButton(this.components);
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxQuestion);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox5.Location = new System.Drawing.Point(9, 20);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Size = new System.Drawing.Size(310, 93);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Вопрос";
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxQuestion.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxQuestion.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.textBoxQuestion.Location = new System.Drawing.Point(4, 20);
            this.textBoxQuestion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxQuestion.Multiline = true;
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(295, 68);
            this.textBoxQuestion.TabIndex = 0;
            // 
            // groupBoxAnswers
            // 
            this.groupBoxAnswers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBoxAnswers.Location = new System.Drawing.Point(9, 118);
            this.groupBoxAnswers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxAnswers.Name = "groupBoxAnswers";
            this.groupBoxAnswers.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxAnswers.Size = new System.Drawing.Size(310, 145);
            this.groupBoxAnswers.TabIndex = 4;
            this.groupBoxAnswers.TabStop = false;
            this.groupBoxAnswers.Text = "Выберите вариант ответа";
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (235)))), ((int) (((byte) (250)))), ((int) (((byte) (235)))));
            this.okButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (132)))), ((int) (((byte) (225)))), ((int) (((byte) (132)))));
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Font = new System.Drawing.Font("Tahoma", 9F);
            this.okButton.Location = new System.Drawing.Point(248, 268);
            this.okButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(71, 33);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // FormAsk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(328, 308);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.groupBoxAnswers);
            this.Controls.Add(this.groupBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormAsk";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBoxAnswers;
        private ES.FormComponent.OkButton okButton;
        private System.Windows.Forms.TextBox textBoxQuestion;

        #endregion
    }
}