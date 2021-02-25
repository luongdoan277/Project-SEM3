using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PageAdmin.Models.ViewModels
{
    public class BookingListViewModel
    {
        public IEnumerable<Booking> Bookings { get; set; }
        public IEnumerable<ShowSeat> ShowSeats { get; set; }
    }
}
