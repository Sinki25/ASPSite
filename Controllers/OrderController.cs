using ASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.Controllers
{
    public class OrderController : Controller
    {
        //BDContext db = new BDContext();
        // GET: Order
        public ActionResult Order(string Id)
        {
            //var orders = db.MenuTab.Where(i => i.Name == Id).ToList();
            //ViewBag.Orders = orders;
            return View();
        }
    }
}