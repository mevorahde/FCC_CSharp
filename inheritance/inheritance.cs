using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class inheritance
    {
        static void Main(string[] args)
        {
            //Create an instance of a new Chef
            Chef chef = new Chef();
            //Call the MakeChicken method that will print that the Chef makes Chicken
            chef.MakeChicken();

            //example that the Italian Chef does indeed inherit the Chef traits
            //Create a new instance of the ItalianChef
            ItalianChef italianChef = new ItalianChef();
            //Call the MakeChicken method that will print that the ItalianChef makes Chicken
            italianChef.MakeChicken();

            //example that you can add unique method on top of inherited methods
            //The Italian chef can make a past dish
            italianChef.MakePasta();
            //While the main Chef cannot make pasta, notice the error when the line below is uncommented
            //chef.MakePasta();

            //example of printing the override method, the Italian Chef making his own special dish
            italianChef.MakeSpecialDish();

            Console.ReadLine();
        }
    }
}
