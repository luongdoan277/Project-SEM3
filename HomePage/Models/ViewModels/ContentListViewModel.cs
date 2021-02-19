using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomePage.Models.ViewModels
{
    public class ContentListViewModel
    {
        public IEnumerable<Movie> Movies { get; set; }
        public IEnumerable<CinemaSeat> CinemaSeats { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Media> Medias { get; set; }
        public IEnumerable<Show> Shows { get; set; }
        public IEnumerable<ShowSeat> ShowSeats { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Shop> Shops { get; set; }
        public IEnumerable<Feedback> Feedbacks { get; set; }
        public decimal Price { get; set; }
        public int Basic { get; set; }
        public int Vip { get; set; }
        public int Couple { get; set; }
    }
}
