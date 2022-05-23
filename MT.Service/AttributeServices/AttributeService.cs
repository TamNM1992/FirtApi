using AutoMapper;
using MT.Data.Dtos;
using MT.Repository.AttributeRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Service.AttributeServices
{
    public class AttributeService : IAttributeService
    {
        private IAttributeRepository _repo;
        private IMapper _mapper;

        public AttributeService(IAttributeRepository attribute, IMapper mapper)
        {
            _repo = attribute;
            _mapper = mapper;
        }
        public bool AddAttribute(AttributeDto attributeDto)
        {
            var temp = _repo.AddAttribute(attributeDto);
            return temp;
        }
    }
}
