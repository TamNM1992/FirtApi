using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MT.Data.Dtos;
using MT.Service.MonterServices;
using Newtonsoft.Json;

namespace MT.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonterController : ControllerBase
    {
        private IMonterService _Service;

        public MonterController(IMonterService monterService)
        {
            _Service = monterService;
        }

        [HttpPost]
        [Route("add")]
        public string AddMonter(MonterDto monterDto)
        {
            var temp = _Service.AddMonter(monterDto);
            var json = JsonConvert.SerializeObject(temp);
            return json;
        }
    }
}
