using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MT.Data.Dtos;
using MT.Service.AuthUserServices;

namespace MT.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthUserController : ControllerBase
    {
        private IAuthUserService _Service;


        public AuthUserController(IAuthUserService userService)
        {
            _Service = userService;
        }
        [HttpPost]
        [Route("SetAuth")]
        public bool SetAuthUser(AuthorityUser authUser)
        {
            var temp = _Service.SetAuthUser(authUser);
            return temp;
        }
    }
}
