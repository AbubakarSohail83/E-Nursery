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
        public string Login(User u)
        {
            var db = new ENurseryContext();
            var checkLogin = db.Users.Where(s => s.UEmail.Equals(u.UEmail) && s.UPassword.Equals(u.UPassword)).FirstOrDefault();
            if (checkLogin != null)
            {
                return "Success";
            }
            return "Unsuccessful";
        }
        [HttpGet]
        public ViewResult Login()
        {
            return View();
        }

    }
}
