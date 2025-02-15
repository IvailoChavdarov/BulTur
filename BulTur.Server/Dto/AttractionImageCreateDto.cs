using BulTur.Server.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BulTur.Server.Dto
{
    public class AttractionImageCreateDto
    {
        [Required]
        public int AttractionId { get; set; }

        public string? Title { get; set; }

        [Required]
        [Url]
        public string? ImageUrl { get; set; }
    }
}
