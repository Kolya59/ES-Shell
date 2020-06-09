using System.ComponentModel;
using System.Windows.Forms;

namespace ES.Forms
{
    partial class FormVar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVar));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDomain = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rbQueryDeducted = new System.Windows.Forms.RadioButton();
            this.rbQueried = new System.Windows.Forms.RadioButton();
            this.rbDeducted = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.addPlusButton = new System.Windows.Forms.Button();
            this.tbVarName = new System.Windows.Forms.TextBox();
            this.btOk = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 14);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label2.Location = new System.Drawing.Point(8, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 14);
            this.label2.TabIndex = 12;
            this.label2.Text = "Domain";
            // 
            // comboBoxDomain
            // 
            this.comboBoxDomain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDomain.FormattingEnabled = true;
            this.comboBoxDomain.Location = new System.Drawing.Point(10, 70);
            this.comboBoxDomain.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxDomain.Name = "comboBoxDomain";
            this.comboBoxDomain.Size = new System.Drawing.Size(215, 21);
            this.comboBoxDomain.TabIndex = 13;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rbQueryDeducted);
            this.groupBox6.Controls.Add(this.rbQueried);
            this.groupBox6.Controls.Add(this.rbDeducted);
            this.groupBox6.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.groupBox6.ForeColor = System.Drawing.Color.Black;
            this.groupBox6.Location = new System.Drawing.Point(10, 95);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(242, 89);
            this.groupBox6.TabIndex = 15;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Kind";
            // 
            // rbQueryDeducted
            // 
            this.rbQueryDeducted.AutoSize = true;
            this.rbQueryDeducted.Location = new System.Drawing.Point(18, 67);
            this.rbQueryDeducted.Margin = new System.Windows.Forms.Padding(2);
            this.rbQueryDeducted.Name = "rbQueryDeducted";
            this.rbQueryDeducted.Size = new System.Drawing.Size(115, 18);
            this.rbQueryDeducted.TabIndex = 2;
            this.rbQueryDeducted.TabStop = true;
            this.rbQueryDeducted.Text = "Query-deducted";
            this.rbQueryDeducted.UseVisualStyleBackColor = true;
            // 
            // rbQueried
            // 
            this.rbQueried.AutoSize = true;
            this.rbQueried.Location = new System.Drawing.Point(18, 20);
            this.rbQueried.Margin = new System.Windows.Forms.Padding(2);
            this.rbQueried.Name = "rbQueried";
            this.rbQueried.Size = new System.Drawing.Size(68, 18);
            this.rbQueried.TabIndex = 1;
            this.rbQueried.TabStop = true;
            this.rbQueried.Text = "Queried";
            this.rbQueried.UseVisualStyleBackColor = true;
            // 
            // rbDeducted
            // 
            this.rbDeducted.AutoSize = true;
            this.rbDeducted.Location = new System.Drawing.Point(18, 44);
            this.rbDeducted.Margin = new System.Windows.Forms.Padding(2);
            this.rbDeducted.Name = "rbDeducted";
            this.rbDeducted.Size = new System.Drawing.Size(79, 18);
            this.rbDeducted.TabIndex = 0;
            this.rbDeducted.TabStop = true;
            this.rbDeducted.Text = "Deducted";
            this.rbDeducted.UseVisualStyleBackColor = true;
            this.rbDeducted.CheckedChanged += new System.EventHandler(this.rbDeducted_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tbQuestion);
            this.groupBox5.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.groupBox5.ForeColor = System.Drawing.Color.Black;
            this.groupBox5.Location = new System.Drawing.Point(9, 188);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(246, 82);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Question";
            // 
            // tbQuestion
            // 
            this.tbQuestion.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbQuestion.Location = new System.Drawing.Point(4, 20);
            this.tbQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.tbQuestion.Multiline = true;
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.Size = new System.Drawing.Size(234, 58);
            this.tbQuestion.TabIndex = 0;
            this.tbQuestion.TextChanged += new System.EventHandler(this.tbQuestion_TextChanged);
            // 
            // addPlusButton
            // 
            this.addPlusButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.addPlusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPlusButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.addPlusButton.Image = ((System.Drawing.Image) (resources.GetObject("addPlusButton.Image")));
            this.addPlusButton.Location = new System.Drawing.Point(229, 63);
            this.addPlusButton.Margin = new System.Windows.Forms.Padding(2);
            this.addPlusButton.Name = "addPlusButton";
            this.addPlusButton.Size = new System.Drawing.Size(26, 28);
            this.addPlusButton.TabIndex = 14;
            this.addPlusButton.UseVisualStyleBackColor = false;
            this.addPlusButton.Click += new System.EventHandler(this.addPlusButton_Click);
            // 
            // tbVarName
            // 
            this.tbVarName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbVarName.Font = new System.Drawing.Font("Arial", 8F);
            this.tbVarName.Location = new System.Drawing.Point(9, 25);
            this.tbVarName.Margin = new System.Windows.Forms.Padding(2);
            this.tbVarName.Multiline = true;
            this.tbVarName.Name = "tbVarName";
            this.tbVarName.Size = new System.Drawing.Size(246, 19);
            this.tbVarName.TabIndex = 10;
            this.tbVarName.TextChanged += new System.EventHandler(this.esTextBoxVarName_TextChanged);
            // 
            // btOk
            // 
            this.btOk.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.btOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOk.Image = ((System.Drawing.Image) (resources.GetObject("btOk.Image")));
            this.btOk.Location = new System.Drawing.Point(193, 275);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(62, 27);
            this.btOk.TabIndex = 17;
            this.btOk.UseVisualStyleBackColor = false;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (128)))));
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancel.Image = ((System.Drawing.Image) (resources.GetObject("btCancel.Image")));
            this.btCancel.Location = new System.Drawing.Point(125, 275);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(62, 27);
            this.btCancel.TabIndex = 19;
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // FormAddVar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(265, 310);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.addPlusButton);
            this.Controls.Add(this.comboBoxDomain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbVarName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormVar";
            this.Text = "FormAddVar";
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button addPlusButton;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.ComboBox comboBoxDomain;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbDeducted;
        private System.Windows.Forms.RadioButton rbQueried;
        private System.Windows.Forms.RadioButton rbQueryDeducted;
        private System.Windows.Forms.TextBox tbQuestion;
        private System.Windows.Forms.TextBox tbVarName;

        #endregion
    }
}