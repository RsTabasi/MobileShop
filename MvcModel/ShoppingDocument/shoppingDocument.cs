using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcModel.ShoppingDocument
{
    class shoppingDocument
    {
        public virtual DocumentSales.documentSale documentSale { get; set; }
        public virtual Transaction.transaction transaction { get; set; }

    }
}
