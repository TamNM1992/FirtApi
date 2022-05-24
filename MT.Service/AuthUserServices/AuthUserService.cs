using AutoMapper;
using MT.Data.Dtos;
using MT.Repository.AuthUserRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Service.AuthUserServices
{
    public class AuthUserService : IAuthUserService
    {
        private IAuthUserRepository _repo;

        public AuthUserService(IAuthUserRepository authority)
        {
            _repo = authority;
        }
        public bool SetAuthUser(AuthorityUser authUser)
        {
            var temp = _repo.SetAuthUser(authUser);
            return temp;
        }
    }
}
