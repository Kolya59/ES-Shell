using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ES.Models;

namespace ES.Forms
{
    public partial class ChooseGoalForm : Form
    {
        private readonly List<Variable> _goals;

        public ChooseGoalForm(List<Variable> goals)
        {
            InitializeComponent();
            foreach (var g in goals)
                cbGoals.Items.Add(g.Name);
            cbGoals.SelectedIndex = 0;
            _goals = goals;
            CenterToScreen();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (cbGoals.SelectedIndex >= 0)
            {
                Program.mainForm.inferenceEngine.SetPrimaryGoal(_goals[cbGoals.SelectedIndex]);
                DialogResult = DialogResult.OK;
                Close();
            } else
            {
                MessageBox.Show("Choose consultation goal");
            }
        }
    }
}
