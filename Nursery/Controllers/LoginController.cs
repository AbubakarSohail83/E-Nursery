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
                var repo = new nurseryRepo();
                var checkLogin = repo.verifyLogin(u);
                if (checkLogin != false)
                {
                   if(!(HttpContext.Request.Cookies.ContainsKey(u.UEmail)))
                        Response.Cookies.Append(u.UEmail,u.UPassword);
                    
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
