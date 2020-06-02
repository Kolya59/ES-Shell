using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ES.FormComponent
{
    public partial class CancelButton : Button
    {
        public CancelButton()
        {
            InitializeComponent();
            Init();
        }

        public CancelButton(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            Text = "Отмена";
            Font = new Font(new FontFamily("Tahoma"), 9);
            Size = new Size(80, 30);
            FlatStyle = FlatStyle.Flat;
            var buttonBorder = Color.FromArgb(255, 153, 153);
            FlatAppearance.BorderColor = buttonBorder;
            BackColor = Color.FromArgb(255, 230, 230);
        }
    }
}
