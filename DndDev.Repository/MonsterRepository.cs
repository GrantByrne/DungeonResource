/////////////////////////////////////////////////////////
// Copywrite GrantTech 2013
/////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Linq;
using DndDev.Domain.Monster;
using Raven.Client.Document;
using Raven.Client;
using DndDev.Repository.Abstract;

namespace DndDev.Repository
{
    /// <summary>
    /// Handles all the CRUD operations for persistant storage information about monsters
    /// </summary>
    public class MonsterRepository : IMonsterRepository
    {
        /// <summary>
        /// The means of connecting to the RavenDB database
        /// </summary>
        private readonly IDocumentStore _documentStore;
        
        /// <summary>
        /// ctor
        /// </summary>
        public MonsterRepository()
        {
            _documentStore = new DocumentStore
            {
                ConnectionStringName = "RavenHQ",
                DefaultDatabase = "Spellbook"
            };
            
            _documentStore.Initialize();
        }

        /// <summary>
        /// Add a new monster to the RavenDB database
        /// </summary>
        /// <param name="monsterAttributes">The details surrounding the monster</param>
        /// <returns>The monster details with the unique id for the monster</returns>
        public Monster Create(Monster monsterAttributes)
        {

            using (var session = _documentStore.OpenSession())
            {
                session.Store(monsterAttributes);
                session.SaveChanges();
            }

            return monsterAttributes;
        }

        /// <summary>
        /// Reads out the data about the monster from the RavenDB database
        /// </summary>
        /// <param name="id">The UID for the monster</param>
        /// <returns>All the details surrounding the monsters in the database</returns>
        public Monster Read(int id)
        {
            Monster someMonster;
            
            using (var session = _documentStore.OpenSession())
            {
                string ravenQuery = string.Format("monsters/{0}", id);
                someMonster = session.Load<Monster>(ravenQuery);
            }

            return someMonster;
        }

        /// <summary>
        /// Updates the information about the monster in the RavenDB database
        /// </summary>
        /// <param name="monsterAttributes">All the details surrounding the monster</param>
        /// <returns>The monster's populated attributes</returns>
        public Monster Update(Monster monsterAttributes)
        {
            
            using (var session = _documentStore.OpenSession())
            {
                session.Store(monsterAttributes);
                session.SaveChanges();
            }

            return monsterAttributes;
        }

        /// <summary>
        /// Deletes a monster from the RavenDB database
        /// </summary>
        /// <param name="id">The UID for the monster</param>
        public void Delete(int id)
        {
            using (var session = _documentStore.OpenSession())
            {
                var entityId = "monsters/" + id;
                session.Advanced.DocumentStore.DatabaseCommands.Delete(entityId, null);
            }
        }

        /// <summary>
        /// Reads out a list of all the monsters in the database
        /// </summary>
        /// <returns>A huge list containing all the monsters in the database</returns>
        public List<Monster> ReadAll()
        {
            List<Monster> allMonsters;

            using (var session = _documentStore.OpenSession())
            {
                allMonsters = session.Query<Monster>().ToList();
            }

            return allMonsters;
        }
    }
}
