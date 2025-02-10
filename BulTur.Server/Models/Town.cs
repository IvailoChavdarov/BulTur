using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace BulTur.Server.Models
{
    public class Town
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public ushort Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public string? BannerImage { get; set; }

        [Required]
        public sbyte RegionId { get; set; }

        [NotMapped]
        public Region Region { get; set; }

        public static List<Town> GetDefaultTownsData()
        {
            List<Town> towns = new List<Town>();
            string text = File.ReadAllText("../TownsDefaultData.json");
            towns = JsonSerializer.Deserialize<List<Town>>(text);

            ushort id = 1;
            foreach (var town in towns)
            {
                town.Id = id++;
            }

            return towns;
        }
    }
}
