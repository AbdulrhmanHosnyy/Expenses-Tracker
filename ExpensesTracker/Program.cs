using ExpensesTracker.Code;
using ExpensesTrackerData.SqlServer;

namespace ExpensesTracker
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            DependencyInjection.AddDependencyValues();
            SqlCon.SqlConnection = Properties.Settings.Default.SqlServerConString;
            Application.Run(new Starter());
        }
    }
}