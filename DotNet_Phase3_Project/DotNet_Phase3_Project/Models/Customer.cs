using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotNet_Phase3_Project.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}