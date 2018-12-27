using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buildingAMadLibGame
{
    class buildingAMadLibGame
    {
        static void Main(string[] args)
        {
            //declare variables for the madlib game
            string color, pluralNoun, celebrity;

            //Ask the user for a color
            Console.Write("Enter a color: ");
            //read the line and store it in the color variable
            color = Console.ReadLine();
            //Ask the user for a plural noun
            Console.Write("Enter a pluralNoun: ");
            //read the line and store it in the pluralNoun variable
            pluralNoun = Console.ReadLine();
            //Ask the user for a celebrity
            Console.Write("Enter a celebrity: ");
            //read the line and store it in the celebrity variable
            celebrity = Console.ReadLine();

            //Update the writeline statements to include the variables from the users input
            Console.WriteLine();
            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I love " + celebrity);

            Console.ReadLine();
        }
    }
}
