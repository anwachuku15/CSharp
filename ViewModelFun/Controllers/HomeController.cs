using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            string message = "Welcome to your Index route.";
            return View("Index", message);
        }

        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            int[] numbers = new int[]
            {
                1, 2, 3, 10, 43, 5
            };
            return View("Numbers", numbers);
        }

        [HttpGet("users")]
        public IActionResult Users()
        {
            User user1 = new User()
            {
                FirstName = "Moose",
                LastName = "Phillips"
            };
            User user2 = new User()
            {
                FirstName = "Sarah",
                LastName = "Silverman"
            };
            User user3 = new User()
            {
                FirstName = "Jerry",
                LastName = "Atrick"
            };
            User user4 = new User()
            {
                FirstName = "Rene",
                LastName = "Ricky"
            };
            User user5 = new User()
            {
                FirstName = "Barbarah",
                LastName = "Barrick"
            };

            List<User> users = new List<User>()
            {
                user1, user2, user3, user4, user5
            };

            return View("Users", users);
        }

        [HttpGet("user")]
        public IActionResult UserPage()
        {
            User oneUser = new User()
            {
                FirstName = "Moose",
                LastName = "Phillips"
            };
            return View("User", oneUser);
        }

    }
}
