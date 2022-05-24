using AutoMapper;
using MT.Data.Dtos;
using MT.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Repository.AuthUserRepo
{
    public class AuthUserRepository : IAuthUserRepository
    {
        private readonly MonterDataContext _authUserContext;
        private readonly IMapper _mapper;
        public AuthUserRepository(MonterDataContext context, IMapper mapper)
        {
            _authUserContext = context;
            _mapper = mapper;
        }

        public bool SetAuthUser(AuthorityUser authUser)
        {
            var utemp = _authUserContext.Users.FirstOrDefault(x=> x.UserName == authUser.UserName);
            var atemp = _authUserContext.Authorities.FirstOrDefault(x=> x.Code == authUser.AuthorityCode);
            //var userEntity = _mapper.Map<UserDto, User>(user);
            //var authEntity = _mapper.Map<AuthorityDto, Authority>(authority);

            utemp.Authorities.Add(atemp);
            atemp.Users.Add(utemp);

            _authUserContext.SaveChanges();
            return true;
        }
    }
}
