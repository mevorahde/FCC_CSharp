using System;

namespace switchStatements
{
    class switchStatements
    {
        static void Main(string[] args)
        {
            //print out the GetDay method with the passing parm of 0.
            Console.WriteLine("The day you have chosen is: " + GetDay(0));
            //print out the GetDay method with the passing parm of 4.
            Console.WriteLine("The day you have chosen is: " + GetDay(4));
            //Invalid number
            Console.WriteLine("The day you have chosen is: " + GetDay(49));
            Console.ReadLine();
        }

        //Create a method that will return a string value of the day of the week, passing one int parm.
        static string GetDay(int dayNum)
        {
            //Create a variable for the name of the days of the weeks
            string dayName;

            //switch statements, 0-7 for the days of the week and set the dayName variable accordingly
            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid Day Number";
                    break;
            }
            //return the dayName based on the case in the switch
            return dayName;
        }
    }
}
