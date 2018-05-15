using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int CafeId { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
        public Menu()
        {
            Categories = new List<Category>();
        }
    }
}