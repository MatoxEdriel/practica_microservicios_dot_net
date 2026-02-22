using System.Data;

namespace Intercore.shared.Interfaces;

public interface IDbConnectionFactory
{
    IDbConnection CreateConnection();
}