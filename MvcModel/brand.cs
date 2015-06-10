using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcModel
{
    class Brand
    {
        public Guid ID { get; set; }
        public string name { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Product> products { get; set; }
        public virtual ICollection<Store> stores { get; set; }
    }
}
