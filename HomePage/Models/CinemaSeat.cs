using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomePage.Models
{
    public class CinemaSeat
    {
        public int CinemaSeatID { get; set; }
        public string SeatNumber { get; set; }
        public int Type { get; set; }
        public int CinemaHallID { get; set; }
        public virtual CinemaHall CinemaHall { get; set; }
    }
    public class ListSeat
    {
        public List<CinemaSeat> Items { get; set; } = new List<CinemaSeat>();
        public void CheckboxAdd(CinemaSeat seat)
        {
            CinemaSeat item = seat;
            Items.Add(item);
        }
        public void CheckboxRemove(CinemaSeat seat)
        {
            CinemaSeat item = seat;
            Items.RemoveAll(i => i.CinemaSeatID == seat.CinemaSeatID);
        }
    }
}
