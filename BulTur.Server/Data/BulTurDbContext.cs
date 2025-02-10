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
            //connects Towns and Regions table
            modelBuilder.Entity<Town>()
                .HasOne(t => t.Region)
                .WithMany(r => r.Towns)
                .HasForeignKey(t => t.RegionId);

            base.OnModelCreating(modelBuilder);

            // Add seed data for your Regions table
            modelBuilder.Entity<Region>().HasData(Region.GetDefaultData());
            modelBuilder.Entity<Town>().HasData(Town.GetDefaultTownsData().ToArray());
        }

        public DbSet<Region> Regions { get; set; } = default!;
        public DbSet<Town> Towns { get; set; } = default!;
    }
}
