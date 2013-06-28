using System.Collections.Generic;
using DndDev.Domain.User;

namespace DndDev.Repository.Abstract
{
    public interface IUserRepository
    {
        User Create(User someFeat);
        User Read(int id);
        User Read(string username);
        User Update(User someFeat);
        void Delete(int id);
        List<User> ReadAll();
    }
}