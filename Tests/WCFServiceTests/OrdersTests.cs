namespace Tests.WCFServiceTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Tests.OrdersService;

    [TestClass]
    public class OrdersTests
    {
        [TestMethod]
        public void GetAllMethodTest()
        {
            using (var client = new OrdersServiceClient())
            {
                client.GetAll();
            }
        }
    }
}
