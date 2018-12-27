using System;

namespace whileLoops
{
    class whileLoops
    {
        static void Main(string[] args)
        {
            //example of a while loop
            //create a variable and set it to 6
            int index = 6;
            //automatically run the code, then check the while condition
            do
            {
                //print index's value and then add 1 to index
                Console.WriteLine(index);
                index++;
            }
            //When index is less than or equal to 5, loop through the code
            while (index <= 5) ;

            Console.ReadLine();
        }
    }
}
