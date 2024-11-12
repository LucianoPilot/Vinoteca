using System.ComponentModel.DataAnnotations;

namespace Vinoteca.Models
{
    public class CreateUserDTO
    {
        [Required]
        public string Username { get; set; } = string.Empty;

        [MinLength(8)]
        public string Password { get; set; }
    }
}
