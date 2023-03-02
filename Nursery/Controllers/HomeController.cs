using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Nursery.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Nursery.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult aboutUs()
        {
            return View();
        }

        public IActionResult showContact()
        {
            return View();
        }
    }
}
