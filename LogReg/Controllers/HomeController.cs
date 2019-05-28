using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LogReg.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace LogReg.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        
        public static PasswordHasher<User> RegisterHasher = new PasswordHasher<User>();
        // Initializing a PasswordHasher object, providing our User class as its
        public static PasswordHasher<LoginUser> LoginHasher = new PasswordHasher<LoginUser>();
     
        // here we can "inject" our context service into the constructor
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
     
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            
            return View();
        }

        [HttpPost("Register")]
        public IActionResult Register(User user)
        {
            //CHECK IF EMAIL ALREADY EXISTS
            // User newUser = dbContext.Users.FirstOrDefault(u => u.Email == user.Email);
            User userInDb = dbContext.GetUserByEmail(user.Email);

            //if userInDb exists...
            if(userInDb != null)
            {
                ModelState.AddModelError("Email", "Email already in use!");
            }

            if(ModelState.IsValid)
            {
                user.Password = RegisterHasher.HashPassword(user, user.Password);
                // dbContext.Add(user);
                // dbContext.SaveChanges();
                int UserId = dbContext.Create(user);
                HttpContext.Session.SetInt32("UserId", UserId);
                return Redirect("success");
            }
            else
            {
                return View("Index");
            }
        }

        [HttpPost("login")]
        public IActionResult Login(LoginUser user)
        {
            User userInDb = dbContext.GetUserByEmail(user.LoginEmail);
            if(userInDb == null)
            {
                ModelState.AddModelError("LoginEmail", "Invalid Email/Password");
            }   

            if(ModelState.IsValid)
            {
                

                // verify provided password against hash stored in db
                var result = LoginHasher.VerifyHashedPassword(user, userInDb.Password, user.LoginPassword);
                
                // result can be compared to 0 for failure
                if(result == 0 )
                {
                    // handle failure (this should be similar to how "existing email" is handled)
                    ModelState.AddModelError("LoginPassword", "Invalid Email/Password");
                }
                else
                {
                    HttpContext.Session.SetInt32("UserId", userInDb.UserId);
                    return Redirect("success");
                }
            }
            return View("Index");
        }

        [HttpGet("success")]
        public IActionResult Success()
        {
            int? UserId = HttpContext.Session.GetInt32("UserId");
            if(UserId == null)
            {
                return Redirect("/");
            }
            else
            {
                ViewBag.User = dbContext.GetUserById((int)UserId);
                return View();
            }
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return Redirect("/");
        }

    }
}
