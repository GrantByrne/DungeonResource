using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndDev.Domain.Book
{
    /// <summary>
    /// Holds all the details surrounding a dungeons and dragons book
    /// </summary>
    public class Book
    {
        /// <summary>
        /// The UID for the book in the database
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// The title of the book
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Collection of the authors who wrote the book
        /// </summary>
        public List<string> Authors { get; set; }

        /// <summary>
        /// The name of the publisher for the book
        /// </summary>
        public string Publisher { get; set; }

        /// <summary>
        /// The date when the book was published
        /// </summary>
        public DateTime PublicationDate { get; set; }

        /// <summary>
        /// The ISBN number for the book (10 digit)
        /// </summary>
        public string Isbn10 { get; set; }

        /// <summary>
        /// The ISBN number for the book (13 digit)
        /// </summary>
        public string Isbn13 { get; set; }

        /// <summary>
        /// The edition of the book
        /// </summary>
        public string Edition { get; set; }

        /// <summary>
        /// Describes the type of book
        /// </summary>
        /// <example>
        /// Core, Supplemental, etc...
        /// </example>
        public string BookType { get; set; }

    }
}
