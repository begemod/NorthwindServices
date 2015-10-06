namespace Tests.DALTests
{
    using System.Linq;

    using DAL;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class OrdersTests
    {
        [TestMethod]
        public void GetAllTest()
        {
            var connectipnFactory = new NortwindDbConnectionFactoryForTests();
            var ordersDataSetvice = new OrdersDataService(connectipnFactory);

            var allOrders = ordersDataSetvice.GetAll();

            Assert.IsTrue(allOrders.Any());
        }
    }
}
