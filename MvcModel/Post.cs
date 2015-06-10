using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcModel
{
    class Post
    {
        public Guid ID { get; set; }
        public string name { get; set; }
        public string address { get; set; }

        public virtual ICollection<ShopDoc> shopDocs { get; set; }
    }
}
