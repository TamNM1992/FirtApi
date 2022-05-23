using System.ComponentModel.DataAnnotations;

namespace MT.Data.Models
{
    public class AuthenticateRequest
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}