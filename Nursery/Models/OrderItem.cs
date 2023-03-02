using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Nursery.Models
{
    public partial class OrderItem
    {
        [Key]
        public int OrderId { get; set; }

        [Range(0,double.PositiveInfinity),Required]
        public int Quantity { get; set; }

        [Range(0,double.PositiveInfinity),Required]
        public int ItemNumber { get; set; }

        [Range(1,double.PositiveInfinity),Required]
        public int ItemId { get; set; }

        [Range(0,double.PositiveInfinity),Required]
        public double TotalPrice { get; set; }
    }
}
