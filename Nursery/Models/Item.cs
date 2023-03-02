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

        [Required]
        public string ItemName { get; set; }

        [MaxLength(100),Required]
        public string ItemDescription { get; set; }

        [Range(0,double.PositiveInfinity),Required]
        public double ItemPrice { get; set; }

        [MaxLength(15),Required]
        public string ItemCategory { get; set; }
        
        public string ItemSubCategory { get; set; }


        public virtual Inventory Inventory { get; set; }
    }
}
