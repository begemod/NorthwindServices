namespace Tests.DALTests
{
    using System.Linq;
    using DAL.DataServices;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class OrdersTests
    {
        [TestMethod]
        public void GetAllTest()
        {
            var connectionFactory = new NortwindDbConnectionFactoryForTests();
            var ordersDataSetvice = new OrdersDataService(connectionFactory);

            var allOrders = ordersDataSetvice.GetAll();

            Assert.IsTrue(allOrders.Any());
        }
    }
}
