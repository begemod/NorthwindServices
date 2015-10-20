namespace WCFServices.CategoriesService
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.ServiceModel;
    using DAL.DataServices;
    using DAL.Infrastructure;
    using WCFServices.DataContracts;

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

                var imageStream = new MemoryStream(categoryImage, 78, categoryImage.Length - 78);

                return imageStream;
            }
            catch (EntityNotFoundException exception)
            {
                throw new FaultException(new FaultReason(exception.Message), new FaultCode("Error"));
            }
        }

        public void SaveCategoryImage(SendingCategory category)
        {
            if (category == null)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(category.CategoryName))
            {
                throw new FaultException(new FaultReason("Category name is not defined."), new FaultCode("Error"));
            }

            try
            {
                var categoryByName = this.categoriesDataService.GetByCategoryName(category.CategoryName);
            }
            catch (EntityNotFoundException exception)
            {
                throw new FaultException(new FaultReason(exception.Message), new FaultCode("Error"));
            }
        }
    }
}
