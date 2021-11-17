using Business.Concrete;
using Business.ValidationRules;
using DataAccess.Concrete.Context;
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
    public class UserContactController : BaseController
    {

       
        // GET: UserContact
      
        [HttpGet]
        [Authorize]
        public ActionResult Contact()
        {
           
            return View();
        }
        [HttpPost]
        public ActionResult Contact(Contact contact)
        {
            ContactValidator contactValidation = new ContactValidator();
            ValidationResult result = contactValidation.Validate(contact);
        
            if (result.IsValid)
            {
                string value = (string)Session["userMail"];
                var userIdInfo = c.Users.Where(x => x.userMail == value).Select(y => y.userId).FirstOrDefault();
                contact.userId = userIdInfo;
                contactManager.ContactAdd(contact);
                return RedirectToAction("Contact");
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