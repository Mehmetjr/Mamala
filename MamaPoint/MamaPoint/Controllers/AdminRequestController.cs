using Business.Concrete;
using DataAccess.Concrete.Context;
using DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MamaPoint.Controllers
{
    public class AdminRequestController : BaseController
    {
        // GET: AdminRequest
      
       
        [Authorize]
        public ActionResult Request()
        {
            var requestValues = requestManager.GetAll();
            return View(requestValues);
        }
        public ActionResult DeleteRequest(int id)
        {
            var requestValue = requestManager.GetById(id);
            requestManager.Delete(requestValue);
            return RedirectToAction("Request");
        }
    }
}