using System;
using System.Windows.Forms;

namespace AppointmentSystem
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu()); // Start with the MainMenu form
        }
    }
}
