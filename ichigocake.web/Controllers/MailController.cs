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
        public EmailResult OrderMail(ChefOrderMailModel model)
        {
            To.Add(model.Email);
            //To.Add("k.oznuriren@gmail.com");
            From = "noreply@ichigocake.com";
            Subject = "Welcome to My Cool Site!";
            return Email("OrderMail", model);
        }
    }
}