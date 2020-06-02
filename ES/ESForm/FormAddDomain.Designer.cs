using System.ComponentModel;
using System.Windows.Forms;
using ES.FormComponent;

namespace ES.ESForm
{
    partial class FormAddDomain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxDomainValues = new System.Windows.Forms.ListBox();
            this.buttonDeleteDomainValue = new System.Windows.Forms.Button();
            this.buttonAddDomainValue = new System.Windows.Forms.Button();
            this.buttonEditDomainValue = new System.Windows.Forms.Button();
            this.esTextBoxDomainName = new ES.FormComponent.EsTextBox(this.components);
            this.esTextBoxDomainValue = new ES.FormComponent.EsTextBox(this.components);
            this.okButton1 = new ES.FormComponent.OkButton(this.components);
            this.cancelButton1 = new ES.FormComponent.CancelButton(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя домена:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Допустимые значения домена:";
            // 
            // listBoxDomainValues
            // 
            this.listBoxDomainValues.FormattingEnabled = true;
            this.listBoxDomainValues.ItemHeight = 16;
            this.listBoxDomainValues.Location = new System.Drawing.Point(15, 128);
            this.listBoxDomainValues.Name = "listBoxDomainValues";
            this.listBoxDomainValues.Size = new System.Drawing.Size(329, 84);
            this.listBoxDomainValues.TabIndex = 3;
            this.listBoxDomainValues.SelectedIndexChanged += new System.EventHandler(this.listBoxDomainValues_SelectedIndexChanged);
            this.listBoxDomainValues.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBoxDomainValues_DragDrop);
            // 
            // buttonDeleteDomainValue
            // 
            this.buttonDeleteDomainValue.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.buttonDeleteDomainValue.Location = new System.Drawing.Point(15, 218);
            this.buttonDeleteDomainValue.Name = "buttonDeleteDomainValue";
            this.buttonDeleteDomainValue.Size = new System.Drawing.Size(326, 31);
            this.buttonDeleteDomainValue.TabIndex = 4;
            this.buttonDeleteDomainValue.Text = "Удалить";
            this.buttonDeleteDomainValue.UseVisualStyleBackColor = true;
            this.buttonDeleteDomainValue.Click += new System.EventHandler(this.buttonDeleteDomainValue_Click);
            // 
            // buttonAddDomainValue
            // 
            this.buttonAddDomainValue.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.buttonAddDomainValue.Location = new System.Drawing.Point(12, 297);
            this.buttonAddDomainValue.Name = "buttonAddDomainValue";
            this.buttonAddDomainValue.Size = new System.Drawing.Size(164, 31);
            this.buttonAddDomainValue.TabIndex = 6;
            this.buttonAddDomainValue.Text = "Добавить";
            this.buttonAddDomainValue.UseVisualStyleBackColor = true;
            this.buttonAddDomainValue.Click += new System.EventHandler(this.buttonAddDomainValue_Click);
            // 
            // buttonEditDomainValue
            // 
            this.buttonEditDomainValue.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.buttonEditDomainValue.Location = new System.Drawing.Point(177, 297);
            this.buttonEditDomainValue.Name = "buttonEditDomainValue";
            this.buttonEditDomainValue.Size = new System.Drawing.Size(164, 31);
            this.buttonEditDomainValue.TabIndex = 7;
            this.buttonEditDomainValue.Text = "Изменить";
            this.buttonEditDomainValue.UseVisualStyleBackColor = true;
            this.buttonEditDomainValue.Click += new System.EventHandler(this.buttonEditDomainValue_Click);
            // 
            // esTextBoxDomainName
            // 
            this.esTextBoxDomainName.Font = new System.Drawing.Font("Arial", 8F);
            this.esTextBoxDomainName.Location = new System.Drawing.Point(12, 52);
            this.esTextBoxDomainName.Multiline = true;
            this.esTextBoxDomainName.Name = "esTextBoxDomainName";
            this.esTextBoxDomainName.Size = new System.Drawing.Size(326, 23);
            this.esTextBoxDomainName.TabIndex = 9;
            // 
            // esTextBoxDomainValue
            // 
            this.esTextBoxDomainValue.Font = new System.Drawing.Font("Arial", 8F);
            this.esTextBoxDomainValue.Location = new System.Drawing.Point(15, 268);
            this.esTextBoxDomainValue.Multiline = true;
            this.esTextBoxDomainValue.Name = "esTextBoxDomainValue";
            this.esTextBoxDomainValue.Size = new System.Drawing.Size(326, 23);
            this.esTextBoxDomainValue.TabIndex = 8;
            this.esTextBoxDomainValue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.esTextBoxDomainValue_KeyUp);
            // 
            // okButton1
            // 
            this.okButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(250)))), ((int)(((byte)(235)))));
            this.okButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.okButton1.Location = new System.Drawing.Point(263, 344);
            this.okButton1.Name = "okButton1";
            this.okButton1.Size = new System.Drawing.Size(80, 30);
            this.okButton1.TabIndex = 10;
            this.okButton1.Text = "OK";
            this.okButton1.UseVisualStyleBackColor = false;
            this.okButton1.Click += new System.EventHandler(this.okButton1_Click);
            // 
            // cancelButton1
            // 
            this.cancelButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.cancelButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cancelButton1.Location = new System.Drawing.Point(153, 344);
            this.cancelButton1.Name = "cancelButton1";
            this.cancelButton1.Size = new System.Drawing.Size(104, 30);
            this.cancelButton1.TabIndex = 11;
            this.cancelButton1.Text = "Отмена";
            this.cancelButton1.UseVisualStyleBackColor = true;
            this.cancelButton1.Click += new System.EventHandler(this.cancelButton1_Click);
            // 
            // FormAddDomain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 386);
            this.Controls.Add(this.cancelButton1);
            this.Controls.Add(this.okButton1);
            this.Controls.Add(this.esTextBoxDomainName);
            this.Controls.Add(this.esTextBoxDomainValue);
            this.Controls.Add(this.buttonEditDomainValue);
            this.Controls.Add(this.buttonAddDomainValue);
            this.Controls.Add(this.buttonDeleteDomainValue);
            this.Controls.Add(this.listBoxDomainValues);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAddDomain";
            this.Text = "Создание домена";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private ListBox listBoxDomainValues;
        private Button buttonDeleteDomainValue;
        private Button buttonAddDomainValue;
        private Button buttonEditDomainValue;
        private EsTextBox esTextBoxDomainValue;
        private EsTextBox esTextBoxDomainName;
        private OkButton okButton1;
        private CancelButton cancelButton1;
    }
}