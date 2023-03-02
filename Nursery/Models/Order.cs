using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Nursery.Models
{
    public partial class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Range(0,double.PositiveInfinity),Required]
        public int UId { get; set; }

        [Required]
        public string OrderShippingMethod { get; set; }

        [Required,DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }

        [Required]
        public string OrderStatus { get; set; }

        public virtual User UIdNavigation { get; set; }
    }
}
