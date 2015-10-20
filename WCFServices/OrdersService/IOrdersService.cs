namespace WCFServices.OrdersService
{
    using System.Collections.Generic;
    using System.ServiceModel;

    using WCFServices.DataContracts;

    [ServiceContract(Namespace = "http://epam.com/NorthwindService")]
    public interface IOrdersService
    {
        [OperationContract]
        IEnumerable<OrderDTO> GetAll();

        [OperationContract]
        OrderDTO GetById(int orderId);

        [OperationContract]
        OrderDTO CreateNewOrder();

        [OperationContract]
        void DeleteOrder(int orderId);
    }
}