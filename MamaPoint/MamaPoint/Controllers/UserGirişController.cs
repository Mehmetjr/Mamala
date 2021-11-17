using Business.Concrete;
using DataAccess.Concrete.Context;
using DataAccess.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MamaPoint.Controllers
{
    public class UserGirişController : BaseController
    {
        // GET: UserGiriş
       
       
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
        public ActionResult Giriş(User user)
        {
            var UserInfo = c.Users.FirstOrDefault(x => x.userMail == user.userMail && x.password == user.password);
            if (UserInfo != null)
            {
                FormsAuthentication.SetAuthCookie(UserInfo.userMail, false);
                Session["UserMail"] = UserInfo.userMail;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Giriş");
            }

        }
        public ActionResult Logout()
        {
            int userId = (int)Session["UserId"];
            Session.Abandon();
            return RedirectToAction("Giriş", "UserGiriş");
        }
    }
}