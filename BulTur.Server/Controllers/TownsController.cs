using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BulTur.Server.Data;
using BulTur.Server.Models;
using BulTur.Server.Dto;
using Microsoft.AspNetCore.Authorization;

namespace BulTur.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TownsController : ControllerBase
    {
        private readonly BulTurDbContext _db;

        public TownsController(BulTurDbContext db)
        {
            _db = db;
        }

        // GET: api/Towns
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Town>>> Get()
        {
            return await _db.Towns.ToListAsync();
        }

        // GET: api/Towns/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Town>> Get(ushort id)
        {
            var town = await _db.Towns
                .Include(t=>t.Attractions)
                .FirstOrDefaultAsync(t=>t.Id==id);

            if (town == null)
            {
                return NotFound();
            }

            return town;
        }

        // PUT: api/Towns/{id}
        [HttpPatch("{id}")]
        [Authorize(Roles = "Admin, Editor")]
        public async Task<IActionResult> Update(ushort id, TownUpdateDto dto)
        {
            Town? townToUpdate = _db.Towns.Find(id);

            if (townToUpdate == null) return NotFound();

            if (!string.IsNullOrEmpty(dto.BannerImage) && dto.BannerImage != townToUpdate.BannerImage) townToUpdate.BannerImage = dto.BannerImage;
            if (!string.IsNullOrEmpty(dto.Description) && dto.Description != townToUpdate.Description) townToUpdate.Description = dto.Description;

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TownExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        private bool TownExists(ushort id)
        {
            return _db.Towns.Any(e => e.Id == id);
        }
    }
}
