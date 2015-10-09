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

            using (host = new ServiceHost(typeof(OrderService.OrdersService)))
            {
                host.Open();
            }

            Console.ReadLine();
            Console.WriteLine("Service closed...");
        }
    }
}
