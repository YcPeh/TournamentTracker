using System;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
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

            // Initialize the database connections
            GlobalConfig.InitializeConnections(DatabaseType.Textfile);
            Application.Run(new CreatePrizeForm());

            //Application.Run(new TournamentDashboardForm());
        }
    }
}
