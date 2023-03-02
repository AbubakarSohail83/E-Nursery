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
        public IActionResult Signup(User u)
        {
            nurseryRepo repo = new ();
            u.URole = "Customer";
            if (ModelState.IsValid)
                repo.addUser(u);
            else
                return View();
            return View("~/Views/Login/Login.cshtml");
        }
    }
}
