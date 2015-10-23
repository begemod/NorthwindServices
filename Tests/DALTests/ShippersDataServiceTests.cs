namespace Tests.DALTests
{
    using System.Linq;
    using DAL.DataServices;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ShippersDataServiceTests
    {
        private ShippersDataService shippersDataService;

        [TestInitialize]
        public void TestInitialize()
        {
            var connectionFactory = new NortwindDbConnectionFactoryForTests();
            this.shippersDataService = new ShippersDataService(connectionFactory);
        }

        [TestMethod]
        public void GetAllTest()
        {
            var allShippers = this.shippersDataService.GetAll();

            Assert.IsTrue(allShippers != null && allShippers.Any());
        }
    }
}