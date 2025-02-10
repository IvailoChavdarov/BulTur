using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BulTur.Server.Models
{
    public class AttractionType
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public ushort Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Url]
        public string? BannerImageUrl { get; set; }

        [Url]
        public string? IconBannerImageUrl { get; set; }

        [NotMapped]
        public IEnumerable<Attraction> Attractions { get; set; }

        public static List<AttractionType> GetDefaultAttractionTypes()
        {
            return new List<AttractionType>
            {
                new AttractionType
                {
                    Id = 1,
                    Name = "Cultural",
                    BannerImageUrl = "https://bulgariatravel.org/wp-content/uploads/2024/05/Lifestyle-and-Culture_bulgariatravel.org_-min-min.jpg",
                    IconBannerImageUrl = null
                },
                new AttractionType
                {
                    Id = 2,
                    Name = "Historical",
                    BannerImageUrl = "https://i.ytimg.com/vi/YE6M1Rz9jSc/maxresdefault.jpg",
                    IconBannerImageUrl = null
                },
                new AttractionType
                {
                    Id = 3,
                    Name = "Sports",
                    BannerImageUrl = "https://prod0mobileapp.blob.core.windows.net/facilities/facilities/bg/3487/images/3_3487_2_FacilityPhoto.jpg?79215499",
                    IconBannerImageUrl = null
                },
                new AttractionType
                {
                    Id = 4,
                    Name = "Restaurants",
                    BannerImageUrl = "https://www.andrey-andreev.com/wp-content/uploads/2023/11/ABA00794-Edit.jpg",
                    IconBannerImageUrl = null
                },
                new AttractionType
                {
                    Id = 5,
                    Name = "Night life",
                    BannerImageUrl = "https://i0.wp.com/Blog.FreeUniBG.eu/wp-content/uploads/2020/06/0bb0beb72ab8b30050628460b803f39f.jpg?fit=1920%2C900&ssl=1",
                    IconBannerImageUrl = null
                },
                new AttractionType
                {
                    Id = 6,
                    Name = "Wellness & Relaxation",
                    BannerImageUrl = "https://forbesbulgaria.com/wp-content/uploads/2024/01/pretty-young-women-relaxing-on-the-deckchair-by-th-2023-11-27-05-33-03-utc.jpg",
                    IconBannerImageUrl = null
                },
                new AttractionType
                {
                    Id = 7,
                    Name = "Urban",
                    BannerImageUrl = "https://img.capital.bg/shimg/zx952y526_2888885.jpg",
                    IconBannerImageUrl = null
                },
                new AttractionType
                {
                    Id = 8,
                    Name = "Religious & Spiritual",
                    BannerImageUrl = "https://central-hotel.com/wp-content/uploads/2016/11/Rila.jpg",
                    IconBannerImageUrl = null
                }
            };
        }
    }
}
