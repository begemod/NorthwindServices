namespace Tests
{
    using System.Configuration;
    using System.Data;
    using System.Data.SqlClient;
    using DAL;

    public class NortwindDbConnectionFactoryForTests : IConnectionFactory
  {
    public IDbConnection Create()
    {
      var connectionString = ConfigurationManager.ConnectionStrings["NortwindDBConnection"].ConnectionString;

      var connection = new SqlConnection(connectionString);

      return connection;
    }
  }
}