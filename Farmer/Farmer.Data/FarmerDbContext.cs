using Farmer.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Farmer.Data
{
    public class FarmerDbContext : IdentityDbContext<User>
    {
        public FarmerDbContext(DbContextOptions<FarmerDbContext> options)
            : base(options)
        {
        }

        public DbSet<Places> Places { get; set; }

        public DbSet<Villages> Villages { get; set; }

        public DbSet<WorkTypes> WorkTypes { get; set; }

        public DbSet<Work> Work { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<Work>()
                .HasOne(t => t.WorkType)
                .WithMany(w => w.Works)
                .HasForeignKey(id => id.WorkTypeID);

            builder
                .Entity<Work>()
                .HasOne(p => p.Place)
                .WithMany(w => w.Works)
                .HasForeignKey(id => id.PlaceID);

            builder
                .Entity<Places>()
                .HasOne(v => v.Village)
                .WithMany(p => p.PlacesInVillage)
                .HasForeignKey(id => id.VillageID);

            base.OnModelCreating(builder);
        }
    }
}
