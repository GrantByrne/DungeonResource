using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonResource.Components.Domain.Book;
using DungeonResource.Components.Repository.Abstract;
using Raven.Client;

namespace DungeonResource.Components.Repository
{
    /// <summary>
    /// Handles all the crud operations for the Book entity in the RavenDB 
    /// Database
    /// </summary>
    public class BookRepository : IBookRepository
    {
        /// <summary>
        /// Creates connection to the database
        /// </summary>
        private readonly IDocumentStore _documentStore;

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="documentStore"></param>
        public BookRepository(IDocumentStore documentStore)
        {
            _documentStore = documentStore;
        }

        /// <summary>
        /// Adds the book to the Database
        /// </summary>
        /// <returns>The book with the newly created Id</returns>
        public Book Create(Book bookDetails)
        {
            using (var session = _documentStore.OpenSession())
            {
                session.Store(bookDetails);
                session.SaveChanges();
            }
            return bookDetails;
        }

        /// <summary>
        /// Reads out all the data about a book in the database
        /// </summary>
        /// <param name="Id">The UID for the book in the database</param>
        /// <returns>The details surrounding the book</returns>
        public Book Read(int Id)
        {
            Book bookDetails;

            using (var session = _documentStore.OpenSession())
            {
                string ravenQuery = string.Format("books/{0}", Id);
                bookDetails = session.Load<Book>(ravenQuery);
            }

            return bookDetails;
        }

        /// <summary>
        /// Updates the information about a book in the database
        /// </summary>
        /// <returns>The updated information about the book</returns>
        public Book Update(Book bookDetails)
        {
            using (var session = _documentStore.OpenSession())
            {
                session.Store(bookDetails);
                session.SaveChanges();
            }
            return bookDetails;
        }

        /// <summary>
        /// Deletes a book from the database
        /// </summary>
        /// <param name="Id">The UID for the single book entity</param>
        public void Delete(int Id)
        {
            using (var session = _documentStore.OpenSession())
            {
                var entityId = "books/" + Id;
                session.Advanced.DocumentStore.DatabaseCommands.Delete(entityId, null);
            }
        }

        /// <summary>
        /// Reads out all the books contained within the database
        /// </summary>
        /// <returns>A list containing all the books in the database</returns>
        public IEnumerable<Book> ReadAll()
        {
            List<Book> allBooks;

            using (var session = _documentStore.OpenSession())
            {
                allBooks = session.Query<Book>().ToList();
            }

            return allBooks;
        }
    }
}
