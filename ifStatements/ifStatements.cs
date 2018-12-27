using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifStatements
{
    class ifStatements
    {
        static void Main(string[] args)
        {
            //Create a boolean variable to give a if/else statment example
            bool isMale = true;
            bool isTall = false;

            //if isMale and isTall is true
            if(isMale && isTall)
            {
                Console.WriteLine("You are a tall male");
            }
            //if isMale is true and isTall is false
            else if (isMale && !isTall)
            {
                Console.WriteLine("You are a short male");
            }
            //if isMale is false and isTall is true
            else if (isMale && !isTall)
            {
                Console.WriteLine("You are not male but you are tall");
            }
            //if isMale or isTall is true
            else if (isMale || isTall)
            {
                Console.WriteLine("You are either a male or tall");
            }
            //else if isMale and isTall is false
            else
            {
                Console.WriteLine("You are not male and not tall");
            }

            Console.ReadLine();
        }
    }
}
