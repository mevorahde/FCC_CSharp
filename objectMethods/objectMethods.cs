using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectMethods
{
    class objectMethods
    {
        static void Main(string[] args)
        {
            //create two new students
            Student student1 = new Student("Jim", "Business", 2.8);
            Student student2 = new Student("Pam", "Art", 3.6);

            //by creating the honor roll method, we can pass each individual student's GPA into the honor roll method.
            Console.WriteLine(student1.name + " is a honor student? " + student1.HasHonors());
            Console.WriteLine(student2.name + " is a honor student? " + student2.HasHonors());

            Console.ReadLine();
        }
    }
}
