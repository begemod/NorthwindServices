namespace OrderService
{
  using System.Configuration;
  using System.Data;
  using System.Data.SqlClient;
  using DAL;

  public class NortwindDbConnectionFactory : IConnectionFactory
  {
    public IDbConnection Create()
    {
      var connectionString = ConfigurationManager.ConnectionStrings["NortwindDBConnection"].ConnectionString;

      var connection = new SqlConnection(connectionString);

      connection.Open();

      return connection;
    }
  }
}