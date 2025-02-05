using Microsoft.EntityFrameworkCore;

namespace BulTur.Server.Data
{
    public partial class BulTurDbContext : DbContext
    {
        public BulTurDbContext(DbContextOptions<BulTurDbContext> options): base(options)
        {
        }
    }
}
