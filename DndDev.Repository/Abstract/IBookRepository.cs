using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndDev.Domain.Book;

namespace DndDev.Repository.Abstract
{
    /// <summary>
    /// Establishes the basic CRUD operations for the Book entity in the database
    /// </summary>
    public interface IBookRepository
    {
        /// <summary>
        /// Adds the book to the Database
        /// </summary>
        /// <returns>The book with the newly created Id</returns>
        Book Create(Book bookDetails);

        /// <summary>
        /// Reads out all the data about a book in the database
        /// </summary>
        /// <param name="Id">The UID for the book in the database</param>
        /// <returns>The details surrounding the book</returns>
        Book Read(int Id);

        /// <summary>
        /// Updates the information about a book in the database
        /// </summary>
        /// <returns>The updated information about the book</returns>
        Book Update(Book bookDetails);

        /// <summary>
        /// Deletes a book from the database
        /// </summary>
        /// <param name="Id">The UID for the single book entity</param>
        void Delete(int Id);

        /// <summary>
        /// Reads out all the books contained within the database
        /// </summary>
        /// <returns>A list containing all the books in the database</returns>
        IEnumerable<Book> ReadAll();
    }
}
