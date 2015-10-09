namespace OrderService.DataContracts
{
    using System.Runtime.Serialization;

    [DataContract]
    public class OrderDTO
    {
        [DataMember]
        public int OrderID { get; set; }

        public OrderDTO()
        {
            
        }
    }
}