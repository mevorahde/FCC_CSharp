using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buildingACalculator
{
    class buildingACalculator
    {
        static void Main(string[] args)
        {
            //example on how to convert a string to an int
            //note this would only work when giving a number string parm
            //int num = Convert.ToInt32("45");
            //Console.WriteLine(num + 6);

            //Ask the user to enter a number
            Console.Write("Enter a number: ");
            //convert it to double as they could enter a integer or a decimal and set to the variable num1
            double num1 = Convert.ToDouble(Console.ReadLine());

            //Ask the user to enter another number
            Console.Write("Enter another number: ");
            //convert it to double as they could enter a integer or a decimal and set to the variable num2
            double num2 = Convert.ToDouble(Console.ReadLine());

            //The user sees the result statement that includes the sum of their two numbers.
            Console.WriteLine("The sum of your two numbers is: " + (num1 + num2));

            Console.ReadLine();
        }
    }
}
