using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using homework3.Application;
using homework3.Models;

namespace homework3.Controllers
{
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly GetUsersInfoRequestHandler _getUsersInfoRequestHandler;
        private readonly AddUsersInfoRequestHandler _addUsersInfoRequestHandler;

        public UsersController(GetUsersInfoRequestHandler getUsersInfoRequestHandler, AddUsersInfoRequestHandler addUsersInfoRequestHandler)
        {
            _getUsersInfoRequestHandler = getUsersInfoRequestHandler;
            _addUsersInfoRequestHandler = addUsersInfoRequestHandler;
        }

        [HttpGet("{id}")]
        public Task<User> GetUserInfo(Guid id)
        {
            return _getUsersInfoRequestHandler.Handle(id);
        }

        [HttpPost("append")]

        public Task<User> AppendUser([FromBody] User user)
        {
            Guid guid = Guid.NewGuid();
            user.id = guid;
            return _addUsersInfoRequestHandler.Handle(user);
        }
    }
}