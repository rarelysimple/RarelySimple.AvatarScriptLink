using Microsoft.VisualStudio.TestTools.UnitTesting;
using RarelySimple.AvatarScriptLink.Examples.Soap.v6.Shared;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Examples.Tests.v6
{
    [TestClass]
    public class GetErrorCode6Tests
    {
        [TestMethod]
        public void RunScript_GetErrorCode6_OptionObject_ReturnsErrorCode0()
        {
            // Arrange
            OptionObject optionObject = new OptionObject();
            OptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);
            var command = new GetErrorCode6Command(optionObjectDecorator);

            // Act
            OptionObject returnOptionObject = (OptionObject)command.Execute();

            // Assert
            Assert.AreEqual(6, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        public void RunScript_GetErrorCode6_OptionObject2_ReturnsErrorCode0()
        {
            // Arrange
            OptionObject2 optionObject = new OptionObject2();
            OptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);
            var command = new GetErrorCode6Command(optionObjectDecorator);

            // Act
            OptionObject2 returnOptionObject = (OptionObject2)command.Execute();

            // Assert
            Assert.AreEqual(6, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        public void RunScript_GetErrorCode6_OptionObject2015_ReturnsErrorCode0()
        {
            // Arrange
            OptionObject2015 optionObject = new OptionObject2015();
            OptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);
            var command = new GetErrorCode6Command(optionObjectDecorator);

            // Act
            OptionObject2015 returnOptionObject = (OptionObject2015)command.Execute();

            // Assert
            Assert.AreEqual(6, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        public void RunScript_GetErrorCode6_OptionObject_FormCountEquals0()
        {
            // Arrange
            OptionObject optionObject = new OptionObject();
            OptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);
            var command = new GetErrorCode6Command(optionObjectDecorator);

            // Act
            OptionObject returnOptionObject = (OptionObject)command.Execute();

            // Assert
            Assert.AreEqual(0, returnOptionObject.Forms.Count);
        }

        [TestMethod]
        public void RunScript_GetErrorCode6_OptionObject2_FormCountEquals0()
        {
            // Arrange
            OptionObject2 optionObject = new OptionObject2();
            OptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);
            var command = new GetErrorCode6Command(optionObjectDecorator);

            // Act
            OptionObject2 returnOptionObject = (OptionObject2)command.Execute();

            // Assert
            Assert.AreEqual(0, returnOptionObject.Forms.Count);
        }

        [TestMethod]
        public void RunScript_GetErrorCode6_OptionObject2015_FormCountEquals0()
        {
            // Arrange
            OptionObject2015 optionObject = new OptionObject2015();
            OptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);
            var command = new GetErrorCode6Command(optionObjectDecorator);

            // Act
            OptionObject2015 returnOptionObject = (OptionObject2015)command.Execute();

            // Assert
            Assert.AreEqual(0, returnOptionObject.Forms.Count);
        }
    }
}
