using System.ComponentModel.DataAnnotations;

namespace BulTur.Server.Dto
{
    public class ChangeRoleDto
    {
        [Required]
        [RegularExpression(@"^(Editor|Writer|Admin)$", ErrorMessage = "Role must be either Editor, Writer or Admin.")]
        public string RoleName { get; set; }

        [Required]
        public string UserEmail { get; set; }
    }
}
