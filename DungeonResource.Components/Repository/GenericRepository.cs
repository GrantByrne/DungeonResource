using DungeonResource.Components.Repository.Abstract;
using Raven.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonResource.Components.Repository
{
    public class GenericRepository : IGenericRepository
    {
        /// <summary>
        /// Creates connection to the database
        /// </summary>
        private readonly IDocumentStore _documentStore;

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="documentStore"></param>
        public GenericRepository(IDocumentStore documentStore)
        {
            _documentStore = documentStore;
        }

        public Domain.Entity Create(Domain.Entity entity)
        {
            using (var session = _documentStore.OpenSession())
            {
                session.Store(entity);
                session.SaveChanges();
            }

            return entity;
        }

        public void Delete(int id)
        {
            using (var session = _documentStore.OpenSession())
            {
                session.SaveChanges();
            }
        }

        public List<Domain.Entity> Read()
        {
            throw new NotImplementedException();
        }

        public List<Domain.Entity> Read(int page, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Domain.Entity Read(int id)
        {
            throw new NotImplementedException();
        }

        public Domain.Entity Update(Domain.Entity newSpell)
        {
            throw new NotImplementedException();
        }
    }
}
