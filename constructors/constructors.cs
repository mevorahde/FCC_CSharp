using classAndObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructors
{
    class constructors
    {
        static void Main(string[] args)
        {
            //Example of setting parms and assigning them to defined values for the Book class
            //Then instead of 8 line of manually setting 2 new books, we just have 2 as we are passing in the book values as parms

            //Create first book
            Book book1 = new Book("Harry Potter", "JK Rowling", 400);

            //Create a second book
            Book book2 = new Book("Lord of the Rings", "Tolkein", 700);

            //Book 2 Title
            Console.WriteLine(book2.title);

            Console.ReadLine();
        }
    }
}
