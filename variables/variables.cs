using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virables
{
    class variables
    {
        static void Main(string[] args)
        {
            //  Create variables as an example to use in the story
            string characterName = "John";
            int characterAge = 35;

            //replaced the static text with the variable names
            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");
            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But didn't like being " + characterAge);

            Console.ReadLine();
        }
    }
}
