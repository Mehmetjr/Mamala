using Business.Concrete;
using Business.ValidationRules;
using DataAccess.Concrete.Context;
using DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MamaPoint.Controllers
{
    public class BaseController : Controller
    {
        //public BaseController()
        //{
        //    if (string.IsNullOrEmpty(UserMail))
        //    {
        //        RedirectToLogin();
        //    }
        //}

        public UserManager userManager = new UserManager(new EfUserDal());
        public FoodContainerManager fcm = new FoodContainerManager(new EfFoodContainerDal());
        public RequestManager requestManager = new RequestManager(new EfRequestDal());
        public MamalaContext c = new MamalaContext();
        public ContainerValidator containerValidator = new ContainerValidator();
        public AdminManager adminManager = new AdminManager(new EfAdminDal());
        public ContactManager contactManager = new ContactManager(new EfContactDal());
        public SupporterManager supporterManager = new SupporterManager(new EfSupporterDal());
        public string UserMail
        {
            get
            {
                if (Session == null || Session["UserMail"] == null)
                    return string.Empty;

                return (string)Session["UserMail"];
            }
        }

        //public void RedirectToLogin()
        //{

        //}
    }
}