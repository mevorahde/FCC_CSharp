using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticClassAttributes
{
    class staticClassAttributes
    {
        static void Main(string[] args)
        {
            //Add a first song
            Song holiday = new Song("Holiday", "Green Day", 200);
            //see what the sound count is after creating a song
            Console.WriteLine(Song.songCount);
            //Add a second song
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
            //see what the sound count is after creating a second song
            Console.WriteLine(Song.songCount);

            //example that an individual song can now call the get sound count method
            Console.WriteLine(kashmir.getSongCount());

            Console.ReadLine();
        }
    }
}
