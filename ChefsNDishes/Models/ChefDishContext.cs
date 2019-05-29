using Microsoft.EntityFrameworkCore;
using ChefsNDishes.Models;
using System.Linq;

namespace ChefsNDishes.Models {
    public class ChefDishContext : DbContext {
        public ChefDishContext(DbContextOptions options) : base(options) { }
        public DbSet<Chef> Chefs {get;set;}
        public DbSet<Dish> Dishes {get;set;}

        public void AddChef(Chef newChef)
        {
            Add(newChef);
            SaveChanges();
        }

        public void AddDish(Dish newDish)
        {
            Add(newDish);
            SaveChanges();
        }
        

    }
}