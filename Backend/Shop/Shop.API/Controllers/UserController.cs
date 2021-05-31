using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.Infrastructure.Models;
using Shop.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [Route("/GetUserByEmail")]
        public ActionResult<UserDTO> Get(string email)
        {
            var user = _userService.Get(email);
            return Ok(user);
        }

        [Route("GetUserById")]
        public ActionResult<UserDTO> Get(Guid id)
        {
            var user = _userService.Get(id);
            return Ok(user);
        }

        [Route("GetAllUser")]
        public ActionResult<IEnumerable<UserDTO>> GetAll()
        {
            var allUser = _userService.GetAll().ToString();
            return Ok(allUser);
        }
    }
}
