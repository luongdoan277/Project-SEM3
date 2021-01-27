using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PageAdmin.Models
{
    public class CinemaSeat
    {
        public int CinemaSeatID { get; set; }
        public string SeatNumber { get; set; }
        public int Type { get; set; }
        public int CinemaHallID { get; set; }
        public virtual CinemaHall CinemaHall { get; set; }
    }
}
