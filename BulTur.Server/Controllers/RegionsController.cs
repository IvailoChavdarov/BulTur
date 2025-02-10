using BulTur.Server.Data;
using BulTur.Server.Dto;
using BulTur.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace BulTur.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly BulTurDbContext _db;
        public RegionsController(BulTurDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public List<Region> Get() {
            return _db.Regions.ToList(); 
        }

        [HttpGet("{id}")]
        public IActionResult Get(sbyte id) {
            Region? region = _db.Regions
                .Include(r=>r.Towns)
                .FirstOrDefault(r=>r.Id==id);
            if (region !=null)
            {
                return Ok(region);
            }
            return NotFound();
        }

        [HttpPatch("{id}")]
        public IActionResult Update(sbyte id, [FromBody] RegionUpdateDto dto)
        {
            Region? regionToUpdate = _db.Regions.Find(id);

            if (regionToUpdate == null) return NotFound();

            if (!string.IsNullOrEmpty(dto.ShortTitle) && dto.ShortTitle!=regionToUpdate.ShortTitle) regionToUpdate.ShortTitle = dto.ShortTitle;
            if (!string.IsNullOrEmpty(dto.Description) && dto.Description != regionToUpdate.Description) regionToUpdate.Description = dto.Description;
            if (!string.IsNullOrEmpty(dto.BannerImageUrl) && dto.BannerImageUrl != regionToUpdate.BannerImageUrl) regionToUpdate.BannerImageUrl = dto.BannerImageUrl;
            if (!string.IsNullOrEmpty(dto.CoatOfArmsImageUrl) && dto.CoatOfArmsImageUrl != regionToUpdate.CoatOfArmsImageUrl) regionToUpdate.CoatOfArmsImageUrl = dto.CoatOfArmsImageUrl;
            
            _db.SaveChanges();
            
            return Ok(regionToUpdate);
        }
    }
}
