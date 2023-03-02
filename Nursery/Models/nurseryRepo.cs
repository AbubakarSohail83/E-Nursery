using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nursery.Models
{
    public class nurseryRepo
    {
        dbModel db= new dbModel();
        
        public List<Item> showProducts(string category)
        {
            var p = db.showProducts(category);
            return p;
        }

    }
}
