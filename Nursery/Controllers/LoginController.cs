using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nursery.Models;

namespace Nursery.Controllers
{
    public class LoginController : Controller
    {
   
        [HttpPost]
        public IActionResult Login(User u)
        {
            if (!ModelState.IsValid)
            {
                var db = new ENurseryContext();
                var checkLogin = db.Users.Where(s => s.UEmail.Equals(u.UEmail) && s.UPassword.Equals(u.UPassword)).FirstOrDefault();
                if (checkLogin != null)
                {
                    return View("~/Views/Home/Index.cshtml");
                }
                else
                    return View() ;
            }
            else
            return View();
        }
        [HttpGet]
        public ViewResult Login()
        {
            return View();
        }

    }
}
