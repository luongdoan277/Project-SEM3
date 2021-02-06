using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomePage.Models
{
    public class Media
    {
        public int MediaID { get; set; }
        public string Url { get; set; }
        public int? ShopID { get; set; }
        public int? MovieID { get; set; }
        public int? ProductID { get; set; }
        public virtual Shop Shops { get; set; }
        public virtual Movie Movies { get; set; }
        public virtual Product Products { get; set; }
    }
}
