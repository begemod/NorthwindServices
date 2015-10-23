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
        void DeleteOrder(int orderId);

        [OperationContract]
        int CreateNewOrder(OrderDTO order);

        [OperationContract]
        void UpdateOrder(OrderDTO order);

        [OperationContract]
        void ProcessOrder(OrderDTO order);

        [OperationContract]
        void CloseOrder(OrderDTO order);
    }
}