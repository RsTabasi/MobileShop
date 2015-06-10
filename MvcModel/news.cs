using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcModel
{
    class News
    {
        public Guid IDNews { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime Date { get; set; }
        public string Auther { get; set; }
        public string Reference { get; set; }

        public virtual ICollection<NewsType> newsTypes { get; set; }
        public virtual ICollection<Comment> comments { get; set; }
     }
}
