using BulTur.Server.Data;
using BulTur.Server.Dto;
using BulTur.Server.Models;
using Microsoft.AspNetCore.Authorization;
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
        public ActionResult<AttractionType> Get(string id)
        {
            AttractionType? attractionType = _db.AttractionTypes
                .FirstOrDefault(at => at.Name == id);
            if (attractionType == null)
            {
                return NotFound();
            }
            attractionType.AttractionsData = _db.Attractions
                .Where(x => x.IsAccepted && x.TypeId == attractionType.Id)
                .Select(attraction =>
                    new AttractionDto
                    {
                        Id = attraction.Id,
                        Name = attraction.Name,
                        Description = attraction.Description,
                        BannerImageUrl = attraction.BannerImageUrl,
                        TownName = attraction.Town.Name,
                        TypeName = attraction.Type.Name,
                        WebsiteUrl = attraction.WebsiteUrl,
                        InstagramUrl = attraction.InstagramUrl,
                        FacebookUrl = attraction.FacebookUrl,
                        MapsEmbedUrl = attraction.MapsEmbedUrl,
                        PhoneNumber = attraction.PhoneNumber,
                        Clicks = attraction.Clicks
                    }
                )
                .OrderByDescending(x => x.Clicks)
                .ToList();
            return attractionType;
        }

        [Authorize(Roles = "Admin, Editor")]
        [HttpPatch("{id}")]
        public ActionResult Update(ushort id, [FromBody] AttractionTypeUpdateDto dto)
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
