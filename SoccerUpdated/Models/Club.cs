﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoccerUpdated.Models
{
    public class Club
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public League League { get; set; }
        public IList<Players> Players { get; set; }
        public string Sponsor { get; set; }
    }
}