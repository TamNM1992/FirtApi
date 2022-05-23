using AutoMapper;
using MT.Data.Dtos;
using MT.Repository.AttributeRepo;
using MT.Repository.TypeRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Service.TypeServices
{
    public class TypeService : ITypeService
    {
        private ITypeRepository _repo;
        private IMapper _mapper;

        public TypeService(ITypeRepository type, IMapper mapper)
        {
            _repo = type;
            _mapper = mapper;
        }
        public bool AddType(TypeDto typeDto)
        {
            var temp = _repo.AddType(typeDto);
            return temp;
        }
    }
}
