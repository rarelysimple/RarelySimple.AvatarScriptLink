using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RarelySimple.AvatarScriptLink.Examples.Soap.v5.Shared;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Examples.Tests.v5
{
    [TestClass]
    public class CommandFactoryTests
    {
        [TestMethod]
        public void GetCommand_OptionObject_EmptyParameter_ReturnsDefaultScriptCommand()
        {
            // Arrange
            OptionObject optionObject = new OptionObject();
            string parameter = "";
            DefaultScriptCommand expected = new DefaultScriptCommand(optionObject.ToOptionObject2015(), parameter);

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject.ToOptionObject2015(), parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject2_EmptyParameter_ReturnsDefaultScriptCommand()
        {
            // Arrange
            OptionObject2 optionObject = new OptionObject2();
            string parameter = "";
            DefaultScriptCommand expected = new DefaultScriptCommand(optionObject.ToOptionObject2015(), parameter);

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject.ToOptionObject2015(), parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject2015_EmptyParameter_ReturnsDefaultScriptCommand()
        {
            // Arrange
            OptionObject2015 optionObject = new OptionObject2015();
            string parameter = "";
            DefaultScriptCommand expected = new DefaultScriptCommand(optionObject, parameter);

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject, parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject_GetErrorCode0_ReturnsGetErrorCode0Command()
        {
            // Arrange
            OptionObject optionObject = new OptionObject();
            string parameter = "GetErrorCode0";
            GetErrorCode0Command expected = new GetErrorCode0Command(optionObject.ToOptionObject2015());

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject.ToOptionObject2015(), parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject2_GetErrorCode0_ReturnsGetErrorCode0Command()
        {
            // Arrange
            OptionObject2 optionObject = new OptionObject2();
            string parameter = "GetErrorCode0";
            GetErrorCode0Command expected = new GetErrorCode0Command(optionObject.ToOptionObject2015());

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject.ToOptionObject2015(), parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject2015_GetErrorCode0_ReturnsGetErrorCode0Command()
        {
            // Arrange
            OptionObject2015 optionObject = new OptionObject2015();
            string parameter = "GetErrorCode0";
            GetErrorCode0Command expected = new GetErrorCode0Command(optionObject);

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject, parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject_GetErrorCode1_ReturnsGetErrorCode1Command()
        {
            // Arrange
            OptionObject optionObject = new OptionObject();
            string parameter = "GetErrorCode1";
            GetErrorCode1Command expected = new GetErrorCode1Command(optionObject.ToOptionObject2015());

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject.ToOptionObject2015(), parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject2_GetErrorCode1_ReturnsGetErrorCode1Command()
        {
            // Arrange
            OptionObject2 optionObject = new OptionObject2();
            string parameter = "GetErrorCode1";
            GetErrorCode1Command expected = new GetErrorCode1Command(optionObject.ToOptionObject2015());

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject.ToOptionObject2015(), parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject2015_GetErrorCode1_ReturnsGetErrorCode1Command()
        {
            // Arrange
            OptionObject2015 optionObject = new OptionObject2015();
            string parameter = "GetErrorCode1";
            GetErrorCode1Command expected = new GetErrorCode1Command(optionObject);

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject, parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject_GetErrorCode2_ReturnsGetErrorCode2Command()
        {
            // Arrange
            OptionObject optionObject = new OptionObject();
            string parameter = "GetErrorCode2";
            GetErrorCode2Command expected = new GetErrorCode2Command(optionObject.ToOptionObject2015());

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject.ToOptionObject2015(), parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject2_GetErrorCode2_ReturnsGetErrorCode2Command()
        {
            // Arrange
            OptionObject2 optionObject = new OptionObject2();
            string parameter = "GetErrorCode2";
            GetErrorCode2Command expected = new GetErrorCode2Command(optionObject.ToOptionObject2015());

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject.ToOptionObject2015(), parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject2015_GetErrorCode2_ReturnsGetErrorCode2Command()
        {
            // Arrange
            OptionObject2015 optionObject = new OptionObject2015();
            string parameter = "GetErrorCode2";
            GetErrorCode2Command expected = new GetErrorCode2Command(optionObject);

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject, parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject_GetErrorCode3_ReturnsGetErrorCode3Command()
        {
            // Arrange
            OptionObject optionObject = new OptionObject();
            string parameter = "GetErrorCode3";
            GetErrorCode3Command expected = new GetErrorCode3Command(optionObject.ToOptionObject2015());

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject.ToOptionObject2015(), parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject2_GetErrorCode3_ReturnsGetErrorCode3Command()
        {
            // Arrange
            OptionObject2 optionObject = new OptionObject2();
            string parameter = "GetErrorCode3";
            GetErrorCode3Command expected = new GetErrorCode3Command(optionObject.ToOptionObject2015());

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject.ToOptionObject2015(), parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject2015_GetErrorCode3_ReturnsGetErrorCode3Command()
        {
            // Arrange
            OptionObject2015 optionObject = new OptionObject2015();
            string parameter = "GetErrorCode3";
            GetErrorCode3Command expected = new GetErrorCode3Command(optionObject);

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject, parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject_GetErrorCode4_ReturnsGetErrorCode4Command()
        {
            // Arrange
            OptionObject optionObject = new OptionObject();
            string parameter = "GetErrorCode4";
            GetErrorCode4Command expected = new GetErrorCode4Command(optionObject.ToOptionObject2015());

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject.ToOptionObject2015(), parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject2_GetErrorCode4_ReturnsGetErrorCode4Command()
        {
            // Arrange
            OptionObject2 optionObject = new OptionObject2();
            string parameter = "GetErrorCode4";
            GetErrorCode4Command expected = new GetErrorCode4Command(optionObject.ToOptionObject2015());

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject.ToOptionObject2015(), parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject2015_GetErrorCode4_ReturnsGetErrorCode4Command()
        {
            // Arrange
            OptionObject2015 optionObject = new OptionObject2015();
            string parameter = "GetErrorCode4";
            GetErrorCode4Command expected = new GetErrorCode4Command(optionObject);

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject, parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject_GetErrorCode5_ReturnsGetErrorCode5Command()
        {
            // Arrange
            OptionObject optionObject = new OptionObject();
            string parameter = "GetErrorCode5";
            GetErrorCode5Command expected = new GetErrorCode5Command(optionObject.ToOptionObject2015());

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject.ToOptionObject2015(), parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject2_GetErrorCode5_ReturnsGetErrorCode5Command()
        {
            // Arrange
            OptionObject2 optionObject = new OptionObject2();
            string parameter = "GetErrorCode5";
            GetErrorCode5Command expected = new GetErrorCode5Command(optionObject.ToOptionObject2015());

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject.ToOptionObject2015(), parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject2015_GetErrorCode5_ReturnsGetErrorCode5Command()
        {
            // Arrange
            OptionObject2015 optionObject = new OptionObject2015();
            string parameter = "GetErrorCode5";
            GetErrorCode5Command expected = new GetErrorCode5Command(optionObject);

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject, parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject_GetErrorCode6_ReturnsGetErrorCode6Command()
        {
            // Arrange
            OptionObject optionObject = new OptionObject();
            string parameter = "GetErrorCode6";
            GetErrorCode6Command expected = new GetErrorCode6Command(optionObject.ToOptionObject2015());

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject.ToOptionObject2015(), parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject2_GetErrorCode6_ReturnsGetErrorCode6Command()
        {
            // Arrange
            OptionObject2 optionObject = new OptionObject2();
            string parameter = "GetErrorCode6";
            GetErrorCode6Command expected = new GetErrorCode6Command(optionObject.ToOptionObject2015());

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject.ToOptionObject2015(), parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject2015_GetErrorCode6_ReturnsGetErrorCode6Command()
        {
            // Arrange
            OptionObject2015 optionObject = new OptionObject2015();
            string parameter = "GetErrorCode6";
            GetErrorCode6Command expected = new GetErrorCode6Command(optionObject);

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject, parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject_GetFieldValue_ReturnsGetFieldValueCommand()
        {
            // Arrange
            OptionObject optionObject = new OptionObject();
            string parameter = "GetFieldValue,123";
            GetFieldValueCommand expected = new GetFieldValueCommand(optionObject.ToOptionObject2015(), parameter);

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject.ToOptionObject2015(), parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject2_GetFieldValue_ReturnsGetFieldValueCommand()
        {
            // Arrange
            OptionObject2 optionObject = new OptionObject2();
            string parameter = "GetFieldValue,123";
            GetFieldValueCommand expected = new GetFieldValueCommand(optionObject.ToOptionObject2015(), parameter);

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject.ToOptionObject2015(), parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject2015_GetFieldValue_ReturnsGetFieldValueCommand()
        {
            // Arrange
            OptionObject2015 optionObject = new OptionObject2015();
            string parameter = "GetFieldValue,123";
            GetFieldValueCommand expected = new GetFieldValueCommand(optionObject, parameter);

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject, parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject_SetFieldValue_ReturnsSetFieldValueCommand()
        {
            // Arrange
            OptionObject optionObject = new OptionObject();
            string parameter = "SetFieldValue,123";
            SetFieldValueCommand expected = new SetFieldValueCommand(optionObject.ToOptionObject2015(), parameter);

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject.ToOptionObject2015(), parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject2_SetFieldValue_ReturnsSetFieldValueCommand()
        {
            // Arrange
            OptionObject2 optionObject = new OptionObject2();
            string parameter = "SetFieldValue,123";
            SetFieldValueCommand expected = new SetFieldValueCommand(optionObject.ToOptionObject2015(), parameter);

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject.ToOptionObject2015(), parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void GetCommand_OptionObject2015_SetFieldValue_ReturnsSetFieldValueCommand()
        {
            // Arrange
            OptionObject2015 optionObject = new OptionObject2015();
            string parameter = "SetFieldValue,123";
            SetFieldValueCommand expected = new SetFieldValueCommand(optionObject, parameter);

            // Act
            IRunScriptCommand actual = CommandFactory.GetCommand(optionObject, parameter);

            // Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }
    }
}
