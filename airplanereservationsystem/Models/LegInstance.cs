﻿using System;
using System.Collections.Generic;

namespace airplanereservationsystem.Models
{
    public partial class LegInstance
    {
        public string AirplaneId { get; set; }
        public string Date { get; set; }
        public int LegNum { get; set; }
        public int? NoAvailSeats { get; set; }
        public int? RouteNum { get; set; }
        public string Time { get; set; }

        public virtual FlightLeg LegNumNavigation { get; set; }
    }
}
