using DungeonResource.Components.Domain.Book;
using DungeonResource.Components.Repository;
using DungeonResource.Components.Repository.Abstract;
using DungeonResource.Components.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonResource.Components.Service
{
    /// <summary>
    /// Handles all the business logic revolving around a book
    /// </summary>
    public class BookService : IBookService
    {
        private readonly IGenericRepository<Book> _genericRepository;

        /// <summary>
        ///     ctor
        /// </summary>
        public BookService(IGenericRepository<Book> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        /// <summary>
        /// Adds the book to the Database
        /// </summary>
        /// <returns>The book with the newly created Id</returns>
        public Book Create(Book bookDetails)
        {
            return _genericRepository.Create(bookDetails);
        }

        /// <summary>
        /// Reads out all the data about a book in the database
        /// </summary>
        /// <param name="id">The UID for the book in the database</param>
        /// <returns>The details surrounding the book</returns>
        public Book Read(int id)
        {
            return _genericRepository.Read(id);
        }

        /// <summary>
        /// Updates the information about a book in the database
        /// </summary>
        /// <returns>The updated information about the book</returns>
        public Book Update(Book bookDetails)
        {
            return _genericRepository.Update(bookDetails);
        }

        /// <summary>
        /// Deletes a book from the database
        /// </summary>
        /// <param name="id">The UID for the single book entity</param>
        public void Delete(int id)
        {
            _genericRepository.Delete(id);
        }

        /// <summary>
        /// Reads out all the books contained within the database
        /// </summary>
        /// <returns>A list containing all the books in the database</returns>
        public IEnumerable<Book> ReadAll()
        {
            return _genericRepository.Read();
        }
    }
}
