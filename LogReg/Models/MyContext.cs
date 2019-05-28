using Microsoft.EntityFrameworkCore;
using System.Linq;
 
namespace LogReg.Models
{
    public class MyContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public MyContext(DbContextOptions options) : base(options) { }
        // "users" table is represented by this DbSet "Users"
            public DbSet<User> Users {get;set;}

            public User GetUserByEmail(string Email)
            {
                return Users.FirstOrDefault(u => u.Email == Email);
            }

            public int Create(User newUser)
            {
                Add(newUser);
                SaveChanges();
                return newUser.UserId;
            }

            public User GetUserById(int UserId)
            {
                return Users.FirstOrDefault(u => u.UserId == UserId);
            }
    }
}
