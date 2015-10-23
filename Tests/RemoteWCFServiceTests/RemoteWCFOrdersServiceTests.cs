namespace Tests.RemoteWCFServiceTests
{
    using System;
    using System.Linq;
    using System.ServiceModel;

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

        [TestMethod]
        [ExpectedException(typeof(FaultException))]
        public void CreateNewOrderFaultTest()
        {
            using (var client = new OrdersServiceClient())
            {
                client.CreateNewOrder(null);
            }
        }

        [TestMethod]
        public void CreateNewOrderTest()
        {
            using (var client = new OrdersServiceClient())
            {
                var newOrder = this.CreateNewOrder();
                var orderId = client.CreateNewOrder(newOrder);

                Assert.IsTrue(orderId > 0);

                var newOrderFromDB = client.GetById(orderId);

                Assert.IsNotNull(newOrderFromDB);
                Assert.IsTrue(newOrderFromDB.OrderState.Equals(OrderState.New));
            }
        }

        [TestMethod]
        [ExpectedException(typeof(FaultException))]
        public void UpdateOrderFaultOnNullParameterTest()
        {
            using (var client = new OrdersServiceClient())
            {
                client.UpdateOrder(null);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(FaultException))]
        public void UpdateOrderFaultOnAttemptNotInNewStateTest()
        {
            using (var client = new OrdersServiceClient())
            {
                var order = this.GetExistingOder(dto => dto.OrderState.Equals(OrderState.InWork) || dto.OrderState.Equals(OrderState.Closed));

                client.UpdateOrder(order);
            }
        }

        private OrderDTO CreateNewOrder()
        {
            var order = this.GetExistingOder();
            order.OrderId = 0;

            return order;
        }

        private OrderDTO GetExistingOder(Func<OrderDTO, bool> predicate = null)
        {
            using (var client = new OrdersServiceClient())
            {
                var allOrders = client.GetAll();

                predicate = predicate ?? (dto => true);

                return allOrders.First(predicate);
            }
        }
    }
}