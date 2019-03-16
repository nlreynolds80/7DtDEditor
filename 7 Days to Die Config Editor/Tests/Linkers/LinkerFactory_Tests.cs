using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Services.Factories;
using Services.Linkers;

namespace Tests.Linkers
{
    [TestClass]
    public class LinkerFactory_Tests
    {
        [TestMethod]
        [TestCategory("Unit")]
        public void GetLinker_GivenEntityGroups_ReturnsCorrectLinker()
        {
            //Arrange
            var entityGroups = new EntityGroups();
            var linkerFactory = new LinkerFactory();

            //Act
            var linker = linkerFactory.GetLinker(entityGroups);

            //Assert
            Assert.IsInstanceOfType(linker, typeof(EntityGroupsLinker));
        }
    }
}
