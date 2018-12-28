using System;
using System.Collections.Generic;
using System.Text;

namespace gettersAndSetters
{
    class Movie
    {
        public string title;
        public string director;
        //make the rating defined value private
        private string rating;

        //Create a movie class with the defined values of a title, director, and a rating
        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating;
        }

        //create a method for the get and set values for rating
        //notice it is public
        public string Rating
        {
            //get the initial rating when a movie is created from the rating value
            get { return rating; }
            //If the values are a legit rating, set rating to it, otherwise set it to NR.
            set
            {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }
    }
}
