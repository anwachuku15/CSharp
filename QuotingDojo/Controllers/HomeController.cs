using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuotingDojo.Models;
using Microsoft.AspNetCore.Http;
using DbConnection;

namespace QuotingDojo.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("add")]
        public IActionResult Add(User user)
        {
            if(ModelState.IsValid)
            {
                User newUser = user;
                string query = $"INSERT INTO users (name, quote, created_at) VALUES ('{user.Name}', '{user.Quote}', '{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")}')";
                DbConnector.Execute(query);
                return RedirectToAction("Quotes");
            }
            else
            {
                return View("Index");
            }
        }

        [HttpGet("quotes")]
        public IActionResult Quotes()
        {
            List<Dictionary<string, object>> AllUsers = DbConnector.Query("SELECT * FROM users ORDER BY id DESC");
            ViewBag.Users = AllUsers;
            return View("Quotes");
        }


    }
}
