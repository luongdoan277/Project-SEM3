using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPage.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryImage { get; set; }
        public string CategoryIcon { get; set; }
        public virtual ICollection<Shop> Shops { get; set; }
    }
}
