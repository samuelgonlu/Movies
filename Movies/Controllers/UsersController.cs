using BusinessLogic.Services;
using DTO;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Movies.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UsersService _usersService;

        public UsersController(UsersService usersService)
        {
            _usersService = usersService;
        }

        [HttpGet]
        public List<User> Get()
        {
            return _usersService.GetUsers();
        }

        [HttpPost]
        public User Post([FromBody] UserSession session)
        {
            return _usersService.CreateUser(session);
        }

       
    }
}
