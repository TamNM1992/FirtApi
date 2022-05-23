using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MT.Data.Dtos;
using MT.Data.Models;
using MT.Service.AttributeServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MT.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttributeController : ControllerBase
    {
        private IAttributeService _Service;

        public AttributeController(IAttributeService attributeService)
        {
            _Service = attributeService;
        }
        [HttpPost]
        [Route("add")]

        public string AddAttribute(AttributeDto attributeDto)
        {
            var temp = _Service.AddAttribute(attributeDto);
            var json = JsonConvert.SerializeObject(temp);
            return json;
        }
    }
}
