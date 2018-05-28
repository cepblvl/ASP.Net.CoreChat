using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using TelegramUI.Models;
using System.Collections.Generic;

public class UserViewModel
{
    public IEnumerable<Users> user { get; set; }
    
}