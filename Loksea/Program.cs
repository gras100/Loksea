using System;
using System.Windows.Forms;

namespace Loksea
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
            using (IconUpdater app = new IconUpdater())
            {
                app.Start();
                Application.Run();
            }
        }
    }
}
