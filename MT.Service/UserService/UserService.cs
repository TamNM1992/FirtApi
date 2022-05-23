using Microsoft.Extensions.Options;
using MT.Data.Dtos;
using MT.Data.Models;
using MT.Repository.UserRepo;
using System;
using System.Collections.Generic;



namespace MT.Service.UserService
{

    public class UserService : IUserService
    {
        private IUserRepository _userRepository;
        //private readonly AppSettings _appSettings;

        // users hardcoded for simplicity, store in a db with hashed passwords in production applications
        //private List<User> _users = new List<User>
        //{
        //    new User { Id = Guid.NewGuid(), FullName = "Test", Email = "gg@gmail.com", UserName = "cr7", Password = "m10", IsActive = true }
        //};

        //private readonly AppSettings _appSettings;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public bool AddUser(UserDto user)
        {
            var temp = _userRepository.AddUser(user);
            return temp;
        }

        public bool ValidateAccount(string userName, string password)
        {
            try
            {
                string salt = _userRepository.GetPasswordSalt(userName);
                string hashPass = BCrypt.Net.BCrypt.HashPassword(password,salt);
                string pass = _userRepository.GetPasswordHash(userName);
                //var isUsernamePasswordValid = BCrypt.Net.BCrypt.Verify(pass, hashPass);
                if(pass == hashPass)
                    return true;
                return false;
                //return isUsernamePasswordValid;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        
        public AuthenticateResponse Authenticate(AuthenticateRequest user)
        {

            if (ValidateAccount(user.UserName, user.Password))
            {
                var temp = _userRepository.Authenticate(user);

                return temp;
            }
            return null;
        }

        public IEnumerable<User> GetAll()
        {
            var temp = _userRepository.GetAll();
            return temp;
        }

        public User GetById(Guid id)
        {
            var temp = _userRepository.GetById(id);
            return temp;
        }


    }
}