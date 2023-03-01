using System;
using System.Collections.Generic;

#nullable disable

namespace Nursery.Models
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public int UId { get; set; }
        public string OrderShippingMethod { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderStatus { get; set; }

        public virtual User UIdNavigation { get; set; }
    }
}
