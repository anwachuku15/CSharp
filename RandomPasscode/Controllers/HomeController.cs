using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RandomPasscode.Models;
using Microsoft.AspNetCore.Http;

namespace RandomPasscode.Controllers
{
    
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            HttpContext.Session.SetInt32("Count", 0);
            ViewBag.Count = HttpContext.Session.GetInt32("Count");
            HttpContext.Session.SetString("Passcode", "Click to Generate");
            ViewBag.Passcode = HttpContext.Session.GetString("Passcode");

            Console.WriteLine(ViewBag.Count);
            Console.WriteLine(ViewBag.Passcode);
            return View();
        }

        [HttpPost("generate")]
        public IActionResult Generate()
        {
            ViewBag.Count = HttpContext.Session.GetInt32("Count");
            ViewBag.Count++;
            int c = ViewBag.Count;
            HttpContext.Session.SetInt32("Count", c);

            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random rand = new Random();
            string passcode = "";

            for(int i=0; i<14; i++)
            {
                passcode += chars[rand.Next(chars.Length)];
            }
            HttpContext.Session.SetString("Passcode", passcode);
            ViewBag.Passcode = HttpContext.Session.GetString("Passcode");
            

            Console.WriteLine(ViewBag.Count);
            Console.WriteLine(ViewBag.Passcode);
            return View("Index");
        }

        [HttpPost("reset")]
        public IActionResult Reset()
        {
            return Redirect("/");
        }

    }
}
