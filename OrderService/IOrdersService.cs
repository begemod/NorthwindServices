namespace OrderService
{
  using System.Collections.Generic;
  using System.ServiceModel;

  using DAL.Entities;

  [ServiceContract(Namespace = "http://epam.com/OrdersService")]
  public interface IOrdersService
  {
    [OperationContract]
    IEnumerable<Order> GetAll();
  }
}