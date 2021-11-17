using Business.Concrete;
using DataAccess.Concrete.Context;
using DataAccess.EntityFramework;
using Entities.Concrete;
using MailKit.Net.Smtp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using SmtpClient = System.Net.Mail.SmtpClient;

namespace MamaPoint.Controllers
{
    public class AdminForgotPasswordController : BaseController
    {
      
        // GET: AdminForgotPassword
       
        [HttpGet]
        public ActionResult ForgotPassword()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ForgotPassword(string adminEmail, string adminName, string adminSurname)
        {
            var Name = c.Admins.Where(x => x.adminName == adminName).SingleOrDefault();
            var Surname = c.Admins.Where(x => x.adminSurname == adminSurname).SingleOrDefault();
            var email = c.Admins.Where(x => x.adminMail == adminEmail).SingleOrDefault();
            var password = c.Admins.Where(x => x.adminMail == adminEmail).Select(y => y.adminPassword).FirstOrDefault();
            var name = c.Admins.Where(x => x.adminMail == adminEmail).Select(y => y.adminName).FirstOrDefault();
            var surname = c.Admins.Where(x => x.adminMail == adminEmail).Select(y => y.adminSurname).FirstOrDefault();
            if (email != null && Name !=null && Surname != null)
            {
                
                MailMessage mail = new MailMessage();
                SmtpClient client = new SmtpClient();
                client.Credentials = new System.Net.NetworkCredential("mehmet_halil79@hotmail.com", "Kilis793427");
                client.Port = 587;
                client.Host = "smtp.live.com";
                client.EnableSsl = true;
                mail.To.Add(adminEmail);
                mail.From = new MailAddress("mehmet_halil79@hotmail.com");
                mail.Subject = "Şifre Sıfırlama";
                mail.Body = "Sayın " +name + " " + surname + "; Şifreniz: " + password + " Lütfen şifrenizi en kısa sürede değiştiriniz ";
                client.Send(mail);
                return RedirectToAction("Giriş", "AdminGiriş");
            }
            else
            {
                ViewBag.Uyarı = "Hata";
                return RedirectToAction("ForgotPassword");
            }
           

        
        }
    }
}