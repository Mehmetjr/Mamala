using DataAccess.Concrete.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MamaPoint.Controllers
{
    public class AdminGirişController : BaseController
    {
        // GET: AdminGiriş
       
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Giriş()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Giriş(Admin admin)
        {
           
            var adminInfo = c.Admins.FirstOrDefault(x => x.adminMail == admin.adminMail && x.adminPassword == admin.adminPassword);
            if (adminInfo != null)
            {
                FormsAuthentication.SetAuthCookie(adminInfo.adminMail, false);

                Session["adminMail"] = adminInfo.adminMail;
                return RedirectToAction("Index","Admin");
            }
            else
            {
                return RedirectToAction("Giriş");
            }

            
        }
        public ActionResult Logout()
        {
            
            Session.Abandon();
            return RedirectToAction("Giriş", "AdminGiriş");
        }
    }
}
