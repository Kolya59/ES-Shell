using System.ComponentModel;

namespace ES.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResultConsult));
            this.readOnlyTextBoxResult = new System.Windows.Forms.TextBox();
            this.buttonExplain = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // readOnlyTextBoxResult
            // 
            this.readOnlyTextBoxResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.readOnlyTextBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.readOnlyTextBoxResult.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.readOnlyTextBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.readOnlyTextBoxResult.Location = new System.Drawing.Point(9, 19);
            this.readOnlyTextBoxResult.Margin = new System.Windows.Forms.Padding(2);
            this.readOnlyTextBoxResult.Multiline = true;
            this.readOnlyTextBoxResult.Name = "readOnlyTextBoxResult";
            this.readOnlyTextBoxResult.Size = new System.Drawing.Size(265, 54);
            this.readOnlyTextBoxResult.TabIndex = 0;
            this.readOnlyTextBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonExplain
            // 
            this.buttonExplain.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (128)))), ((int) (((byte) (128)))), ((int) (((byte) (255)))));
            this.buttonExplain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExplain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.buttonExplain.Image = ((System.Drawing.Image) (resources.GetObject("buttonExplain.Image")));
            this.buttonExplain.Location = new System.Drawing.Point(9, 84);
            this.buttonExplain.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExplain.Name = "buttonExplain";
            this.buttonExplain.Size = new System.Drawing.Size(139, 32);
            this.buttonExplain.TabIndex = 1;
            this.buttonExplain.UseVisualStyleBackColor = false;
            this.buttonExplain.Click += new System.EventHandler(this.buttonExplain_Click);
            // 
            // btOk
            // 
            this.btOk.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.btOk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (132)))), ((int) (((byte) (225)))), ((int) (((byte) (132)))));
            this.btOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOk.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btOk.Image = ((System.Drawing.Image) (resources.GetObject("btOk.Image")));
            this.btOk.Location = new System.Drawing.Point(152, 84);
            this.btOk.Margin = new System.Windows.Forms.Padding(2);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(122, 32);
            this.btOk.TabIndex = 2;
            this.btOk.UseVisualStyleBackColor = false;
            this.btOk.Click += new System.EventHandler(this.okButton1_Click);
            // 
            // FormResultConsult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(286, 125);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.buttonExplain);
            this.Controls.Add(this.readOnlyTextBoxResult);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormResultConsult";
            this.Text = "Result";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button buttonExplain;
        private System.Windows.Forms.TextBox readOnlyTextBoxResult;

        #endregion
    }
}