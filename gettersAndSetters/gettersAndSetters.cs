using System;

namespace gettersAndSetters
{
    class gettersAndSetters
    {
        static void Main(string[] args)
        {
            //create two new movies
            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");

            //now we can call the Rating method to see the rating of a movie.
            Console.WriteLine(avengers.Rating);
            //however, when anything else besides a valid rating is entered, it will now show as NR.
            shrek.Rating = "Dog";
            Console.WriteLine(shrek.Rating);

            Console.ReadLine();
        }
    }
}
