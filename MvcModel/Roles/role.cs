using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcModel.Roles
{
    class role
    {
        public Guid IDRole { get; set; }
        public string Role { get; set; }

        public virtual ICollection<Users.user> users { get; set; }
    }
}
