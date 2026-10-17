using System;
using System.Windows.Forms;

namespace BasketManagerApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // MAIN ENTRY
            Application.Run(new MainForm());
        }
    }
}