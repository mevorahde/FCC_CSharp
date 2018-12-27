using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace returnStatement
{
    class returnStatment
    {
        static void Main(string[] args)
        {
            //call and print the Cube method with the parm of 3
            Console.WriteLine(Cube(3));

            //Another example to show the the Cube method returns the result number
            int cubedNumber = Cube(5);
            Console.WriteLine(cubedNumber);


            Console.ReadLine();

        }

        //Create a new method that will return an int value, thus static int
        //Passing the parm, num
        static int Cube(int num)
        {
            // cube the parm num and return the result
            int result = num * num * num;
            return result;

        }
    }
}
