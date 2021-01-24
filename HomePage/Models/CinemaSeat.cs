using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomePage.Models
{
    public class CinemaSeat
    {
        public int CinemaSeatID { get; set; }
        public String SeatNumber { get; set; }
        public int Type { get; set; }
        public int CinemaHallID { get; set; }
        public virtual CinemaHell CinemaHell { get; set; }
    }
}
