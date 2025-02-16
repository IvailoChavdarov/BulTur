using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BulTur.Server.Models
{
    //Authorization system based on the default provided by IdentityFramework
    //This class stores data of users that are responsible for:
    //- adding data for attractions(with requests)(if in the role of Writer)
    //- editing and approving requests(if in the role of Editor)
    //- creates accounts and manages roles(if in the role of Administrator)
    //Inherits default user class provided by IdentityFramework to add additional fields
    public class StaffAccount : IdentityUser
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

        [NotMapped]
        public IEnumerable<Attraction> AttractionsRequested { get; set; }
    }
}
