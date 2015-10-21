namespace Tests.RemoteWCFServiceTests
{
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Tests.OrdersService;

    [TestClass]
    public class RemoteWCFOrdersServiceTests
    {
        [TestMethod]
        public void GetAllTest()
        {
            using (var client = new OrdersServiceClient())
            {
                var allOrders = client.GetAll();

                Assert.IsTrue(allOrders != null && allOrders.Any());
            }
        }

        [TestMethod]
        public void GetByIdTest()
        {
            using (var client = new OrdersServiceClient())
            {
                var allOrders = client.GetAll();

                var orderId  = allOrders.First().OrderId;

                var orderById = client.GetById(orderId);

                Assert.IsNotNull(orderById);
            }
        }
    }
}
