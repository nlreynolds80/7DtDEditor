using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class Result_Tests
    {
        [TestMethod]
        [TestCategory("Unit")]
        public void Ok_GivenObject_ReturnsCorrectResult()
        {
            //Arrange
            var o = new Entity("test");

            //Act
            var result = Result.Ok(o);

            //Arrange
            Assert.AreEqual(o, result.Value);
            Assert.IsTrue(result.IsSuccess);
            Assert.IsFalse(result.IsFailure);
            Assert.IsNull(result.Error);
        }

        [TestMethod]
        [TestCategory("Unit")]
        public void Ok_GivenNoReturn_ReturnsCorrectResult()
        {
            //Arrange
            //Act
            var result = Result.Ok();

            //Arrange
            Assert.IsTrue(result.IsSuccess);
            Assert.IsFalse(result.IsFailure);
            Assert.IsNull(result.Error);
        }

        [TestMethod]
        [TestCategory("Unit")]
        public void Fail_ReturnsCorrectResult()
        {
            //Arrange
            //Act
            var result = Result.Fail("error");

            //Arrange
            Assert.AreEqual("error", result.Error);
            Assert.IsFalse(result.IsSuccess);
            Assert.IsTrue(result.IsFailure);
        }
    }
}
