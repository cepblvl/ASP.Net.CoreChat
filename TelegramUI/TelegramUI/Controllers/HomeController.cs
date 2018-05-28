using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TelegramUI.Models;
using TelegramUI.Controllers;
using Microsoft.EntityFrameworkCore;
namespace TelegramUI.Controllers
{
    public class HomeController : Controller
    {
        private UserContext db;
        public HomeController(UserContext context)
        {
            db = context;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
        public async Task<IActionResult> Index()
        {
            return View(await db.user.ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Users user)
        {
            db.user.Add(user);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
