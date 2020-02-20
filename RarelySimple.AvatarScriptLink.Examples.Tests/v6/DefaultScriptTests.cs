using Microsoft.VisualStudio.TestTools.UnitTesting;
using RarelySimple.AvatarScriptLink.Examples.Soap.v6.Shared;
using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;

namespace RarelySimple.AvatarScriptLink.Examples.Tests.v6
{
    [TestClass]
    public class DefaultScriptTests
    {
        [TestMethod]
        public void RunScript_DefaultScript_OptionObject_ReturnsErrorCode0()
        {
            // Arrange
            OptionObject optionObject = new OptionObject();
            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);
            IParameter parameter = new Parameter("?");
            var command = new DefaultScriptCommand(optionObjectDecorator, parameter);

            // Act
            OptionObject returnOptionObject = (OptionObject)command.Execute();

            // Assert
            Assert.AreEqual(3, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        public void RunScript_DefaultScript_OptionObject2_ReturnsErrorCode0()
        {
            // Arrange
            OptionObject2 optionObject = new OptionObject2();
            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);
            IParameter parameter = new Parameter("?");
            var command = new DefaultScriptCommand(optionObjectDecorator, parameter);

            // Act
            OptionObject2 returnOptionObject = (OptionObject2)command.Execute();

            // Assert
            Assert.AreEqual(3, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        public void RunScript_DefaultScript_OptionObject2015_ReturnsErrorCode0()
        {
            // Arrange
            OptionObject2015 optionObject = new OptionObject2015();
            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);
            IParameter parameter = new Parameter("?");
            var command = new DefaultScriptCommand(optionObjectDecorator, parameter);

            // Act
            OptionObject2015 returnOptionObject = (OptionObject2015)command.Execute();

            // Assert
            Assert.AreEqual(3, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        public void RunScript_DefaultScript_OptionObject_FormCountEquals0()
        {
            // Arrange
            OptionObject optionObject = new OptionObject();
            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);
            IParameter parameter = new Parameter("?");
            var command = new DefaultScriptCommand(optionObjectDecorator, parameter);

            // Act
            OptionObject returnOptionObject = (OptionObject)command.Execute();

            // Assert
            Assert.AreEqual(0, returnOptionObject.Forms.Count);
        }

        [TestMethod]
        public void RunScript_DefaultScript_OptionObject2_FormCountEquals0()
        {
            // Arrange
            OptionObject2 optionObject = new OptionObject2();
            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);
            IParameter parameter = new Parameter("?");
            var command = new DefaultScriptCommand(optionObjectDecorator, parameter);

            // Act
            OptionObject2 returnOptionObject = (OptionObject2)command.Execute();

            // Assert
            Assert.AreEqual(0, returnOptionObject.Forms.Count);
        }

        [TestMethod]
        public void RunScript_DefaultScript_OptionObject2015_FormCountEquals0()
        {
            // Arrange
            OptionObject2015 optionObject = new OptionObject2015();
            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);
            IParameter parameter = new Parameter("?");
            var command = new DefaultScriptCommand(optionObjectDecorator, parameter);

            // Act
            OptionObject2015 returnOptionObject = (OptionObject2015)command.Execute();

            // Assert
            Assert.AreEqual(0, returnOptionObject.Forms.Count);
        }
    }
}
