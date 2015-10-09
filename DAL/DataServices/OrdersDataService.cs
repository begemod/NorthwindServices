namespace DAL.DataServices
{
    using System.Collections.Generic;
    using System.Linq;

    using DAL.Entities;
    using DAL.QueryObjects;

    public class OrdersDataService : BaseDataService
    {
        public OrdersDataService(IConnectionFactory connectionFactory)
            : base(connectionFactory)
        {
        }

        public IEnumerable<Order> GetAll()
        {
            using (var connection = this.GetConnection())
            {
                var orderQueryObject = new OrderQueryObject();
                return connection.Query<Order>(orderQueryObject.GetAll());
            }
        }

        public Order GetById(int orderId)
        {
            using (var connection = this.GetConnection())
            {
                var orderQueryObject = new OrderQueryObject();
                return connection.Query<Order>(orderQueryObject.GetById(orderId)).SingleOrDefault();
            }
        }
    }
}