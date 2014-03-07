using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ichigocake.domain.Base;

namespace ichigocake.domain
{
    public class Comment : AuditEntity
    {
        public virtual User User { get; set; }
        public virtual Reference Reference { get; set; }
        public virtual Cake Cake { get; set; }
        public string Note { get; set; }
    }
}
