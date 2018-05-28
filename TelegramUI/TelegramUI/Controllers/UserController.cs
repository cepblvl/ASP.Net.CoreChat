using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TelegramUI.Models;
using TelegramUI;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TelegramUI.Controllers
{

    
    public class UserController : Controller
    {
        List<Users> users = new List<Users>();
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(string id1)
        {
            string authData =id1;
            users.Add(new Users { id1 = id1 });
            return Content(authData);
        }
        // GET: /<controller>/
        [HttpGet]
        
        public IActionResult Users()
        {
            // формируем список компаний для передачи в представление
            users.Add(new Users { id1 = "dsd" });
            users.Add(new Users { id1 = "gjgffg" });
            UserViewModel ivm = new UserViewModel { user = users };

            // если передан id компании, фильтруем список


            return View(ivm);
        }
    }
}
