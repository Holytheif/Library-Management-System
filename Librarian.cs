using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class Librarian : Library
    {
        public override string UserType { get; set; }
        public override string Username { get; set; }
        public override string Password { get; set; }

        public Librarian()
        {
            UserType = "Librarian";
        }
        public override void Login()
        {
            Console.WriteLine($"Login Successful for {UserType}: {Username}");
        }

        public override void Logout()
        {
            Console.WriteLine($"Logging Out: {Username}");
        }

        public void IssueBook(Book book, Account userAccount)
        {
            userAccount.NoOfBorrowedBooks++;
            userAccount.BorrowedBooks.Add(book);
        }

        public void ReturnBook(Book book, Account userAccount)
        {
            userAccount.NoOfBorrowedBooks--;
            userAccount.NoOfReturnedBooks++;
            userAccount.BorrowedBooks.Remove(book);
        }
        ~Librarian()
        {
            Logout();
        }
    }
}
