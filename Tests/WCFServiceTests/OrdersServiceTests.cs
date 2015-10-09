namespace Tests.WCFServiceTests
{
    using System.Linq;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Tests.ServiceReference1;

    [TestClass]
    public class OrdersServiceTests
    {
        [TestMethod]
        public void GetAllTest()
        {
            var client = new OrdersServiceClient();

            var allOrders = client.GetAll();

            Assert.IsTrue(allOrders != null && allOrders.Any());
        }
    }
}
