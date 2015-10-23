namespace Tests.DALTests
{
    using System.Linq;
    using DAL.DataServices;
    using DAL.Infrastructure;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CategoriesDataServiceTests
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
            var categoryName = categoryNames.First();

            var category = this.categoriesDataService.GetByCategoryName(categoryName);

            Assert.IsNotNull(category);
        }

        [TestMethod]
        public void GetCategoryNames()
        {
            var categoryNames = this.categoriesDataService.GetCategoryNames();
            Assert.IsTrue(categoryNames.Any());
        }

        [TestMethod]
        public void SaveCategoryImageTest()
        {
            var categoryNames = this.categoriesDataService.GetCategoryNames();
            var categoryName = categoryNames.First();

            var category = this.categoriesDataService.GetByCategoryName(categoryName);

            using (TransactionScopeHelper.GetDefaultTransactionScope())
            {
                this.categoriesDataService.UpdateCategoryPicture(category);
            }
        }
    }
}
