using Microsoft.VisualStudio.TestTools.UnitTesting;
using RarelySimple.AvatarScriptLink.Examples.Soap.v4.Shared;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Examples.Tests.v4
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

            // Act
            OptionObject returnOptionObject = DefaultScript.RunScript(optionObject, scriptName);

            // Assert
            Assert.AreEqual(3, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        public void RunScript_DefaultScript_OptionObject2_ReturnsErrorCode0()
        {
            // Arrange
            OptionObject2 optionObject = new OptionObject2();
            string scriptName = "?";

            // Act
            OptionObject2 returnOptionObject = DefaultScript.RunScript(optionObject, scriptName);

            // Assert
            Assert.AreEqual(3, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        public void RunScript_DefaultScript_OptionObject2015_ReturnsErrorCode0()
        {
            // Arrange
            OptionObject2015 optionObject = new OptionObject2015();
            string scriptName = "?";

            // Act
            OptionObject2015 returnOptionObject = DefaultScript.RunScript(optionObject, scriptName);

            // Assert
            Assert.AreEqual(3, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        public void RunScript_DefaultScript_OptionObject_FormCountEquals0()
        {
            // Arrange
            OptionObject optionObject = new OptionObject();
            string scriptName = "?";

            // Act
            OptionObject returnOptionObject = DefaultScript.RunScript(optionObject, scriptName);

            // Assert
            Assert.AreEqual(0, returnOptionObject.Forms.Count);
        }

        [TestMethod]
        public void RunScript_DefaultScript_OptionObject2_FormCountEquals0()
        {
            // Arrange
            OptionObject2 optionObject = new OptionObject2();
            string scriptName = "?";

            // Act
            OptionObject2 returnOptionObject = DefaultScript.RunScript(optionObject, scriptName);

            // Assert
            Assert.AreEqual(0, returnOptionObject.Forms.Count);
        }

        [TestMethod]
        public void RunScript_DefaultScript_OptionObject2015_FormCountEquals0()
        {
            // Arrange
            OptionObject2015 optionObject = new OptionObject2015();
            string scriptName = "?";

            // Act
            OptionObject2015 returnOptionObject = DefaultScript.RunScript(optionObject, scriptName);

            // Assert
            Assert.AreEqual(0, returnOptionObject.Forms.Count);
        }
    }
}
