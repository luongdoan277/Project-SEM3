using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomePage.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public int ShopID { get; set; }
        public int ProductLike { get; set; }
        public virtual Shop Shops { get; set; }
    }
}
