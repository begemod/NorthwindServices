namespace WCFServices.CategoriesService
{
    using System.Collections.Generic;
    using System.IO;
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
            return new MemoryStream();
        }

        public void SaveCategoryImage(Stream categoryImage)
        {
            throw new System.NotImplementedException();
        }
    }
}
