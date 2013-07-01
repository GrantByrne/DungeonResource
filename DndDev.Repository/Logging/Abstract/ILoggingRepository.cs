using System.Collections.Generic;
using DndDev.Domain.Logging;

namespace DndDev.Repository.Logging
{
    public interface ILoggingRepository
    {
        /// <summary>
        /// Creates a single log entry in the database
        /// </summary>
        /// <param name="log"></param>
        void Create(Log log);

        /// <summary>
        /// Reads out a paged collection of log entries
        /// </summary>
        /// <param name="pageNumber">
        /// The current page of the log query
        /// </param>
        /// <param name="count">
        /// The number of row entries the query should 
        /// return
        /// </param>
        /// <returns>
        /// A paged collection of log entries
        /// </returns>
        List<Log> Read(int pageNumber, int count);
    }
}