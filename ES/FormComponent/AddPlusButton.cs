using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ES.FormComponent
{
    public partial class AddPlusButton : Button
    {
        public AddPlusButton()
        {
            InitializeComponent();
            Init();
        }

        public AddPlusButton(IContainer container)
        {
            container.Add(this);   
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            Text = "+";
            Font = new Font(new FontFamily("Tahoma"), 12, FontStyle.Bold);
            Height = 35;
            Width = 35;
            TextAlign = ContentAlignment.TopCenter;
            FlatStyle = FlatStyle.Flat;
            var buttonBorder = Color.Silver;
            FlatAppearance.BorderColor = buttonBorder;
            BackColor = SystemColors.ControlLightLight;
        }
    }
}
