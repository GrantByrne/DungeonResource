using System;
using NUnit.Framework;
using DungeonResource.Components.Repository.Abstract;
using DungeonResource.Components.Repository;
using Moq;
using Raven.Client;
using System.Collections.Generic;
using DungeonResource.Test.Components.Domain;
using DungeonResource.Test.Components.Service;

namespace DungeonResource.Test.Unit.Components.Repository
{
    [TestFixture]
    public class GenericRepositoryTest
    {
        private Mock<IDocumentStore> _documentStoreMock;
        private Mock<IDocumentSession> _documentSessionMock;
        private readonly IGenericRepository<TestObject> _genericRepository;
        private TestObjectService _testObjectService;

        /// <summary>
        ///     ctor
        /// </summary>
        public GenericRepositoryTest()
        {
            _documentSessionMock = new Mock<IDocumentSession>();
            _documentStoreMock = new Mock<IDocumentStore>();
            _genericRepository = new GenericRepository<TestObject>(_documentStoreMock.Object);
            _testObjectService = new TestObjectService();
        }

        [Test]
        public void GenericRepository_ReadById_Success()
        {
            // Arrange
            var testObject = _testObjectService.GetTestObject();
            _documentSessionMock.Setup(foo => foo.Load<TestObject>(12)).Returns(testObject);
            _documentStoreMock.Setup(foo => foo.OpenSession()).Returns(_documentSessionMock.Object);

            // Act
            var result = _genericRepository.Read(12);

            // Assert
            Assert.AreEqual(testObject, result);
        }
    }
}
