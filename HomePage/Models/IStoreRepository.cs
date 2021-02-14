using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomePage.Models
{
    public interface IStoreRepository
    {
        IQueryable<Movie> Movies { get; }
        IQueryable<Product> Products { get; }
        IQueryable<Media> Medias { get; }
        IQueryable<Show> Shows { get; }

        IQueryable<CinemaSeat> CinemaSeats { get; }
        IQueryable<Category> Categories { get; }
        IQueryable<Shop> Shops { get; }
        IQueryable<Feedback> Feedbacks { get; }
    }
}
