namespace OrderService
{
    using System;
    using System.Runtime.Serialization;

    [DataContract(Namespace = "http://epam.com/OrdersService")]
    public class OrderDTO
    {
        [DataMember]
        public int OrderId { get; set; }

        [DataMember]
        public DateTime? OrderDate { get; set; }
    }
}