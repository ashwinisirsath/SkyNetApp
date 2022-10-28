using System.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace SkynetApp.API.Data
{
    public class SkynetDbContext
    { private readonly string   _connectionString;
        public SkynetDbContext(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DeafaultconnectionPC");
        }
        public DbConnection CreateConnection() => new SqlConnection(_connectionString);
    }
}
