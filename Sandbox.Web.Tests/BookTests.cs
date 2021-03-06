﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sandbox.Web2;

namespace Sandbox.Web.Tests
{
    [TestClass]
    public class BookTests
    {
        [TestMethod]
        public void Book_Constructor_Assigns_Title()
        {
            var book = new Book("ABC", "");
            Assert.AreEqual("ABC", book.Title);
        }

        [TestMethod]
        public void Book_Constructor_Assigns_Author()
        {
            var book = new Book("", "Mike");
            Assert.AreEqual("Mike", book.Author);
        }

        [TestMethod]
        public void Book_Constructor_Assigns_Author2()
        {
            var book = new Book("", "Bob");
            Assert.AreEqual("Bob", book.Author);
        }
    }
}
