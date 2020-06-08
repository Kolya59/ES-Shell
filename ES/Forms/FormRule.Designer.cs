using System.ComponentModel;
using System.Windows.Forms;

namespace ES.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddRule));
            this.tbRuleName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lbPremises = new System.Windows.Forms.ListBox();
            this.btDeletePremise = new System.Windows.Forms.Button();
            this.btEditPremise = new System.Windows.Forms.Button();
            this.btAddPremise = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbReason = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbConclusion = new System.Windows.Forms.ListBox();
            this.btDeleteConclusion = new System.Windows.Forms.Button();
            this.btEditConclusion = new System.Windows.Forms.Button();
            this.btAddConclusion = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbRuleName
            // 
            this.tbRuleName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbRuleName.Font = new System.Drawing.Font("Arial", 8F);
            this.tbRuleName.Location = new System.Drawing.Point(11, 28);
            this.tbRuleName.Margin = new System.Windows.Forms.Padding(2);
            this.tbRuleName.Multiline = true;
            this.tbRuleName.Name = "tbRuleName";
            this.tbRuleName.Size = new System.Drawing.Size(285, 19);
            this.tbRuleName.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lbPremises);
            this.groupBox6.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.groupBox6.ForeColor = System.Drawing.Color.Black;
            this.groupBox6.Location = new System.Drawing.Point(11, 55);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(248, 109);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Condition";
            // 
            // lbPremises
            // 
            this.lbPremises.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbPremises.FormattingEnabled = true;
            this.lbPremises.Location = new System.Drawing.Point(4, 20);
            this.lbPremises.Margin = new System.Windows.Forms.Padding(2);
            this.lbPremises.Name = "lbPremises";
            this.lbPremises.Size = new System.Drawing.Size(234, 82);
            this.lbPremises.TabIndex = 0;
            this.lbPremises.SelectedIndexChanged += new System.EventHandler(this.listBoxPremises_SelectedIndexChanged);
            // 
            // btDeletePremise
            // 
            this.btDeletePremise.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (128)))));
            this.btDeletePremise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeletePremise.Image = ((System.Drawing.Image) (resources.GetObject("btDeletePremise.Image")));
            this.btDeletePremise.Location = new System.Drawing.Point(269, 138);
            this.btDeletePremise.Margin = new System.Windows.Forms.Padding(2);
            this.btDeletePremise.Name = "btDeletePremise";
            this.btDeletePremise.Size = new System.Drawing.Size(27, 26);
            this.btDeletePremise.TabIndex = 20;
            this.btDeletePremise.UseVisualStyleBackColor = false;
            this.btDeletePremise.Click += new System.EventHandler(this.buttonDeletePremise_Click);
            // 
            // btEditPremise
            // 
            this.btEditPremise.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (255)))), ((int) (((byte) (128)))));
            this.btEditPremise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditPremise.Image = ((System.Drawing.Image) (resources.GetObject("btEditPremise.Image")));
            this.btEditPremise.Location = new System.Drawing.Point(269, 106);
            this.btEditPremise.Margin = new System.Windows.Forms.Padding(2);
            this.btEditPremise.Name = "btEditPremise";
            this.btEditPremise.Size = new System.Drawing.Size(27, 27);
            this.btEditPremise.TabIndex = 19;
            this.btEditPremise.UseVisualStyleBackColor = false;
            this.btEditPremise.Click += new System.EventHandler(this.buttonEditPremise_Click);
            // 
            // btAddPremise
            // 
            this.btAddPremise.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.btAddPremise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddPremise.ForeColor = System.Drawing.Color.Black;
            this.btAddPremise.Image = ((System.Drawing.Image) (resources.GetObject("btAddPremise.Image")));
            this.btAddPremise.Location = new System.Drawing.Point(269, 75);
            this.btAddPremise.Margin = new System.Windows.Forms.Padding(2);
            this.btAddPremise.Name = "btAddPremise";
            this.btAddPremise.Size = new System.Drawing.Size(27, 27);
            this.btAddPremise.TabIndex = 18;
            this.btAddPremise.UseVisualStyleBackColor = false;
            this.btAddPremise.Click += new System.EventHandler(this.buttonAddPremise_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbReason);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(15, 282);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(244, 80);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Description";
            // 
            // tbReason
            // 
            this.tbReason.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbReason.Font = new System.Drawing.Font("Tahoma", 9F);
            this.tbReason.Location = new System.Drawing.Point(4, 17);
            this.tbReason.Margin = new System.Windows.Forms.Padding(2);
            this.tbReason.Multiline = true;
            this.tbReason.Name = "tbReason";
            this.tbReason.Size = new System.Drawing.Size(230, 59);
            this.tbReason.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbConclusion);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(11, 169);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(248, 109);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conclusion";
            // 
            // lbConclusion
            // 
            this.lbConclusion.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbConclusion.FormattingEnabled = true;
            this.lbConclusion.Location = new System.Drawing.Point(4, 18);
            this.lbConclusion.Margin = new System.Windows.Forms.Padding(2);
            this.lbConclusion.Name = "lbConclusion";
            this.lbConclusion.Size = new System.Drawing.Size(234, 82);
            this.lbConclusion.TabIndex = 0;
            this.lbConclusion.SelectedIndexChanged += new System.EventHandler(this.listBoxConclusion_SelectedIndexChanged);
            // 
            // btDeleteConclusion
            // 
            this.btDeleteConclusion.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (128)))));
            this.btDeleteConclusion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeleteConclusion.Image = ((System.Drawing.Image) (resources.GetObject("btDeleteConclusion.Image")));
            this.btDeleteConclusion.Location = new System.Drawing.Point(269, 249);
            this.btDeleteConclusion.Margin = new System.Windows.Forms.Padding(2);
            this.btDeleteConclusion.Name = "btDeleteConclusion";
            this.btDeleteConclusion.Size = new System.Drawing.Size(27, 26);
            this.btDeleteConclusion.TabIndex = 28;
            this.btDeleteConclusion.UseVisualStyleBackColor = false;
            this.btDeleteConclusion.Click += new System.EventHandler(this.buttonDeleteConclusion_Click);
            // 
            // btEditConclusion
            // 
            this.btEditConclusion.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (255)))), ((int) (((byte) (128)))));
            this.btEditConclusion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditConclusion.Image = ((System.Drawing.Image) (resources.GetObject("btEditConclusion.Image")));
            this.btEditConclusion.Location = new System.Drawing.Point(269, 218);
            this.btEditConclusion.Margin = new System.Windows.Forms.Padding(2);
            this.btEditConclusion.Name = "btEditConclusion";
            this.btEditConclusion.Size = new System.Drawing.Size(27, 27);
            this.btEditConclusion.TabIndex = 27;
            this.btEditConclusion.UseVisualStyleBackColor = false;
            this.btEditConclusion.Click += new System.EventHandler(this.buttonEditConclusion_Click);
            // 
            // btAddConclusion
            // 
            this.btAddConclusion.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.btAddConclusion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddConclusion.ForeColor = System.Drawing.Color.Black;
            this.btAddConclusion.Image = ((System.Drawing.Image) (resources.GetObject("btAddConclusion.Image")));
            this.btAddConclusion.Location = new System.Drawing.Point(269, 187);
            this.btAddConclusion.Margin = new System.Windows.Forms.Padding(2);
            this.btAddConclusion.Name = "btAddConclusion";
            this.btAddConclusion.Size = new System.Drawing.Size(27, 27);
            this.btAddConclusion.TabIndex = 26;
            this.btAddConclusion.UseVisualStyleBackColor = false;
            this.btAddConclusion.Click += new System.EventHandler(this.buttonAddConclusion_Click);
            // 
            // btOk
            // 
            this.btOk.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.btOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOk.ForeColor = System.Drawing.Color.Black;
            this.btOk.Image = ((System.Drawing.Image) (resources.GetObject("btOk.Image")));
            this.btOk.Location = new System.Drawing.Point(269, 296);
            this.btOk.Margin = new System.Windows.Forms.Padding(2);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(27, 27);
            this.btOk.TabIndex = 29;
            this.btOk.UseVisualStyleBackColor = false;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (128)))));
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancel.ForeColor = System.Drawing.Color.Black;
            this.btCancel.Image = ((System.Drawing.Image) (resources.GetObject("btCancel.Image")));
            this.btCancel.Location = new System.Drawing.Point(269, 327);
            this.btCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(27, 27);
            this.btCancel.TabIndex = 30;
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // FormAddRule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(310, 369);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.btDeleteConclusion);
            this.Controls.Add(this.btEditConclusion);
            this.Controls.Add(this.btAddConclusion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btDeletePremise);
            this.Controls.Add(this.btEditPremise);
            this.Controls.Add(this.btAddPremise);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRuleName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAddRule";
            this.Text = "FormAddRule";
            this.groupBox6.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btAddConclusion;
        private System.Windows.Forms.Button btAddPremise;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btDeleteConclusion;
        private System.Windows.Forms.Button btDeletePremise;
        private System.Windows.Forms.Button btEditConclusion;
        private System.Windows.Forms.Button btEditPremise;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbConclusion;
        private System.Windows.Forms.ListBox lbPremises;
        private System.Windows.Forms.TextBox tbReason;
        private System.Windows.Forms.TextBox tbRuleName;

        #endregion
    }
}