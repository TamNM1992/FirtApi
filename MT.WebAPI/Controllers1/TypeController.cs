using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MT.Data.Dtos;
using MT.Data.Models;
using MT.Service.TypeServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MT.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeController : ControllerBase
    {
        private ITypeService _Service;

        public TypeController(ITypeService typeService)
        {
            _Service = typeService;
        }
        [HttpPost]
        [Route("add")]

        public string AddType(TypeDto typeDto)
        {
            var temp = _Service.AddType(typeDto);
            var json = JsonConvert.SerializeObject(temp);
            return json;
        }
    }
}
