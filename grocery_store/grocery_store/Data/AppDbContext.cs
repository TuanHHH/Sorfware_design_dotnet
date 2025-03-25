using grocery_store.Models;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;
namespace grocery_store.Data
{
    public class AppDbContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public AppDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = _configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));  // Đảm bảo sử dụng ServerVersion.AutoDetect
        }
        //Gọi đúng tên database
        public DbSet<Cart> cart { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<User>  users { get; set; }
    }
}

