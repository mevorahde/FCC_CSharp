using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buildingABetterCalculator
{
    class buildingABetterCalculator
    {
        static void Main(string[] args)
        {
            //Prompt the user to enter a number
            Console.Write("Enter a number: ");
            //read the line and assign it to the double variable num1
            double num1 = Convert.ToDouble(Console.ReadLine());

            //Prompt the user to enter an operator
            Console.Write("Enter an operator:");
            string op = Console.ReadLine();

            //Prompt the user to enter another number
            Console.Write("Enter another number: ");
            //read the line and assign it to the double variable num2
            double num2 = Convert.ToDouble(Console.ReadLine());

            //if the user enters a + operator, add the two numbers
            if (op == "+")
            {
                Console.WriteLine("Your answer is: " + (num1 + num2));
            }
            // if the user enters the - operator, subtract the two numbers
            else if (op == "-")
            {
                Console.WriteLine("Your answer is: " + (num1 - num2));
            }
            //if the user enters the * operator, multiply the two numbers
            else if (op == "*")
            {
                Console.WriteLine("Your answer is: " + (num1 * num2));
            }
            //if the user enters the / operator, divide the two numbers
            else if (op == "/")
            {
                Console.WriteLine("Your answer is: " + (num1 / num2));
            }
            //If the user enters any other type of operator
            else
            {
                Console.WriteLine("Invalid Operator");
            }

            Console.ReadLine();
        }
    }
}
