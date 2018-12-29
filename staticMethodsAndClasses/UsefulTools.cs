using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticMethodsAndClasses
{
    //There are some cases where you'd want to create a new instance of a static method, however to make it so a new instance cannot be created, make the class static as well
    static class UsefulTools
    {
        //Creation of a static method.
        public static void SayHi(string name)
        {
            Console.Write("Hello " + name);
        }
    }
}
