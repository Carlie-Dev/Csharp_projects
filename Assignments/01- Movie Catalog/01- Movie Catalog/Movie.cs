using System;
using System.Collections.Generic;
using System.Text;

namespace _01__Movie_Catalog
{
    internal class Movie
    {
        private string title;
        private string releaseDate;
        private int timesWatched;

        //getters and setters. Publically accessable variables
        public string Title { get { return title; } set {title = value; } }
        public string ReleaseDate { get { return releaseDate; } set { releaseDate = value; } }
        public int TimesWatched { get { return timesWatched; } set { timesWatched = value; } }

        //default movie constructor
        public Movie() { }
        //constructor
        public Movie(string _title, string _releaseDate) {
            this. title = _title;
            this. releaseDate = _releaseDate;
            this.timesWatched = 0;
        }

        //movie watch function
        public void WatchMovie()
        {
            //increase times watched by 1
            timesWatched++;
        }

        public override string ToString()
        {
            if (timesWatched == 1)
            {
                return $"{title} ({releaseDate}) - Watched {timesWatched} time.";
            }
            return $"{title} ({releaseDate}) - Watched {timesWatched} times.";
        }
        
    }
}
