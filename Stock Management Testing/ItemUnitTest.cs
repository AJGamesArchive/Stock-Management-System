namespace Stock_Management_Testing
{
    public class ItemUnitTest
    {
        [Fact]
        public void sellItemTestA()
        {
            // Test that the sellItem() method fails correctly when the given item is out of stock
            StockSystem stockSystem = createStockInstence();
            bool success = stockSystem.completePurchase(3, 45);
            Assert.False(success);
        }

        [Fact]
        public void sellItemTestB()
        {
            // Test that the sellItem() method succseeds and that a new purchase is created and stored when the given item is in stock
            // Test 1 of 4 - Clothing

            //Running Test
            StockSystem stockSystem = createStockInstence();
            bool success = stockSystem.completePurchase(3, 1);

            // Retrieve Expected Results
            bool detailRetrieval = stockSystem.retrieveCoreItemDetails(1, out string[] coreDetails);
            bool purchaseRetrieval = stockSystem.getCustomerPurchases(3, out string[] purchaseDetails);
            string[] purchaseNameSplit = purchaseDetails[1].Split(": ");
            string[] purchasePriceSplit = purchaseDetails[2].Split(": ");

            // Check expected results against actual results
            Assert.True(success);
            Assert.True(detailRetrieval);
            Assert.True(purchaseRetrieval);
            Assert.Equal(coreDetails[0], purchaseNameSplit[1]);
            Assert.Equal(coreDetails[1], purchasePriceSplit[1]);
        }

        [Fact]
        public void sellItemTestC()
        {
            // Test that the sellItem() method succseeds and that a new purchase is created and stored when the given item is in stock
            // Test 2 of 4 - Shoe

            //Running Test
            StockSystem stockSystem = createStockInstence();
            bool success = stockSystem.completePurchase(3, 14);

            // Retrieve Expected Results
            bool detailRetrieval = stockSystem.retrieveCoreItemDetails(14, out string[] coreDetails);
            bool purchaseRetrieval = stockSystem.getCustomerPurchases(3, out string[] purchaseDetails);
            string[] purchaseNameSplit = purchaseDetails[1].Split(": ");
            string[] purchasePriceSplit = purchaseDetails[2].Split(": ");

            // Check expected results against actual results
            Assert.True(success);
            Assert.True(detailRetrieval);
            Assert.True(purchaseRetrieval);
            Assert.Equal(coreDetails[0], purchaseNameSplit[1]);
            Assert.Equal(coreDetails[1], purchasePriceSplit[1]);
        }

        [Fact]
        public void sellItemTestD()
        {
            // Test that the sellItem() method succseeds and that a new purchase is created and stored when the given item is in stock
            // Test 3 of 4 - Accessory Known Type

            //Running Test
            StockSystem stockSystem = createStockInstence();
            bool success = stockSystem.completePurchase(3, 36);

            // Retrieve Expected Results
            bool detailRetrieval = stockSystem.retrieveCoreItemDetails(36, out string[] coreDetails);
            bool purchaseRetrieval = stockSystem.getCustomerPurchases(3, out string[] purchaseDetails);
            string[] purchaseNameSplit = purchaseDetails[1].Split(": ");
            string[] purchasePriceSplit = purchaseDetails[2].Split(": ");

            // Check expected results against actual results
            Assert.True(success);
            Assert.True(detailRetrieval);
            Assert.True(purchaseRetrieval);
            Assert.Equal(coreDetails[0], purchaseNameSplit[1]);
            Assert.Equal(coreDetails[1], purchasePriceSplit[1]);
        }

        [Fact]
        public void sellItemTestE()
        {
            // Test that the sellItem() method succseeds and that a new purchase is created and stored when the given item is in stock
            // Test 4 of 4 - Accessory Unknown Type

            //Running Test
            StockSystem stockSystem = createStockInstence();
            bool success = stockSystem.completePurchase(3, 46);

            // Retrieve Expected Results
            bool detailRetrieval = stockSystem.retrieveCoreItemDetails(46, out string[] coreDetails);
            bool purchaseRetrieval = stockSystem.getCustomerPurchases(3, out string[] purchaseDetails);
            string[] purchaseNameSplit = purchaseDetails[1].Split(": ");
            string[] purchasePriceSplit = purchaseDetails[2].Split(": ");

            // Check expected results against actual results
            Assert.True(success);
            Assert.True(detailRetrieval);
            Assert.True(purchaseRetrieval);
            Assert.Equal(coreDetails[0], purchaseNameSplit[1]);
            Assert.Equal(coreDetails[1], purchasePriceSplit[1]);
        }

        [Fact]
        public void sellItemTestF()
        {
            // Test that the sellItem() method succseeds and that a new purchase is created and stored when the given item is in stock but needs restocking
            // Test 1 of 2 - Clothing

            //Running Test
            StockSystem stockSystem = createStockInstence();
            bool success = stockSystem.completePurchase(3, 5);

            // Retrieve Expected Results
            bool detailRetrieval = stockSystem.retrieveCoreItemDetails(5, out string[] coreDetails);
            bool purchaseRetrieval = stockSystem.getCustomerPurchases(3, out string[] purchaseDetails);
            string[] purchaseNameSplit = purchaseDetails[1].Split(": ");
            string[] purchasePriceSplit = purchaseDetails[2].Split(": ");

            // Check expected results against actual results
            Assert.True(success);
            Assert.True(detailRetrieval);
            Assert.True(purchaseRetrieval);
            Assert.Equal(coreDetails[0], purchaseNameSplit[1]);
            Assert.Equal(coreDetails[1], purchasePriceSplit[1]);
        }

        [Fact]
        public void sellItemTestG()
        {
            // Test that the sellItem() method succseeds and that a new purchase is created and stored when the given item is in stock but needs restocking
            // Test 2 of 2 - Accessory

            //Running Test
            StockSystem stockSystem = createStockInstence();
            bool success = stockSystem.completePurchase(3, 27);

            // Retrieve Expected Results
            bool detailRetrieval = stockSystem.retrieveCoreItemDetails(27, out string[] coreDetails);
            bool purchaseRetrieval = stockSystem.getCustomerPurchases(3, out string[] purchaseDetails);
            string[] purchaseNameSplit = purchaseDetails[1].Split(": ");
            string[] purchasePriceSplit = purchaseDetails[2].Split(": ");

            // Check expected results against actual results
            Assert.True(success);
            Assert.True(detailRetrieval);
            Assert.True(purchaseRetrieval);
            Assert.Equal(coreDetails[0], purchaseNameSplit[1]);
            Assert.Equal(coreDetails[1], purchasePriceSplit[1]);
        }

        // Function to create an instence of the StockSystem and add all the TestData to it
        private StockSystem createStockInstence()
        {
            StockSystem stockSystem = new StockSystem();
            TestData testData = new TestData();
            testData.createTestCustomers(stockSystem);
            testData.createTestSuppliers(stockSystem);
            testData.createTestItems(stockSystem);
            testData.createTestPurchases(stockSystem);
            return stockSystem;
        }
    }
}
