using System.ComponentModel.DataAnnotations;

namespace BulTur.Server.Dto
{
    public class AttractionUpdateDto
    {
        public string? Name { get; set; }

        public bool IsAccepted { get; set; }

        public string? Description { get; set; }

        [Url]
        public string? BannerImageUrl { get; set; }

        public ushort? TownId { get; set; }

        public ushort? TypeId { get; set; }

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
    }
}
