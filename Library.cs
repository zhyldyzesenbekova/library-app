using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6_69451_
{
    static class Library
    {
        private static List<Book> books = new List<Book>();
        

        public static void AddBook(Book book)
        {
            books.Add(book);
        }

       
    }
}
