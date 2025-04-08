using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uml
{
    class Book
    {
        private string title;
        private string author;
        private int pages;

        public Book(string title, string author, int pages)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
        }

        public string GetSummary()
        {
            return $"{title} by {author}, {pages} pages.";
        }
    }
}
