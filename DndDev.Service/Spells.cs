using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndDev.Repository;
using Raven.Client.Document;
using Raven.Client;

namespace DndDev.Service
{
    public class Spells : ISpells
    {

        public Spells()
        {
            documentStore.Initialize();
        }
        
        IDocumentStore documentStore = new DocumentStore
        {
            Url = "http://localhost:8080"
        };

        /// <summary>
        /// Adds a new spell to the database
        /// </summary>
        /// <param name="newSpell"></param>
        public void CreateSpell(Spell newSpell)
        {
            using (var session = documentStore.OpenSession())
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
            
            using (var session = documentStore.OpenSession())
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
            
            using (var session = documentStore.OpenSession())
            {
                string ravenQuery = string.Format("Id/{0}", newSpell.Id);
                var oldSpell = session.Load<Spell>(ravenQuery);
                oldSpell = newSpell;
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
            using (var session = documentStore.OpenSession())
            {
                string ravenQuery = string.Format("Id/{0}", id);
                var someSpell = session.Load<Spell>(ravenQuery);
                session.Delete(someSpell);
                session.SaveChanges();
            }
        }

        /// <summary>
        /// Gathers a list of all the spell contained in the 
        /// database
        /// </summary>
        public List<Spell> ReadAllSpells()
        {

            List<Spell> allSpells;
            
            using (var session = documentStore.OpenSession())
            {
                allSpells = session.Query<Spell>().ToList();
            }

            return allSpells;
        }

    }
}
