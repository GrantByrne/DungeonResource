using DungeonResource.Components.Domain.Monster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonResource.Components.Repository.Abstract
{
    public interface IMonsterRepository
    {
        Monster Create(Monster someFeat);
        Monster Read(int id);
        Monster Update(Monster someFeat);
        void Delete(int id);
        List<Monster> ReadAll();
    }
}
