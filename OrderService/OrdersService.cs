﻿namespace OrderService
{
    using System.Collections.Generic;
    using System.Linq;
    using AutoMapper;
    using DAL.DataServices;
    using DAL.Entities;
    using OrderService.DataContracts;

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

        public OrderDTO GetById(int orderId)
        {
            var orderById = this.ordersDataService.GetById(orderId);

            var result = Mapper.Map<Order, OrderDTO>(orderById);

            return result;
        }

        private void ConfigureInMapping()
        {
            Mapper.CreateMap<OrderDTO, Order>();
            Mapper.CreateMap<OrderDetailDTO, OrderDetail>();
            Mapper.CreateMap<ProductDTO, Product>();
        }

        private void ConfigureOutMapping()
        {
            Mapper.CreateMap<Order, OrderDTO>().ForMember(
                d => d.OrderState,
                o => o.MapFrom(src => src.OrderDate == null ? OrderState.New : src.ShippedDate == null ? OrderState.InWork : OrderState.Closed));

            Mapper.CreateMap<OrderDetail, OrderDetailDTO>();
            Mapper.CreateMap<Product, ProductDTO>();
        }
    }
}