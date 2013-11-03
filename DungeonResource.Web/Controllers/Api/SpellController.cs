using DungeonResource.Components.Domain.Spell;
using DungeonResource.Components.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DungeonResource.Web.Controllers.Api
{
    /// <summary>
    /// Handles restful spell operations
    /// </summary>
    public class SpellController : ApiController
    {
        /// <summary>
        /// Handles the management of the spell data
        /// </summary>
        private readonly ISpellService _spellService;

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="spellService"></param>
        public SpellController(ISpellService spellService)
        {
            _spellService = spellService;
        }
        
        /// <summary>
        /// Reads a spell out of the database
        /// </summary>
        /// <param name="id">
        /// The UID for the spell
        /// </param>
        /// <returns>
        /// The data associated with a single spell
        /// </returns>
        public Spell Get(int id)
        {
            return _spellService.ReadSpell(id);
        }
    }
}
