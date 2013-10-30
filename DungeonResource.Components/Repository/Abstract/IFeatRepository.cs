using DungeonResource.Components.Domain.Feat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonResource.Components.Repository.Abstract
{
    public interface IFeatRepository
    {
        Feat Create(Feat someFeat);
        Feat Read(int id);
        Feat Update(Feat someFeat);
        void Delete(int id);
        List<Feat> ReadAll();
    }
}
