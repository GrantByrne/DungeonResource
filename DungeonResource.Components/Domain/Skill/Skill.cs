using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonResource.Components.Domain.Skill
{
    public class Skill : Entity
    {
        public string Name { get; set; }
        public string SubType { get; set; }
        public string KeyAbility { get; set; }
        public bool Psionic { get; set; }
        public bool Trained { get; set; }
        public bool ArmorCheck { get; set; }
        public string Description { get; set; }
        public string SkillCheck { get; set; }
        public string Action { get; set; }
        public string TryAgain { get; set; }
        public string Special { get; set; }
        public string Restriction { get; set; }
        public string Synergy { get; set; }
        public string EpicUse { get; set; }
        public string Untrained { get; set; }
        public string FullText { get; set; }
        public string Reference { get; set; }
    }
}
