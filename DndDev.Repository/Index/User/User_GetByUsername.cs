using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raven.Client.Indexes;
using DndDev.Domain.Spell;

namespace DndDev.Repository.Index.User
{
    public class User_GetByUsername : AbstractIndexCreationTask<DndDev.Domain.User.User>
    {
        public User_GetByUsername()
        {
            Map = users => from user in users
                            select new { user.Username };
        }
    }
}
