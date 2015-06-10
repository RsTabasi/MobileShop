using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcModel.TypeNews
{
    class typeNews
    {
        public Guid IDTypeNews { get; set; }
        public string Type { get; set; }

        public virtual ICollection<News.news> news { get; set; }
    }
}
