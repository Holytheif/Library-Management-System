using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class LibraryDatabase
    {
        public List<Book> books = new List<Book> ();
        public void AddBook(Book book)
        {
            books.Add((Book)book);
        }
        public void RemoveBook(Book book)
        {
            books.Remove((Book)book);
        }
        public void DisplayBooks()
        {
            Console.WriteLine("The books available in the library are: ");
            Console.WriteLine();
            foreach (Book book in books) { 
                Console.WriteLine($"Title: {book.Title}");
                Console.WriteLine($"Author: {book.Author}");
                Console.WriteLine($"Publication: {book.Publication}");
                Console.WriteLine($"ISBN: {book.ISBN}");
                Console.WriteLine("----------------------------------");
            }
        }
    }
}
