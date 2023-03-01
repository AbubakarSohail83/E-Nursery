using System;
using System.Collections.Generic;

#nullable disable

namespace Nursery.Models
{
    public partial class User
    {
        public User()
        {
            Orders = new HashSet<Order>();
        }

        public int UId { get; set; }
        public string UEmail { get; set; }
        public string UPassword { get; set; }
        public string UName { get; set; }
        public string UPhone { get; set; }
        public string URole { get; set; }
        public string UAddress { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
