using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ichigocake.domain
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }

        [StringLength(256)]
        public string RoleName { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
