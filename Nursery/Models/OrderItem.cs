using System;
using System.Collections.Generic;

#nullable disable

namespace Nursery.Models
{
    public partial class OrderItem
    {
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public int ItemNumber { get; set; }
        public int ItemId { get; set; }
        public double TotalPrice { get; set; }
    }
}
