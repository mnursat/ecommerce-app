namespace EcommerceAppBackend.API.Persistence.Database
{
    using EcommerceAppBackend.API.Models;
    using Microsoft.EntityFrameworkCore;

    public class EcommerceAppDbContext : DbContext
    {
        public EcommerceAppDbContext(DbContextOptions<EcommerceAppDbContext> options) : base(options)
        {
        }


        public DbSet<Device> Devices { get; set; }
    }
}
