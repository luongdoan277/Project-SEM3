using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPage.Models
{
    public class Shop
    {
        public int ShopID { get; set; }
        public string ShopName { get; set; }
        public string ShopLocation { get; set; }
        public string ShopOpenTime { get; set; }
        public string ShopContact { get; set; }
        public int CategoryID { get; set; }
        public string ShopAbout { get; set; }

        public virtual Category Categories { get; set; }
        public virtual ICollection<Media> Medias { get; set; }
    }
}
