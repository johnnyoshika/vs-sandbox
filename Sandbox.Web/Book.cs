using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sandbox.Web
{
    public class Book
    {
        public Book(string title)
        {
            Title = title;
        }
        public string Title { get; }
    }
}