using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using ichigocake.domain.Base;

namespace ichigocake.domain
{
    public class Message : AuditEntity
    {
        public virtual User User { get; set; }
        public string Type { get; set; }
        public string Subject { get; set; }
        public string MessageContent { get; set; }
    }
}
