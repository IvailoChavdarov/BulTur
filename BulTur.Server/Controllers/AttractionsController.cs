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
    public class AttractionsController : ControllerBase
    {
        private readonly BulTurDbContext _db;
        public AttractionsController(BulTurDbContext db)
        {
            _db = db;
        }

        //returns attractions that will be shown to the user
        [HttpGet]
        public ActionResult<List<Attraction>> Get()
        {
            return _db.Attractions
                .Include(a=>a.Type)
                .Include(a=>a.Town)
                .Where(x=>x.IsAccepted)
                .OrderByDescending(x=>x.Clicks)
                .ToList();
        }

        //TODO: Add authorization
        //returns attraction requests waiting for approval (by admin or editor)
        [HttpGet("GetPending", Name = "GetPending")]
        public ActionResult<List<Attraction>> GetPending()
        {
            return _db.Attractions
                .Include(a => a.Writer)
                .Include(a => a.Type)
                .Include(a => a.Town)
                .Where(a => !a.IsAccepted)
                .ToList();
        }

        //TODO: Add authorization
        //returns all attractions (for editing/deleting by admin or editor)
        [HttpGet("GetAll", Name = "GetAll")]
        public ActionResult<List<Attraction>> GetAll()
        {
            return _db.Attractions
                .Include(a => a.Writer)
                .Include(a => a.Type)
                .Include(a => a.Town)
                .ToList();
        }

        //returns details of attraction and increments attraction clicks
        [HttpGet("{id}")]
        public ActionResult<Attraction> Get(int id)
        {
            //TODO: restrict access to details of pending attractions for users with with no role and include writer if user is editor or admin
            Attraction? attractionData = _db.Attractions
                                            .Include(a => a.Type)
                                            .Include(a => a.Town)
                                            .Include(a => a.Images)
                                            .FirstOrDefault(a=>a.Id==id);

            if (attractionData == null) return NotFound();

            //increments clicks
            string cookieKey = $"attraction_{id}_clicked";
            if (!Request.Cookies.ContainsKey(cookieKey))
            {
                attractionData.Clicks += 1;

                // Set a cookie with a 24 hours to stop user from incrementing clicks non stop
                Response.Cookies.Append(cookieKey, "true", new CookieOptions
                {
                    Expires = DateTime.UtcNow.AddHours(24),
                    HttpOnly = true
                });

                _db.SaveChanges();
            }

            return attractionData;
        }

        //Adds attraction request to the database
        [HttpPost]
        public ActionResult Post(AttractionCreateDto dto)
        {
            //TODO change WriterId, add authorization
            Attraction newAttraction = new Attraction(dto);
            _db.Attractions.Add(newAttraction);
            _db.SaveChanges();
            return Ok();
        }

        [HttpPatch("{id}")]
        public ActionResult Update(int id, AttractionUpdateDto dto)
        {
            //TODO add authorization
            Attraction? attractionToUpdate = _db.Attractions.Find(id);

            if (attractionToUpdate == null) return NotFound();

            if (!string.IsNullOrEmpty(dto.Name) && dto.Name != attractionToUpdate.Name) attractionToUpdate.Name = dto.Name;
            if (!string.IsNullOrEmpty(dto.Description) && dto.Description != attractionToUpdate.Description) attractionToUpdate.Description = dto.Description;
            if (!string.IsNullOrEmpty(dto.BannerImageUrl) && dto.BannerImageUrl != attractionToUpdate.BannerImageUrl) attractionToUpdate.BannerImageUrl = dto.BannerImageUrl;
            if (!string.IsNullOrEmpty(dto.WebsiteUrl) && dto.WebsiteUrl != attractionToUpdate.WebsiteUrl) attractionToUpdate.WebsiteUrl = dto.WebsiteUrl;
            if (!string.IsNullOrEmpty(dto.InstagramUrl) && dto.InstagramUrl != attractionToUpdate.InstagramUrl) attractionToUpdate.InstagramUrl = dto.InstagramUrl;
            if (!string.IsNullOrEmpty(dto.FacebookUrl) && dto.FacebookUrl != attractionToUpdate.FacebookUrl) attractionToUpdate.FacebookUrl = dto.FacebookUrl;
            if (!string.IsNullOrEmpty(dto.MapsEmbedUrl) && dto.MapsEmbedUrl != attractionToUpdate.MapsEmbedUrl) attractionToUpdate.MapsEmbedUrl = dto.MapsEmbedUrl;
            if (!string.IsNullOrEmpty(dto.PhoneNumber) && dto.PhoneNumber != attractionToUpdate.PhoneNumber) attractionToUpdate.PhoneNumber = dto.PhoneNumber;
            attractionToUpdate.IsAccepted = dto.IsAccepted;
            if (dto.TownId.HasValue && dto.TownId.Value != attractionToUpdate.TownId) attractionToUpdate.TownId = dto.TownId.Value;
            if (dto.TypeId.HasValue && dto.TypeId.Value != attractionToUpdate.TypeId) attractionToUpdate.TypeId = dto.TypeId.Value;

            _db.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            //TODO add authorization
            Attraction? attractionToUpdate = _db.Attractions.Find(id);

            if (attractionToUpdate == null) return NotFound();

            _db.Attractions.Remove(attractionToUpdate);
            _db.SaveChanges();
            return Ok();
        }
    }
}
