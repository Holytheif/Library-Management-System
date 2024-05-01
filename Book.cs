using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public string Publication { get; set; }

        public Book(string title, string author, string iSBN, string publication)
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
            Publication = publication; 
        }

        public void dueDate() { }
        public void bookRequest() { }
    }
}
