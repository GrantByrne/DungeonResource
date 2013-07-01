using System.Collections.Generic;
using DndDev.Domain.Spell;

namespace DndDev.Service.Abstract
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
