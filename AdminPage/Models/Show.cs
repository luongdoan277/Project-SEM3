﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPage.Models
{
    public class Show
    {
        public int ShowID { get; set; }
        public DateTime Date { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int CinemaHellID { get; set; }
        public int MovieID { get; set; }
        public virtual CinemaHell CinemaHell { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
