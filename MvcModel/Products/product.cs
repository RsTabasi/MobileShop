using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcModel.Products
{
    class product
    {
        public Guid IDProduct { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }

        public virtual ICollection<StoreHouse.storeHouse> StoreHouse { get; set; }
        public virtual ICollection<Pictuers.Picture> Picture { get; set; }
        public virtual ICollection<Users.user> user { get; set; }
    }
}
