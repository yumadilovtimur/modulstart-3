using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using homework3.Models;

namespace homework3.Services
{
    public interface IUserInfoService
    {
        Task<User> GetById(Guid id);

        public async void AppendUser(User user)
        {
            using (var connection = new NpgsqlConnection(ConnectionString))
            {
                string query = "INSERT INTO users (id, email, nickname, phone) VALUES (@id, @email, @nickname, @phone)";

                await connection.QuerySingleAsync<User>(query, user);
            }
        }
    }
}
