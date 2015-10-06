namespace DAL
{
  using System.Collections.Generic;
  using DAL.Entities;
  using DAL.QueryObjects;

    public class OrdersDataService
  {
    private readonly IConnectionFactory connectionFactory;

    public OrdersDataService(IConnectionFactory connectionFactory)
    {
      this.connectionFactory = connectionFactory;
    }

    public IEnumerable<Order> GetAll()
    {
      using (var connection = this.connectionFactory.Create())
      {
          var orderQueryObject = new OrderQueryObject();
          return connection.Query<Order>(orderQueryObject.GetAll());
      }
    }
  }
}