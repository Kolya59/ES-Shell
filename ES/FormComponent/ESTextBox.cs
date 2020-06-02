using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ES.FormComponent
{
    public partial class EsTextBox : TextBox
    {
        public EsTextBox()
        {
            InitializeComponent();
            Init();
        }

        public EsTextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            Init();
        }

        private void Init()
        {
            Font = new Font(new FontFamily("Tahoma"), 9);
            Multiline = true;
            Height = 30;
        }
    }
}
