
namespace DndDev.Domain.Monster
{
    /// <summary>
    /// Attribute for a monster to manage single skills
    /// </summary>
    public class MonsterSkill
    {
        /// <summary>
        /// The name of the skill
        /// </summary>
        public string SkillName { get; set; }

        /// <summary>
        /// Mesure of how compitent the Monster is in this skill
        /// </summary>
        public int SkillModifier { get; set; }
    }
}
