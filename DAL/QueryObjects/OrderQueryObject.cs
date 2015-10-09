namespace DAL.QueryObjects
{
    public class OrderQueryObject
    {
        public QueryObject GetAll()
        {
            const string Sql =
                "select OrderID, CustomerID, EmployeeID, OrderDate, RequiredDate, ShippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry from dbo.Orders";
            return new QueryObject(Sql);
        }
    }
}