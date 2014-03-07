using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ichigocake.domain.Base
{
    public class AuditEntity : Entity
    {
        public virtual int? CreatedBy { get; set; }
        public virtual int? LastModifiedBy { get; set; }
        public virtual DateTime? CreatedDate { get; set; }
        public virtual DateTime? LastModifiedDate { get; set; }

        public virtual byte[] TimeStamp { get; set; }
    }
}
