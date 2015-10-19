namespace WCFServices.CategoriesService
{
    using System.Collections.Generic;
    using System.IO;
    using System.ServiceModel;
    using DAL.DataServices;
    using DAL.Infrastructure;

    public class CategoriesService : ICategoriesService
    {
        private readonly CategoriesDataService categoriesDataService;

        public CategoriesService()
        {
            var connectionFactory = new NortwindDbConnectionFactory();
            this.categoriesDataService = new CategoriesDataService(connectionFactory);
        }

        public IEnumerable<string> GetCategoryNames()
        {
            return this.categoriesDataService.GetCategoryNames();
        }

        public Stream GetCategoryImage(string categoryName)
        {
            if (string.IsNullOrWhiteSpace(categoryName))
            {
                return null;
            }

            try
            {
                var category = this.categoriesDataService.GetByCategoryName(categoryName);

                var categoryImage = category.Picture;
                return new MemoryStream(categoryImage, 78, categoryImage.Length - 78);
            }
            catch (EntityNotFoundException exception)
            {
                throw new FaultException(exception.Message);
            }
        }

        public void SaveCategoryImage(Stream categoryImage)
        {
            throw new System.NotImplementedException();
        }
    }
}
