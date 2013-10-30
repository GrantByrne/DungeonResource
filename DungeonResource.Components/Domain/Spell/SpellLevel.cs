using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonResource.Components.Domain.Spell
{
    /// <summary>
    /// Object which specifies the Class and Level that a spell
    /// belongs to
    /// </summary>
    public class SpellLevel
    {
        /// <summary>
        /// A class a spell may be associated with
        /// </summary>
        public string SpellClass { get; set; }

        /// <summary>
        /// The level a spell may be associated with
        /// </summary>
        public int Level { get; set; }

    }
}
