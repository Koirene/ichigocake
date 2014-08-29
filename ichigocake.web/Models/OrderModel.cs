using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ichigocake.domain;

namespace ichigocake.web.Models
{
    public class OrderModel
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public double TotalAmount { get; set; }
        public string RequestedDate { get; set; }
        public string RequestedTime { get; set; }
        public Cake Cake { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}