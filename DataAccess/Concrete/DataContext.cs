using Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MEHMETGON ; Database=TestAzersunDb ; Integrated Security=true ; User ID=sa ; Password=664189Mg++");
        }

        public DbSet<Messages> Messages { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Settings> Settings { get; set; }
        public DbSet<Sliders> Sliders { get; set; }
        public DbSet<SocialMedia> SocialMedia { get; set; }
        public DbSet<Videos> Videos { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
