using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gettingUserInput
{
    class gettingUserInput
    {
        static void Main(string[] args)
        {
            //console.write allows the user to input on the same line
            Console.Write("Enter your name: ");
            //pauses the application to allow the user to enter input, when input is entered, store it to a variable
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            //write a line using the text and the variables from the user input
            Console.WriteLine("Hello " + name + ", you are " + age);

            Console.ReadLine();
        }
    }
}
