using System.Collections.Generic;
using DndDev.Domain.Monster;

namespace DndDev.Repository.Abstract
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