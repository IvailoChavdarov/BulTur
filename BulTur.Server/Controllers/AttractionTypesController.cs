using BulTur.Server.Data;
using BulTur.Server.Dto;
using BulTur.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BulTur.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttractionTypesController : ControllerBase
    {
        private readonly BulTurDbContext _db;
        public AttractionTypesController(BulTurDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public List<AttractionType> Get()
        {
            return _db.AttractionTypes.ToList();
        }

        [HttpGet("{id}")]
        public IActionResult Get(ushort id)
        {
            AttractionType? attractionType = _db.AttractionTypes
                .Include(at => at.Attractions)
                .FirstOrDefault(at => at.Id == id);
            if (attractionType != null)
            {
                return Ok(attractionType);
            }
            return NotFound();
        }

        [HttpPatch("{id}")]
        public IActionResult Update(ushort id, [FromBody] AttractionTypeUpdateDto dto)
        {
            AttractionType? attractionTypeToUpdate = _db.AttractionTypes.Find(id);

            if (attractionTypeToUpdate == null) return NotFound();

            if (!string.IsNullOrEmpty(dto.BannerImageUrl) && dto.BannerImageUrl != attractionTypeToUpdate.BannerImageUrl) attractionTypeToUpdate.BannerImageUrl = dto.BannerImageUrl;
            if (!string.IsNullOrEmpty(dto.IconBannerImageUrl) && dto.IconBannerImageUrl != attractionTypeToUpdate.IconBannerImageUrl) attractionTypeToUpdate.IconBannerImageUrl = dto.IconBannerImageUrl;

            _db.SaveChanges();

            return Ok(attractionTypeToUpdate);
        }
    }
}
