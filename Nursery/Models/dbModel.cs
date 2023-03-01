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
        public List<Item> showProducts()
        {
            ENurseryContext mydb= new ENurseryContext();
            var p = mydb.Items.ToList();
            return p;
        }
    }
}
