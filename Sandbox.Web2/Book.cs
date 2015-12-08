using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sandbox.Web2
{
    public class Book
    {
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public string Author { get; }
        public string Title { get; }
    }
}