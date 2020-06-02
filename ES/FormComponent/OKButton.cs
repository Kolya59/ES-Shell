using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ES.FormComponent
{
    public partial class OkButton : Button
    {
        
        public OkButton()
        {
            InitializeComponent();
            Init();
        }

        public OkButton(IContainer container)
        {
            container.Add(this);
            
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            Text = "OK";
            Font = new Font(new FontFamily("Tahoma"), 9);
            Size = new Size(80, 30);
            var buttonBorder = Color.FromArgb(132, 225, 132);
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderColor = buttonBorder;
            BackColor = Color.FromArgb(235, 250, 235);
        }
    }
}
