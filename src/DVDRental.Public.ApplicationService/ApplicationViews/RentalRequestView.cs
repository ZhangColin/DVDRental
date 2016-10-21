﻿using System;

namespace DVDRental.Public.ApplicationService.ApplicationViews
{
    public class RentalRequestView
    {
        //public int Id { get; set; }
        public int FilmId { get; set; }
        public int SubscriptionId { get; set; }
        public DateTime Requested { get; set; }
        public bool CanBeRemovedFromList { get; set; }
        public string SubscriptionIdString { get; set; }
        public string FilmTitle { get; set; }
    }
}