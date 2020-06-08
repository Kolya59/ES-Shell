using System;
using System.Drawing;
using System.Windows.Forms;
using ES.Models;

namespace ES.Forms
{
    public partial class FormResultConsult : Form
    {
        private readonly InferenceEngine _inferenceEngine;
        public FormResultConsult(InferenceEngine inferenceEngine, string result)
        {
            InitializeComponent();
            _inferenceEngine = inferenceEngine;
            readOnlyTextBoxResult.Text = $@"Result:{Environment.NewLine}{result}";
            readOnlyTextBoxResult.Enabled = false;
            CenterToScreen();
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
    }
}
