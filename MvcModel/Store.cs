using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcModel
{
    class Store
    {
        public Guid ID { get; set; }
        public int IDBrand { get; set; }
        public int count { get; set; }

        public virtual ICollection<Brand> brands { get; set; }
        public virtual ICollection<Product> products { get; set; }
        public virtual StoreType storeTypes { get; set; }
    }
}
