using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BulTur.Server.Models
{
    public class AttractionType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Url]
        public string? BannerImageUrl { get; set; }

        [Url]
        public string? IconImageUrl { get; set; }

        [NotMapped]
        public IEnumerable<Attraction> Attractions { get; set; }
    }
}
