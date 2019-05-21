using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyMVC.Models;

namespace DojoSurveyMVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpPost("")]
        public IActionResult Entry(User ninja)
        {
            if(ModelState.IsValid)
            {
                User ninjaEntry = ninja;
                return RedirectToAction("Result", ninjaEntry);
            }
            else
            {
                return View("Index");
            }
        }

        [HttpGet("result")]
        public IActionResult Result(User ninja)
        {
            User ninjaEntry = ninja;
            return View("Result", ninjaEntry);
        }
    }
}
