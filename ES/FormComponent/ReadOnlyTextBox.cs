using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ES.FormComponent
{
    public partial class ReadOnlyTextBox : TextBox
    {
        public ReadOnlyTextBox()
        {
            Init();
            InitializeComponent();
        }

        public ReadOnlyTextBox(IContainer container)
        {
            container.Add(this);
            
            Init();
            InitializeComponent();
        }
        private void Init()
        {
            GotFocus += TextBoxGotFocus;
            Cursor = Cursors.Arrow;
            Multiline = true;
            BorderStyle = BorderStyle.None;
            BackColor = SystemColors.ControlLightLight;
        }

        private void TextBoxGotFocus(object sender, EventArgs args)
        {
            var t = (TextBox)sender;
            t.Enabled = false;
            t.Enabled = true;
        }
    }
}
