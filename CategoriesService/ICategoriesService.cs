namespace CategoriesService
{
    using System.Collections.Generic;
    using System.ServiceModel;

    [ServiceContract]
    public interface ICategoriesService
    {
        [OperationContract]
        IEnumerable<string> GetCategoryNames();
    }
}