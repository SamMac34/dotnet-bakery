using Microsoft.EntityFrameworkCore;
namespace DotnetBakery.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) {}

        // Activate our models for the DB
        // THIS WILL MAKE A TABLE CALLED Bakers
        public DbSet<Baker> Bakers {get; set;}

        public DbSet<Bread> Breads {get; set;}
    }
}


// Creates table and adds it to the DB
// dotnet ef migration add CreateBreadTable
// dotnet ef database update