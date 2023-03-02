using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using Nursery.Models;


namespace Nursery.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult ShowProducts([FromRoute]string id)
        {
            List<Item> prod = new();
            nurseryRepo repo = new();
            prod = repo.showProducts(id);
            
            return View("sshowProducts", prod);

        }
    }
}
