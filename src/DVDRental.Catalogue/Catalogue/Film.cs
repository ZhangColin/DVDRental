﻿using System;

namespace DVDRental.Catalogue.Catalogue
{
    public class Film
    {
        public int Id { get; private set; }
        public DateTime ReleaseDate { get; private set; }
        public string Title { get; set; }
        public string Certification { get; set; }

        public Film(DateTime releaseDate, string title)
        {
            ReleaseDate = releaseDate;
            Title = title;
        }
    }
}