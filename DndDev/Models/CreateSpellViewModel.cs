using System;
using System.Collections.Generic;
using DndDev.Repository;
using System.ComponentModel.DataAnnotations;

namespace DndDev.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateSpellViewModel
    {
        
        /// <summary>
        /// The Name of the Spell
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The Description of the Spell
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Specifies the Classes and Levels that this spell 
        /// pertains to
        /// </summary>
        public IEnumerable<SpellLevel> Classes { get; set; }

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
        [Required]
        public bool SavingThrow { get; set; }

        /// <summary>
        /// Specifies the Definite Spell Component
        /// </summary>
        public SpellComponent Component { get; set; }

        /// <summary>
        /// Specifies the School that the Spell Belongs To
        /// </summary>
        public String School { get; set; }

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