namespace OrderService
{
  using System.ServiceModel;

  [ServiceContract]
  public interface IOrdersService
  {
    [OperationContract]
    string GetAll();
  }
}