using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raven.Client.Indexes;
using DndDev.Domain.Spell;

namespace DndDev.Repository.Index.Spell
{
    public class Spell_GetById : AbstractIndexCreationTask<DndDev.Domain.Spell.Spell>
    {
        public Spell_GetById()
        {
            Map = spells => from spell in spells
                            select new { spell.Id };
        }
    }
}
