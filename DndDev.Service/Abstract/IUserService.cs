using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndDev.Domain.User;

namespace DndDev.Service.Abstract
{
    public interface IUserService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        bool AuthenticateUser(string username, string password);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userDetails"></param>
        /// <returns></returns>
        bool CreateUser(User userDetails);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        bool UserExists(string username);
    }
}
