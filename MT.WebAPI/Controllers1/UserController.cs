using Microsoft.AspNetCore.Mvc;
using MT.Common.Enums;
using MT.Data.Dtos;
using MT.Data.Models;
using MT.Service.UserService;
using MT.WebAPI.Attributes;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace MT.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;

        public UsersController(IUserService userService)
        {
            // đoạn này khởi tạo controller, để xem là nó nhảy vào đây trước hay vào middleware trước, hay thẻ attribute trước nhé
            _userService = userService;
        }

        [Authorize]
        [Role(Role.admintrator, Role.get_all_user)]  // action này có cần 1 trong 2 quyền này để vào
        [HttpGet("get-all")]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }


    }
}
