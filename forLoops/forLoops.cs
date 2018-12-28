using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forLoops
{
    class forLoops
    {
        static void Main(string[] args)
        {
            //example of a while loop
            int i = 1;
            Console.WriteLine("While Loop:");
            while (i <= 5)
            {
                Console.Write(i + "\n");
                i++;
            }



            //using the same logic, an example of a for loop
            Console.WriteLine("For Loop:");
            for (int a = 1; a <= 5; a++)
            {

                Console.Write(a + "\n");
            }

           


            //an example of using a for loop to go through an array
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            Console.WriteLine("Lucky Numbers:");
            for (int l = 0; l < luckyNumbers.Length; l++)
            {
                Console.WriteLine(luckyNumbers[l]);

            }

            Console.ReadLine();

        }
    }
}
