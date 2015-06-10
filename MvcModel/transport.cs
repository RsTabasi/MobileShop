using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcModel
{
    class Transport
    {
        public Guid ID { get; set; }
        public string name { get; set; }
        public string address { get; set; }

        public virtual ICollection<StoreType> storeTypes { get; set; }
    }
}
