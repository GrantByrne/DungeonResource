using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndDev.Domain.Spell;
using Raven.Client.Document;
using Raven.Client;
using DndDev.Repository.Abstract;

namespace DndDev.Repository
{
    public class SpellRepository : ISpellRepository
    {
        /// <summary>
        /// Creates connection to the database
        /// </summary>
        private readonly IDocumentStore _documentStore;
        
        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="documentStore"></param>
        public SpellRepository(IDocumentStore documentStore)
        {
            _documentStore = documentStore;
        }

        /// <summary>
        /// Adds a new spell to the database
        /// </summary>
        /// <param name="newSpell"></param>
        public void CreateSpell(Spell newSpell)
        {
            using (var session = _documentStore.OpenSession())
            {
                session.Store(newSpell);
                session.SaveChanges();
            }
        }

        /// <summary>
        /// Gets the spell for the user from the database 
        /// based off of a the id
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the spell
        /// </param>
        /// <returns>
        /// All the information about that spell
        /// </returns>
        public Spell ReadSpell(int id)
        {
            Spell someSpell;

            using (var session = _documentStore.OpenSession())
            {
                string ravenQuery = string.Format("spells/{0}", id);
                someSpell = session.Load<Spell>(ravenQuery);
            }

            return someSpell;
        }

        /// <summary>
        /// Updates the spell that is in the database with
        /// the spell data provided
        /// </summary>
        /// <param name="newSpell">
        /// Updates the data for that 
        /// spell
        /// </param>
        public Spell UpdateSpell(Spell newSpell)
        {

            using (var session = _documentStore.OpenSession())
            {
                session.Store(newSpell);
                session.SaveChanges();
            }

            return newSpell;
        }

        /// <summary>
        /// Deletes the spell from the database based off the
        /// unique id
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the 
        /// spell
        /// </param>
        public void DeleteSpell(int id)
        {
            using (var session = _documentStore.OpenSession())
            {
                var entityId = "spells/" + id;
                session.Advanced.DocumentStore.DatabaseCommands.Delete(entityId, null);
            }
        }

        /// <summary>
        /// Gathers a list of all the spell contained in the 
        /// database
        /// </summary>
        public List<Spell> ReadAllSpells()
        {
            List<Spell> allSpells;

            using (var session = _documentStore.OpenSession())
            {
                allSpells = session.Query<Spell>().ToList();
            }

            return allSpells;
        }

    }
}
