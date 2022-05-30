using Microsoft.AspNetCore.Mvc;
using MT.Data.Dtos;
using MT.Data.Models;
using MT.Service.UserService;
using System.Collections.Generic;
using System;
namespace MT.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IUserService _userService;


        public LoginController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("LoginAndGetToken")]
        public IActionResult GetToken(AuthenticateRequest user)
        {
            var response = _userService.Authenticate(user);
            if (response == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(response.Token);
        }



        [HttpPost]
        [Route("Register")]
        public bool Register(UserDto user)
        {
            var temp = _userService.AddUser(user);


            return temp;
        }

        [HttpGet]
        [Route("test")]
        [Authorize]
        public IActionResult test()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }

        [HttpGet]
        [Route("test2/{username}")]
        [UserInfor]
        public IActionResult test2(string username)
        {
            var users = _userService.GetByUserName(username);
            return Ok(users);
        }

    }
}
