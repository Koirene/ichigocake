using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ichigocake.web.Models.MailModels
{
    public class MailModel
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string Phone { get; set; }
    }

    public class OrderMailModel
    {
        public OrderModel Order { get; set; }
    }

}