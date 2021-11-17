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
    public class AdminProfileController : BaseController
    {
       
       
        // GET: AdminProfile
        [HttpGet]
        [Authorize]
        public ActionResult AProfile(int id = 0)
        {
            string p = (string)Session["adminMail"];
            id = c.Admins.Where(x => x.adminMail == p).Select(y => y.adminId).FirstOrDefault();
            var name = c.Admins.Where(x => x.adminMail == p).Select(y => y.adminName).FirstOrDefault();
            ViewBag.a = name;
            var adminValue = adminManager.GetById(id);
            return View(adminValue);
        }
        [HttpPost]
        public ActionResult AProfile(Admin admin)
        {
            adminManager.AdminUpdate(admin);
            return RedirectToAction("AProfile");
        }
    }
}