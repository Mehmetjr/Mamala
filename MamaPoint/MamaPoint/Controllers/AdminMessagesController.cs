using Business.Concrete;
using DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MamaPoint.Controllers
{
    public class AdminMessagesController : BaseController
    {
       
        // GET: AdminMessages
        public ActionResult Index()
        {
            return View();
        }
        [Authorize]
        public ActionResult Mesajlar()
        {
            var contactValues = contactManager.GetAll();
            return View(contactValues);
        }
        public ActionResult DeleteMesajlar(int id)
        {
            var contactValue = contactManager.GetById(id);
            contactManager.ContactDelete(contactValue);
            return RedirectToAction("Mesajlar");
        }

    }
}