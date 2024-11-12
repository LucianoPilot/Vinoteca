using System.ComponentModel.DataAnnotations;

namespace Vinoteca.Models
{
    public class AuthDTO
    {
        [Required]
        public string? UserName { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}
