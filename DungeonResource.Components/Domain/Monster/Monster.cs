using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonResource.Components.Domain.Monster
{
    public class Monster
    {
        /// <summary>
        /// The UID for the Monster in the DB
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of the monster
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A general indicator of the size of the monster
        /// </summary>
        public SizeCategory Size { get; set; }

        /// <summary>
        /// The general type of the monster
        /// </summary>
        public MonsterType Type { get; set; }

        /// <summary>
        /// The subtype of the monster
        /// </summary>
        public MonsterSubtype SubType { get; set; }

        /// <summary>
        /// What to role to determine the hit points
        /// </summary>
        public string HitDice { get; set; }

        /// <summary>
        /// The Initiative modifier
        /// </summary>
        public int Initiative { get; set; }

        /// <summary>
        /// Details for the monsters armor class
        /// </summary>
        public string ArmorClass { get; set; }

        /// <summary>
        /// The base attack bonus for the monster
        /// </summary>
        public int BaseAttack { get; set; }

        /// <summary>
        /// The grapple bonus for the monster
        /// </summary>
        public int GrappleBonus { get; set; }

        /// <summary>
        /// The attack and damage for the monster
        /// </summary>
        public string Attack { get; set; }

        /// <summary>
        /// The full list of attacks and damage for the monster
        /// </summary>
        public string FullAttack { get; set; }

        /// <summary>
        /// The amount of space the monster takes up
        /// </summary>
        public int Space { get; set; }

        /// <summary>
        /// The total reach of the monster
        /// </summary>
        public int Reach { get; set; }

        /// <summary>
        /// The special attacks associated with the monster
        /// </summary>
        public string SpecialAttack { get; set; }

        /// <summary>
        /// Unusual abilities of the monster
        /// </summary>
        public string SpecialQualities { get; set; }

        /// <summary>
        /// The Fort, Ref, and Will Saves of the Monster
        /// </summary>
        public string Saves { get; set; }

        /// <summary>
        /// Listing of Abilities for the Montster
        /// </summary>
        /// <remarks>
        /// eg: Str 18, Dex 17, Con 12, Int 10, Wis 14, Cha 10
        /// </remarks>
        public string Abilities { get; set; }

        /// <summary>
        /// List of Feats which the monster has
        /// </summary>
        public string Feats { get; set; }

        /// <summary>
        /// The environment that the monster normally resides in
        /// </summary>
        public string Environment { get; set; }

        /// <summary>
        /// The grouping of this type of monster when found in the wild
        /// </summary>
        public string Organization { get; set; }

        /// <summary>
        /// How difficult the monster is to fight
        /// </summary>
        public int ChallengeRating { get; set; }

        /// <summary>
        /// The alignment of the monster
        /// </summary>
        public string Alignment { get; set; }

        /// <summary>
        /// The amount of treasure the monster depenses
        /// </summary>
        public string Treasure { get; set; }

        /// <summary>
        /// How tough a monster can get
        /// </summary>
        public string Advancement { get; set; }

        /// <summary>
        /// Something about cohorts
        /// </summary>
        public string LevelAdjustment { get; set; }

        /// <summary>
        /// Summary of the monster as a whole 
        /// </summary>
        public string HighLevelDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Combat { get; set; }

        public string AdditionalDetails { get; set; }

    }
}
