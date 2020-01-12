using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models.Repositories
{
    public class AuthorReop : IBookstoreRepo<Author>
    {
        List<Author> authors;
        public AuthorReop()
        {
            authors = new List<Author>()
            {
                new Author
                {
                    Id = 1,
                    FullName = "Steven.R covey"
                },
                new Author
                {
                    Id = 2,
                    FullName = "Anthonny Robbins"
                },
                new Author
                {
                    Id = 3,
                    FullName = "Jimmy Cartsen"
                }

            };
        }
        public Author Find(int id)
        {
            var author = authors.SingleOrDefault(auth => auth.Id == id);
            return author;
        }
        public void Add(Author newAuthor)
        {
            authors.Add(newAuthor);
        }

        public void Delete(int id)
        {
            var author = Find(id);
            authors.Remove(author);
        }

        public IList<Author> List()
        {
            return authors;
        }

        public void Update(int id, Author newAuthor)
        {
            var author = Find(id);
            author.FullName = newAuthor.FullName;
        }
    }
}
