namespace Tests.DALTests
{
    using System.Linq;
    using DAL.DataServices;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CategoriesDataTests
    {
        private CategoriesDataService categoriesDataService;

        [TestInitialize]
        public void ClassInitialize()
        {
            var connectionFactory = new NortwindDbConnectionFactoryForTests();
            this.categoriesDataService = new CategoriesDataService(connectionFactory);
        }

        [TestMethod]
        public void GetByCategoryNameTest()
        {
            var categoryNames = this.categoriesDataService.GetCategoryNames();
            var beveragesCategoryName = categoryNames.First();

            var category = this.categoriesDataService.GetByCategoryName(beveragesCategoryName);

            Assert.IsNotNull(category);
        }

        [TestMethod]
        public void GetCategoryNames()
        {
            var categoryNames = this.categoriesDataService.GetCategoryNames();
            Assert.IsTrue(categoryNames.Any());
        }
    }
}
