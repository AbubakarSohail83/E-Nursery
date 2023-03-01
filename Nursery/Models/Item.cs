using Nursery.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Nursery.Models
{
    public class Item : FullAuditModel
    { 
        [Key]
        public int ItemId { get; set; }
        public string ItemDescription { get; set; }
        public double ItemPrice { get; set; }
        public string ItemCategory { get; set; }
        
        public string ItemSubCategory { get; set; }


        public virtual Inventory Inventory { get; set; }
    }
}
