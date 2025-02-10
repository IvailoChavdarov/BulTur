using Microsoft.EntityFrameworkCore;
using BulTur.Server.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

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

            //connects Towns and Attractions table
            modelBuilder.Entity<Town>()
                .HasMany(t => t.Attractions)
                .WithOne(a => a.Town)
                .HasForeignKey(a => a.TownId);

            //connects Attractions and AttractionImages table
            modelBuilder.Entity<Attraction>()
                .HasMany(a => a.Images)
                .WithOne(i => i.Attraction)
                .HasForeignKey(i => i.AttractionId);

            //connects Attractions and AttractionTypes table
            modelBuilder.Entity<Attraction>()
                .HasOne(a => a.Type)
                .WithMany(t => t.Attractions)
                .HasForeignKey(a => a.TypeId);

            base.OnModelCreating(modelBuilder);

            // Add seed data for your Regions table
            modelBuilder.Entity<Region>().HasData(Region.GetDefaultData());

            // Seeds data for towns
            modelBuilder.Entity<Town>().HasData(Town.GetDefaultTownsData().ToArray());

            // Seeds data for attraction types
            modelBuilder.Entity<AttractionType>().HasData(AttractionType.GetDefaultAttractionTypes());

            // Seeds data for staff roles
            List<IdentityRole> rolesToSeed = new List<IdentityRole>
                {
                    new IdentityRole
                    {
                        Id = "fc012751-2557-4a1c-98aa-d1d8dd7b4ff5", //static GUID
                        Name = "Admin",
                        NormalizedName = "ADMIN"
                    },
                    new IdentityRole
                    {
                        Id = "4e072768-3a78-4cc4-8d63-7ae87aaa5cae",
                        Name = "Editor",
                        NormalizedName = "EDITOR"
                    },
                    new IdentityRole
                    {
                        Id = "32066165-0fca-49b2-801d-fd4517b6d5db",
                        Name = "Writer",
                        NormalizedName = "WRITER"
                    }
                };

            modelBuilder.Entity<IdentityRole>().HasData(rolesToSeed);
        }

        public DbSet<Region> Regions { get; set; } = default!;
        public DbSet<Town> Towns { get; set; } = default!;
        public DbSet<Town> Attractions { get; set; } = default!;
        public DbSet<AttractionType> AttractionTypes { get; set; } = default!;
        public DbSet<AttractionImage> AttractionImages { get; set; } = default!;
    }
}
