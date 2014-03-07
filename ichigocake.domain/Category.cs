using ichigocake.domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ichigocake.domain
{
    public class Category : AuditEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
