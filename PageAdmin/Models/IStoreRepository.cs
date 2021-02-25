using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PageAdmin.Models
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
        IQueryable<Movie> Movies { get; }
        IQueryable<Media> Medias { get; }
        IQueryable<Category> Categories { get; }
        IQueryable<Booking> Bookings { get; }
        IQueryable<ShowSeat> ShowSeats { get; }
    }
}
