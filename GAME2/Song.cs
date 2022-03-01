using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesTutorial
{
    class Song
    {
        public string title;
        public string author;
        public float rating;
        public int duration;

        //static variable can be used to know how many songs have been created.
        // to use it instead of calling the attribute of the object, you call the attribute of the class
        // SONG.SongCount

        // static class attributes can only be accessed through the class name 
        public static int songCount = 0;



        //constructor method with no parameters
        public Song()
        {
            title = "default song";
            author = "default author";
            rating = 3.0f;
            duration = 300;
            songCount++; 
            //adds one to the count if we use this constructor
        }
        
        //constructor method with multiple parameters.
        public Song(string _title, string _author, float _rating, int _duration)
        {
            title = _title;
            author = _author;
            rating = _rating;
            duration = _duration;
            songCount++;
            //adds one more to the object count of the class;

        }

    }
}
