using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class methods
    {
        static void Main(string[] args)
        {
            //even though a new method is creating, you still got to call the method in the main method to have it run.
            //Can also call it multiple times
            SayHi("David", 33);
            SayHi("John", 56);
            SayHi("Tom", 12);
            Console.ReadLine();
           
        }

        //An example of creating a new method that just says hello
        //Also an example of passing in a parm
        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + ", you are " + age);
        }
    }
}
