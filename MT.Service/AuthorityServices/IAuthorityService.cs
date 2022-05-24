using MT.Data.Dtos;
using MT.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Service.AuthorityServices
{
    public interface IAuthorityService
    {
        public bool AddAuthority(AuthorityDto authorityDto);
    }
}
