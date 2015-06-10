using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcModel
{
    class PictureType
    {
        public Guid ID { get; set; }
        public string type { get; set; }

        public virtual Picture pictures { get; set; }
    }
}
