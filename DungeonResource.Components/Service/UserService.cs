using DungeonResource.Components.Domain.User;
using DungeonResource.Components.Repository.Abstract;
using DungeonResource.Components.Service.Abstract;
using SimpleCrypto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonResource.Components.Service
{
    /// <summary>
    /// Performs the business logic as it applies to managing users
    /// </summary>
    public class UserService : IUserService
    {
        /// <summary>
        /// Repository to handle the crud operations surrounding a user account
        /// </summary>
        private readonly IUserRepository _userRepository;

        /// <summary>
        /// Service for handling the password encryption for the user accounts
        /// </summary>
        private readonly ICryptoService _cryptoService;

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="userRepository"></param>
        /// <param name="cryptoService"></param>
        public UserService(IUserRepository userRepository, ICryptoService cryptoService)
        {
            _userRepository = userRepository;
            _cryptoService = cryptoService;
        }


        /// <summary>
        /// Authenticates the user credentials based on the username and password
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool AuthenticateUser(string username, string password)
        {
            var validUser = false;

            // try to pull down the user data
            var user = _userRepository.Read(username);

            // If the username is valid, and some data was pulled down
            if (null != user)
            {
                // Validate that the password is valid

                // hash the password with the saved salt for that user
                string hashed = _cryptoService.Compute(password, user.PasswordSalt);

                // return true if both hashes are the same
                if (hashed == user.PasswordHash)
                {
                    validUser = true;
                }
            }

            return validUser;
        }

        /// <summary>
        /// Adds a brand new user to the database
        /// </summary>
        /// <param name="userDetails"></param>
        /// <returns></returns>
        public bool CreateUser(User userDetails)
        {
            // Flag to say whether the user was created or not
            var userCreated = false;

            // Try to pull down a user with that username
            var someUser = _userRepository.Read(userDetails.Username);

            // If there isn't a user in the database by that username
            if (null == someUser)
            {
                // Add the user to the database, and then populate the 
                // object with the unique id
                userDetails = _userRepository.Create(userDetails);
                userCreated = true;
            }

            // Return whether the user was created or not
            return userCreated;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public bool UserExists(string username)
        {
            return (null != _userRepository.Read(username));
        }

    }
}
