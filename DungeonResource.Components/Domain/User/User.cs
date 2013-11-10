using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonResource.Components.Domain.User
{
    /// <summary>
    /// Datatype to hold all the information surround a user's login 
    /// credentials
    /// </summary>
    public class User : Entity
    {

        /// <summary>
        /// The login name for the user
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// The user's hashed password
        /// </summary>
        public string PasswordHash { get; set; }

        /// <summary>
        /// The salt used to generate the password
        /// </summary>
        public string PasswordSalt { get; set; }

        /// <summary>
        /// The user's e-mail address
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The datetime when the user created their account
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// The User's E-mail address
        /// </summary>
        public DateTime? DateLastLogin { get; set; }

        /// <summary>
        /// The list of the various roles the user can have
        /// </summary>
        public IList<string> Roles { get; set; }
    }
}
