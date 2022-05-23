using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Data.Models
{
    public class AuthenticateResponse
    {
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Token { get; set; }


        public AuthenticateResponse(User user, string token)
        {
            FullName = user.FullName;
            UserName = user.UserName;
            Token = token;
        }
    }
}