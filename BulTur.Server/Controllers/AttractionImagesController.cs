using BulTur.Server.Data;
using BulTur.Server.Dto;
using BulTur.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BulTur.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttractionImagesController : ControllerBase
    {
        private readonly BulTurDbContext _db;
        public AttractionImagesController(BulTurDbContext db)
        {
            _db = db;
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            AttractionImage? image = _db.AttractionImages.Find(id);
            if (image == null) return NotFound();

            return Ok(image);
        }

        [HttpPost]
        public ActionResult Post([FromBody] AttractionImageCreateDto dto)
        {
            //TODO: Add authorization
            AttractionImage newAttractionImage = new AttractionImage(dto);
            _db.AttractionImages.Add(newAttractionImage);
            _db.SaveChanges();
            return Ok();
        }
    }
}
