namespace OrderService
{
  using DAL;

  public class OrdersService : IOrdersService
  {
    private readonly OrdersDataService ordersDataService = new OrdersDataService();

    public string GetAll()
    {
      return "Orders list";
    }
  }
}