using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieDB.Models
{
    public class Movie
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Director { get; set; }
        public int ReleaseYear { get; set; }
        public double Rating { get; set; }
    }
}