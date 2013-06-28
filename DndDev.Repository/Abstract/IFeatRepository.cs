using System.Collections.Generic;
using DndDev.Domain.Feat;

using Feat = DndDev.Domain.Feat.Feat;

namespace DndDev.Repository.Abstract
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