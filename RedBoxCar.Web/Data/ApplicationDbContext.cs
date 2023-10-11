using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace RedBoxCar.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {}

        //public ApplicationDbContext CreateDbContext(string[] args) {
        //    var optBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
        //    optBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=aspnet-RedBoxCar.Web-695d96aa-bbf2-47b5-9f0d-b0ac24fc3a55;Trusted_Connection=True;MultipleActiveResultSets=true");
        //    return new ApplicationDbContext(optBuilder.Options);
        //}
        //public virtual DbSet<Users> Users { get; set; }
        //public virtual DbSet<Orders> Orders { get; set; }
        //public virtual DbSet<Products> Products { get; set; }
        //public virtual DbSet<Ingredients> Ingredients { get; set; }
    }
}