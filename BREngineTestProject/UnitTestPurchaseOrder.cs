using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BREngineTestProject
{

    [TestClass]
    public class UnitTestPurchaseOrder
    {
        [TestMethod]
        public void TestMethod_PhysicalProduct()
        {
            var purchaseOrderPhysicalProduct = new PurchaseOrderPhysicalProduct();
            var purchaseOrderBook = new PurchaseOrderBook();
            var purchaseOrderMembership = new PurchaseOrderMembership();
            var pruchaseOrderUpgradeMembership = new PruchaseOrderUpgradeMembership();
            var purchaseOrderVideo = new PurchaseOrderVideo();

            purchaseOrderPhysicalProduct.SetNext(purchaseOrderBook)
                .SetNext(purchaseOrderMembership)
                .SetNext(pruchaseOrderUpgradeMembership)
                .SetNext(purchaseOrderVideo);

            string testMessage = "Generate a packing slip for shipping \nCommission generated for your Product Purchase";
            string resultMessage = purchaseOrderPhysicalProduct.OrderProcess(PaymentFor.PhysicalProduct);

            StringAssert.Contains(resultMessage, testMessage);          
        }

        [TestMethod]
        public void TestMethod_Book()
        {
            var purchaseOrderPhysicalProduct = new PurchaseOrderPhysicalProduct();
            var purchaseOrderBook = new PurchaseOrderBook();
            var purchaseOrderMembership = new PurchaseOrderMembership();
            var pruchaseOrderUpgradeMembership = new PruchaseOrderUpgradeMembership();
            var purchaseOrderVideo = new PurchaseOrderVideo();

            purchaseOrderPhysicalProduct.SetNext(purchaseOrderBook)
                .SetNext(purchaseOrderMembership)
                .SetNext(pruchaseOrderUpgradeMembership)
                .SetNext(purchaseOrderVideo);

            string testMessage = "Create a duplicate slip for royalty department \nCommission generated for your Book Purchase";
            string resultMessage = purchaseOrderBook.OrderProcess(PaymentFor.Book);

            StringAssert.Contains(resultMessage, testMessage);
        }

        [TestMethod]
        public void TestMethod_ActivateMembership()
        {
            var purchaseOrderPhysicalProduct = new PurchaseOrderPhysicalProduct();
            var purchaseOrderBook = new PurchaseOrderBook();
            var purchaseOrderMembership = new PurchaseOrderMembership();
            var pruchaseOrderUpgradeMembership = new PruchaseOrderUpgradeMembership();
            var purchaseOrderVideo = new PurchaseOrderVideo();

            purchaseOrderPhysicalProduct.SetNext(purchaseOrderBook)
                .SetNext(purchaseOrderMembership)
                .SetNext(pruchaseOrderUpgradeMembership)
                .SetNext(purchaseOrderVideo);


            string testMessage = "Membership is activated \nEmail sent regarding you Membership Activation to your registered email account";
            string resultMessage = purchaseOrderMembership.OrderProcess(PaymentFor.Membership);

            StringAssert.Contains(resultMessage, testMessage);
        }

        [TestMethod]
        public void TestMethod_UpgradeMembership()
        {
            var purchaseOrderPhysicalProduct = new PurchaseOrderPhysicalProduct();
            var purchaseOrderBook = new PurchaseOrderBook();
            var purchaseOrderMembership = new PurchaseOrderMembership();
            var pruchaseOrderUpgradeMembership = new PruchaseOrderUpgradeMembership();
            var purchaseOrderVideo = new PurchaseOrderVideo();

            purchaseOrderPhysicalProduct.SetNext(purchaseOrderBook)
                .SetNext(purchaseOrderMembership)
                .SetNext(pruchaseOrderUpgradeMembership)
                .SetNext(purchaseOrderVideo);

            string testMessage = "Membership is upgraded...\nEmail sent regarding you Membership Upgrade to your registered email account";
            string resultMessage = pruchaseOrderUpgradeMembership.OrderProcess(PaymentFor.UpgradeMembership);

            StringAssert.Contains(resultMessage, testMessage);
        }


        [TestMethod]
        public void TestMethod_Video()
        {
            var purchaseOrderPhysicalProduct = new PurchaseOrderPhysicalProduct();
            var purchaseOrderBook = new PurchaseOrderBook();
            var purchaseOrderMembership = new PurchaseOrderMembership();
            var pruchaseOrderUpgradeMembership = new PruchaseOrderUpgradeMembership();
            var purchaseOrderVideo = new PurchaseOrderVideo();

            purchaseOrderPhysicalProduct.SetNext(purchaseOrderBook)
                .SetNext(purchaseOrderMembership)
                .SetNext(pruchaseOrderUpgradeMembership)
                .SetNext(purchaseOrderVideo);

            string testMessage = "Generated purchase slip for Learning to Ski video \nAdded a free video on First Aid as per 1997 court order";
            string resultMessage = purchaseOrderVideo.OrderProcess(PaymentFor.Video);

            StringAssert.Contains(resultMessage, testMessage);
        }
    }
}
