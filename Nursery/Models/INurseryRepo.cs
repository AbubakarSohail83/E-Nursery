using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nursery.Models
{
     public interface INurseryRepo
    {
         public List<Item> showProducts(string category);

        public void addUser(User u);

        public bool verifyLogin(User u);
     
    }
}
