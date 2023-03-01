using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nursery.Models;

namespace Nursery.Controllers
{
    public class SignupController : Controller
    {
        [HttpGet]
        public ViewResult Signup()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult Signup(User u)
        {
            var db = new ENurseryContext();
            u.URole = "Customer";
            db.Users.Add(u);
            db.SaveChanges();
            return RedirectToAction("Login","Login");
        }
    }
}
