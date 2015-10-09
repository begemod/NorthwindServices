namespace DAL.DataServices
{
    using System.Collections.Generic;
    using System.Linq;
    using DAL.Entities;
    using DAL.QueryObjects;

    public class CategoriesDataService : BaseDataService
    {
        public CategoriesDataService(IConnectionFactory connectionFactory)
            : base(connectionFactory)
        {
        }

        public Category GetByCategoryName(string categoryName)
        {
            using (var connection = this.GetConnection())
            {
                var categoryQueryObject = new CategoryQueryObject();
                return connection.Query<Category>(categoryQueryObject.GetByCategoryName(categoryName)).FirstOrDefault();
            }
        }

        public IEnumerable<string> GetCategoryNames()
        {
            using (var connection = this.GetConnection())
            {
                var categoryQueryObject = new CategoryQueryObject();
                return connection.Query<string>(categoryQueryObject.GetCategoryNames());
            }
        }
    }
}