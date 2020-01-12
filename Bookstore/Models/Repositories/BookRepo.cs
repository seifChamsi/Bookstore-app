using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models.Repositories
{
    public class BookRepo : IBookstoreRepo<Book>
    {
        List<Book> books;
        public BookRepo()
        {
            books = new List<Book>()
            {
                new Book
                {
                    Id=1,
                    Title=".Net core handBook",
                    Description="All what you need to know about .Net core ",

                },
                new Book
                {
                    Id=2,
                    Title="7 facts of highly effective people",
                    Description="unleash your power with these fabulous habits",

                },
                new Book
                {
                    Id=1,
                    Title="Unlimited Power",
                    Description="Tony Robbins Bible to unlock your potential",

                }
            };
        }

        public Book Find(int id)
        {
            var book = books.SingleOrDefault(b => b.Id == id);
            return book;
        }

        public void Add(Book newBook)
        {
            books.Add(newBook);
        }

        public void Delete(int id)
        {
            var book = Find(id);
            books.Remove(book);
        }

        public IList<Book> List()
        {
            return books;
        }

        public void Update(int id , Book newBook)
        {
            var book = Find(id);
            book.Title = newBook.Title;
            book.Description = newBook.Description;
            book.Author = newBook.Author;
        }
    }
}
