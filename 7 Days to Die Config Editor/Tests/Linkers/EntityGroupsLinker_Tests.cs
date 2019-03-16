using System;
using System.Linq;
using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services.Linkers;

namespace Tests.Linkers
{
    [TestClass]
    public class EntityGroupsLinker_Tests
    {
        [TestMethod]
        public void Link_LinksCorrectly()
        {
            //Arrange
            var entity = new Entity("valid");
            var entities = new Entities()
            {
                entity
            };
            var entityGroup = new EntityGroup("group");
            entityGroup.AddEntity(new Entity("invalid"), "0");
            entityGroup.AddEntity(entity, "1");
            var entityGroups = new EntityGroups()
            {
                entityGroup
            };
            var linker = new EntityGroupsLinker(entityGroups);

            //Act
            entityGroups = linker.Link(entities);

            //Assert
            Assert.AreEqual(1, entityGroups.Single().EntitySubscriptions.Where(s => s.Entity.Name == "valid").Count());
            Assert.AreEqual(0, entityGroups.Single().EntitySubscriptions.Where(s => s.Entity.Name == "invalid").Count());
        }
    }
}
