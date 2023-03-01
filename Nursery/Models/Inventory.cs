using System;
using System.Collections.Generic;

#nullable disable

namespace Nursery.Models
{
    public partial class Inventory
    {
        public int ItemId { get; set; }
        public int ItemQuantity { get; set; }
        public double ItemUnitPrice { get; set; }
        public double ItemInventoryValue { get; set; }
        public DateTime DateAdded { get; set; }

        public virtual Item Item { get; set; }
    }
}
