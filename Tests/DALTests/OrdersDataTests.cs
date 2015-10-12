namespace Tests.DALTests
{
    using System.Linq;
    using DAL.DataServices;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class OrdersDataTests
    {
        private OrdersDataService ordersDataService;

        [TestInitialize]
        public void ClassInitialize()
        {
            var connectionFactory = new NortwindDbConnectionFactoryForTests();
            this.ordersDataService = new OrdersDataService(connectionFactory);
        }

        [TestMethod]
        public void GetAllTest()
        {
            var allOrders = this.ordersDataService.GetAll();

            Assert.IsTrue(allOrders.Any());
        }

        [TestMethod]
        public void GetByIdTest()
        {
            var allOrders = this.ordersDataService.GetAll();
            var orderId = allOrders.First().OrderID;

            var orderById = this.ordersDataService.GetById(orderId);

            Assert.IsNotNull(orderById);
        }
    }
}
