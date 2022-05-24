using AutoMapper;
using MT.Data.Dtos;
using MT.Data.Models;
using MT.Repository.AuthorityRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Service.AuthorityServices
{
    public class AuthorityService : IAuthorityService
    {
        private IAuthorityRepository _repo;
        private IMapper _mapper;

        public AuthorityService(IAuthorityRepository authority, IMapper mapper)
        {
            _repo = authority;
            _mapper = mapper;
        }
        public bool AddAuthority(AuthorityDto authorityDto)
        {
            var temp = _repo.AddAuthority(authorityDto);
            return temp;
        }
    }
}
