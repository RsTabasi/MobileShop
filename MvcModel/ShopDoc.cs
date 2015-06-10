using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcModel
{
    class ShopDoc
    {
        public Guid ID { get; set; }
        public int userId { get; set; }
        public int productId { get; set; }
        public double price { get; set; }
        public double postPrice { get; set; }

        public virtual ICollection<User> users { get; set; }
        public virtual Post posts { get; set; }
        public virtual Transaction transactions { get; set; }
    }
}
