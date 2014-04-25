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

                smtpClient.Host = "smtp.gmail.com";
                smtpClient.Port = 587;
                smtpClient.Credentials = new System.Net.NetworkCredential("k.oznuriren@gmail.com", "OznStc26");
                smtpClient.UseDefaultCredentials = false;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.EnableSsl = true;
                MailMessage mail = new MailMessage();

                //Setting From , To and CC
                mail.Subject = Request["subject"];
                mail.Body = "Kullanıcı İsmi: " + Request["name"] + " Telefon Numarası: " + Request["phone"] + "Kullanıcı Email: " + Request["mail"] +
                    " Mesajı: " +  Request["message"]  ;
                mail.From = new MailAddress("k.oznuriren@gmail.com");
                mail.To.Add(new MailAddress("k.oznuriren@gmail.com"));
                //mail.CC.Add(new MailAddress("k.oznuriren@gmail.com"));

                smtpClient.Send(mail);
                return Json(String.Format("'Success':'true'"));
            }
            catch (Exception error)
            {
                return Json(String.Format("'Success':'false','Error':'{0}'", error));
            }
        }
    }
}