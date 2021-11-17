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
    public class AdminContainerListController : BaseController
    {
        // GET: AdminContainerList
       
        public ActionResult Index()
        {
            return View();
        }
        [Authorize]
        public ActionResult ContainerList()
        {
            var foodValues = fcm.GetList(); 
            return View(foodValues);
        }
        public ActionResult NewContainerList()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewContainerList(FoodContainer fc)
        {
            ContainerValidator containerValidator = new ContainerValidator();
            ValidationResult results = containerValidator.Validate(fc);
            if (results.IsValid)
            {
               
                fcm.Add(fc);
                return RedirectToAction("ContainerList");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                    
                }
                return RedirectToAction("NewContainerList");
            }
           
        }
        [HttpGet]
        public ActionResult UpdateContainerList(int id)
        {
            var foodValue = fcm.GetById(id);
            return View(foodValue);
        }
        [HttpPost]
        public ActionResult UpdateContainerList(FoodContainer fc)
        {
            fcm.Update(fc);
            return RedirectToAction("ContainerList");
            
        }
        public ActionResult DeleteContainerList(int id)
        {
            var foodValue = fcm.GetById(id);
            fcm.Delete(foodValue);
            return RedirectToAction("ContainerList");
        }
    }
}