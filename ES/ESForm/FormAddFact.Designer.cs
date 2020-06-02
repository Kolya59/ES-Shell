using System.ComponentModel;
using System.Windows.Forms;
using ES.FormComponent;

namespace ES.ESForm
{
    partial class FormAddFact
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
            this.comboBoxVar = new System.Windows.Forms.ComboBox();
            this.addPlusVarButton = new ES.FormComponent.AddPlusButton(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDomain = new System.Windows.Forms.ComboBox();
            this.okButton1 = new ES.FormComponent.OkButton(this.components);
            this.cancelButton1 = new ES.FormComponent.CancelButton(this.components);
            this.SuspendLayout();
            // 
            // comboBoxVar
            // 
            this.comboBoxVar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVar.FormattingEnabled = true;
            this.comboBoxVar.Location = new System.Drawing.Point(12, 28);
            this.comboBoxVar.Name = "comboBoxVar";
            this.comboBoxVar.Size = new System.Drawing.Size(292, 24);
            this.comboBoxVar.TabIndex = 0;
            this.comboBoxVar.SelectedIndexChanged += new System.EventHandler(this.comboBoxVar_SelectedIndexChanged);
            // 
            // addPlusVarButton
            // 
            this.addPlusVarButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addPlusVarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPlusVarButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.addPlusVarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addPlusVarButton.Location = new System.Drawing.Point(310, 28);
            this.addPlusVarButton.Name = "addPlusVarButton";
            this.addPlusVarButton.Size = new System.Drawing.Size(35, 35);
            this.addPlusVarButton.TabIndex = 1;
            this.addPlusVarButton.Text = "+";
            this.addPlusVarButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addPlusVarButton.UseVisualStyleBackColor = true;
            this.addPlusVarButton.Click += new System.EventHandler(this.addPlusVarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(166, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "=";
            // 
            // comboBoxDomain
            // 
            this.comboBoxDomain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDomain.FormattingEnabled = true;
            this.comboBoxDomain.Location = new System.Drawing.Point(12, 79);
            this.comboBoxDomain.Name = "comboBoxDomain";
            this.comboBoxDomain.Size = new System.Drawing.Size(332, 24);
            this.comboBoxDomain.TabIndex = 3;
            // 
            // okButton1
            // 
            this.okButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(250)))), ((int)(((byte)(235)))));
            this.okButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okButton1.Location = new System.Drawing.Point(273, 118);
            this.okButton1.Name = "okButton1";
            this.okButton1.Size = new System.Drawing.Size(80, 30);
            this.okButton1.TabIndex = 4;
            this.okButton1.Text = "OK";
            this.okButton1.UseVisualStyleBackColor = true;
            this.okButton1.Click += new System.EventHandler(this.okButton1_Click);
            // 
            // cancelButton1
            // 
            this.cancelButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.cancelButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton1.Location = new System.Drawing.Point(153, 118);
            this.cancelButton1.Name = "cancelButton1";
            this.cancelButton1.Size = new System.Drawing.Size(114, 30);
            this.cancelButton1.TabIndex = 5;
            this.cancelButton1.Text = "Отмена";
            this.cancelButton1.UseVisualStyleBackColor = true;
            this.cancelButton1.Click += new System.EventHandler(this.cancelButton1_Click);
            // 
            // FormAddFact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 153);
            this.Controls.Add(this.cancelButton1);
            this.Controls.Add(this.okButton1);
            this.Controls.Add(this.comboBoxDomain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addPlusVarButton);
            this.Controls.Add(this.comboBoxVar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAddFact";
            this.Text = "FormAddFact";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBoxVar;
        private AddPlusButton addPlusVarButton;
        private Label label1;
        private ComboBox comboBoxDomain;
        private OkButton okButton1;
        private CancelButton cancelButton1;
    }
}