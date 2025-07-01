using PlannerDataService;

namespace WinFormsAppDP
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

            var dataServiceWrapper = new PlannerDataService.PlannerDataService();
            var dataService = dataServiceWrapper.GetDataService();
            Application.Run(new Form1(dataService));
        }
    }
}