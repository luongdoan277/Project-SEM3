using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPage.Models
{
    public class Booking
    {
        public int BookingID { get; set; }
        public int NumberOfSeat { get; set; }
        public DateTime Timestamp { get; set; }
        public int Status { get; set; }
        public int UserBookingID { get; set; }
        public int ShowID { get; set; }
        public virtual UserBooking UserBooking { get; set; }
        public virtual Show Shows { get; set; }
    }
}
