namespace DAL
{
  using System.Collections.Generic;
  using DAL.Entities;

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
        return new List<Order>();
      }
    }
  }
}