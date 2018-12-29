using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticClassAttributes
{
    class Song
    {
        //These three things are not specific variables associated with the class.
        public string title;
        public string artist;
        public int duration;
        //example of a static variable
        //where the value is associated with the class itself
        public static int songCount = 0;

        public Song(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            //for each new song, add 1 to the sound count
            songCount++;
        }

        //by creating a new method to return the songCount, each song can now call the songCount method
        public int getSongCount()
        {
            return songCount;
        }
    }
}
