using System;
using System.Threading.Tasks;
using Dapper;
using homework3.Models;
using homework3.Services;
using Npgsql;

namespace homework3.Infrastructure
{
    public class UserInfoService : IUserInfoService
    {
        private const string ConnectionString = "host=localhost;port=5432;database=homework3;username=postgres;password=1";

    public async Task<User> GetById(Guid id)
            {
                using (var connection = new NpgsqlConnection(ConnectionString))
            {
                return await connection.QuerySingleAsync<User>("SELECT * FROM Users WHERE Id = @id", new { id });
            }
            }
    }
}
