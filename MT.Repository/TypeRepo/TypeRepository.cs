using AutoMapper;
using MT.Data.Dtos;
using MT.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = MT.Data.Models.Type;

namespace MT.Repository.TypeRepo
{
    public class TypeRepository : ITypeRepository
    {
        private readonly MonterDataContext _context;
        private readonly IMapper _mapper;
        public TypeRepository(MonterDataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public bool AddType(TypeDto typeDto)
        {
            try
            {
                var typeEntity = _mapper.Map<TypeDto, Type>(typeDto);

                _context.Types.Add(typeEntity);
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
