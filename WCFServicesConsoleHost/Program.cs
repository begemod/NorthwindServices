namespace WCFServicesConsoleHost
{
    using System;
    using System.Linq;
    using System.ServiceModel;
    using WCFServices.CategoriesService;
    using WCFServices.OrdersService;

    public class Program
    {
        private enum ServiceHostType
        {
            Orders = 1,

            Categories = 2
        }

        public static void Main(string[] args)
        {
            var serviceHostType = GetServiceHostType(args);

            using (var host = GetServiceHost(serviceHostType))
            {
                Console.WriteLine("Service {0} is running..", host.Description.Name);

                host.Open();

                Console.ReadLine();
                Console.WriteLine("Service closed");
            }
        }

        private static ServiceHostType GetServiceHostType(string[] args)
        {
            if (args == null || !args.Any())
            {
                return ServiceHostType.Orders;
            }

            ServiceHostType result;

            if (!Enum.TryParse(args[0], out result))
            {
                result = ServiceHostType.Orders;
            }

            return result;
        }

        private static ServiceHost GetServiceHost(ServiceHostType selectedServiceHostType)
        {
            Type serviceHostType;

            switch (selectedServiceHostType)
            {
                case ServiceHostType.Categories:
                    serviceHostType = typeof(CategoriesService);
                    break;
                default:
                    serviceHostType = typeof(OrdersService);
                    break;
            }

            return new ServiceHost(serviceHostType);
        }
    }
}
