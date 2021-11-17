using Business.Concrete;
using DataAccess.Concrete.Context;
using DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace MamaPoint.Controllers
{
    public class UserForgotPasswordController : BaseController
    {
       
        // GET: AdminForgotPassword

        [HttpGet]
        public ActionResult ForgotPassword()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ForgotPassword(string userEmail, string userName, string userSurname)
        {
            var Name = c.Users.Where(x => x.userName == userName).SingleOrDefault();
            var Surname = c.Users.Where(x => x.userSurname == userSurname).SingleOrDefault();
            var email = c.Users.Where(x => x.userMail == userEmail).SingleOrDefault();
            var password = c.Users.Where(x => x.userMail == userEmail).Select(y => y.password).FirstOrDefault();
            var name = c.Users.Where(x => x.userMail == userEmail).Select(y => y.userName).FirstOrDefault();
            var surname = c.Users.Where(x => x.userMail == userEmail).Select(y => y.userSurname).FirstOrDefault();
            if (email != null && Name != null && Surname != null)
            {

                MailMessage mail = new MailMessage();
                SmtpClient client = new SmtpClient();
                client.Credentials = new System.Net.NetworkCredential("mehmet_halil79@hotmail.com", "Kilis793427");
                client.Port = 587;
                client.Host = "smtp.live.com";
                client.EnableSsl = true;
                mail.To.Add(userEmail);
                mail.From = new MailAddress("mehmet_halil79@hotmail.com");
                mail.Subject = "Şifre Sıfırlama";
                mail.Body = "Sayın " + name + " " + surname + "; Şifreniz: " + password + " Lütfen şifrenizi en kısa sürede değiştiriniz ";
                client.Send(mail);
                return RedirectToAction("Giriş", "UserGiriş");
            }
            else
            {
                ViewBag.Uyarı = "Hata";
                return RedirectToAction("ForgotPassword");
            }



        }
    }
}