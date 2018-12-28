using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buildingAExponentMethod
{
    class buildingAExponentMethod
    {
        static void Main(string[] args)
        {
            //call and print the GetPow method and pass the two number you want to set for the base number and power number.
            Console.WriteLine(GetPow(9, 2));
            Console.ReadLine();
        }

        //Create a method, passing two variables, the base number and the power number
        static int GetPow(int baseNum, int powNum)
        {
            //set the variable result to 1
            int result = 1;
            //for as long as i is less than the power number, keep looping through, adding 1 to i each time you loop through
            for (int i = 0; i < powNum; i++)
            {
                //have result time the baseNum and set it to the variable result.
                //this will keep looping as long as i is less than the power number.
                result = result * baseNum;
            }
            //return the final result
            return result;

        }
    }
}
