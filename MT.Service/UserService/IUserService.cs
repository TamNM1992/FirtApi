using MT.Data.Dtos;
using MT.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Service.UserService
{
    public interface IUserService
    {
            AuthenticateResponse Authenticate(AuthenticateRequest model);
            IEnumerable<User> GetAll();
            User GetById(Guid id);
            public bool AddUser(UserDto user);
            public bool ValidateAccount(string userName, string password);
    }
}
