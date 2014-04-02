using ichigocake.domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ichigocake.domain.Content;

namespace ichigocake.domain
{
    public class Category : AuditEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual Image Image { get; set; }
        public int MaxDaytoOrder { get; set; }
    }
}
