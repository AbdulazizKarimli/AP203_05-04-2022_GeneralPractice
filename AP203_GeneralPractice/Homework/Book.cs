using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    internal class Book
    {
        private static int _no;

        public int No { get; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public Genre Genre { get; set; }
        public double Price { get; set; }

        public Book()
        {
            _no++;
            No = _no;
        }
    }
}
