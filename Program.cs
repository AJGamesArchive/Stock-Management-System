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

            // Creating main instences of the Entity Manager and Item Manager classes to act as the main data stores and data managers within the system
            EntityManager em = new EntityManager(new TestData());
            ItemManager im = new ItemManager(new TestData());
            Application.Run(new MainSystem(em, im));
        }
    }
}