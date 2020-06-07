using System;
using System.Drawing;
using System.Windows.Forms;
using ES.Models;

namespace ES.ESForm
{
    public partial class FormResultConsult : Form
    {
        private readonly InferenceEngine _inferenceEngine;
        public FormResultConsult(InferenceEngine inferenceEngine, string result)
        {
            InitializeComponent();
            _inferenceEngine = inferenceEngine;
            readOnlyTextBoxResult.Text = $"Результат:{Environment.NewLine}{result}";
            SetStyle();
        }

        private void okButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonExplain_Click(object sender, EventArgs e)
        {
            var f = new FormExplain(_inferenceEngine.ExplainTree, _inferenceEngine.log, _inferenceEngine.Statements);
            f.ShowDialog();
        }

        private void SetStyle()
        {
            BackColor = SystemColors.ControlLightLight;
            var buttonBorder = Color.Silver;
            buttonExplain.FlatStyle = FlatStyle.Flat;
            buttonExplain.FlatAppearance.BorderColor = buttonBorder;
            buttonExplain.BackColor = SystemColors.ControlLightLight;
            CenterToScreen();
        }
    }
}
