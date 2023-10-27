namespace Stock_Management_System
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

            // Declaring EntityManager object and pass it into form GUI class(s) so manager methods can be accessed by the GUI
            EntityManager em = new EntityManager();
            Application.Run(new MainSystem(em));
        }
    }
}