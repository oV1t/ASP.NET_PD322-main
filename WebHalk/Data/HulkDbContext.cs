﻿using Microsoft.EntityFrameworkCore;
using WebHalk.Data.Entities;

namespace WebHalk.Data
{
    public class HulkDbContext : DbContext
    {
        public HulkDbContext(DbContextOptions<HulkDbContext> options) : base(options) { }

        public DbSet<CategoryEntity> Categories { get; set; }
    }
}
