using DungeonResource.Components.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonResource.Components.Repository.Abstract
{
    public interface IGenericRepository
    {
        Entity Create(Entity newSpell);
        void Delete(int id);
        List<Entity> Read();
        List<Entity> Read(int page, int pageSize);
        Entity Read(int id);
        Entity Update(Entity newSpell);
    }
}
