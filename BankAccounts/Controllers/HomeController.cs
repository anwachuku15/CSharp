using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankAccounts.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace BankAccounts.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public static PasswordHasher<User> RegisterHasher = new PasswordHasher<User>();
        // Initializing a PasswordHasher object, providing our User class as its
        public static PasswordHasher<UserLog> LoginHasher = new PasswordHasher<UserLog>();
     
        // here we can "inject" our context service into the constructor
        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register(User user)
        {
            User userInDb = dbContext.GetUserByEmail(user.Email);
            if(userInDb != null)
            {
                ModelState.AddModelError("Email", "Email already exists");
            }

            if(ModelState.IsValid)
            {
                user.Password = RegisterHasher.HashPassword(user, user.Password);
                int UserId = dbContext.Create(user);
                HttpContext.Session.SetInt32("UserId", UserId);
                return Redirect("account/{UserId}");
            }
            else
            {
                return View("Index");
            }
        }

        [HttpGet("login")]
        public IActionResult LoginPage()
        {
            return View();
        }

        [HttpPost("success")]
        public IActionResult Login(UserLog user, int UserId)
        {
            User userInDb = dbContext.GetUserByEmail(user.LogEmail);
            if(userInDb == null)
            {
                ModelState.AddModelError("LogEmail", "Invalid Email/Password");
            }   

            if(ModelState.IsValid)
            {
                // verify provided password against hash stored in db
                var result = LoginHasher.VerifyHashedPassword(user, userInDb.Password, user.LogPassword);
                
                // result can be compared to 0 for failure
                if(result == 0)
                {
                    // handle failure (this should be similar to how "existing email" is handled)
                    ModelState.AddModelError("LogPassword", "Invalid Email/Password");
                }
                else
                {
                    HttpContext.Session.SetInt32("UserId", userInDb.UserId);
                    return Redirect("account");
                }
            }
            return View("LoginPage");
        }

        [HttpGet("account")]
        public IActionResult Welcome(Transaction money)
        {
            int? UserId = HttpContext.Session.GetInt32("UserId");
            if(UserId == null)
            {
                return Redirect("/");
            }
            else
            {
                ViewBag.User = dbContext.GetUserById((int)UserId);
                ViewBag.Transactions = dbContext.Transactions
                    .OrderByDescending(d => d.CreatedAt)
                    .ToList();
                
                return View("Account");
            }
        }

        [HttpPost("maketransaction")]
        public IActionResult MakeTransaction(Transaction money)
        { 
            int? UserId = HttpContext.Session.GetInt32("UserId");
            if(UserId != null)
            {
                money.UserId = (int)UserId;
                dbContext.MakeTrans(money);
            }
            
            return Redirect("account");
        }


        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return Redirect("/");
        }

    }
}
