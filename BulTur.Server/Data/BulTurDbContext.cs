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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Add seed data for your Regions table
            modelBuilder.Entity<Region>().HasData(Region.GetDefaultData());
        }

        public DbSet<Region> Regions { get; set; } = default!;
    }
}
