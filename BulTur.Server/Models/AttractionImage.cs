using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using BulTur.Server.Dto;

namespace BulTur.Server.Models
{
    public class AttractionImage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int AttractionId { get; set; }

        public string? Title { get; set; }

        [Required]
        [Url]
        public string? ImageUrl { get; set; }

        [NotMapped]
        public Attraction Attraction { get; set; }

        public AttractionImage()
        {
        }

        public AttractionImage(AttractionImageCreateDto dto)
        {
            AttractionId = dto.AttractionId;
            Title = dto.Title;
            ImageUrl = dto.ImageUrl;
        }
    }
}
