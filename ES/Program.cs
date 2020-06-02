using System;
using System.Windows.Forms;

namespace ES
{
    internal static class Program
    {
        public static MainForm mainForm;

        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainForm = new MainForm();
            Application.Run(mainForm);
        }
    }
}
