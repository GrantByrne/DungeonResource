using DungeonResource.Components.Domain.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonResource.Components.Repository.Abstract
{
    public interface IUserRepository
    {
        User Create(User someFeat);
        User Read(int id);
        User Read(string username);
        User Update(User someFeat);
        void Delete(int id);
    }
}
