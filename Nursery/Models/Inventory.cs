using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Nursery.Models
{
    public partial class Inventory
    {
        [Key]
        public int ItemId { get; set; }
        [Range(0,double.PositiveInfinity),Required]
        public int ItemQuantity { get; set; }
        [Range(0, double.PositiveInfinity), Required]
        public double ItemUnitPrice { get; set; }
        [Range(0, double.PositiveInfinity), Required]
        public double ItemInventoryValue { get; set; }
        [DataType(DataType.Date), Required]
        public DateTime DateAdded { get; set; }

        public virtual Item Item { get; set; }
    }
}
