using Microsoft.EntityFrameworkCore;
using Vinoteca.Data.Entities;

namespace Vinoteca.Data
{
    public class VinotecaContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Wine> Wines { get; set; }
        public DbSet<Cata> Catas { get; set; }

        public VinotecaContext(DbContextOptions<VinotecaContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            User Hideo = new User()
            {
                Id = 1,
                UserName = "mgs@gmail.com",
                Password = "Pa$$w0rd",
                Rol = Data.Rol.Admin,
            };

            User Keanu = new User()
            {
                Id = 2,
                UserName = "jhonwick@gmail.com",
                Password = "Cl4ve!",
                Rol = Data.Rol.Admin,
            };

            Wine cabernetSauvignon = new Wine()
            {
                Id = 1,
                Name = "Cabernet Sauvignon",
                Variety = "Cabernet Sauvignon",
                Year = 2018,
                Region = "Mendoza",
                Stock = 50,
                CreatedAt = DateTime.UtcNow
            };

            Wine malbec = new Wine()
            {
                Id = 2,
                Name = "Malbec",
                Variety = "Malbec",
                Year = 2020,
                Region = "Mendoza",
                Stock = 30,
                CreatedAt = DateTime.UtcNow
            };


            modelBuilder.Entity<User>().HasData(Hideo, Keanu);
            modelBuilder.Entity<Wine>().HasData(malbec, cabernetSauvignon);


            modelBuilder.Entity<Cata>()
                .HasMany(c => c.Wines)
                .WithMany();


            base.OnModelCreating(modelBuilder);
        }

    }
}
