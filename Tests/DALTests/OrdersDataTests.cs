namespace Tests.DALTests
{
    using System.Linq;
    using DAL.DataServices;
    using DAL.Infrastructure;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class OrdersDataTests
    {
        private OrdersDataService ordersDataService;

        [TestInitialize]
        public void TestInitialize()
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

        [TestMethod]
        public void DeleteOrderTest()
        {
            var allOrders = this.ordersDataService.GetAll();
            var orderId = allOrders.First().OrderID;

            using (TransactionScopeHelper.GetDefaultTransactionScope())
            {
                var affectedRows = this.ordersDataService.DeleteOrder(orderId);

                Assert.IsTrue(affectedRows == 1);
            }
        }
    }
}
