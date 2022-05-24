using MT.Data.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Repository.AuthUserRepo
{
    public interface IAuthUserRepository
    {
        public bool SetAuthUser(AuthorityUser authUser);
    }
}
