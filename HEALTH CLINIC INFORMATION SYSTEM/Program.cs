using System;
using System.Windows.Forms;
using HEALTH_CLINIC_INFORMATION_SYSTEM.Visual;

namespace HEALTH_CLINIC_INFORMATION_SYSTEM.Visual
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
