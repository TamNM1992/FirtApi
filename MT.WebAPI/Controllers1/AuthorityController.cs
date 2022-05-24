using Microsoft.AspNetCore.Mvc;
using MT.Data.Dtos;
using MT.Service.AuthorityServices;
using Newtonsoft.Json;

namespace MT.WebAPI.Controllers1
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorityController : ControllerBase
    {
        private IAuthorityService _Service;

        public AuthorityController(IAuthorityService authorityService)
        {
            _Service = authorityService;
        }
        [HttpPost]
        [Route("add")]

        public string AddAuthority(AuthorityDto authorityDto)
        {
            var temp = _Service.AddAuthority(authorityDto);
            var json = JsonConvert.SerializeObject(temp);
            return json;
        }
    }
}
