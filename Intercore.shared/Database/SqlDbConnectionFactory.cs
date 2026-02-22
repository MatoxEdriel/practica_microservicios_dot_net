using System.Data;
using Intercore.shared.Interfaces;
using Microsoft.Data.SqlClient;

namespace Intercore.shared.Database;

public class SqlDbConnectionFactory: IDbConnectionFactory
{
    private readonly string _connectionString;
    public SqlDbConnectionFactory(string connectionString) => _connectionString = connectionString;
    public IDbConnection CreateConnection() => new SqlConnection(_connectionString);
}