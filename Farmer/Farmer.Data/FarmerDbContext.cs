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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        }
    }
}
