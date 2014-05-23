using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using ichigocake.web.Models.MailModels;

namespace ichigocake.web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public JsonResult SendMail()
        {
            try
            {

                //MailMessage mail = new MailMessage();

                //System.Net.NetworkCredential userInformation = new System.Net.NetworkCredential("web@ichigocake.com", "ss4b7858");
                //SmtpClient MailSend = new SmtpClient("mail.ichigocake.com", 587);
                //MailSend.EnableSsl = false;
                //MailSend.UseDefaultCredentials = true;
                //MailSend.Credentials = userInformation;
               

                ////Setting From , To and CC
                //mail.Subject = Request["subject"];
              
                //mail.Body = "Kullanıcı İsmi: " + Request["name"] + " Telefon Numarası: " + Request["phone"] + "Kullanıcı Email: " + Request["mail"] +
                //   " Mesajı: " +  Request["message"]  ;
                //mail.From = new MailAddress("web@ichigocake.com","ICHIGO CAKE");
                //mail.To.Add(new MailAddress("info@ichigocake.com"));
                //mail.Bcc.Add(new MailAddress("k.oznuriren@gmail.com"));
                //MailSend.Send(mail);

                var mailModel=new MailModel();
                mailModel.Email = "noreply@ichigocake.com";
                mailModel.UserName = Request["name"];
                mailModel.Subject = Request[""];
                mailModel.Message = Request[""];
                mailModel.Phone = Request[""];
                new MailController().MessageMail(mailModel).Deliver();
                new MailController().CustomerMessageNotificationMail(mailModel).Deliver();
                var message = "Mesajınız başarıyla iletilmiştir.";
                return Json(String.Format("'Success':'true', 'Başarı':'{0}'", message));

            }
            catch (Exception error)
            {
                var errormessage = "Bir Hata Oluştu. Daha sonra tekrar deneyiniz";
                return Json(String.Format("'Success':'false','Hata':'{0}'", error));
            }
        }
    }
}