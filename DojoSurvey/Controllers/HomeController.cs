using Microsoft.AspNetCore.Mvc;
using System;
//Main job of CONTROLLERS - handle requests & deliver responses
namespace HelloASP
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("index");
        }

        [HttpPost("result")]
        public IActionResult Result(string name, string locations, string languages, string comment)
        {
            ViewBag.Name = name;
            ViewBag.Location = locations;
            ViewBag.Language = languages;
            ViewBag.Comment = comment;
            return View("result");
        }

        [HttpGet("result")]
        public IActionResult Results()
        {
            return View("result");
        }
    }
}