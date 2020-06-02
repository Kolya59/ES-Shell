using System.ComponentModel;
using System.Windows.Forms;
using ES.FormComponent;

namespace ES.ESForm
{
    partial class FormAddRule
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
            this.textBoxRuleName = new ES.FormComponent.EsTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.listBoxPremises = new System.Windows.Forms.ListBox();
            this.buttonDeletePremise = new System.Windows.Forms.Button();
            this.buttonEditPremise = new System.Windows.Forms.Button();
            this.buttonAddPremise = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxReason = new ES.FormComponent.EsTextBox(this.components);
            this.cancelButton1 = new ES.FormComponent.CancelButton(this.components);
            this.okButton1 = new ES.FormComponent.OkButton(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxConclusion = new System.Windows.Forms.ListBox();
            this.buttonDeleteConclusion = new System.Windows.Forms.Button();
            this.buttonEditConclusion = new System.Windows.Forms.Button();
            this.buttonAddConclusion = new System.Windows.Forms.Button();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxRuleName
            // 
            this.textBoxRuleName.Font = new System.Drawing.Font("Arial", 8F);
            this.textBoxRuleName.Location = new System.Drawing.Point(12, 55);
            this.textBoxRuleName.Multiline = true;
            this.textBoxRuleName.Name = "textBoxRuleName";
            this.textBoxRuleName.Size = new System.Drawing.Size(483, 23);
            this.textBoxRuleName.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Имя правила:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.listBoxPremises);
            this.groupBox6.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.groupBox6.ForeColor = System.Drawing.Color.Black;
            this.groupBox6.Location = new System.Drawing.Point(21, 111);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(323, 171);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Посылка";
            // 
            // listBoxPremises
            // 
            this.listBoxPremises.FormattingEnabled = true;
            this.listBoxPremises.ItemHeight = 17;
            this.listBoxPremises.Location = new System.Drawing.Point(6, 24);
            this.listBoxPremises.Name = "listBoxPremises";
            this.listBoxPremises.Size = new System.Drawing.Size(311, 140);
            this.listBoxPremises.TabIndex = 0;
            this.listBoxPremises.SelectedIndexChanged += new System.EventHandler(this.listBoxPremises_SelectedIndexChanged);
            // 
            // buttonDeletePremise
            // 
            this.buttonDeletePremise.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDeletePremise.Location = new System.Drawing.Point(358, 213);
            this.buttonDeletePremise.Name = "buttonDeletePremise";
            this.buttonDeletePremise.Size = new System.Drawing.Size(137, 32);
            this.buttonDeletePremise.TabIndex = 20;
            this.buttonDeletePremise.Text = "Удалить";
            this.buttonDeletePremise.UseVisualStyleBackColor = false;
            this.buttonDeletePremise.Click += new System.EventHandler(this.buttonDeletePremise_Click);
            // 
            // buttonEditPremise
            // 
            this.buttonEditPremise.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEditPremise.Location = new System.Drawing.Point(358, 174);
            this.buttonEditPremise.Name = "buttonEditPremise";
            this.buttonEditPremise.Size = new System.Drawing.Size(137, 33);
            this.buttonEditPremise.TabIndex = 19;
            this.buttonEditPremise.Text = "Изменить";
            this.buttonEditPremise.UseVisualStyleBackColor = false;
            this.buttonEditPremise.Click += new System.EventHandler(this.buttonEditPremise_Click);
            // 
            // buttonAddPremise
            // 
            this.buttonAddPremise.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAddPremise.ForeColor = System.Drawing.Color.Black;
            this.buttonAddPremise.Location = new System.Drawing.Point(358, 135);
            this.buttonAddPremise.Name = "buttonAddPremise";
            this.buttonAddPremise.Size = new System.Drawing.Size(137, 33);
            this.buttonAddPremise.TabIndex = 18;
            this.buttonAddPremise.Text = "Добавить";
            this.buttonAddPremise.UseVisualStyleBackColor = false;
            this.buttonAddPremise.Click += new System.EventHandler(this.buttonAddPremise_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxReason);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(21, 496);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(474, 57);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Пояснение";
            // 
            // textBoxReason
            // 
            this.textBoxReason.Font = new System.Drawing.Font("Tahoma", 9F);
            this.textBoxReason.Location = new System.Drawing.Point(6, 21);
            this.textBoxReason.Multiline = true;
            this.textBoxReason.Name = "textBoxReason";
            this.textBoxReason.Size = new System.Drawing.Size(468, 30);
            this.textBoxReason.TabIndex = 0;
            // 
            // cancelButton1
            // 
            this.cancelButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.cancelButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cancelButton1.Location = new System.Drawing.Point(301, 560);
            this.cancelButton1.Name = "cancelButton1";
            this.cancelButton1.Size = new System.Drawing.Size(108, 30);
            this.cancelButton1.TabIndex = 24;
            this.cancelButton1.Text = "Отмена";
            this.cancelButton1.UseVisualStyleBackColor = true;
            this.cancelButton1.Click += new System.EventHandler(this.cancelButton1_Click);
            // 
            // okButton1
            // 
            this.okButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(250)))), ((int)(((byte)(235)))));
            this.okButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.okButton1.Location = new System.Drawing.Point(421, 560);
            this.okButton1.Name = "okButton1";
            this.okButton1.Size = new System.Drawing.Size(74, 30);
            this.okButton1.TabIndex = 23;
            this.okButton1.Text = "OK";
            this.okButton1.UseVisualStyleBackColor = true;
            this.okButton1.Click += new System.EventHandler(this.okButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxConclusion);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(21, 308);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 155);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Заключение";
            // 
            // listBoxConclusion
            // 
            this.listBoxConclusion.FormattingEnabled = true;
            this.listBoxConclusion.ItemHeight = 17;
            this.listBoxConclusion.Location = new System.Drawing.Point(6, 24);
            this.listBoxConclusion.Name = "listBoxConclusion";
            this.listBoxConclusion.Size = new System.Drawing.Size(311, 123);
            this.listBoxConclusion.TabIndex = 0;
            this.listBoxConclusion.SelectedIndexChanged += new System.EventHandler(this.listBoxConclusion_SelectedIndexChanged);
            // 
            // buttonDeleteConclusion
            // 
            this.buttonDeleteConclusion.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDeleteConclusion.Location = new System.Drawing.Point(358, 412);
            this.buttonDeleteConclusion.Name = "buttonDeleteConclusion";
            this.buttonDeleteConclusion.Size = new System.Drawing.Size(137, 32);
            this.buttonDeleteConclusion.TabIndex = 28;
            this.buttonDeleteConclusion.Text = "Удалить";
            this.buttonDeleteConclusion.UseVisualStyleBackColor = false;
            this.buttonDeleteConclusion.Click += new System.EventHandler(this.buttonDeleteConclusion_Click);
            // 
            // buttonEditConclusion
            // 
            this.buttonEditConclusion.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEditConclusion.Location = new System.Drawing.Point(358, 373);
            this.buttonEditConclusion.Name = "buttonEditConclusion";
            this.buttonEditConclusion.Size = new System.Drawing.Size(137, 33);
            this.buttonEditConclusion.TabIndex = 27;
            this.buttonEditConclusion.Text = "Изменить";
            this.buttonEditConclusion.UseVisualStyleBackColor = false;
            this.buttonEditConclusion.Click += new System.EventHandler(this.buttonEditConclusion_Click);
            // 
            // buttonAddConclusion
            // 
            this.buttonAddConclusion.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAddConclusion.ForeColor = System.Drawing.Color.Black;
            this.buttonAddConclusion.Location = new System.Drawing.Point(358, 334);
            this.buttonAddConclusion.Name = "buttonAddConclusion";
            this.buttonAddConclusion.Size = new System.Drawing.Size(137, 33);
            this.buttonAddConclusion.TabIndex = 26;
            this.buttonAddConclusion.Text = "Добавить";
            this.buttonAddConclusion.UseVisualStyleBackColor = false;
            this.buttonAddConclusion.Click += new System.EventHandler(this.buttonAddConclusion_Click);
            // 
            // FormAddRule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 604);
            this.Controls.Add(this.buttonDeleteConclusion);
            this.Controls.Add(this.buttonEditConclusion);
            this.Controls.Add(this.buttonAddConclusion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancelButton1);
            this.Controls.Add(this.okButton1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonDeletePremise);
            this.Controls.Add(this.buttonEditPremise);
            this.Controls.Add(this.buttonAddPremise);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRuleName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAddRule";
            this.Text = "FormAddRule";
            this.groupBox6.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EsTextBox textBoxRuleName;
        private Label label1;
        private GroupBox groupBox6;
        private ListBox listBoxPremises;
        private Button buttonDeletePremise;
        private Button buttonEditPremise;
        private Button buttonAddPremise;
        private GroupBox groupBox2;
        private EsTextBox textBoxReason;
        private CancelButton cancelButton1;
        private OkButton okButton1;
        private GroupBox groupBox1;
        private ListBox listBoxConclusion;
        private Button buttonDeleteConclusion;
        private Button buttonEditConclusion;
        private Button buttonAddConclusion;
    }
}