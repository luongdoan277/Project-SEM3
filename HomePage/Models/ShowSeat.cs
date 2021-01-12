using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HomePage.Models
{
    public class ShowSeat
    {
        public int ShowSeatID { get; set; }
        public int Status { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public decimal Price { get; set; }
        public int ShowID { get; set; }
        public int CinemaSeatID { get; set; }
        public int BookingID { get; set; }
        public virtual Show Shows { get; set; }
        public virtual CinemaSeat CinemaSeat { get; set; }
        public virtual ICollection<Booking> Booking { get; set; }
    }
}
