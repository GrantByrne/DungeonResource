/////////////////////////////////////////////////////////
// Copywrite GrantTech 2013
/////////////////////////////////////////////////////////

using System;
using DndDev.Domain.Spell;
using System.Collections.Generic;

namespace DndDev.Repository.Abstract
{
    public interface ISpellRepository
    {
        void CreateSpell(Spell newSpell);
        void DeleteSpell(int id);
        List<Spell> ReadAllSpells();
        Spell ReadSpell(int id);
        Spell UpdateSpell(Spell newSpell);
    }
}
