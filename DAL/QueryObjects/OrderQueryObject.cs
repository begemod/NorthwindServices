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

        public QueryObject GetById(int orderId)
        {
            const string Sql =
                "select OrderID, CustomerID, EmployeeID, OrderDate, RequiredDate, ShippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry from dbo.Orders where OrderID = @OrderID";
            return new QueryObject(Sql, new { OrderID = orderId });
        }
    }
}