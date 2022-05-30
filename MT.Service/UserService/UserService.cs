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
                if(pass == hashPass)
                    return true;
                return false;
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

        public User GetByUserName(string username)
        {
            var temp = _userRepository.GetByUserName(username);
            return temp;
        }


    }
}