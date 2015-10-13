namespace OrderService
{
    using System.Collections.Generic;
    using System.ServiceModel;
    using OrderService.DataContracts;

    [ServiceContract(Namespace = "http://epam.com/OrdersService")]
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