﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campsite_Manager.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public string GuestName { get; set; }
        public string Unit { get; set; }
        public string ReservationStart { get; set; }
        public string ReservationEnd { get; set; }
        public int Capacity { get; set; }
    }
}
