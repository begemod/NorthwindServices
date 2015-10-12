namespace OrderService.DataContracts
{
    using System.Runtime.Serialization;

    [DataContract(Namespace = "http://epam.com/OrdersService")]
    public enum OrderState
    {
        [EnumMember]
        New = 0,

        [EnumMember]
        InWork = 1,

        [EnumMember]
        Closed = 2
    }
}