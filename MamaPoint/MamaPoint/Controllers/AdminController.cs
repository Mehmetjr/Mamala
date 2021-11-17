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
   
    public class AdminController : BaseController
    {
        // GET: Admin
        [Authorize]
        [HttpGet]
        public ActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin admin)
        {

            string value = (string)Session["UserMail"];
            var adminInfo = c.Admins.Where(x => x.adminMail == value).Select(y => y.adminId).FirstOrDefault();
            admin.adminId = adminInfo;
            return View();
        }
            public JsonResult GetAllLocation()
        {
            var data = c.FoodContainers.ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}