using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotNet_Phase3_Project.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int CustomerID { get; set; }

        public virtual Customer Course { get; set; }
        public virtual Product Product { get; set; }
    }
}