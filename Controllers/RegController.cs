using ASP.Models;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.Controllers
{
    public class RegController : Controller
    {

        /*public ActionResult Registration()
        {
            return View();
        }*/

        public ActionResult Auth()
        {
            return View("Auth");
        }

        [HttpPost]
        public ActionResult Auth(ApplicationUser user)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                ViewBag.Users = db.Users.Where(i => i.UserName == user.UserName && i.PasswordHash == user.PasswordHash).Count();
                if (db.Users.Where(i=>i.UserName==user.UserName && i.PasswordHash==user.PasswordHash).Count()>0)
                    return View("/Views/Home/Index.cshtml");
                else return View("Auth");
            }

        }

       /* [HttpPost]
        public ActionResult Registration(ApplicationUser user)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Users.Add(user);
                db.SaveChanges();
                return View("Auth");
            }
           
        }*/
    }
}