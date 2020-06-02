using System.ComponentModel;
using System.Windows.Forms;
using ES.FormComponent;

namespace ES.ESForm
{
    partial class FormAddVar
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
            this.comboBoxDomain = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.radioButtonVivodZapr = new System.Windows.Forms.RadioButton();
            this.radioButtonZaprshivaemaya = new System.Windows.Forms.RadioButton();
            this.radioButtonVivodymaya = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.cancelButton1 = new ES.FormComponent.CancelButton(this.components);
            this.okButton1 = new ES.FormComponent.OkButton(this.components);
            this.addPlusButton = new ES.FormComponent.AddPlusButton(this.components);
            this.esTextBoxVarName = new ES.FormComponent.EsTextBox(this.components);
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Имя переменной:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Домен:";
            // 
            // comboBoxDomain
            // 
            this.comboBoxDomain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDomain.FormattingEnabled = true;
            this.comboBoxDomain.Location = new System.Drawing.Point(15, 115);
            this.comboBoxDomain.Name = "comboBoxDomain";
            this.comboBoxDomain.Size = new System.Drawing.Size(285, 24);
            this.comboBoxDomain.TabIndex = 13;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.radioButtonVivodZapr);
            this.groupBox6.Controls.Add(this.radioButtonZaprshivaemaya);
            this.groupBox6.Controls.Add(this.radioButtonVivodymaya);
            this.groupBox6.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.groupBox6.ForeColor = System.Drawing.Color.Black;
            this.groupBox6.Location = new System.Drawing.Point(15, 158);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(323, 109);
            this.groupBox6.TabIndex = 15;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Тип переменной";
            // 
            // radioButtonVivodZapr
            // 
            this.radioButtonVivodZapr.AutoSize = true;
            this.radioButtonVivodZapr.Location = new System.Drawing.Point(24, 82);
            this.radioButtonVivodZapr.Name = "radioButtonVivodZapr";
            this.radioButtonVivodZapr.Size = new System.Drawing.Size(212, 22);
            this.radioButtonVivodZapr.TabIndex = 2;
            this.radioButtonVivodZapr.TabStop = true;
            this.radioButtonVivodZapr.Text = "Запрашиваемо-выводимая";
            this.radioButtonVivodZapr.UseVisualStyleBackColor = true;
            // 
            // radioButtonZaprshivaemaya
            // 
            this.radioButtonZaprshivaemaya.AutoSize = true;
            this.radioButtonZaprshivaemaya.Location = new System.Drawing.Point(24, 24);
            this.radioButtonZaprshivaemaya.Name = "radioButtonZaprshivaemaya";
            this.radioButtonZaprshivaemaya.Size = new System.Drawing.Size(139, 22);
            this.radioButtonZaprshivaemaya.TabIndex = 1;
            this.radioButtonZaprshivaemaya.TabStop = true;
            this.radioButtonZaprshivaemaya.Text = "Запрашиваемая";
            this.radioButtonZaprshivaemaya.UseVisualStyleBackColor = true;
            // 
            // radioButtonVivodymaya
            // 
            this.radioButtonVivodymaya.AutoSize = true;
            this.radioButtonVivodymaya.Location = new System.Drawing.Point(24, 54);
            this.radioButtonVivodymaya.Name = "radioButtonVivodymaya";
            this.radioButtonVivodymaya.Size = new System.Drawing.Size(106, 22);
            this.radioButtonVivodymaya.TabIndex = 0;
            this.radioButtonVivodymaya.TabStop = true;
            this.radioButtonVivodymaya.Text = "Выводимая";
            this.radioButtonVivodymaya.UseVisualStyleBackColor = true;
            this.radioButtonVivodymaya.CheckedChanged += new System.EventHandler(this.radioButtonVivodymaya_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxQuestion);
            this.groupBox5.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.groupBox5.ForeColor = System.Drawing.Color.Black;
            this.groupBox5.Location = new System.Drawing.Point(15, 273);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(323, 101);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Текст вопроса";
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Location = new System.Drawing.Point(6, 24);
            this.textBoxQuestion.Multiline = true;
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(311, 71);
            this.textBoxQuestion.TabIndex = 0;
            this.textBoxQuestion.TextChanged += new System.EventHandler(this.textBoxQuestion_TextChanged);
            // 
            // cancelButton1
            // 
            this.cancelButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.cancelButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cancelButton1.Location = new System.Drawing.Point(147, 380);
            this.cancelButton1.Name = "cancelButton1";
            this.cancelButton1.Size = new System.Drawing.Size(105, 30);
            this.cancelButton1.TabIndex = 18;
            this.cancelButton1.Text = "Отмена";
            this.cancelButton1.UseVisualStyleBackColor = true;
            this.cancelButton1.Click += new System.EventHandler(this.cancelButton1_Click);
            // 
            // okButton1
            // 
            this.okButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(250)))), ((int)(((byte)(235)))));
            this.okButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.okButton1.Location = new System.Drawing.Point(258, 380);
            this.okButton1.Name = "okButton1";
            this.okButton1.Size = new System.Drawing.Size(80, 30);
            this.okButton1.TabIndex = 17;
            this.okButton1.Text = "OK";
            this.okButton1.UseVisualStyleBackColor = true;
            this.okButton1.Click += new System.EventHandler(this.okButton1_Click);
            // 
            // addPlusButton
            // 
            this.addPlusButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addPlusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPlusButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.addPlusButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addPlusButton.Location = new System.Drawing.Point(306, 106);
            this.addPlusButton.Name = "addPlusButton";
            this.addPlusButton.Size = new System.Drawing.Size(35, 35);
            this.addPlusButton.TabIndex = 14;
            this.addPlusButton.Text = "+";
            this.addPlusButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addPlusButton.UseVisualStyleBackColor = true;
            this.addPlusButton.Click += new System.EventHandler(this.addPlusButton_Click);
            // 
            // esTextBoxVarName
            // 
            this.esTextBoxVarName.Font = new System.Drawing.Font("Arial", 8F);
            this.esTextBoxVarName.Location = new System.Drawing.Point(12, 50);
            this.esTextBoxVarName.Multiline = true;
            this.esTextBoxVarName.Name = "esTextBoxVarName";
            this.esTextBoxVarName.Size = new System.Drawing.Size(326, 23);
            this.esTextBoxVarName.TabIndex = 10;
            this.esTextBoxVarName.TextChanged += new System.EventHandler(this.esTextBoxVarName_TextChanged);
            // 
            // FormAddVar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 420);
            this.Controls.Add(this.cancelButton1);
            this.Controls.Add(this.okButton1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.addPlusButton);
            this.Controls.Add(this.comboBoxDomain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.esTextBoxVarName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAddVar";
            this.Text = "FormAddVar";
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EsTextBox esTextBoxVarName;
        private Label label1;
        private Label label2;
        private ComboBox comboBoxDomain;
        private AddPlusButton addPlusButton;
        private GroupBox groupBox6;
        private RadioButton radioButtonVivodZapr;
        private RadioButton radioButtonZaprshivaemaya;
        private RadioButton radioButtonVivodymaya;
        private GroupBox groupBox5;
        private TextBox textBoxQuestion;
        private CancelButton cancelButton1;
        private OkButton okButton1;
    }
}