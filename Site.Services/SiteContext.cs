﻿using Microsoft.EntityFrameworkCore;
using Site.Models;

namespace Site.Services
{
    public class SiteContext : DbContext
    {
        public SiteContext(DbContextOptions<SiteContext> options) : base(options)
        {
        }

        public DbSet<HeadModel> HeadModels { get; set; }
        public DbSet<ImageModel> ImageModels { get; set; }
        public DbSet<PageModel> PageModels { get; set; }
    }
}
