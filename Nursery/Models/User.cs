using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Nursery.Models
{
    public partial class User
    {
        public User()
        {
            Orders = new HashSet<Order>();
        }
        [Key]
        public int UId { get; set; }

        [EmailAddress, Required]
        public string UEmail { get; set; }

        [MinLength(8),MaxLength(12), Required]
        public string UPassword { get; set; }

        [MaxLength(30), Required]
        public string UName { get; set; }

        [Phone,Required]
        public string UPhone { get; set; }

        [Required]
        public string URole { get; set; }

        public string UAddress { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
