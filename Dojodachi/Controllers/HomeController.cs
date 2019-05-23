using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dojodachi.Models;
using Microsoft.AspNetCore.Http;

namespace Dojodachi.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            HttpContext.Session.SetInt32("Fullness", 20);
            ViewBag.Fullness = HttpContext.Session.GetInt32("Fullness");
            HttpContext.Session.SetInt32("Happiness", 20);
            ViewBag.Happiness = HttpContext.Session.GetInt32("Happiness");
            HttpContext.Session.SetInt32("Energy", 50);
            ViewBag.Energy = HttpContext.Session.GetInt32("Energy");
            HttpContext.Session.SetInt32("Meals", 3);
            ViewBag.Meals = HttpContext.Session.GetInt32("Meals");

            HttpContext.Session.SetString("Feed", "");
            ViewBag.Feed = HttpContext.Session.GetString("Feed");
            return RedirectToAction("Dojodachi");
        }

        [HttpPost("feed")]
        public IActionResult Feed()
        {
            ViewBag.Happiness = HttpContext.Session.GetInt32("Happiness");
            ViewBag.Energy = HttpContext.Session.GetInt32("Energy");


            ViewBag.Meals = HttpContext.Session.GetInt32("Meals");
            if(ViewBag.Meals == 0)
            {
                ViewBag.Happiness = HttpContext.Session.GetInt32("Happiness");
                HttpContext.Session.SetString("Feed", "There's nothing to eat!");
                ViewBag.Feed = HttpContext.Session.GetString("Feed");
                return RedirectToAction("Dojodachi");
            }
            else
            {
                ViewBag.Meals--;
                int m = ViewBag.Meals;
                HttpContext.Session.SetInt32("Meals", m);

                Random rand = new Random();
                ViewBag.Fullness = HttpContext.Session.GetInt32("Fullness");
                int randFull = rand.Next(5,11);
                ViewBag.Fullness += randFull;
                int f = ViewBag.Fullness;
                HttpContext.Session.SetInt32("Fullness", f);
                
                return RedirectToAction("Dojodachi"); 
            }
        }

        [HttpPost("play")]
        public IActionResult Play() 
        {
            ViewBag.Fullness = HttpContext.Session.GetInt32("Fullness");
            ViewBag.Meals = HttpContext.Session.GetInt32("Meals");

            ViewBag.Energy = HttpContext.Session.GetInt32("Energy");
            ViewBag.Energy -= 5;
            int e = ViewBag.Energy;
            HttpContext.Session.SetInt32("Energy", e);

            Random rand = new Random();
            ViewBag.Happiness = HttpContext.Session.GetInt32("Happiness");
            int randHappy = rand.Next(5,11);
            ViewBag.Happiness += randHappy;
            int h = ViewBag.Happiness;
            HttpContext.Session.SetInt32("Happiness", h);

            return RedirectToAction("Dojodachi");
        }

        [HttpPost("work")]
        public IActionResult Work()
        {
            ViewBag.Fullness = HttpContext.Session.GetInt32("Fullness");
            ViewBag.Happiness = HttpContext.Session.GetInt32("Happiness");

            ViewBag.Energy = HttpContext.Session.GetInt32("Energy");
            ViewBag.Energy -= 5;
            int e = ViewBag.Energy;
            HttpContext.Session.SetInt32("Energy", e);

            Random rand = new Random();
            ViewBag.Meals = HttpContext.Session.GetInt32("Meals");
            int randMeal = rand.Next(1,4);
            ViewBag.Meals += randMeal;
            int m = ViewBag.Meals;
            HttpContext.Session.SetInt32("Meals", m);

            return RedirectToAction("Dojodachi");
        }

        [HttpPost("sleep")]
        public IActionResult Sleep()
        {
            ViewBag.Energy = HttpContext.Session.GetInt32("Energy");
            ViewBag.Energy += 15;
            int e = ViewBag.Energy;
            HttpContext.Session.SetInt32("Energy", e);

            ViewBag.Fullness = HttpContext.Session.GetInt32("Fullness");
            ViewBag.Fullness -= 5;
            int f = ViewBag.Fullness;
            HttpContext.Session.SetInt32("Fullness", f);

            ViewBag.Happiness = HttpContext.Session.GetInt32("Happiness");
            ViewBag.Happiness -= 5;
            int h = ViewBag.Happiness;
            HttpContext.Session.SetInt32("Happiness", h);

            return RedirectToAction("Dojodachi");
        }



        [HttpGet("dojodachi")]
        public IActionResult Dojodachi()
        {
            ViewBag.Fullness = HttpContext.Session.GetInt32("Fullness");
            ViewBag.Happiness = HttpContext.Session.GetInt32("Happiness");
            ViewBag.Energy = HttpContext.Session.GetInt32("Energy");
            ViewBag.Meals = HttpContext.Session.GetInt32("Meals");
            ViewBag.Feed = HttpContext.Session.GetString("Feed");
            
            if(ViewBag.Fullness >= 100 && ViewBag.Happiness >= 100 && ViewBag.Energy >= 100)
            {
                HttpContext.Session.SetString("Feed", "Congratulations! You Won!");
                ViewBag.Feed = HttpContext.Session.GetString("Feed");
            }
            
            return View("Index");
        }

    }
}
