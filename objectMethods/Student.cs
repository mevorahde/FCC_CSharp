using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectMethods
{
    class Student
    {
        public string name;
        public string major;
        public double gpa;

        public Student(string aName, string aMajor, double aGpa)
        {
            name = aName;
            major = aMajor;
            gpa = aGpa;
        }

        //Create a method to check if a student is in the honor roll.
        public bool HasHonors()
        {
            //if a student's GPA is greater than 3.5, they are on the honor roll.
            if (gpa >= 3.5)
            {
                return true;
            }
            return false;
        }

    }
}
