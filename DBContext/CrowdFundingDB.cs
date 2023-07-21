using Microsoft.EntityFrameworkCore;
using Crowdfunding_WebApp.Models;
using Microsoft.EntityFrameworkCore.Internal;

namespace Crowdfunding_WebApp.DBContext
{
    public class CrowdFundingDB : DbContext
    {
        public CrowdFundingDB(DbContextOptions<CrowdFundingDB> options) : base(options)
        {
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Rewards> Rewards { get; set; }
        public DbSet<BackedProjects> BackedProjects { get; set; }
        public DbSet<Backer> Backers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Projects)
                .HasForeignKey(p => p.CategoryId);

            base.OnModelCreating(modelBuilder);
        }


    }
}

