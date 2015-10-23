namespace Tests.DALTests
{
    using System;
    using System.Linq;
    using DAL.DataServices;
    using DAL.Entities;
    using DAL.Infrastructure;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class OrdersDataServiceTests
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

        [TestMethod]
        public void InsertOrderTest()
        {
            var allOrders = this.ordersDataService.GetAll();
            var orderId = allOrders.First().OrderID;

            var orderById = this.ordersDataService.GetById(orderId);

            var newOrder = (Order)orderById.Clone();

            newOrder.OrderID = 0;
            foreach (var orderDetail in newOrder.OrderDetails)
            {
                orderDetail.OrderID = 0;
            }

            using (TransactionScopeHelper.GetDefaultTransactionScope())
            {
                var newOrderId = this.ordersDataService.InsertOrder(newOrder);

                Assert.IsTrue(newOrderId > 0);
            }
        }

        [TestMethod]
        public void UpdateOrderTest()
        {
            var allOrders = this.ordersDataService.GetAll();
            var orderId = allOrders.First().OrderID;

            var orderById = this.ordersDataService.GetById(orderId);

            var originalOrderDate = orderById.OrderDate;
            var originalShippedDate = orderById.ShippedDate;

            using (TransactionScopeHelper.GetDefaultTransactionScope())
            {
                orderById.OrderDate = DateTime.Now;
                orderById.ShippedDate = DateTime.Now;

                var affectedRows = this.ordersDataService.UpdateOrder(orderById);

                Assert.IsTrue(affectedRows == 1);

                var updatedOrder = this.ordersDataService.GetById(orderId);

                Assert.AreNotEqual(updatedOrder.OrderDate, originalOrderDate);
                Assert.AreNotEqual(updatedOrder.ShippedDate, originalShippedDate);
            }
        }
    }
}
