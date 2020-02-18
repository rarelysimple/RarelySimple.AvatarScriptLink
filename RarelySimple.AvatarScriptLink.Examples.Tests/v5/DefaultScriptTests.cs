using Microsoft.VisualStudio.TestTools.UnitTesting;
using RarelySimple.AvatarScriptLink.Examples.Soap.v5.Shared;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Examples.Tests.v5
{
    [TestClass]
    public class DefaultScriptTests
    {
        [TestMethod]
        public void RunScript_DefaultScript_OptionObject_ReturnsErrorCode0()
        {
            // Arrange
            OptionObject optionObject = new OptionObject();
            string scriptName = "?";
            var command = new DefaultScriptCommand(optionObject.ToOptionObject2015(), scriptName);

            // Act
            OptionObject returnOptionObject = command.Execute().ToOptionObject();

            // Assert
            Assert.AreEqual(3, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        public void RunScript_DefaultScript_OptionObject2_ReturnsErrorCode0()
        {
            // Arrange
            OptionObject2 optionObject = new OptionObject2();
            string scriptName = "?";
            var command = new DefaultScriptCommand(optionObject.ToOptionObject2015(), scriptName);

            // Act
            OptionObject2 returnOptionObject = command.Execute().ToOptionObject2();

            // Assert
            Assert.AreEqual(3, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        public void RunScript_DefaultScript_OptionObject2015_ReturnsErrorCode0()
        {
            // Arrange
            OptionObject2015 optionObject = new OptionObject2015();
            string scriptName = "?";
            var command = new DefaultScriptCommand(optionObject, scriptName);

            // Act
            OptionObject2015 returnOptionObject = command.Execute();

            // Assert
            Assert.AreEqual(3, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        public void RunScript_DefaultScript_OptionObject_FormCountEquals0()
        {
            // Arrange
            OptionObject optionObject = new OptionObject();
            string scriptName = "?";
            var command = new DefaultScriptCommand(optionObject.ToOptionObject2015(), scriptName);

            // Act
            OptionObject returnOptionObject = command.Execute().ToOptionObject();

            // Assert
            Assert.AreEqual(0, returnOptionObject.Forms.Count);
        }

        [TestMethod]
        public void RunScript_DefaultScript_OptionObject2_FormCountEquals0()
        {
            // Arrange
            OptionObject2 optionObject = new OptionObject2();
            string scriptName = "?";
            var command = new DefaultScriptCommand(optionObject.ToOptionObject2015(), scriptName);

            // Act
            OptionObject2 returnOptionObject = command.Execute().ToOptionObject2();

            // Assert
            Assert.AreEqual(0, returnOptionObject.Forms.Count);
        }

        [TestMethod]
        public void RunScript_DefaultScript_OptionObject2015_FormCountEquals0()
        {
            // Arrange
            OptionObject2015 optionObject = new OptionObject2015();
            string scriptName = "?";
            var command = new DefaultScriptCommand(optionObject, scriptName);

            // Act
            OptionObject2015 returnOptionObject = command.Execute();

            // Assert
            Assert.AreEqual(0, returnOptionObject.Forms.Count);
        }
    }
}
