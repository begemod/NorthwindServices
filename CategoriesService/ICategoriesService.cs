namespace CategoriesService
{
    using System.Collections.Generic;
    using System.IO;
    using System.ServiceModel;

    [ServiceContract]
    public interface ICategoriesService
    {
        [OperationContract]
        IEnumerable<string> GetCategoryNames();

        [OperationContract]
        Stream GetCategoryImage(string categoryName);

        [OperationContract]
        void SaveCategoryImage(Stream categoryImage);
    }
}