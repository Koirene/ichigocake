using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ichigocake.domain.Base;
using ichigocake.domain.Content;

namespace ichigocake.domain
{
    public class Reference : AuditEntity
    {
        public string Caption { get; set; }
        public virtual IList<Image> Images { get; set; }
        public string BodyContent { get; set; }
    }
}
