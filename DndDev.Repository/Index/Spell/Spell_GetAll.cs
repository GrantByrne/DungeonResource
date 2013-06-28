using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raven.Client.Indexes;
using DndDev.Domain.Spell;

namespace DndDev.Repository.Index
{
    public class Spell_GetAll : AbstractIndexCreationTask<DndDev.Domain.Spell.Spell>
    {
        public Spell_GetAll()
        {
            Map = spells => from spell in spells 
                            select new 
                            { 
                                spell 
                            };
        }
    }
}
