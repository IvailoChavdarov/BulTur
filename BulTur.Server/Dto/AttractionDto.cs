using BulTur.Server.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BulTur.Server.Dto
{
    public class AttractionDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Url]
        public string? BannerImageUrl { get; set; }

        [Required]
        public string TownName { get; set; }

        [Required]
        public string TypeName { get; set; }

        [Url]
        public string? WebsiteUrl { get; set; }

        [Url]
        public string? InstagramUrl { get; set; }

        [Url]
        public string? FacebookUrl { get; set; }

        [Url]
        public string? MapsEmbedUrl { get; set; }

        [Phone]
        public string? PhoneNumber { get; set; }

        public string? WriterName { get; set; }
        public string? WriterId { get; set; }

        public bool? IsAccepted { get; set; }

        [Required]
        public int Clicks { get; set; }

        public IEnumerable<AttractionImage>? Images { get; set; }
    }
}
