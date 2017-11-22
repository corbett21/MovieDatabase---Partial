using System;
using System.Collections.Generic;

namespace MovieDatabase.Models
{
    public enum Genre { comedy, drama, action, fiction, horror, romance, sciFi,
                        western, family}
    public class Movie
    {
        public List<Genre> Genre { get; set; }
        public List<string> Actor { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public int durationInMins { get; set; }
        public double budgetInDollars { get; set; }
        public int movieRating { get; set; }
        public string URL { get; set; }

        public Movie()
        {
            Title = "";
            Year = 0;
            Director = "";
            durationInMins = 0;
            budgetInDollars = 0.0;
            movieRating = 0;
            URL = "";
            Actor = new List<String>();
            Genre = new List<Genre>();

        }
        // declare the movie properties and a constructor to initialise a blank movie
    
    }

}
