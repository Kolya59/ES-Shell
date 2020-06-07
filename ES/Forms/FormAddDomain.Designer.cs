using System.ComponentModel;
using System.Windows.Forms;

namespace ES.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddDomain));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxDomainValues = new System.Windows.Forms.ListBox();
            this.buttonDeleteDomainValue = new System.Windows.Forms.Button();
            this.buttonAddDomainValue = new System.Windows.Forms.Button();
            this.buttonEditDomainValue = new System.Windows.Forms.Button();
            this.tbDomainName = new System.Windows.Forms.TextBox();
            this.tbDomainValue = new System.Windows.Forms.TextBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Values";
            // 
            // listBoxDomainValues
            // 
            this.listBoxDomainValues.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listBoxDomainValues.FormattingEnabled = true;
            this.listBoxDomainValues.Location = new System.Drawing.Point(6, 70);
            this.listBoxDomainValues.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxDomainValues.Name = "listBoxDomainValues";
            this.listBoxDomainValues.Size = new System.Drawing.Size(248, 69);
            this.listBoxDomainValues.TabIndex = 3;
            this.listBoxDomainValues.SelectedIndexChanged += new System.EventHandler(this.listBoxDomainValues_SelectedIndexChanged);
            this.listBoxDomainValues.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBoxDomainValues_DragDrop);
            // 
            // buttonDeleteDomainValue
            // 
            this.buttonDeleteDomainValue.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (128)))));
            this.buttonDeleteDomainValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteDomainValue.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.buttonDeleteDomainValue.Image = ((System.Drawing.Image) (resources.GetObject("buttonDeleteDomainValue.Image")));
            this.buttonDeleteDomainValue.Location = new System.Drawing.Point(94, 166);
            this.buttonDeleteDomainValue.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeleteDomainValue.Name = "buttonDeleteDomainValue";
            this.buttonDeleteDomainValue.Size = new System.Drawing.Size(40, 27);
            this.buttonDeleteDomainValue.TabIndex = 4;
            this.buttonDeleteDomainValue.UseVisualStyleBackColor = false;
            this.buttonDeleteDomainValue.Click += new System.EventHandler(this.buttonDeleteDomainValue_Click);
            // 
            // buttonAddDomainValue
            // 
            this.buttonAddDomainValue.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.buttonAddDomainValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddDomainValue.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.buttonAddDomainValue.Image = ((System.Drawing.Image) (resources.GetObject("buttonAddDomainValue.Image")));
            this.buttonAddDomainValue.Location = new System.Drawing.Point(6, 166);
            this.buttonAddDomainValue.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddDomainValue.Name = "buttonAddDomainValue";
            this.buttonAddDomainValue.Size = new System.Drawing.Size(40, 27);
            this.buttonAddDomainValue.TabIndex = 6;
            this.buttonAddDomainValue.UseVisualStyleBackColor = false;
            this.buttonAddDomainValue.Click += new System.EventHandler(this.buttonAddDomainValue_Click);
            // 
            // buttonEditDomainValue
            // 
            this.buttonEditDomainValue.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (255)))), ((int) (((byte) (128)))));
            this.buttonEditDomainValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditDomainValue.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.buttonEditDomainValue.Image = ((System.Drawing.Image) (resources.GetObject("buttonEditDomainValue.Image")));
            this.buttonEditDomainValue.Location = new System.Drawing.Point(50, 166);
            this.buttonEditDomainValue.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEditDomainValue.Name = "buttonEditDomainValue";
            this.buttonEditDomainValue.Size = new System.Drawing.Size(40, 27);
            this.buttonEditDomainValue.TabIndex = 7;
            this.buttonEditDomainValue.UseVisualStyleBackColor = false;
            this.buttonEditDomainValue.Click += new System.EventHandler(this.buttonEditDomainValue_Click);
            // 
            // tbDomainName
            // 
            this.tbDomainName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbDomainName.Font = new System.Drawing.Font("Arial", 8F);
            this.tbDomainName.Location = new System.Drawing.Point(6, 23);
            this.tbDomainName.Margin = new System.Windows.Forms.Padding(2);
            this.tbDomainName.Multiline = true;
            this.tbDomainName.Name = "tbDomainName";
            this.tbDomainName.Size = new System.Drawing.Size(246, 19);
            this.tbDomainName.TabIndex = 9;
            // 
            // tbDomainValue
            // 
            this.tbDomainValue.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbDomainValue.Font = new System.Drawing.Font("Arial", 8F);
            this.tbDomainValue.Location = new System.Drawing.Point(6, 143);
            this.tbDomainValue.Margin = new System.Windows.Forms.Padding(2);
            this.tbDomainValue.Multiline = true;
            this.tbDomainValue.Name = "tbDomainValue";
            this.tbDomainValue.Size = new System.Drawing.Size(248, 19);
            this.tbDomainValue.TabIndex = 8;
            this.tbDomainValue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.esTextBoxDomainValue_KeyUp);
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (128)))));
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancel.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.btCancel.Image = ((System.Drawing.Image) (resources.GetObject("btCancel.Image")));
            this.btCancel.Location = new System.Drawing.Point(170, 166);
            this.btCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(40, 27);
            this.btCancel.TabIndex = 10;
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btOk
            // 
            this.btOk.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.btOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOk.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.btOk.Image = ((System.Drawing.Image) (resources.GetObject("btOk.Image")));
            this.btOk.Location = new System.Drawing.Point(214, 166);
            this.btOk.Margin = new System.Windows.Forms.Padding(2);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(40, 27);
            this.btOk.TabIndex = 11;
            this.btOk.UseVisualStyleBackColor = false;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // FormAddDomain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 200);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.tbDomainName);
            this.Controls.Add(this.tbDomainValue);
            this.Controls.Add(this.buttonEditDomainValue);
            this.Controls.Add(this.buttonAddDomainValue);
            this.Controls.Add(this.buttonDeleteDomainValue);
            this.Controls.Add(this.listBoxDomainValues);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAddDomain";
            this.Text = "Domain";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button buttonAddDomainValue;
        private System.Windows.Forms.Button buttonDeleteDomainValue;
        private System.Windows.Forms.Button buttonEditDomainValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxDomainValues;
        private System.Windows.Forms.TextBox tbDomainName;
        private System.Windows.Forms.TextBox tbDomainValue;

        #endregion
    }
}