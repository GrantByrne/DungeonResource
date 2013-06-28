using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndDev.Repository;

namespace DndDev.Service
{
    public interface ISpells
    {

        /// <summary>
        /// Adds a new spell to the database
        /// </summary>
        /// <param name="newSpell"></param>
        void CreateSpell(Spell newSpell);

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
        Spell ReadSpell(int id);

        /// <summary>
        /// Updates the spell that is in the database with
        /// the spell data provided
        /// </summary>
        /// <param name="newSpell">
        /// Updates the data for that 
        /// spell
        /// </param>
        Spell UpdateSpell(Spell newSpell);
        
        /// <summary>
        /// Deletes the spell from the database based off the
        /// unique id
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the 
        /// spell
        /// </param>
        void DeleteSpell(int id);

        /// <summary>
        /// Gathers a list of all the spell contained in the 
        /// database
        /// </summary>
        List<Spell> ReadAllSpells();

    }
}
