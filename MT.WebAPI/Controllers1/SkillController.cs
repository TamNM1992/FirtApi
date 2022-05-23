using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MT.Data.Dtos;
using MT.Service.SkillServices;
using Newtonsoft.Json;

namespace MT.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillController : ControllerBase
    {
        private ISkillService _Service;

        public SkillController(ISkillService skillService)
        {
            _Service = skillService;
        }
        [HttpPost]
        [Route("add")]

        public string AddSkill(SkillDto skillDto)
        {
            var temp = _Service.AddSkill(skillDto);
            var json = JsonConvert.SerializeObject(temp);
            return json;
        }
    }
}
