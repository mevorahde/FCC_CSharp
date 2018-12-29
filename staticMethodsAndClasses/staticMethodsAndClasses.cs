using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticMethodsAndClasses
{
    class staticMethodsAndClasses
    {
        static void Main(string[] args)
        {
            //Static methods are methods that belong with the class and you are able to use without having to create an instance of the method
            //The math method below is an example of that
            Console.WriteLine(Math.Sqrt(144));

            //Example of when a created static method that prints a message with a parm, you can just call that method.
            UsefulTools.SayHi("David");

            //Now that the UsefulTools method is associated with a class that is now static, a new instance cannot be created. Notice the error when the line below is uncommented.
            //UsefulTools tools = new UsefulTools();


            Console.ReadLine();
        }
    }
}
