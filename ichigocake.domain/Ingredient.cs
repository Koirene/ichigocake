using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ichigocake.domain.Base;

namespace ichigocake.domain
{
    public class Ingredient : AuditEntity 
    {
        public string Name { get; set; }
    }
}
