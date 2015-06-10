using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcModel
{
    class Transaction
    {
        public Guid ID { get; set; }
        public string numbre { get; set; }
        public DateTime date { get; set; }
        public DateTime time { get; set; }

        public virtual ShopDoc shopDocs { get; set; }
        public virtual Bank banks { get; set; }
    }
}
