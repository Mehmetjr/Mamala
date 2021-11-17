using Business.Concrete;
using DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MamaPoint.Controllers
{
    public class UserSupporterController : BaseController
    {
      
        // GET: UserSupporter
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Supporter()
        {
            var supporterValues = supporterManager.GetAll();
            return View(supporterValues);
        }
    }
}