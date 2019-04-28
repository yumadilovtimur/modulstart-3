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
        void AppendUser(User user);

    }
}
