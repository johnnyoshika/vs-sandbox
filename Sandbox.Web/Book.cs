using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sandbox.Web
{
    public class Book
    {
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public string Title { get; }
        public string Author { get; }
    }
}