using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndDev.Domain.Book;

namespace DndDev.Domain
{
    /// <summary>
    /// Defines some base characteristics for object to be entered 
    /// into the database
    /// </summary>
    public abstract class ReferenceEntity
    {
        /// <summary>
        /// The UID for any database object
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The Username of the person who last edited the spell
        /// </summary>
        public string Editor { get; set; }

        /// <summary>
        /// The time when the spell was last updated
        /// </summary>
        public DateTime LastEdited { get; set; }

        /// <summary>
        /// List of ID's and Page Numbers which can be used to compse a 
        /// collection of book references
        /// </summary>
        public List<Reference> BookReferences { get; set; }
    }
}
