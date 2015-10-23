namespace WCFServices.OrdersService
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Linq;
    using System.ServiceModel;
    using System.Threading.Tasks;
    using AutoMapper;
    using DAL.DataServices;
    using DAL.Entities;
    using DAL.Infrastructure;
    using WCFServices.DataContracts;
    using WCFServices.OrdersSubscriptionService;

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class OrdersService : IOrdersService, IOrdersSubscriptionService
    {
        private static readonly ConcurrentDictionary<string, IBroadcastCallback> Callbacks = new ConcurrentDictionary<string, IBroadcastCallback>();
        private readonly OrdersDataService ordersDataService;

        public OrdersService()
        {
            var connectionFactory = new NortwindDbConnectionFactory();
            this.ordersDataService = new OrdersDataService(connectionFactory);

            this.ConfigureInMapping();
            this.ConfigureOutMapping();
        }

        #region IOrdersService members

        public IEnumerable<OrderDTO> GetAll()
        {
            return this.ordersDataService.GetAll().Select(Mapper.Map<Order, OrderDTO>);
        }

        public OrderDTO GetById(int orderId)
        {
            var orderById = this.ordersDataService.GetById(orderId);

            var result = Mapper.Map<Order, OrderDTO>(orderById);

            return result;
        }

        public OrderDTO CreateNewOrder()
        {
            return new OrderDTO();
        }

        public void UpdateOrder(OrderDTO order)
        {
            // update order only in New status
        }

        public void ProcessOrder(OrderDTO order)
        {
            // set status to InWork
            this.OnOrderStatusChanged(order.OrderId, OrderState.InWork);
        }

        public void CloseOrder(OrderDTO order)
        {
            // set status on Closed
            this.OnOrderStatusChanged(order.OrderId, OrderState.Closed);
        }

        public void DeleteOrder(int orderId)
        {
            try
            {
                var orderById = this.ordersDataService.GetById(orderId);

                this.ordersDataService.DeleteOrder(orderId);
            }
            catch (EntityNotFoundException exception)
            {
                throw new FaultException(new FaultReason(exception.Message), new FaultCode("Error"));
            }
        }

        #endregion

        #region IOrdersSubscriptionService members

        public bool Subscribe(string clientIdentifier)
        {
            if (string.IsNullOrWhiteSpace(clientIdentifier))
            {
                return false;
            }

            if (Callbacks.ContainsKey(clientIdentifier))
            {
                return false;
            }

            var callbackChannel = OperationContext.Current.GetCallbackChannel<IBroadcastCallback>();
            return Callbacks.TryAdd(clientIdentifier, callbackChannel);
        }

        public bool Unsubscribe(string clientIdentifier)
        {
            if (string.IsNullOrWhiteSpace(clientIdentifier))
            {
                return false;
            }

            if (!Callbacks.ContainsKey(clientIdentifier))
            {
                return false;
            }

            IBroadcastCallback callbackChannel;
            return Callbacks.TryRemove(clientIdentifier, out callbackChannel);
        }

        #endregion

        private void OnOrderStatusChanged(int orderId, OrderState previousState)
        {
            Task.Factory.StartNew(() =>
                {
                    var clientKeys = Callbacks.Keys.ToArray();
                    foreach (var clientKey in clientKeys)
                    {
                        IBroadcastCallback callback;
                        if (Callbacks.TryGetValue(clientKey, out callback))
                        {
                            if (callback != null)
                            {
                                try
                                {
                                    callback.OrderStatusIsChanged(orderId);
                                }
                                catch (TimeoutException)
                                {
                                    // suppose that connection to client has been lost
                                    // and callback should be removed from list
                                    IBroadcastCallback faultedCallback;
                                    var faultedClientId = clientKey;
                                    Callbacks.TryRemove(faultedClientId, out faultedCallback);
                                }
                            }
                        }
                    }
                });
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