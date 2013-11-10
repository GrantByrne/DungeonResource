using DungeonResource.Components.Domain.User;
using DungeonResource.Components.Repository.Abstract;
using Raven.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonResource.Components.Repository
{
    /// <summary>
    /// Repository to handle the crud operations for the persistance user data
    /// </summary>
    public class UserRepository : IUserRepository
    {

        private readonly IDocumentStore _documentStore;

        public UserRepository(IDocumentStore documentStore)
        {
            _documentStore = documentStore;
        }

        /// <summary>
        /// Add a user to the database
        /// </summary>
        /// <param name="newUser">The user data to be inserted into the database</param>
        /// <returns>Returns the user back to the caller of the method</returns>
        public User Create(User newUser)
        {
            using (var session = _documentStore.OpenSession())
            {
                session.Store(newUser);
                session.SaveChanges();
            }

            return newUser;
        }

        /// <summary>
        /// Reads out the data from a single user from the database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public User Read(int id)
        {
            User userDetails;

            using (var session = _documentStore.OpenSession())
            {
                string ravenQuery = string.Format("users/{0}", id);
                userDetails = session.Load<User>(ravenQuery);
            }

            return userDetails;
        }

        public User Read(string username)
        {
            User userDetails;

            using (var session = _documentStore.OpenSession())
            {
                userDetails = session.Query<User>()
                    .Where(p => p.Username == username)
                    .ToList<User>()
                    .FirstOrDefault();
            }

            return userDetails;
        }

        /// <summary>
        /// Update the details about the user
        /// </summary>
        /// <param name="someFeat"></param>
        /// <returns></returns>
        public User Update(User userDetails)
        {
            using (var session = _documentStore.OpenSession())
            {
                session.Store(userDetails);
                session.SaveChanges();
            }

            return userDetails;
        }

        /// <summary>
        /// Deletes a user from the database
        /// </summary>
        /// <param name="id">The UID for the user to be deleted</param>
        public void Delete(int id)
        {
            using (var session = _documentStore.OpenSession())
            {
                var entityId = "users/" + id;
                session.Advanced.DocumentStore.DatabaseCommands.Delete(entityId, null);
            }
        }
    }
}
