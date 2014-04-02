using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ichigocake.domain.Base;
using ichigocake.domain.Lookup;

namespace ichigocake.domain
{
    public class User:AuditEntity
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public City City { get; set; }
        public District District { get; set; }
        public string Password { get; set; }
        public virtual Role Role { get; set; }
    }
}
