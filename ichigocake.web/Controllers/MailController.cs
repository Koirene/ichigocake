using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using ActionMailer.Net.Mvc;
using ichigocake.domain;
using ichigocake.web.Models.MailModels;

namespace ichigocake.web.Controllers
{
    public class MailController : MailerBase
    {
        public EmailResult OrderMail(OrderMailModel model)
        {
            //To.Add(model.Order.Email);
            //To.Add("k.oznuriren@gmail.com");
            To.Add("noreply@ichigocake.com");
            From = "noreply@ichigocake.com";
            Subject = "Welcome to My Cool Site!";
            return Email("OrderMail", model);
        }

        public EmailResult MessageMail(MailModel model)
        {
            //To.Add(model.Email);
            //To.Add("k.oznuriren@gmail.com");
            To.Add("noreply@ichigocake.com");
            From = "noreply@ichigocake.com";
            Subject = model.Subject;
            return Email("MessageMail", model);
        }

        public EmailResult CustomerMessageNotificationMail(MailModel model)
        {
            To.Add(model.Email);
            //To.Add("k.oznuriren@gmail.com");
            From = "noreply@ichigocake.com";
            Subject = "Mesajınız Bize Ulaştı";
            return Email("CustomerMessageNotification", model);
        }

        public EmailResult CustomerOrderNotificationMail(OrderMailModel model)
        {
            To.Add(model.Order.Email);
            //To.Add("k.oznuriren@gmail.com");
            From = "noreply@ichigocake.com";
            Subject = "Siparişiniz Bize Ulaştı";
            return Email("CustomerOrderNotification", model);
        }
    }
}