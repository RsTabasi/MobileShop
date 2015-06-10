using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcModel.Pictuers
{
    class Picture
    {
        public Guid IDPic { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Products.product> product { get; set; }
        public virtual ICollection<News.news> news { get; set; }
        public virtual ICollection<Users.user> user { get; set; }
        public virtual ICollection<TypePictures.typePicture> typePicture { get; set; }
    }
}
