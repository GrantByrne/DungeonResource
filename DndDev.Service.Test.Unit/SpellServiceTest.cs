using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using DndDev.Service;
using DndDev.Repository;
using DndDev.Domain.Spell;

namespace DndDev.Service.Test.Unit
{
    [TestClass]
    public class SpellServiceTest
    {
        [TestMethod]
        public void SpellService_Create()
        {
            // Arrange
            var testSpell = new Spell
            {
                Name = "Butter Tarts"
            };

            var spellRepositoryMock = new Mock<ISpellRepository>();
            spellRepositoryMock.Setup(foo => foo.CreateSpell(testSpell));

            var testSpellService = new SpellService(spellRepositoryMock.Object);

            // Act
            testSpellService.CreateSpell(testSpell);

            // Assert
            spellRepositoryMock.VerifyAll();
        }
    }
}
