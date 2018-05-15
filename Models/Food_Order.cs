using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.Models
{
    public class Food_Order
    {
        public int MenuId { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }
    }
}