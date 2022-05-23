using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MT.Service.AttributeServices;
using MT.Service.MonterServices;
using MT.Service.SkillServices;
using MT.Service.TypeServices;

namespace MT.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BattleController : ControllerBase
    {
        private IMonterService _monterService;
        private IAttributeService _attributeService;
        private ITypeService _typeService;
        private ISkillService _skillService;


        public BattleController(IMonterService monterService, IAttributeService attributeService, ITypeService typeService, ISkillService skillService)
        {
            _monterService = monterService;
            _attributeService = attributeService;
            _typeService = typeService;
            _skillService = skillService;
        }


    }
}
