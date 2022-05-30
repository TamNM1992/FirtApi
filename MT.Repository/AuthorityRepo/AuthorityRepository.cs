using AutoMapper;
using Microsoft.Extensions.Options;
using MT.Data.Dtos;
using MT.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MT.Repository.AuthorityRepo
{
    public class AuthorityRepository : IAuthorityRepository
    {
        private readonly MonterDataContext _authorityContext;
        private readonly IMapper _mapper;
        private readonly AppSettings _appSettings;
        public AuthorityRepository(MonterDataContext context, IMapper mapper, IOptions<AppSettings> appSettings)
        {
            _authorityContext = context;
            _mapper = mapper;
            _appSettings = appSettings.Value;
        }
        public bool AddAuthority(AuthorityDto authority)
        {
            var temp = _authorityContext.Authorities.FirstOrDefault(x=> x.Code == authority.Code);
            if (temp == null)
            {
                var authEntity = _mapper.Map<AuthorityDto, Authority>(authority);
                _authorityContext.Add(authEntity);
                _authorityContext.SaveChanges();
                return true;
            }
            return false;
        }

        public IEnumerable<Authority> GetAuthorityByUser(Guid user)
        {
            var authorities = _authorityContext.Users.Where(x => x.Id == user).SelectMany(x => x.Authorities);
            return authorities;
        }

    }
}
