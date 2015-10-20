namespace Tests.RemoteWCFServiceTests
{
    using System;
    using System.IO;
    using System.Linq;
    using System.ServiceModel;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Tests.CategoriesServiceReference;

    [TestClass]
    public class RemoteWCFCategoriesServiceTests
    {
        [TestMethod]
        public void GetCategoryNamesTest()
        {
            using (var client = new CategoriesServiceClient())
            {
                var names = client.GetCategoryNames();

                Assert.IsTrue(names != null && names.Any());
            }
        }

        [TestMethod]
        [ExpectedException(typeof(FaultException))]
        public void GetCategoryImageFaultTest()
        {
            using (var client = new CategoriesServiceClient())
            {
                var invalidCategoryName = Guid.NewGuid().ToString();
                var stream = client.GetCategoryImage(invalidCategoryName);
            }
        }

        [TestMethod]
        public void GetCategoryImageTest()
        {
            using (var client = new CategoriesServiceClient())
            {
                const int BuffSize = 1000;

                var names = client.GetCategoryNames();

                var categoryName = names.First();

                var readerStream = client.GetCategoryImage(categoryName);

                var buffer = new byte[BuffSize];

                var memoryStream = new MemoryStream();

                var readed = readerStream.Read(buffer, 0, BuffSize);

                while (readed != 0)
                {
                    memoryStream.Write(buffer, 0, readed);
                    readed = readerStream.Read(buffer, 0, BuffSize);
                }

                Assert.IsTrue(memoryStream.Length > 0);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(FaultException))]
        public void SaveCategoryImageNullCategoryNameFaultTest()
        {
            using (var client = new CategoriesServiceClient())
            {
                client.SaveCategoryImage(string.Empty, new MemoryStream());
            }
        }

        [TestMethod]
        [ExpectedException(typeof(FaultException))]
        public void SaveCategoryImageWrongCategoryNameFaultTest()
        {
            using (var client = new CategoriesServiceClient())
            {
                var wrongCategoryName = Guid.NewGuid().ToString();
                var stream = new MemoryStream();

                client.SaveCategoryImage(wrongCategoryName, stream);
            }
        }

        [TestMethod]
        public void SaveCategoryImageTest()
        {
            using (var client = new CategoriesServiceClient())
            {
                var image = new byte[20000];

                for (var i = 0; i < image.Length - 1; i++)
                {
                    image[i] = (byte)i;
                }

                var categoryNames = client.GetCategoryNames();
                var categoryName = categoryNames.First();

                var stream = new MemoryStream(image);

                client.SaveCategoryImage(categoryName, stream);
            }
        }
    }
}
