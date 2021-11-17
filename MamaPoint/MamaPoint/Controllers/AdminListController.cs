using Business.Concrete;
using Business.ValidationRules;
using DataAccess.EntityFramework;
using Entities.Concrete;
using FluentValidation.Results;
using MamaPoint.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MamaPoint.Controllers
{
    public class AdminListController : BaseController
    {
        // GET: AdminList
        public ActionResult Index()
        {
            return View();
        }
        [Authorize]
        public ActionResult AdminList()
        {
            var adminValues = adminManager.GetList();
            return View(adminValues);
        }
        public ActionResult NewAdminList()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewAdminList(Admin a)
        {
           
            AdminValidator adminValidator = new AdminValidator();
            ValidationResult results = adminValidator.Validate(a);
            if (results.IsValid)
            {
                adminManager.AdminAdd(a);
                return RedirectToAction("AdminList");
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

        public ActionResult DeleteAdmin(int id)
        {
            var adminValue = adminManager.GetById(id);
            adminManager.AdminDelete(adminValue);
            return RedirectToAction("AdminList");
        }
        [HttpGet]
        public ActionResult UpdateAdmin(int id)
        {
            var adminValue = adminManager.GetById(id);
            return View(adminValue);
        }
        [HttpPost]
        public ActionResult UpdateAdmin(Admin admin)
        {
            adminManager.AdminUpdate(admin);
            return RedirectToAction("AdminList");
        }

    }
}