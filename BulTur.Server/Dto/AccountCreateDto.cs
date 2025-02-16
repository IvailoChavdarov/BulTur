using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulTur.Server.Dto
{
    public class AccountCreateDto
    {
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [RegularExpression(@"^(Editor|Writer)$", ErrorMessage = "Role must be either 'Editor' or 'Writer'.")]
        public string RoleName { get; set; }
    }
}
