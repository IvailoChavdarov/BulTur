using BulTur.Server.Data;
using BulTur.Server.Dto;
using BulTur.Server.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BulTur.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttractionsController : ControllerBase
    {
        private readonly BulTurDbContext _db;
        private readonly UserManager<StaffAccount> _userManager;
        public AttractionsController(BulTurDbContext db, UserManager<StaffAccount> userManager)
        {
            _db = db;
            _userManager = userManager;
        }

        //returns attractions that will be shown to the user
        [HttpGet]
        public ActionResult<List<AttractionDto>> Get(int? count)
        {
            return _db.Attractions
                .Where(x=>x.IsAccepted)
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
        }

        //returns attraction requests waiting for approval (by admin or editor)
        [Authorize(Roles = "Admin, Editor")]
        [HttpGet("GetPending", Name = "GetPending")]
        public ActionResult<List<AttractionDto>> GetPending()
        {
            return _db.Attractions
                .Where(a => !a.IsAccepted)
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
                        WriterId = attraction.WriterId,
                        WriterName = attraction.Writer.FirstName + " " + attraction.Writer.LastName
                    }
                )
                .ToList();
        }

        //returns all attractions (for editing/deleting by admin or editor)
        [Authorize(Roles = "Admin, Editor")]
        [HttpGet("GetAll", Name = "GetAll")]
        public ActionResult<List<AttractionDto>> GetAll()
        {
            return _db.Attractions
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
                        WriterId = attraction.WriterId,
                        WriterName = attraction.Writer.FirstName + " " + attraction.Writer.LastName
                    }
                )
                .ToList();
        }

        //returns details of attraction and increments attraction clicks
        [HttpGet("{id}")]
        public ActionResult<AttractionDto> Get(int id)
        {
            AttractionDto? attractionData = _db.Attractions
                .Where(x=>x.Id==id)
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
                        IsAccepted = attraction.IsAccepted
                    }
                )
                .FirstOrDefault();

            if (attractionData == null) return NotFound();

            //Restricts access to details of pending attractions for unauthorized users
            if (!attractionData.IsAccepted.Value)
            {
                if (!User.Identity.IsAuthenticated)
                {
                    return Unauthorized();
                }
            }

            //increments clicks
            string cookieKey = $"attraction_{id}_clicked";
            if (!Request.Cookies.ContainsKey(cookieKey))
            {
                _db.Attractions.Find(id).Clicks += 1;

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
        [Authorize]
        public ActionResult Post([FromBody] AttractionCreateDto dto)
        {
            dto.WriterId = _userManager.GetUserId(User);
            if (string.IsNullOrEmpty(dto.WriterId))
                return BadRequest("Writer is not valid");
            if (!ModelState.IsValid)
                return BadRequest("Input is not valid");

            Attraction newAttraction = new Attraction(dto);

            _db.Attractions.Add(newAttraction);
            _db.SaveChanges();

            return Ok();
        }

        [HttpPatch("{id}")]
        [Authorize(Roles = "Admin, Editor")]
        public ActionResult Update(int id, [FromBody] AttractionUpdateDto dto)
        {
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

        [Authorize(Roles = "Admin, Editor")]
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            Attraction? attractionToUpdate = _db.Attractions.Find(id);

            if (attractionToUpdate == null) return NotFound();

            _db.Attractions.Remove(attractionToUpdate);
            _db.SaveChanges();
            return Ok();
        }
    }
}
