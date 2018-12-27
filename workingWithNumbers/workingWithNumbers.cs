using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workingWithNumbers
{
    class workingWithNumbers
    {
        static void Main(string[] args)
        {
            //write out a number
            Console.WriteLine(-5.783);
            //C# will write the sum instead of actually printing 5 + 8
            Console.WriteLine(5 + 8);
            //same with subtraction
            Console.WriteLine(5 - 8);
            //example for division
            Console.WriteLine(5 / 8);
            //example for multiplication 
            Console.WriteLine(5 * 8);
            //example of a modulus
            Console.WriteLine(5 % 2);
            //order of operation example
            Console.WriteLine((4 + 2)*3);
            //add two decmials, you will get a decimal
            Console.WriteLine(5.0 + 8.1);
            //add one decmial and one integer, you will get a decimal
            Console.WriteLine(5.0 + 8.1);
            //two integers, you will get a intger
            Console.WriteLine(5 / 2);
            //one decmial and one integer, you will get a decimal
            Console.WriteLine(5 / 2.0);
            //example that a variable can store a number and print the variable
            int num = 6;
            //adding one to a variable
            num++;
            //subtracting one to a variable
            num--;
            Console.WriteLine(num);

            //example of the some math methods
            //example of absolute value
            Console.WriteLine(Math.Abs(-40));
            //example of to the power of the parms
            Console.WriteLine(Math.Pow(3,2));
            //example of square root
            Console.WriteLine(Math.Sqrt(36));
            //example of max, gives the bigger number between two parms
            Console.WriteLine(Math.Max(4,90));
            //example of min, gives the lesser number between two parms
            Console.WriteLine(Math.Min(4, 90));
            //example of round, rounding numbers by standard rounding rules
            Console.WriteLine(Math.Round(4.9));

            Console.ReadLine();
        }
    }
}
