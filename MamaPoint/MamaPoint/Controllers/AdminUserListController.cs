using Business.Concrete;
using DataAccess.EntityFramework;
using Entities.Concrete;
using MamaPoint.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MamaPoint.Controllers
{
   
    public class AdminUserListController : Controller
    {
        UserManager userManager = new UserManager(new EfUserDal());
        // GET: AdminUserList
        public ActionResult Index()
        {
            return View();

        }
        [Authorize]
        public ActionResult UserList()
        {
            var userValues = userManager.GetList();
            return View(userValues);
            
        }
        public ActionResult DeleteUser(int id)
        {
            var userValue = userManager.GetById(id);
            userManager.UserDelete(userValue);
            return RedirectToAction("UserList");

        }
        [HttpGet]
        public ActionResult UpdateUserList(int id)
        {
            var userValue = userManager.GetById(id);
            return View(userValue);
        }
        
        [HttpPost]
        public ActionResult UpdateUserList(User user)
        {
            userManager.UserUpdate(user);
            return RedirectToAction("UserList");
        }
    }
}