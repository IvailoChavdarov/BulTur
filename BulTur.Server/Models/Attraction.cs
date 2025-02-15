using BulTur.Server.Dto;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BulTur.Server.Models
{
    public class Attraction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        //determines if the attraction will be shown to the users, can be changed by editors or admin
        [Required]
        public bool IsAccepted { get; set; }

        [Required]
        public string Description { get; set; }

        [Url]
        public string? BannerImageUrl { get; set; }

        [Required]
        public ushort TownId { get; set; }

        [Required]
        public ushort TypeId { get; set; }

        [Url]
        public string? WebsiteUrl { get; set; }

        [Url]
        public string? InstagramUrl { get; set; }

        [Url]
        public string? FacebookUrl { get; set; }

        //Url with which the website will embed window from Google Maps (go to location in maps, click share, embed in website, then the link in src="...")
        [Url]
        public string? MapsEmbedUrl { get; set; }

        [Phone]
        public string? PhoneNumber { get; set; }

        [Required]
        public string WriterId { get; set; }

        [Required]
        public int Clicks { get; set; } = 0;

        [NotMapped]
        public AttractionType Type { get; set; }

        [NotMapped]
        public StaffAccount Writer { get; set; }

        [NotMapped]
        public Town Town { get; set; }

        [NotMapped]
        public IEnumerable<AttractionImage> Images { get; set; }

        public Attraction() { }

        public Attraction(AttractionCreateDto dto)
        {
            Name = dto.Name;
            IsAccepted = false;
            Description = dto.Description;
            BannerImageUrl = dto.BannerImageUrl;
            TownId = dto.TownId;
            TypeId = dto.TypeId;
            WebsiteUrl = dto.WebsiteUrl;
            InstagramUrl = dto.InstagramUrl;
            FacebookUrl = dto.FacebookUrl;
            MapsEmbedUrl = dto.MapsEmbedUrl;
            PhoneNumber = dto.PhoneNumber;
            WriterId = dto.WriterId;
            Clicks = 0;
        }
    }
}
