namespace OrderService
{
    using System.Collections.Generic;
    using AutoMapper;
    using DAL.DataServices;
    using DAL.Entities;

    public class OrdersService : IOrdersService
    {
        private readonly OrdersDataService ordersDataService;

        public OrdersService()
        {
            var connectionFactory = new NortwindDbConnectionFactory();
            this.ordersDataService = new OrdersDataService(connectionFactory);

            this.ConfigureMapping();
        }

        public IEnumerable<OrderDTO> GetAll()
        {
            var orderDTO = new List<OrderDTO>();
            var allOrders = this.ordersDataService.GetAll();

            return Mapper.Map(allOrders, orderDTO);
        }

        private void ConfigureMapping()
        {
            Mapper.CreateMap<Order, OrderDTO>();
        }
    }
}