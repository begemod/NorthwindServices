namespace WCFServicesConsoleHost
{
    using System;
    using System.ServiceModel;
    using WCFServices.CategoriesService;

    public class Program
    {
        public static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(CategoriesService)))
            {
                Console.WriteLine("Service started");

                host.Open();

                Console.ReadLine();
                Console.WriteLine("Service closed");
            }
        }
    }
}
