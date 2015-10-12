namespace OrderService
{
    using System.Collections.Generic;
    using System.Linq;

    using AutoMapper;
    using DAL.DataServices;
    using DAL.Entities;

    using OrderService.DTO;

    public class OrdersService : IOrdersService
    {
        private readonly OrdersDataService ordersDataService;

        public OrdersService()
        {
            var connectionFactory = new NortwindDbConnectionFactory();
            this.ordersDataService = new OrdersDataService(connectionFactory);

            this.ConfigureInMapping();
            this.ConfigureOutMapping();
        }

        public IEnumerable<OrderDTO> GetAll()
        {
            var allOrders = this.ordersDataService.GetAll().Select(Mapper.Map<Order, OrderDTO>);

            return allOrders;
        }

        private void ConfigureInMapping()
        {
            Mapper.CreateMap<OrderDTO, Order>();
        }

        private void ConfigureOutMapping()
        {
            Mapper.CreateMap<Order, OrderDTO>();
        }
    }
}