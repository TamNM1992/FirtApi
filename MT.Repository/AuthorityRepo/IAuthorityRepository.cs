using MT.Data.Dtos;
using MT.Data.Models;
using System;
using System.Collections.Generic;

namespace MT.Repository.AuthorityRepo
{
    public interface IAuthorityRepository
    {
        public bool AddAuthority(AuthorityDto authority);
        IEnumerable<Authority> GetAuthorityByUser(Guid user);
    }
}
