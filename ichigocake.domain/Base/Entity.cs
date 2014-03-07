using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ichigocake.domain.Base
{
    public class Entity
    {
        public virtual int Id
        {
            get;
            set;
        }

        public virtual bool IsTransient()
        {
            return Id == default(int);
        }
    }
}
