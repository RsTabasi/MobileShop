using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcModel
{
    class StoreType
    {
        public Guid ID { get; set; }
        public string name { get; set; }
        public string address { get; set; }

        public virtual Store storehoses { get; set; }
        public virtual ICollection<Transport> transports { get; set; }
    }
}
