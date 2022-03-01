using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesTutorial
{
    class Movie
    {
        //public is open to the rest of the program
        //private means only the class MOVIE can access the property

        public string title;
        public string director;
        private string rating;

        public Movie(string _title,string _director, string _rating)
        {
            title = _title;
            director = _director;
            Rating = _rating;
        }

        //these are getters and setters to have access to private attributes
        public string Rating
        {
            //getter and setter allow custom rules to get and set values into our class property. 
            get { return rating; }
            set {
                if (value =="G" ||  value =="PG" || value == "PG-13" || value =="R")
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
