using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ichigocake.domain.Base;
using ichigocake.domain.Content;

namespace ichigocake.domain
{
    public class Cake : AuditEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<Image> CakeImages { get; set; }
        public bool IsDecorative { get; set; }
        public double PiePrice { get; set; }
    }
}
