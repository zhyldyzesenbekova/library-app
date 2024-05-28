using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6_69451_
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }

        public Book(string title, string author, string category, string type)
        {
            Title = title;
            Author = author;
            Category = category;
            Type = type;
        }
    }
}
