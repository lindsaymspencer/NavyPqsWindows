using System;
using System.Windows.Forms;
using NavyPqs.Data;
using NavyPqs.Views;

namespace NavyPqs
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
            var data = new SessionData();
            Application.Run(new ListOfficersView(data.Officers));
        }
    }
}
