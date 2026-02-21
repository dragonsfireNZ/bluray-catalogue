using System;
using System.Collections.Generic;

namespace BlurayApp.Core.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Barcode { get; set; }
        public int TmdbId { get; set; }
        public string Overview { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double Rating { get; set; }
        public string PosterPath { get; set; }
        public List<string> Genres { get; set; }
        public string Director { get; set; }
        public int Runtime { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime LastModified { get; set; }
    }
}