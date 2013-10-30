using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonResource.Components.Domain.Book
{
    /// <summary>
    /// Entity for associating an entity with a Dungeons and Dragons book
    /// </summary>
    public class Reference
    {
        /// <summary>
        /// All the major details surrounding the book
        /// </summary>
        public int BookId;

        /// <summary>
        /// The name of the book that is being referenced
        /// </summary>
        public string BookName;

        /// <summary>
        /// The actual page that the entity is referenced on
        /// </summary>
        public int PageNumber;
    }
}
