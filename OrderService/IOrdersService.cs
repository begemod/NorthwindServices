namespace OrderService
{
    using System.Collections.Generic;
    using System.ServiceModel;

    [ServiceContract(Namespace = "http://epam.com/OrdersService")]
    public interface IOrdersService
    {
        [OperationContract]
        IEnumerable<OrderDTO> GetAll();
    }
}