using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string CafeId { get; set; }
    }
}