namespace Tests.WCFServiceTests
{
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class OrdersServiceTests
    {
        public void GetAllTest()
        {
            var ordersService = new OrderService.OrdersService();

            var allOrders = ordersService.GetAll();

            Assert.IsTrue(allOrders != null && allOrders.Any());
        }

        [TestMethod]
        public void GetByIdTest()
        {
            var ordersService = new OrderService.OrdersService();

            var allOrders = ordersService.GetAll();

            var orderId = allOrders.First().OrderId;

            var orderById = ordersService.GetById(orderId);

            Assert.IsNotNull(orderById);
        }

        [TestMethod]
        public void AddNewOrderTest()
        {
        }
    }
}
