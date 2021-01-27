using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PageAdmin.Models
{
    public class Media
    {
        public int MediaID { get; set; }
        public string Url { get; set; }
        public int? ShopID { get; set; }
        public int? MovieID { get; set; }
        public int? ProductID { get; set; }
        public virtual Shop Shops { get; set; }
        public virtual Movie Movie { get; set; }
        public virtual Product Product { get; set; }
    }
}
