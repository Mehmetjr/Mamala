using Business.Concrete;
using DataAccess.Concrete.Context;
using DataAccess.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MamaPoint.Controllers
{
    public class UserProfileController : BaseController
    {
       
        // GET: AdminProfile
        [HttpGet]
      
        public ActionResult UProfile(int id = 0)
        {
            string p = (string)Session["userMail"];
            id = c.Users.Where(x => x.userMail == p).Select(y => y.userId).FirstOrDefault();
            var name = c.Users.Where(x => x.userMail == p).Select(y => y.userName).FirstOrDefault();
            ViewBag.a = name;
            var userValue = userManager.GetById(id);
            return View(userValue);
        }
        [HttpPost]
        public ActionResult UProfile(User user)
        {
            userManager.UserUpdate(user);
            return RedirectToAction("UProfile");
        }
    }
}