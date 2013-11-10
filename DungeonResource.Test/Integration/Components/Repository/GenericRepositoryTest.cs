using System;
using DungeonResource.Test.Components.Domain;
using DungeonResource.Components.Repository;
using Raven.Client;
using Raven.Client.Embedded;
using DungeonResource.Test.Components.Service;
using NUnit.Framework;

namespace DungeonResource.Test.Integration.Components.Repository
{
    [TestFixture]
    public class GenericRepositoryTest
    {
        private readonly IGenericRepository<TestObject> _genericRepository;
        private readonly TestObjectService _testObjectService;

        public GenericRepositoryTest()
        {
            IDocumentStore documentStore = new EmbeddableDocumentStore
            {
                RunInMemory = true,
                Configuration = { 
                    RunInUnreliableYetFastModeThatIsNotSuitableForProduction = true
                }
            };
            documentStore.Initialize();

            _genericRepository = new GenericRepository<TestObject>(documentStore);
            _testObjectService = new TestObjectService();
        }

        [Test]
        public void GenericRepository_Create_Success()
        {
            // Arrange
            var testObject = _testObjectService.GetTestObject();

            // Act
            var result = _genericRepository.Create(testObject);

            // Assert
            Assert.IsTrue(result.Id > 0);
            Assert.IsTrue(testObject.Title == result.Title);
            Assert.IsTrue(testObject.Description == result.Description);
        }

        [Test]
        public void GenericRepository_Delete_Succes()
        {
            // Arrange
            var testObject = _testObjectService.GetTestObject();
            testObject = _genericRepository.Create(testObject);
            var id = testObject.Id;

            // Act
            _genericRepository.Delete(id);

            // Assert
            var result = _genericRepository.Read(id);
            Assert.IsNull(result);
        }

        [Test]
        public void GenericRepository_Update_Success()
        {
            // Arrange
            var testObject = _testObjectService.GetTestObject();
            testObject = _genericRepository.Create(testObject);
            var newTestObject = testObject;
            newTestObject.Title = "New Test Object Title";

            // Act
            _genericRepository.Update(newTestObject);

            // Assert
            var result = _genericRepository.Read(testObject.Id);
            Assert.AreEqual(result.Id, newTestObject.Id);
            Assert.AreEqual(result.Title, newTestObject.Title);
            Assert.AreEqual(result.Description, newTestObject.Description);
        }

        [Test]
        public void GenericRepository_Read_Success()
        {
            // Arrange
            var testObject = _testObjectService.GetTestObject();
            testObject = _genericRepository.Create(testObject);

            // Act
            var result = _genericRepository.Read(testObject.Id);

            // Assert
            Assert.AreEqual(testObject.Title, result.Title);
            Assert.AreEqual(testObject.Description, result.Description);
        }

        [Test]
        public void GenericRepository_ReadAll_Success()
        {
            // Arrange
            var testObjects = _testObjectService.GetTestObjectCollection(100);
            foreach(var testObject in testObjects)
            {
                _genericRepository.Create(testObject);
            }

            // Act
            var result = _genericRepository.Read();

            // Assert
            Assert.IsTrue(testObjects.Count <= result.Count);
        }

        [Test]
        public void GenericRepository_ReadPaged_Success()
        {
            // Arrange
            var testObjects = _testObjectService.GetTestObjectCollection(100);
            foreach (var testObject in testObjects)
            {
                _genericRepository.Create(testObject);
            }

            // Act
            var result = _genericRepository.Read(2, 20);

            // Assert
            Assert.AreEqual(20, result.Count);
        }

        [Test]
        public void GenericRepository_ReadPaged_ArgumentException()
        {
            Assert.Throws(typeof(ArgumentException), ()=>_genericRepository.Read(2, 1001));
        }
    }
}
