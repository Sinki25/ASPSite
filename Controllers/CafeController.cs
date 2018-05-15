using ASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.Controllers
{
    public class CafeController : Controller
    {
       ApplicationContext db = new ApplicationContext();

        // GET: Cafe
        public ActionResult Cafe(int id, string type)
        {
            var cat = db.Categories.Where(c => c.Type == type).FirstOrDefault();

            var cafes = db.Cafes
                // .Join(db.Menus, cafe => cafe.Id, menu => menu.CafeId, (cafe, menu) => new { cafe, menu })
                // .Where(x => x.menu.Categories.Contains(cat))
                .ToList();
            ViewBag.Cafes = cafes;
            //  var cafes = db.Categories.Where(i => i.Type == type).ToList();
            //  ViewBag.Cafes = cafes;
            return View();
        }
    }
}