using System;
using System.Collections.Generic;
using System.Linq;



#nullable disable

namespace Nursery.Models
{
    public class dbModel
    {
        ENurseryContext dbCxt;
        public dbModel()
        {
            dbCxt = new ENurseryContext();
        }
        public List<Item> showProducts(string category)
        {
            try
            {
                if (category == "Products")
                {
                    var prods2 = dbCxt.Items.ToList();
                    return prods2;
                }
                var prods = dbCxt.Items.Where((prod) => prod.ItemCategory == category).ToList();
                return prods;
            }
            catch
            {
                return null;
            }
        }
        public bool AddUser(User u)
        {
            try
            {
                var f = dbCxt.Users.Add(u);
                dbCxt.SaveChanges();
                if (f != null)

                    return true;
            }
            catch
            {
                return false;
            }
            return false;
        }

        public bool verifyLoginCredentials(string email, string pass)
        {
            var something=dbCxt.Users.Where(s => s.UEmail.Equals(email) && s.UPassword.Equals(pass)).FirstOrDefault();
            if (something != null)
                return true;
            else return false;
        }
    }
}
