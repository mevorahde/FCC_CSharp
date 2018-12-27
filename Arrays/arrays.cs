using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class arrays
    {
        static void Main(string[] args)
        {
            //to declare an array, put the [] after the data type
            int[] luckyNumbers = { 4, 8 , 15, 16, 23, 42};
            //create an string array, not knowing the values for the array
            string[] friends = new string[5];
            //example of adding to an array individually
            friends[0] = "Jim";
            friends[1] = "Kelly";

            //example to change an index
            luckyNumbers[1] = 900;
            Console.WriteLine(luckyNumbers[1]);

            //print out the first index in the array
            Console.WriteLine(luckyNumbers[0]);
            //print out the 4th index in the array
            Console.WriteLine(luckyNumbers[3]);
            Console.ReadLine();
        }
    }
}
