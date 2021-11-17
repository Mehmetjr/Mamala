using Business.Concrete;
using Business.ValidationRules;
using DataAccess.EntityFramework;
using Entities.Concrete;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MamaPoint.Controllers
{
    public class UserRegisterController : BaseController
    {
        // GET: UserRegister
       
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(User user)
        {
            UserValidator userValidator = new UserValidator();
            ValidationResult result = userValidator.Validate(user);
            if (result.IsValid)
            {
                userManager.UserAdd(user);
                return RedirectToAction("Giriş", "UserGiriş");
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