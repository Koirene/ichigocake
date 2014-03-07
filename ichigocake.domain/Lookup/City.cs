using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ichigocake.domain.Lookup
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Code { get; set; }
        public bool IsActive { get; set; }
        public IList<District> Districts { get; set; }
    }
}
