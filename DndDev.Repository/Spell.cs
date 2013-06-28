using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndDev.Repository
{
    
    /// <summary>
    /// Flat object to store all the details about a single
    /// spell
    /// </summary>
    public class Spell
    {

        /// <summary>
        /// The UID of the Spell
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Specifies the Classes and Levels that this spell 
        /// pertains to
        /// </summary>
        public List<SpellLevel> SpellLevels {get; set;}

        /// <summary>
        /// The Name of the Spell
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The Description of the Spell
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Flag to Say Whether the Spell Is Effected by 
        /// Spell Resistence
        /// </summary>
        public bool SpellResistance { get; set; }

        /// <summary>
        /// Specifies Who the Spell Can Effect
        /// </summary>
        public string Target { get; set; }

        /// <summary>
        /// Specifies how long the Spell Stays in Effect
        /// </summary>
        public string CastingTime { get; set; }

        /// <summary>
        /// Specifies the definite range of the spell
        /// </summary>
        public SpellRange Range { get; set; }

        /// <summary>
        /// Spefies whether a saving throw can/cannot be made
        /// to this spell
        /// </summary>
        public bool SavingThrow { get; set; }

        /// <summary>
        /// Specifies the Definite Spell Component
        /// </summary>
        public SpellComponent Component { get; set; }

        /// <summary>
        /// Specifies the School that the Spell Belongs To
        /// </summary>
        public string School { get; set; }

        /// <summary>
        /// Specifies the Definite Type of Spell
        /// </summary>
        public SpellType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Duration { get; set; }

    }
}
