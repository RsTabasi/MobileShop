using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcModel.Comment
{
    class comment
    {
        public virtual ICollection<Users.user> user { get; set; }
    }
}
