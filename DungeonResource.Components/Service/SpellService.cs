using DungeonResource.Components.Domain.Spell;
using DungeonResource.Components.Repository;
using DungeonResource.Components.Repository.Abstract;
using DungeonResource.Components.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonResource.Components.Service
{
    public class SpellService : ISpellService
    {

        private readonly IGenericRepository<Spell> _genericRepository;

        /// <summary>
        /// ctor
        /// </summary>
        public SpellService(IGenericRepository<Spell> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        /// <summary>
        /// Add a spell to the database
        /// </summary>
        /// <param name="newSpell">Details for the new spell</param>
        public void CreateSpell(Spell newSpell)
        {
            _genericRepository.Create(newSpell);
        }

        /// <summary>
        /// Deletes a spell from the database
        /// </summary>
        /// <param name="id">The Uid of the spell</param>
        public void DeleteSpell(int id)
        {
            _genericRepository.Delete(id);
        }

        /// <summary>
        /// Gathers all the spells in the database
        /// </summary>
        /// <returns>All the spells in the database</returns>
        public List<Spell> ReadAllSpells()
        {
            return _genericRepository.Read();
        }

        /// <summary>
        /// Gets the details for a single spell
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Spell ReadSpell(int id)
        {
            return _genericRepository.Read(id);
        }

        /// <summary>
        /// Updates a spell in the database
        /// </summary>
        /// <param name="newSpell">Details for the spell</param>
        /// <returns>The new spell object</returns>
        public Spell UpdateSpell(Spell newSpell)
        {
            return _genericRepository.Update(newSpell);
        }

    }
}
