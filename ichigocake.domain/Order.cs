using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ichigocake.domain.Base;

namespace ichigocake.domain
{
    public class Order : AuditEntity
    {
        public virtual User User { get; set; }
        public IList<CakeOrder> CakeOrders { get; set; }
        public virtual Delivery Delivery { get; set; }
        public string Address { get; set; }
        public double TotalAmount { get; set; }
        public DateTime RequestedDateTime { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

    }

    public class CakeOrder
    {
        public int Id { get; set; }     
        public Cake Cake { get; set; }
        public int Amount { get; set; }
    }
}
