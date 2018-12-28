using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionHandling
{
    class exceptionHandling
    {
        static void Main(string[] args)
        {
            //an example of a try/catch
            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }
            //examples that you can multiple catch blocks for specific exceptions. 
            //Also you can pass in specific exceptions as a parm and then call the error message that occurs.
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Error: " + e.Message);
                Console.WriteLine("Please enter a number other than zero.");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error: " + e.Message);
                Console.WriteLine("Please enter numbers only.");
            }


            Console.ReadLine();

        }
    }
}
