﻿using System;
using System.Threading.Tasks;
using homework3.Models;
using homework3.Services;

namespace homework3.Infrastructure
{
    public class UserInfoService : IUserInfoService
    {
        private const string ConnectionString = "host=localhost;port=5432;database=postgres;username=postgres;password=1";

    public async Task<User> GetById(Guid id)
            {
                User user = new User
                {
                    Email = "test@test.ru",
                    id = id,
                    Nickname = "test",
                    Phone = "+7 987 654 32 10"
                };

                return await Task.FromResult<User>(user);
            }
    }
}
