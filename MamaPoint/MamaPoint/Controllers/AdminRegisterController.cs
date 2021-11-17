using Business.Concrete;
using Business.ValidationRules;
using DataAccess.EntityFramework;
using Entities.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MamaPoint.Controllers
{
    public class AdminRegisterController : BaseController
    {
       
       
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Admin admin)
        {
            AdminValidator adminValidator = new AdminValidator();
            ValidationResult result = adminValidator.Validate(admin);
            if (result.IsValid)
            {
                adminManager.AdminAdd(admin);
                return RedirectToAction("Giriş","AdminGiriş");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}