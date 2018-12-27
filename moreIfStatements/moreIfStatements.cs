using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moreIfStatements
{
    class moreIfStatements
    {
        static void Main(string[] args)
        {
            //Call the GetMax method, with three int numbers
            Console.WriteLine("The biggest number is: " + GetMax(2, 10, 49));
            Console.ReadLine();
        }

        //Create a method, with three int parms that compares the numbers and prints out the larger number
        static int GetMax(int num1, int num2, int num3)
        {
            int result;
            //if num1 is greater than num2 and num3, set num1 to the variable result
            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }
            //if num2 is greater than num1 and num3, set num1 to the variable result
            else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            //if num2 is greater than num1, set num2 to the variable result
            else
            {
                result = num3;
            }
            //return the result variable
            return result;
        }
    }
}
