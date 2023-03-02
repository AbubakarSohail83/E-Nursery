using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nursery.Models
{
    public class nurseryRepo : INurseryRepo
    {
        dbModel db= new dbModel();

        public void addUser(User u)
        {
            db.AddUser(u);
        }

        public List<Item> showProducts(string category)
        {
            var p = db.showProducts(category);
            return p;
        }

        public bool verifyLogin(User u)
        {
            return db.verifyLoginCredentials(u.UEmail, u.UPassword);
        }


    }
}
