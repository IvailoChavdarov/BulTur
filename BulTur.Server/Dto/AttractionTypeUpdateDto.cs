using System.ComponentModel.DataAnnotations;

namespace BulTur.Server.Dto
{
    public class AttractionTypeUpdateDto
    {
        [Url]
        public string? BannerImageUrl { get; set; }

        [Url]
        public string? IconBannerImageUrl { get; set; }
    }
}
