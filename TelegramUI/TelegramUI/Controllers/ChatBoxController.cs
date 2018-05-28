//using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TelegramUI.Controllers
{
    public class ChatBoxController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}