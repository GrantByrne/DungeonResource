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
        public void GenericRepsoitory_Create_Success()
        {
            // Arrange
            var testObject = _testObjectService.GetTestObject();

            // Act
            testObject = _genericRepository.Create(testObject);

            // Assert
            Assert.IsTrue(testObject.Id > 0);
        }
    }
}
