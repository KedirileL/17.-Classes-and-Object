using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Classes_and_Object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book(); //creation of the book1 object, it gets all the attributes of the Book class

            //Create the first book
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;

            //Create a second book
            Book book2 = new Book();
            book2.title = "Lord of the Ring";
            book2.author = "Tolkein";
            book2.pages = 900;

            //Creation of a third book
            Book book3 = new Book();
            book3.title = "Find you peace and hold it hostage";
            book3.author = "KLE Ledwaba";
            book3.pages = 25;

            Console.WriteLine(book1.title);
            Console.WriteLine(book2.title);
            Console.WriteLine(book1.author);

            //freeze
            Console.ReadLine();

        }
    }
}
