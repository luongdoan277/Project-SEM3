using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomePage.Models
{
    public class Feedback
    {
        public int FeedbackID { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string NumberPhone { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public DateTime FeedbackDate { get; set; }
    }
}
