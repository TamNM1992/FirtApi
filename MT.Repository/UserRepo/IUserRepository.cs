using MT.Data.Dtos;
using MT.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Repository.UserRepo
{
    public interface IUserRepository
    {
        public AuthenticateResponse Authenticate(AuthenticateRequest model);
        public IEnumerable<User> GetAll();
        public User GetById(Guid id);
        public bool AddUser(UserDto user);
        public string GetPasswordHash(string userName);
        public string GetPasswordSalt(string userName);

    }
}
