using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcModel
{
    class Role
    {
        public Guid IDRole { get; set; }
        public string RoleType { get; set; }

        public virtual ICollection<User> users { get; set; }
    }
}
