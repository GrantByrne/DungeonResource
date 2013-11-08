using Raven.Client;
using Raven.Client.Document;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raven;
using Raven.Database;
using Raven.Database.Server;
using DungeonResource.Components.Domain;

namespace DungeonResource.Components.Repository
{
    public class DomainRepository
    {
                /// <summary>
        /// Creates connection to the database
        /// </summary>
        private readonly IDocumentStore _documentStore;

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="documentStore"></param>
        public DomainRepository()
        {
            _documentStore = new DocumentStore
            {
                Url = "localhost:8080"
            };
            _documentStore.Initialize();
        }

        /// <summary>
        /// Adds the book to the Database
        /// </summary>
        /// <returns>The book with the newly created Id</returns>
        public Entity Create(Entity entity)
        {
            using (var session = _documentStore.OpenSession())
            {
                session.Store(entity);
                session.SaveChanges();
            }
            return entity;
        }
    }
}
