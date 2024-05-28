using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6_69451_
{
    class AddBooks
    {
        public class PaperBook : Book
        {
            public string ISBN { get; set; }
            public int NumberOfPages { get; set; }

            public PaperBook(string title, string author, string category, string type, string isbn, int numberOfPages)
                : base(title, author, category, type)
            {
                ISBN = isbn;
                NumberOfPages = numberOfPages;
            }
        }

        public class EBook : Book
        {
            public string Format { get; set; }
            public int FileSize { get; set; }

            public EBook(string title, string author, string category, string type, string format, int fileSize)
                : base(title, author, category, type)
            {
                Format = format;
                FileSize = fileSize;
            }
        }

        public class AudioBook : Book
        {
            public string Narrator { get; set; }
            public int Duration { get; set; }

            public AudioBook(string title, string author, string category, string type, string narrator, int duration)
                : base(title, author, category, type)
            {
                Narrator = narrator;
                Duration = duration;
            }
        }

    }
}
