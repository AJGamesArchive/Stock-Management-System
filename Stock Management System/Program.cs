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

            // Creating main instences of the Stock System classe to act as the main data store and data managers within the system
            StockSystem stockSystem = new StockSystem();
            
            // Adding test data to the system
            TestData testData = new TestData();
            testData.createTestCustomers(stockSystem);
            testData.createTestSuppliers(stockSystem);
            testData.createTestItems(stockSystem);
            testData.createTestPurchases(stockSystem);

            // Starting the application
            Application.Run(new MainSystem(stockSystem));
        }
    }
}