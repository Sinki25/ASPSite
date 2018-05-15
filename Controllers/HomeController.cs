using ASP.Models;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.Controllers
{
    public class HomeController : Controller
    {
        // создаем контекст данных
        //BDContext db = new BDContext();

        public ActionResult Index(ApplicationUser user)
        {
            using (ApplicationContext db = new ApplicationContext())
            {

                if (User.Identity.IsAuthenticated)
                    ViewBag.Auth = 1;
                // возвращаем представление
                return View();
            }
        }
    }
}