using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomePage.Models.ViewModels
{
    public class ContentListViewModel
    {
        public IEnumerable<Movie> Movies { get; set; }

        public IEnumerable<Category> Categories { get; set; }

        public IEnumerable<Media> Medias { get; set; }

        public IEnumerable<Product> Products { get; set; }

        public IEnumerable<Shop> Shops { get; set; }

    }
}
