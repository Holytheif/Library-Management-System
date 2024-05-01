using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class User : Library
    {
        public override string UserType { get; set; }
        public override string Username { get; set; }
        public override string Password { get; set; }

        public User()
        {
            UserType = "User";
        }
        public override void Login()
        {
            Console.WriteLine($"Login Successful for {UserType}: {Username}");
        }

        public override void Logout()
        {
            Console.WriteLine($"Logging Out: {Username}");
        }
        ~User()
        {
            Logout();
        }
    }

    public class Account : User
    {
        public int NoOfBorrowedBooks { get; set; }
        public int NoOfLostBooks { get; set; }
        public int NoOfReturnedBooks { get; set; }
        public int fineAmount { get; set; }
        public List<Book> BorrowedBooks { get; set; }

        public Account()
        {
            NoOfBorrowedBooks = 0;
            NoOfLostBooks = 0;
            NoOfReturnedBooks = 0;
            fineAmount = 0;
            BorrowedBooks = new List<Book>();
        }
        public Account(User user) : this()
        {
            base.Username = user.Username;
            base.Password = user.Password;
        }

        public void IssueBook(Book book, Librarian librarian) {
            librarian.IssueBook(book, this);
        }
        public void ReturnBook(Book book, Librarian librarian) {
            librarian.ReturnBook(book, this);
        }
        public void ReportLostBook() { }
        
        public void ShowIssuedBooks() {
            Console.WriteLine();
            Console.Write($"Total Books Borrowed by user {Username} are: ");
            Console.WriteLine(NoOfBorrowedBooks);
            Console.WriteLine($"List of Books Borrowed by user {Username} are: ");
            foreach (Book book in BorrowedBooks)
            {
                Console.WriteLine();
                Console.WriteLine($"Title: {book.Title}");
                Console.WriteLine($"Author: {book.Author}");
                Console.WriteLine($"Publication: {book.Publication}");
                Console.WriteLine($"ISBN: {book.ISBN}");
                Console.WriteLine();
                Console.WriteLine("//////////////////////////////////");
            }
        }

    }
}
