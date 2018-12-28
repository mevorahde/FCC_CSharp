using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classAndObjects
{
    class classesAndObjects
    {
        //Create a book class, Book.cs, to define a book has a title, author, and the number of pages.
        //once book is defined, I can now call it and create a variable, book1 and set the title, author, and number of pages for book1
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;

            //once book1 has values, I can then call and print those values
            Console.WriteLine(book1.title);

            //Create a second book
            Book book2 = new Book();
            book2.title = "Lord of the Rings";
            book2.author = "Tolkein";
            book2.pages = 700;

            //print out the author of book2
            Console.WriteLine(book2.author);

            Console.ReadLine();
        }
    }
}
