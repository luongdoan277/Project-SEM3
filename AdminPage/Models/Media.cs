using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPage.Models
{
    public class Media
    {
        public int MediaID { get; set; }
        public string url { get; set; }
        public int ShopID { get; set; }
        public int MovieID { get; set; }
        public virtual Shop Shops { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
