namespace OrderService
{
    using System.Collections.Generic;
    using DAL;
    using DAL.DataServices;
    using DAL.Entities;

    public class OrdersService : IOrdersService
    {
        private readonly OrdersDataService ordersDataService;

        public OrdersService()
        {
            var connectionFactory = new NortwindDbConnectionFactory();
            this.ordersDataService = new OrdersDataService(connectionFactory);
        }

        public IEnumerable<Order> GetAll()
        {
            return this.ordersDataService.GetAll();
        }
    }
}