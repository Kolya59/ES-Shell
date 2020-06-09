using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using ES.Models;

namespace ES.Forms
{
    public partial class FormAsk : Form
    {
        private readonly Statement _statement;
        public FormAsk(Statement statement, int number)
        {
            InitializeComponent();
            CenterToScreen();
            _statement = statement;
            tbQuestion.Text = statement.Variable.Question;
            tbQuestion.ReadOnly = true;

            for (var i = 0; i < statement.Variable.Domain.Values.Count; i++)
            {
                var value = statement.Variable.Domain.Values[i];
                var bt = new Button
                {
                    Text = value.Value, Tag = i, Width = Width - 50, Location = new Point(10, 20 + i * 30)
                };

                bt.Click += btChosen_Click;

                gbAnswers.Controls.Add(bt);
            }
            gbAnswers.Height = 20 + 30 * statement.Variable.Domain.Values.Count;
            Height = gbAnswers.Height + 170;
            Text = $@"Question №{number}";
        }

        private void btChosen_Click(object sender, EventArgs e)
        {
            _statement.Value = ((Button) sender).Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
