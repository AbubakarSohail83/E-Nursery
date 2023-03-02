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
            if(category=="Products")
            {
                var prods2 = dbCxt.Items.ToList();
                return prods2;
            }
            var prods = dbCxt.Items.Where((prod) => prod.ItemCategory == category).ToList();
            return prods;
        }
    }
}
