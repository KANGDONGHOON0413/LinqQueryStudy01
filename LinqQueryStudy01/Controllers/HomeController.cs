using LinqQueryStudy01.DBContextm;
using LinqQueryStudy01.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LinqQueryStudy01.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            using (var db = new DbcontextM())
            {
                IQueryable<bool> lists = from user in db.Users
                            select user.UserNo == 1;
                int no = lists.Count();
                ViewBag.lists = no;
            }
            return View();
        }
        [HttpPost]
        public IActionResult Privacy(UserC model)
        {
            if (ModelState.IsValid)
            {
                using(var db = new DbcontextM())
                {
                    db.Add(model);
                    db.SaveChanges();
                }
                return Redirect("Index");
            }

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
