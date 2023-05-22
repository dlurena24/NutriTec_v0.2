using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace NutriTec_v0._2.Data
{
    public class AppDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public AppDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql(Configuration.GetConnectionString("WebApiDatabase"));
        }

        public DbSet<Client> Clients { get; set; }
    }
}
