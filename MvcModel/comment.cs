using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcModel
{
    class Comment
    {
        public Guid ID { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string body { get; set; }
        public virtual News news { get; set; }
        public virtual User users { get; set; }
    }
}
