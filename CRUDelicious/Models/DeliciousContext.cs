using Microsoft.EntityFrameworkCore;
 
namespace CRUDelicious.Models
{
    public class DeliciousContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public DeliciousContext(DbContextOptions options) : base(options) { }
        // "users" table is represented by this DbSet "Users"
            public DbSet<Dish> Dishes {get;set;}
    }
}
