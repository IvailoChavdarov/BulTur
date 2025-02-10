using System.ComponentModel.DataAnnotations;

namespace BulTur.Server.Dto
{
    public class RegionUpdateDto
    {
        [StringLength(2500)]
        public string? Description { get; set; }

        //Catchphrase for the region
        [StringLength(150)]
        public string? ShortTitle { get; set; }

        //Url to image to be shown in the page with info about the region
        [Url]
        public string? BannerImageUrl { get; set; }

        //Url to image to be shown in the page with info about the region and on the map on hover
        [Url]
        public string? CoatOfArmsImageUrl { get; set; }
    }
}
