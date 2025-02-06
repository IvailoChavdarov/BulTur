using Microsoft.EntityFrameworkCore;
using BulTur.Server.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace BulTur.Server.Data
{
    public partial class BulTurDbContext : IdentityDbContext<StaffAccount>
    {
        public BulTurDbContext(DbContextOptions<BulTurDbContext> options) : base(options)
        {
        }
    }
}
