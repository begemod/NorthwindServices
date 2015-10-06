namespace DAL
{
    using System.Collections.Generic;
    using System.Data;
    using DAL.QueryObjects;
    using Dapper;

    public static class DapperQueryObjectExtensions
    {
        public static IEnumerable<T> Query<T>(this IDbConnection cnn, QueryObject queryObject, IDbTransaction transaction = null, bool buffered = true, int? commandTimeout = null, CommandType? commandType = null)
        {
            return cnn.Query<T>(queryObject.Sql, queryObject.QueryParams, transaction, buffered, commandTimeout, commandType);
        }
    }
}