using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcModel
{
    class Picture
    {
        public Guid IDPic { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string picture { get; set; }

        public virtual ICollection<Product> products { get; set; }
        public virtual ICollection<News> news { get; set; }
        public virtual ICollection<User> user { get; set; }
        public virtual ICollection<PictureType> pictureTypes { get; set; }
    }
}
