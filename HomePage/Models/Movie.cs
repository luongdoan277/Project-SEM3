﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomePage.Models
{
    public class Movie
    {
        public int MovieID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        //Thời lượng
        public string Duration { get; set; }
        public string Language { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Country { get; set; }
        public string Genre { get; set; }
    }
}
