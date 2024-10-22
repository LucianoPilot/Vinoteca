using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using Vinoteca.Data.Entities;

namespace Vinoteca.Data
{
    namespace Data
    {
        public class WineInventoryDbContext : DbContext
        {
            public WineInventoryDbContext(DbContextOptions<WineInventoryDbContext> options)
                : base(options)
            {
            }

            public DbSet<Wine> Wines { get; set; }
            public DbSet<User> Users { get; set; }
            public DbSet<Cata> Catas { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);
            }
        }
    }
}
