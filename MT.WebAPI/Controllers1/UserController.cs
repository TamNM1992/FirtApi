using Microsoft.AspNetCore.Mvc;
using MT.Data.Dtos;
using MT.Data.Models;
using MT.Service.UserService;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace MT.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;
        private readonly AppSettings _appSettings;


        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [Authorize]
        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }
    }
}
