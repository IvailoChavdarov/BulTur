using BulTur.Server.Data;
using BulTur.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public List<Region> GetRegions() {
            return _db.Regions.ToList(); 
        }
    }
}
