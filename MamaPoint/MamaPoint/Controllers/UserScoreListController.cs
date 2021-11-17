using Business.Concrete;
using DataAccess.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MamaPoint.Controllers
{
    public class UserScoreListController : BaseController
    {
        // GET: UserScoreList
 
        public ActionResult Index()
        {   
            return View();
        }
        public ActionResult ScoreList()
        {
            var userValues = userManager.GetList();
            return View(userValues);
        }

        public PartialViewResult UserScore()
        {
            string value = (string)Session["UserMail"];
            var user = c.Users.Where(x => x.userMail == value).FirstOrDefault();
            return PartialView(user);
        }
    }
}