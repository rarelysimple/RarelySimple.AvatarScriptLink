using Microsoft.VisualStudio.TestTools.UnitTesting;
using RarelySimple.AvatarScriptLink.Examples.Soap.v5.Shared;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Examples.Tests.v5
{
    [TestClass]
    public class GetVersionCommandTests
    {
        [TestMethod]
        public void Execute_OptionObject_ReturnsString()
        {
            // Arrange
            string expected = "";
            IGetVersionCommand command = new GetVersionCommand(typeof(OptionObject));

            // Act
            var actual = command.Execute();

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void Execute_OptionObject2_ReturnsString()
        {
            // Arrange
            string expected = "";
            IGetVersionCommand command = new GetVersionCommand(typeof(OptionObject2));

            // Act
            var actual = command.Execute();

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void Execute_OptionObject2015_ReturnsString()
        {
            // Arrange
            string expected = "";
            IGetVersionCommand command = new GetVersionCommand(typeof(OptionObject2015));

            // Act
            var actual = command.Execute();

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void Execute_String_ReturnsString()
        {
            // Arrange
            string expected = "";
            IGetVersionCommand command = new GetVersionCommand(typeof(string));

            // Act
            var actual = command.Execute();

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }
    }
}
