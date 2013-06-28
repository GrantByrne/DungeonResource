using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndDev.Service.Abstract;
using DndDev.Domain.Book;
using DndDev.Repository.Abstract;

namespace DndDev.Service
{
    /// <summary>
    /// Handles all the business logic revolving around a book
    /// </summary>
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        
        /// <summary>
        /// ctor
        /// </summary>
        public BookService(IBookRepository bookrepository)
        {
            _bookRepository = bookrepository;
        }
        
        /// <summary>
        /// Adds the book to the Database
        /// </summary>
        /// <returns>The book with the newly created Id</returns>
        public Book Create(Book bookDetails)
        {
            return _bookRepository.Create(bookDetails);
        }

        /// <summary>
        /// Reads out all the data about a book in the database
        /// </summary>
        /// <param name="Id">The UID for the book in the database</param>
        /// <returns>The details surrounding the book</returns>
        public Book Read(int Id)
        {
            return _bookRepository.Read(Id);
        }

        /// <summary>
        /// Updates the information about a book in the database
        /// </summary>
        /// <returns>The updated information about the book</returns>
        public Book Update(Book bookDetails)
        {
            return _bookRepository.Update(bookDetails);
        }

        /// <summary>
        /// Deletes a book from the database
        /// </summary>
        /// <param name="Id">The UID for the single book entity</param>
        public void Delete(int Id)
        {
            _bookRepository.Delete(Id);
        }

        /// <summary>
        /// Reads out all the books contained within the database
        /// </summary>
        /// <returns>A list containing all the books in the database</returns>
        public IEnumerable<Book> ReadAll()
        {
            return _bookRepository.ReadAll();
        }
    }
}
