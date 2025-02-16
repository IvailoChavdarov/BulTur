using System.ComponentModel.DataAnnotations;

namespace BulTur.Server.Dto
{
    public class LoginDto
    {
        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
