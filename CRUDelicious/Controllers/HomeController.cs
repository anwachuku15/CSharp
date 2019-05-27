using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;

namespace CRUDelicious.Controllers
{
    public class HomeController : Controller
    {
        private DeliciousContext dbContext;
     
        // here we can "inject" our context service into the constructor
        public HomeController(DeliciousContext context)
        {
            dbContext = context;
        }
     
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            List<Dish> AllDishes = dbContext.Dishes
                .OrderByDescending(d => d.CreatedAt)
                .ToList();

            return View(AllDishes);
        }

        [HttpGet("new")]
        public IActionResult New()
        {
            return View("New");
        }

        [HttpPost("add")]
        public IActionResult Add(Dish newDish)
        {
            if(ModelState.IsValid)
            {
                dbContext.Add(newDish);
                dbContext.SaveChanges();
            }
            else{
                return View("New");
            }
            return RedirectToAction("Index");
        }

        [HttpGet("{DishID}")]
        public IActionResult Details(int DishID)
        {
            Dish dishSelected = dbContext.Dishes.FirstOrDefault(dish => dish.DishID == DishID);
            return View("Details", dishSelected);
        }

        

        [HttpPost("edit/{DishID}")]
        public IActionResult Edit(int DishID)
        {
            Dish dishSelected = dbContext.Dishes.FirstOrDefault(dish => dish.DishID == DishID);
            return View("Edit", dishSelected);
        }

        [HttpPost("update/{DishID}")]
        public IActionResult Update(int DishID, Dish d)
        {
            
            if(ModelState.IsValid)
            {
                dbContext.Update(d);
                d.UpdatedAt = DateTime.Now;
                dbContext.SaveChanges();
            }
            else{
                return View("Edit", d);
            }
            
            return RedirectToAction("Details");
        }

        [HttpPost("delete/{DishID}")]
        public IActionResult Delete(int DishID)
        {
            Dish dishSelected = dbContext.Dishes.SingleOrDefault(dish => dish.DishID == DishID);
            dbContext.Dishes.Remove(dishSelected);
            dbContext.SaveChanges();

            return RedirectToAction("Index");
        }


    }
}
