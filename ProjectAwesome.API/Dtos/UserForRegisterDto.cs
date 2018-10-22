using System.ComponentModel.DataAnnotations;

namespace ProjectAwesome.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(14, MinimumLength = 8, ErrorMessage = "You must specify a password between 8 and 14 characters long")]
        public string Password { get; set; }
    }
}