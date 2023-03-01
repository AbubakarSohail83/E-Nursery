using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nursery.Models;

namespace Nursery.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult sshowProducts()
        {
            dbModel db = new dbModel();
            List<Item> prod = db.showProducts();
            

          
            return View(prod);
        }
    }
}
