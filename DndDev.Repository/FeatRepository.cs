/////////////////////////////////////////////////////////
// Copywrite GrantTech 2013
/////////////////////////////////////////////////////////

using System.Collections.Generic;
using DndDev.Domain.Feat;
using DndDev.Repository.Abstract;

namespace DndDev.Repository
{
    public class FeatRepository : IFeatRepository
    {
        public Feat Create(Feat someFeat)
        {
            return someFeat;
        }

        public Feat Read(int id)
        {
            return new Feat();
        }

        public Feat Update(Feat someFeat)
        {
            return someFeat;
        }

        public void Delete(int id)
        {
        }

        public List<Feat> ReadAll()
        {
            return new List<Feat>();
        }

    }
}
