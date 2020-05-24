using Microsoft.EntityFrameworkCore;

namespace GunShopBackend.Models
{
    public class WeaponsContext : DbContext
    {
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Caliber> Calibers { get; set; }

        public WeaponsContext(DbContextOptions<WeaponsContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
