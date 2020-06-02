using System.ComponentModel;
using System.Windows.Forms;
using ES.FormComponent;

namespace ES.ESForm
{
    partial class FormResultConsult
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
            this.readOnlyTextBoxResult = new ES.FormComponent.ReadOnlyTextBox(this.components);
            this.buttonExplain = new System.Windows.Forms.Button();
            this.okButton1 = new ES.FormComponent.OkButton(this.components);
            this.SuspendLayout();
            // 
            // readOnlyTextBoxResult
            // 
            this.readOnlyTextBoxResult.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.readOnlyTextBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyTextBoxResult.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.readOnlyTextBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.readOnlyTextBoxResult.Location = new System.Drawing.Point(12, 23);
            this.readOnlyTextBoxResult.Multiline = true;
            this.readOnlyTextBoxResult.Name = "readOnlyTextBoxResult";
            this.readOnlyTextBoxResult.Size = new System.Drawing.Size(353, 66);
            this.readOnlyTextBoxResult.TabIndex = 0;
            this.readOnlyTextBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonExplain
            // 
            this.buttonExplain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExplain.Location = new System.Drawing.Point(12, 103);
            this.buttonExplain.Name = "buttonExplain";
            this.buttonExplain.Size = new System.Drawing.Size(249, 39);
            this.buttonExplain.TabIndex = 1;
            this.buttonExplain.Text = "Показать объяснение";
            this.buttonExplain.UseVisualStyleBackColor = true;
            this.buttonExplain.Click += new System.EventHandler(this.buttonExplain_Click);
            // 
            // okButton1
            // 
            this.okButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(250)))), ((int)(((byte)(235)))));
            this.okButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(225)))), ((int)(((byte)(132)))));
            this.okButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.okButton1.Location = new System.Drawing.Point(274, 103);
            this.okButton1.Name = "okButton1";
            this.okButton1.Size = new System.Drawing.Size(91, 39);
            this.okButton1.TabIndex = 2;
            this.okButton1.Text = "OK";
            this.okButton1.UseVisualStyleBackColor = false;
            this.okButton1.Click += new System.EventHandler(this.okButton1_Click);
            // 
            // FormResultConsult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(381, 154);
            this.Controls.Add(this.okButton1);
            this.Controls.Add(this.buttonExplain);
            this.Controls.Add(this.readOnlyTextBoxResult);
            this.KeyPreview = true;
            this.Name = "FormResultConsult";
            this.Text = "Результат";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReadOnlyTextBox readOnlyTextBoxResult;
        private Button buttonExplain;
        private OkButton okButton1;
    }
}