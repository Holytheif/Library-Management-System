using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public abstract class Library
    {
        public abstract string UserType { get; set; }
        public abstract string Username { get; set; }
        public abstract string Password { get; set; }

        public abstract void Login();
        public abstract void Logout();
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User() { Username = "Risabh", Password = "RISABH_PASSWORD" };
            user.Login();
            Console.WriteLine();

            Librarian librarian = new Librarian() { Username = "Vipin", Password = "VIPIN_PASSWORD" };
            librarian.Login();
            Console.WriteLine();

            LibraryDatabase database = new LibraryDatabase();

            Book book1 = new Book("The Canterville Ghost", "Oscar Wilde", "83628193", "Penguin Publications");
            Book book2 = new Book("Gulliver's Travels", "Jonathon Swift", "72534618", "Sun Publications");
            Book book3 = new Book("The Intelligent Investor", "Benjamin Graham", "12353532", "Bloomberg");

            database.AddBook(book1);
            database.AddBook(book2);
            database.AddBook(book3);

            Account userAccount = new Account(user);

            bool showMenu = true;
            while(showMenu){
                Console.WriteLine("");
                Console.WriteLine("________________________________");
                Console.WriteLine("1. Issue Book");
                Console.WriteLine("2. Return Book");
                Console.WriteLine("3. Display available books");
                Console.WriteLine("4. Display issued books");
                Console.WriteLine("________________________________");
                Console.WriteLine("");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Enter book title: ");
                        string title = Console.ReadLine();
                        Book B = database.books.Find(b => b.Title == title);
                        userAccount.IssueBook(B, librarian);
                        Console.Clear();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Enter book title: ");
                        title = Console.ReadLine();
                        B = database.books.Find(b => b.Title == title);
                        userAccount.ReturnBook(B, librarian);
                        Console.Clear();
                        break;
                    case "3":
                        Console.Clear();
                        database.DisplayBooks();
                        break;
                    case "4":
                        Console.Clear();
                        userAccount.ShowIssuedBooks();
                        break;
                    default:
                        showMenu = false;
                        break;
                }
            }
        }
    }
}
