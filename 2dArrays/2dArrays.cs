using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2dArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] numberGrid =
            {
                {1, 2 },
                {3, 4 },
                {5, 6 }
            };

            //calling and printing array/row 0, array/column 0
            Console.WriteLine(numberGrid[0, 0]);

            //calling and printing array/row 2, array/column 2
            Console.WriteLine(numberGrid[1, 1]);

            //create an blank 2d array, not sure of the values at this time example
            //This would be 2 row, 3 column array
            int[,] myArray = new int[2, 3];

            Console.ReadLine();
        }
    }
}
