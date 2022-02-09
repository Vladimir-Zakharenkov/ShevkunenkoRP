using Microsoft.EntityFrameworkCore;
using Site.Models;

namespace Site.Services
{
    public class SiteContext : DbContext
    {
        public SiteContext(DbContextOptions<SiteContext> options) : base(options)
        {
        }

        public DbSet<ImageModel> ImageModels { get; set; }
        public DbSet<MovieModel> MovieModels { get; set; }
        public DbSet<CardModel> CardModels { get; set; }

        public DbSet<SitemapModel> SitemapModels { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SitemapModel>()
                .Property(b => b.Lastmod)
                .HasDefaultValueSql("getdate()");
        }

        public DbSet<AdminAccess> AdminAccess { get; set; }
    }
}