﻿using System;
using System.Drawing;
using System.Windows.Forms;
using ES.Models;

namespace ES.Forms
{
    public partial class FormAsk : Form
    {
        private readonly Statement _statement;
        public FormAsk(Statement statement)
        {
            InitializeComponent();
            CenterToScreen();
            _statement = statement;
            tbQuestion.Text = statement.Variable.Question;
            tbQuestion.Enabled = false;

            for (var i=0; i < statement.Variable.Domain.Values.Count; i++)
            {
                var value = statement.Variable.Domain.Values[i];
                var rb = new RadioButton
                {
                    Text = value.Value, Tag = i, AutoSize = true, Location = new Point(10, 20 + i * 30)
                };

                gbAnswers.Controls.Add(rb);
            }
            ((RadioButton)gbAnswers.Controls[0]).Checked = true;
            gbAnswers.Height = 20 + 30 * statement.Variable.Domain.Values.Count;
            Height = gbAnswers.Height + 210;
            btOk.Location = new Point(btOk.Location.X, Height - 80);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            foreach(RadioButton rb in gbAnswers.Controls)
            {
                if (!rb.Checked) continue;
                _statement.Value = rb.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
