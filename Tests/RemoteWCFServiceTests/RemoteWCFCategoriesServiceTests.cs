namespace Tests.RemoteWCFServiceTests
{
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Tests.CategoriesServiceReference;

    [TestClass]
    public class RemoteWCFCategoriesServiceTests
    {
        [TestMethod]
        public void GetCategoryNamesTest()
        {
            using (var client = new CategoriesServiceClient("BasicHttpBinding_ICategoriesService"))
            {
                var names = client.GetCategoryNames();

                Assert.IsTrue(names != null && names.Any());
            }
        }
    }
}
