using System;
using System.Threading.Tasks;
using homework3.Models;
using homework3.Services;

namespace homework3.Application
{
    public class AddUsersInfoRequestHandler
    {
        private readonly IUserInfoService _userInfoService;

        public AddUsersInfoRequestHandler(IUserInfoService userInfoService)
        {
            _userInfoService = userInfoService;
        }

        public void Handle(User user)
        {
            if (user.id == Guid.Empty)
            {
                throw new ArgumentException("Некорректный идентификатор пользователя", nameof(user.id));
            }

            _userInfoService.AppendUser(user);
        }
    }
}
