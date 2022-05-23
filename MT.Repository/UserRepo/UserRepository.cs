using AutoMapper;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using MT.Data.Dtos;
using MT.Data.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace MT.Repository.UserRepo
{

    public class UserRepository : IUserRepository
    {
        private readonly MonterDataContext _userContext;
        private readonly IMapper _mapper;
        private readonly AppSettings _appSettings;
        public UserRepository(MonterDataContext context, IMapper mapper, IOptions<AppSettings> appSettings)
        {
            _userContext = context;
            _mapper = mapper;
            _appSettings = appSettings.Value;
        }

        public string GenerateJwtToken(User user)
        {
            // generate token that is valid for 7 days
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("id", user.Id.ToString()) }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public bool AddUser(UserDto user)
        {
            try
            {
                
                var salt = BCrypt.Net.BCrypt.GenerateSalt();
                var username = _userContext.Users.SingleOrDefault(x=> x.UserName == user.UserName);
                
                if (username != null)
                    return false;

                var userEntity = _mapper.Map<UserDto, User>(user);
                string hashPass = BCrypt.Net.BCrypt.HashPassword(userEntity.Password, salt);
                userEntity.Password = hashPass;
                userEntity.PasswordSalt = salt;

                _userContext.Users.Add(userEntity);
                _userContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public string GetPasswordHash(string userName)
        {
            var hashPass = _userContext.Users.Where(x => x.UserName == userName).FirstOrDefault();

            if (hashPass != null)
                return hashPass.Password;
            else
                return null;
        }
        public string GetPasswordSalt(string userName)
        {
            var hashPass = _userContext.Users.Where(x => x.UserName == userName).FirstOrDefault();

            if (hashPass != null)
                return hashPass.PasswordSalt;
            else
                return null;
        }
        public AuthenticateResponse Authenticate(AuthenticateRequest model)
        {
            var user = _userContext.Users.SingleOrDefault(x => x.UserName == model.UserName);
            
            // authentication successful so generate jwt token
            var token = GenerateJwtToken(user);
            return new AuthenticateResponse(user, token);
        }

        public IEnumerable<User> GetAll()
        {
            return _userContext.Users;
        }

        public User GetById(Guid id)
        {
            return _userContext.Users.FirstOrDefault(x => x.Id == id);
        }

    }
}
