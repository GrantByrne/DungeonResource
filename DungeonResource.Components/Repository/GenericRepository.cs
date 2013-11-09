using Raven.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonResource.Components.Repository
{
    public class GenericRepository<T>
    {
        /// <summary>
        ///     Creates connection to the database
        /// </summary>
        private readonly IDocumentStore _documentStore;

        /// <summary>
        ///     ctor
        /// </summary>
        public GenericRepository(IDocumentStore documentStore)
        {
            _documentStore = documentStore;
        }

        public T Create(T entity)
        {
            using (var session = _documentStore.OpenSession())
            {
                session.Store(entity);
                session.SaveChanges();
            }

            return entity;
        }

        public T Read(int id)
        {
            T entity;

            using (var session = _documentStore.OpenSession())
            {
                entity = session.Load<T>(id);
            }

            return entity;
        }

        public List<T> Read()
        {
            List<T> entities;

            using (var session = _documentStore.OpenSession())
            {
                entities = session.Query<T>().Take(1000).ToList();
            }

            return entities;
        }

        public List<T> Read(int page, int pageSize)
        {
            List<T> entities;

            using (var session = _documentStore.OpenSession())
            {
                entities = session.Query<T>().Skip(page*pageSize).Take(pageSize).ToList();
            }

            return entities;
        }

        public T Update(T entity)
        {
            using (var session = _documentStore.OpenSession())
            {
                session.Store(entity);
                session.SaveChanges();
            }

            return entity;
        }

        public void Delete(T entity)
        {
            using (var session = _documentStore.OpenSession())
            {
                session.Delete<T>(entity);
                session.SaveChanges();
            }
        }
    }
}
