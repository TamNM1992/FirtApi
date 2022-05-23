using AutoMapper;
using MT.Data.Dtos;
using MT.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Attribute = MT.Data.Models.Attribute;

namespace MT.Repository.AttributeRepo
{
    public class AttributeRepository : IAttributeRepository
    {
        private readonly MonterDataContext _context;
        private readonly IMapper _mapper;
        public AttributeRepository(MonterDataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public bool AddAttribute(AttributeDto attributeDto)
        {
            try
            {
                var attributeEntity = _mapper.Map<AttributeDto, Attribute>(attributeDto);

                _context.Attributes.Add(attributeEntity);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
