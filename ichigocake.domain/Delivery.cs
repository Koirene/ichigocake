using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ichigocake.domain.Base;
using ichigocake.domain.Lookup;

namespace ichigocake.domain
{
    public class Delivery : AuditEntity
    {
        public Category Category { get; set; }
        public int MaxDaytoOrder { get; set; }
        public virtual DeliveryArea DeliveryArea { get; set; }
        public double DeliveryPrice { get; set; }
    }

    public class DeliveryArea
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public City City { get; set; }
        public IList<District> Districts { get; set; }

    }
}
