
using System.Collections.Generic;

namespace DndDev.Domain.Spell
{
    
    /// <summary>
    /// Flat object to store all the details about a single
    /// spell
    /// </summary>
    public class Spell : ReferenceEntity
    {
        /// <summary>
        /// The Name of the Spell
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Flag whether the spell is a spoken incantation
        /// </summary>
        public bool Verbal { get; set; }

        /// <summary>
        /// Flag whether the spell is meseaured precise 
        /// movements of the hands
        /// </summary>
        public bool Somatic { get; set; }

        /// <summary>
        /// Flag whether the spell is contained within a 
        /// material component
        /// </summary>
        public bool Material { get; set; }

        /// <summary>
        /// Flag whether the spell uses a prop of some sort
        /// </summary>
        public bool Focus { get; set; }

        /// <summary>
        /// Specifies the Classes and Levels that this spell 
        /// pertains to
        /// </summary>
        public List<SpellLevel> SpellLevels {get; set;}

        /// <summary>
        /// Specifies how long the Spell Stays in Effect
        /// </summary>
        public string CastingTime { get; set; }

        /// <summary>
        /// Specifies the definite range of the spell
        /// </summary>
        public SpellRange Range { get; set; }

        /// <summary>
        /// Specifies Who the Spell Can Effect
        /// </summary>
        public string Targets { get; set; }

        /// <summary>
        /// How long the magical energy of the spell lasts
        /// </summary>
        public string Duration { get; set; }

        /// <summary>
        /// Spefies whether a saving throw can/cannot be made
        /// to this spell
        /// </summary>
        public bool SavingThrow { get; set; }

        /// <summary>
        /// Flag to Say Whether the Spell Is Effected by 
        /// Spell Resistence
        /// </summary>
        public bool SpellResistance { get; set; }

        /// <summary>
        /// The Description of the Spell
        /// </summary>
        public string Description { get; set; }

    }
}
