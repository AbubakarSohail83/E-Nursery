using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

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

        public void addUser(User u)
        {
            db.AddUser(u);
        }

        public bool verifyLogin(User u)
        {
            return db.verifyLoginCredentials(u.UEmail, u.UPassword);
        }

        public void makeCookie(User u)
        {
            HttpCookie userInfo = new HttpCookie("userInfo");
            userInfo["UserName"] = "Annathurai";
            userInfo["UserColor"] = "Black";
            userInfo.Expires.Add(new TimeSpan(0, 1, 0));
            Response.Cookies.Add(userInfo);
        }

    }
}
