namespace DAL.QueryObjects
{
    public class OrderQueryObject
    {
        public QueryObject GetAll()
        {
            return new QueryObject("select OrderID, CustomerID, EmployeeID, OrderDate, RequiredDate, ShippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry from dbo.Orders");
        }
    }
}