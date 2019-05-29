using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChefsNDishes.Models;
using Microsoft.EntityFrameworkCore;

namespace ChefsAndDishes.Controllers
{
    public class HomeController : Controller
    {
        private ChefDishContext dbContext;
     
        // here we can "inject" our context service into the constructor
        public HomeController(ChefDishContext context)
        {
            dbContext = context;
        }

        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            List<Chef> AllChefs = dbContext.Chefs
                .Include(c => c.CreatedDishes)
                .OrderByDescending(c => c.CreatedAt)
                .ToList();
            return View(AllChefs);
        }

        [HttpGet("dishes")]
        public IActionResult Dishes()
        {
            List<Dish> AllDishes = dbContext.Dishes
                .Include(d => d.Creator)
                .OrderByDescending(d => d.CreatedAt)
                .ToList();
            
            // ViewBag.Chefs = dbContext.Chefs.ToList();

            return View(AllDishes);
        }

        [HttpGet("new")]
        public IActionResult NewChef()
        {
            return View();
        }

        [HttpPost("addChef")]
        public IActionResult AddChef(Chef newChef)
        {
            if(ModelState.IsValid)
            {
                dbContext.AddChef(newChef);
            }
            else
            {
                return View("NewChef");
            }
            // return RedirectToAction("Index");
            return Redirect("/");
        }

        [HttpGet("dishes/new")]
        public IActionResult NewDish()
        {
            ViewBag.Chefs = dbContext.Chefs.ToList();
            return View();
        }

        [HttpPost("addDish")]
        public IActionResult AddDish(Dish newDish)
        {
            ViewBag.Chefs = dbContext.Chefs.ToList();  
            if(ModelState.IsValid)
            {
                dbContext.AddDish(newDish);
            }
            else
            {
                return View("NewDish");
            }
            // return RedirectToAction("Index");
            return Redirect("/");
        }

        

        

    }
}
