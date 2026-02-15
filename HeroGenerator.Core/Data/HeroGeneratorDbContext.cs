using HeroGenerator.Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HeroGenerator.Core.Data
{
    public class HeroGeneratorDbContext : IdentityDbContext
    {
        public HeroGeneratorDbContext(DbContextOptions<HeroGeneratorDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Hero> Heroes { get; set; } = null!;
        public virtual DbSet<Race> Races { get; set; } = null!;
        public virtual DbSet<Equipment> Equipment { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(HeroGeneratorDbContext).Assembly);
        }
    }
}
