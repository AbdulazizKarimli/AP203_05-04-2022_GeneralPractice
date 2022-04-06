using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    internal class Library
    {
        public List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }

        public List<Book> FilterByPrice(double minPrice, double maxPrice)
        {
            List<Book> filteredBooks = books.FindAll(b => b.Price >= minPrice && b.Price <= maxPrice); ;
            if (filteredBooks.Count == 0)
                throw new Exception("list boshdur");

            return filteredBooks;
        }
        public List<Book> FilterByGenre(Genre genre)
        {
            return books.FindAll(b => b.Genre == genre);
        }
        public Book FindBookByNo(int no)
        {
            return books.Find(b => b.No == no);
        }
    }
}
