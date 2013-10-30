using DungeonResource.Components.Domain.Spell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonResource.Components.Service.Abstract
{
    public interface ISpellService
    {
        void CreateSpell(Spell newSpell);
        void DeleteSpell(int id);
        List<Spell> ReadAllSpells();
        Spell ReadSpell(int id);
        Spell UpdateSpell(Spell newSpell);
    }
}
