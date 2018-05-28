using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TelegramUI.Models;
using TelegramUI.Controllers;
using Microsoft.EntityFrameworkCore;

namespace TelegramUI.Controllers
{
    
    public class ChatController : Controller
    {
        private UserContext db;
        public ChatController(UserContext context)
        {
            db = context;
        }
        public async Task<IActionResult> Index(Users user)
        {
            //db.user.Add(user);
            //await db.SaveChangesAsync();
           
            return View();
            //await db.user.ToListAsync()
        }
    }
}