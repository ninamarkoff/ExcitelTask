using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Excitel.Models;

namespace Excitel.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Excitel.Models.Lead>? Leads { get; set; }
        public DbSet<Excitel.Models.Subarea>? Subareas { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            for (int i = 0; i < 20; i++)
            {
                builder.Entity<Subarea>().HasData(
                              new Subarea
                              {
                                  Id = i + 1,
                                  Name = $"Subarea name {i + 1}",
                                  PINCode = (i + 1) * 100000,
                              });
            }
        }
    }
}