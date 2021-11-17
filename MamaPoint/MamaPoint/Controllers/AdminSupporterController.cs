using Business.Concrete;
using Business.ValidationRules;
using DataAccess.EntityFramework;
using Entities.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MamaPoint.Controllers
{
    public class AdminSupporterController : BaseController
    {
       
        // GET: AdminSupporter
        public ActionResult Index()
        {
            return View();
        }
        [Authorize]
        public ActionResult Supporter()
        {
            var supporterValues = supporterManager.GetAll();
            return View(supporterValues);
        }
        [HttpGet]
        public ActionResult NewSupporter()
        {   
            return View();
        }
        [HttpPost]
        public ActionResult NewSupporter(Supporter supporter)
        {
        SupporterValidator supporterValidator = new SupporterValidator();
        ValidationResult results = supporterValidator.Validate(supporter);
            if (results.IsValid)
            {
                if (Request.Files.Count>0)
                {
                    string filename = Path.GetFileName(Request.Files[0].FileName);
                    string extension = Path.GetExtension(Request.Files[0].FileName);
                    string path = "~/Image/" + filename + extension;
                    Request.Files[0].SaveAs(Server.MapPath(path));
                    supporter.SupporterImage = "/Image/" + filename + extension;
                }
                supporterManager.SupporterAdd(supporter);
                return RedirectToAction("Supporter");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        [HttpGet]
        public ActionResult UpdateSupporter(int id)
        {
            var supporterValues = supporterManager.GetById(id);
            return View(supporterValues);
        }
        [HttpPost]
        
        public ActionResult UpdateSupporter(Supporter supporter)
        {
            supporterManager.SupporterUpdate(supporter);
            return RedirectToAction("Supporter");
        }
        public ActionResult DeleteSupporter(int id)
        {
            var supporterValue = supporterManager.GetById(id);
            supporterManager.SupporterDelete(supporterValue);
            return RedirectToAction("Supporter");
        }
    }
}