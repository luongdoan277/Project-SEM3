using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPage.Models
{
    public class Payment
    {
        public int PaymentID { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public decimal Amount { get; set; }
        public DateTime Timestamp { get; set; }
        public int PaymentMethod { get; set; }
        public int BookingID { get; set; }
        public virtual Booking Booking { get; set; }
    }
}
