using System;
using DungeonResource.Test.Components.Domain;
using DungeonResource.Components.Repository;
using Raven.Client;
using Raven.Client.Embedded;
using DungeonResource.Test.Components.Service;
using NUnit.Framework;
using DungeonResource.Components.Repository.Abstract;
using DungeonResource.Components.Domain.User;
using System.Threading;

namespace DungeonResource.Test.Integration.Components.Repository
{
    [TestFixture]
    public class UserRepositoryTest
    {
        private readonly IUserRepository _userRepository;

        public UserRepositoryTest()
        {
            IDocumentStore documentStore = new EmbeddableDocumentStore
            {
                RunInMemory = true,
                Configuration = { 
                    RunInUnreliableYetFastModeThatIsNotSuitableForProduction = true
                }
            };
            documentStore.Initialize();

            _userRepository = new UserRepository(documentStore);
        }

        [Test]
        public void UserRepository_Create_Success()
        {
            // Arrange
            var testUser = GetTestUser();

            // Act
            var result = _userRepository.Create(testUser);

            // Assert
            Assert.IsTrue(result.Id > 0);
        }

        [Test]
        public void UserRepository_Read_Success()
        {
            // Arrange
            var testUser = GetTestUser();
            testUser = _userRepository.Create(testUser);

            // Act
            var result = _userRepository.Read(testUser.Id);

            // Assert
            Assert.AreEqual(testUser.Id, result.Id);
            Assert.AreEqual(testUser.Username, result.Username);
            Assert.AreEqual(testUser.Email, result.Email);
        }

        [Test]
        public void UserRepository_Delete_Success()
        {
            // Arrange
            var testUser = GetTestUser();
            testUser = _userRepository.Create(testUser);

            // Act
            _userRepository.Delete(testUser.Id);

            // Assert
            var result = _userRepository.Read(testUser.Id);
            Assert.IsNull(result);
        }

        [Test]
        public void UserRepository_ReadByUsername_Success()
        {
            // Arrange
            var testUser = GetTestUser();
            testUser.Username = "Read by Username";
            testUser = _userRepository.Create(testUser);

            // Act
            var result = _userRepository.Read(testUser.Username);

            // Assert
            Assert.AreEqual(result.Id, testUser.Id);
            Assert.AreEqual(result.Username, testUser.Username);
            Assert.AreEqual(result.Email, testUser.Email);
        }

        [Test]
        public void UserRepository_Update_Sucess()
        {
            // Arrange
            var testUser = GetTestUser();
            testUser = _userRepository.Create(testUser);
            testUser.Username = "Updated username";

            // Act
            _userRepository.Update(testUser);
            Thread.Sleep(1000); // Coping with eventual consistency

            // Assert
            var result = _userRepository.Read(testUser.Username);
            Assert.NotNull(result);
        }

        private User GetTestUser()
        {
            return new User
            {
                Username = "test user",
                Email = "fakeuser@email.com",
            };
        }
    }
}
