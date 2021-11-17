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
    public class HomeController : BaseController
    {
        [HttpGet]
        public ActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Index(Request request, FormCollection frm)
        {

            string value = (string)Session["UserMail"];
            var userIdInfo = c.Users.Where(x => x.userMail == value).Select(y => y.userId).FirstOrDefault();
            request.userId = userIdInfo;
            request.request = checkRadio(frm);
            requestManager.Add(request);
            return RedirectToAction("Index");
        }
        public String checkRadio(FormCollection frm)
        {
            string radio = frm["choice"].ToString();
            return radio;
        }

        public JsonResult GetAllLocation()
        {
            var data = c.FoodContainers.ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public PartialViewResult PartialModal()
        {
            string value = (string)Session["UserMail"];
            var user = c.Users.Where(x => x.userMail == value).FirstOrDefault();
            return PartialView(user);
        }
        [HttpPost]
        public RedirectToRouteResult PartialModal(string Pin)
        {
            var user = c.Users.Where(x => x.userMail == UserMail).FirstOrDefault();
            var pin = c.FoodContainers.FirstOrDefault(x => x.pin.ToString() == Pin);
            if (pin != null)
            {
                user.point += 10;
                userManager.UserUpdate(user);
            }
            return RedirectToAction("Index");

        }



    }
}