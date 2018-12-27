using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workingWithStrings
{
    class workingWithStrings
    {
        static void Main(string[] args)
        {
            string phrase = "Hi Giraffe Academy";

            //example of a new line
            Console.WriteLine("Giraffe\nAcademy\n");
            //example of a quotation mark
            Console.WriteLine("Giraffe\"Academy\n");
            //example of printing a variable
            Console.WriteLine(phrase);
            //example of concadation
            Console.WriteLine(phrase + ". Am I as cool as you?");
            //example of the length of a phrase
            //.length is a string method
            Console.WriteLine(phrase.Length);
            //example of an uppercase method
            Console.Write(phrase.ToUpper());
            //example of an lowercase method
            Console.Write(phrase.ToLower());
            //example of the contains method to see if something is inside a variable or line
            //This provides a boolean result

            //New line to seperate from the last example
            Console.WriteLine("");
            Console.WriteLine(phrase.Contains("Academy"));
            //index to find the first character
            Console.WriteLine(phrase[0]);
            //index to find the 4th character
            Console.WriteLine(phrase[3]);
            //example to find what index a string is
            //notice the double quote
            Console.WriteLine(phrase.IndexOf("Academy"));
            //example to find what index a character is
            //notice the single quote
            Console.WriteLine(phrase.IndexOf('f'));
            //example of the result when searching for a character that is not in the index
            //result is -1
            Console.WriteLine(phrase.IndexOf('z'));
            //to pull certain sections of a substring, by passing the index value
            Console.WriteLine(phrase.Substring(11));
            //can also have a start and ending index value
            Console.WriteLine(phrase.Substring(11, 3));

            Console.ReadLine();
        }
    }
}
