namespace OrdersServiceHost
{
  using System;
  using System.ServiceModel;

  public class Program
  {
    private static ServiceHost host;

    public static void Main(string[] args)
    {
      Console.WriteLine("Service started...");

      try
      {
        host = new ServiceHost(typeof(OrderService.OrdersService));

        host.Open();

        Console.ReadLine();
      }
      finally
      {
        if (host != null)
        {
          host.Close();
        }
      }

      Console.WriteLine("Service closed...");
    }
  }
}
