﻿using Microsoft.AspNetCore.Http;
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
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Route("GetUserByEmail/{email}")]
        public ActionResult<UserDTO> Get(string email)
        {
            var user = _userService.Get(email);
            return Ok(user);
        }

        [HttpGet]
        [Route("GetUserById/{id}")]
        public ActionResult<UserDTO> Get(Guid id)
        {
            var user = _userService.Get(id);
            return Ok(user);
        }

        [HttpGet]
        [Route("/GetAll")]
        public ActionResult<IEnumerable<UserDTO>> GetAll()
        {
            var allUser = _userService.GetAll(); 
            return Ok(allUser);
        }

        [HttpPost]
        public ActionResult Post([FromBody] UserDTO userDTO)
        {
            _userService.Create(userDTO.Login, userDTO.Password, userDTO.Email, userDTO.Role = "user");
            return Created("api/[controller]/" + userDTO.Email, null);
        }

        [HttpDelete]
        [Route("DeleteUserById/{id}")]
        public ActionResult DeleteUser(Guid id)
        {
            _userService.DeleteUser(id);
            return Ok();
        }
       
    }
}
