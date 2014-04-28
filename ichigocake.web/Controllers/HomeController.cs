using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

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
                SmtpClient smtpClient = new SmtpClient();

                smtpClient.Host = "mail.ichigocake.com";
                smtpClient.Port = 587;
                smtpClient.Credentials = new System.Net.NetworkCredential("info@ichigocake.com", "ss4b7858");
                smtpClient.UseDefaultCredentials = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.EnableSsl = true;
                MailMessage mail = new MailMessage();

                //Setting From , To and CC
                mail.Subject = Request["subject"];
                mail.Body = "Kullanıcı İsmi: " + Request["name"] + " Telefon Numarası: " + Request["phone"] + "Kullanıcı Email: " + Request["mail"] +
                    " Mesajı: " +  Request["message"]  ;
                mail.From = new MailAddress("k.oznuriren@gmail.com");
                mail.To.Add(new MailAddress("info@ichigocake.com"));
                //mail.CC.Add(new MailAddress("k.oznuriren@gmail.com"));

                smtpClient.Send(mail);
                var message = "Mesajınız başarıyla iletilmiştir.";
                return Json(String.Format("'Success':'true', 'Başarı':'{0}'",message));
            }
            catch (Exception error)
            {
                var hatamesaji = "Bir Hata Oluştu. Daha sonra tekrar deneyiniz";
                return Json(String.Format("'Success':'false','Hata':'{0}'", error));
            }
        }
    }
}