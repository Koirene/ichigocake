using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ichigocake.web.Models
{
    public class OrderModel
    {
        //public virtual User User { get; set; }
        //public IList<CakeOrder> CakeOrders { get; set; }
        //public virtual Category Category { get; set; }
        //public virtual Delivery Delivery { get; set; }
        public string Address { get; set; }
        public double TotalAmount { get; set; }
        public DateTime RequestedDateTime { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}