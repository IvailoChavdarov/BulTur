using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BulTur.Server.Models
{
    //Represents the 28 administrative regions of Bulgaria
    public class Region
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [Required]
        [StringLength(2500)]
        public string Description { get; set; }

        //Catchphrase for the region
        [StringLength(150)]
        public string ShortTitle { get; set; }

        //Url to image to be shown in the page with info about the region
        [Url]
        public string BannerImageUrl { get; set; }

        //Coords that shape the region on the map that will be shown on the UI
        [Required]
        public string PolygonCoords { get; set; }
    }
}
