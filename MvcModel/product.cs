using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcModel
{
    class Product
    {
        public Guid IDProduct { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
        public double weight { get; set; }
        public string shortDesc { get; set; }
        public string longDesc { get; set; }
        public DateTime update { get; set; }

        public virtual ICollection<Picture> pictures { get; set; }
        public virtual Brand brands { get; set; }
        public virtual ICollection<Store> stores { get; set; }

    
    }
}
