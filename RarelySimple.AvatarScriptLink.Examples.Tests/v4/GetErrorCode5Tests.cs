using Microsoft.VisualStudio.TestTools.UnitTesting;
using RarelySimple.AvatarScriptLink.Examples.Soap.v4.Shared;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Examples.Tests.v4
{
    [TestClass]
    public class GetErrorCode5Tests
    {
        [TestMethod]
        public void RunScript_GetErrorCode5_OptionObject_ReturnsErrorCode0()
        {
            // Arrange
            OptionObject optionObject = new OptionObject();

            // Act
            OptionObject returnOptionObject = GetErrorCode5.RunScript(optionObject);

            // Assert
            Assert.AreEqual(5, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        public void RunScript_GetErrorCode5_OptionObject2_ReturnsErrorCode0()
        {
            // Arrange
            OptionObject2 optionObject = new OptionObject2();

            // Act
            OptionObject2 returnOptionObject = GetErrorCode5.RunScript(optionObject);

            // Assert
            Assert.AreEqual(5, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        public void RunScript_GetErrorCode5_OptionObject2015_ReturnsErrorCode0()
        {
            // Arrange
            OptionObject2015 optionObject = new OptionObject2015();

            // Act
            OptionObject2015 returnOptionObject = GetErrorCode5.RunScript(optionObject);

            // Assert
            Assert.AreEqual(5, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        public void RunScript_GetErrorCode5_OptionObject_FormCountEquals0()
        {
            // Arrange
            OptionObject optionObject = new OptionObject();

            // Act
            OptionObject returnOptionObject = GetErrorCode5.RunScript(optionObject);

            // Assert
            Assert.AreEqual(0, returnOptionObject.Forms.Count);
        }

        [TestMethod]
        public void RunScript_GetErrorCode5_OptionObject2_FormCountEquals0()
        {
            // Arrange
            OptionObject2 optionObject = new OptionObject2();

            // Act
            OptionObject2 returnOptionObject = GetErrorCode5.RunScript(optionObject);

            // Assert
            Assert.AreEqual(0, returnOptionObject.Forms.Count);
        }

        [TestMethod]
        public void RunScript_GetErrorCode5_OptionObject2015_FormCountEquals0()
        {
            // Arrange
            OptionObject2015 optionObject = new OptionObject2015();

            // Act
            OptionObject2015 returnOptionObject = GetErrorCode5.RunScript(optionObject);

            // Assert
            Assert.AreEqual(0, returnOptionObject.Forms.Count);
        }
    }
}
