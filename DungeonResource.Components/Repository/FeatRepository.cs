using DungeonResource.Components.Domain.Feat;
using DungeonResource.Components.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonResource.Components.Repository
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
