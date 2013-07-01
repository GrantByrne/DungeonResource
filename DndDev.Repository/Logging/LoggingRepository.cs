using System.Collections.Generic;
using System.Linq;
using DndDev.Domain.Logging;
using DndDev.Repository.Logging.Abstract;
using Raven.Client;
using Raven.Client.Linq;

namespace DndDev.Repository.Logging
{
    public class LoggingRepository : ILoggingRepository
    {
        /// <summary>
        /// Creates a connection to the database
        /// </summary>
        private readonly IDocumentStore _documentStore;

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="documentStore"></param>
        public LoggingRepository(IDocumentStore documentStore)
        {
            _documentStore = documentStore;
        }

        /// <summary>
        /// Creates a single log entry in the database
        /// </summary>
        /// <param name="log"></param>
        public void Create(Log log)
        {
            using (var session = _documentStore.OpenSession())
            {
                session.Store(log);
                session.SaveChanges();
            }
        }

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
        public List<Log> Read(int pageNumber, int count)
        {
            List<Log> logs;
            
            using (var session = _documentStore.OpenSession())
            {
                logs = session.Query<Log>()
                    .Skip(pageNumber*count)
                    .Take(count)
                    .ToList();

            }

            return logs;
        }
    }
}
