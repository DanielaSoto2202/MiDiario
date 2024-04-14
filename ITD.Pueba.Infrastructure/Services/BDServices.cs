
using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace ITD.MiDiario.Infrastructure.Services
{
    public class BDServices
    {
        private IDbConnection? _dbConnection { get; set; }
        private string? _conection { get; set; }
        public BDServices(IConfiguration configuration)
        {
            _conection = configuration?.GetConnectionString("DefaultConnection");
        }
        private IDbConnection CreateConnection()
        {
            return new SqlConnection(_conection);
        }
        public async ValueTask<IEnumerable<T>> ExecuteStoredProcedureQuery<T>(string storedProcedure, DynamicParameters? parameters = null)
            {
                using (var dbConnection = CreateConnection())
                {
                    _dbConnection = dbConnection;
                    return (await dbConnection.QueryAsync<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure)).AsQueryable();
                }
            }
        }
    }

