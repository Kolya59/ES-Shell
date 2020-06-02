using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ES.Models;

namespace ES.ESForm
{
    public partial class ChooseGoalForm : Form
    {
        List<Variable> _goals;

        public ChooseGoalForm(List<Variable> goals)
        {
            InitializeComponent();
            foreach (var g in goals)
                comboBoxGoals.Items.Add(g.Name);
            comboBoxGoals.SelectedIndex = 0;
            _goals = goals;
            CenterToScreen();
        }

        private void okButton1_Click(object sender, EventArgs e)
        {
            if (comboBoxGoals.SelectedIndex >= 0)
            {
                Program.mainForm.inferenceEngine.SetPrimaryGoal(_goals[comboBoxGoals.SelectedIndex]);
                DialogResult = DialogResult.OK;
                Close();
            } else
            {
                MessageBox.Show("Выберите цель консультации");
            }
        }
    }
}
