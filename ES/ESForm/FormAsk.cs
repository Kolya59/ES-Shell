using System;
using System.Drawing;
using System.Windows.Forms;
using ES.Models;

namespace ES.ESForm
{
    public partial class FormAsk : Form
    {
        Statement _statement;
        public FormAsk(Statement statement)
        {
            InitializeComponent();
            SetStyle();
            _statement = statement;
            textBoxQuestion.Text = statement.Variable.Question;

            for (var i=0; i < statement.Variable.Domain.Values.Count; i++)
            {
                var value = statement.Variable.Domain.Values[i];
                var rb = new RadioButton();
                rb.Text = value.Value;
               
                rb.Tag = i;
                rb.AutoSize = true;
                rb.Location = new Point(10, 20 + i * 30);
                groupBoxAnswers.Controls.Add(rb);
            }
            ((RadioButton)groupBoxAnswers.Controls[0]).Checked = true;
            groupBoxAnswers.Height = 20 + 30 * statement.Variable.Domain.Values.Count;
            Height = groupBoxAnswers.Height + 210;
            okButton.Location = new Point(okButton.Location.X, Height - 80);
        }

        private void SetStyle()
        {
            BackColor = SystemColors.ControlLightLight;
            CenterToScreen();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            foreach(RadioButton rb in groupBoxAnswers.Controls)
            {
                if (!rb.Checked) continue;
                _statement.Value = rb.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
