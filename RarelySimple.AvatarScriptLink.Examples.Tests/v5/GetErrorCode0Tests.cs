﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using RarelySimple.AvatarScriptLink.Examples.Soap.v5.Shared;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Examples.Tests.v5
{
    [TestClass]
    public class GetErrorCode0Tests
    {
        [TestMethod]
        public void RunScript_GetErrorCode0_OptionObject_ReturnsErrorCode0()
        {
            // Arrange
            OptionObject optionObject = new OptionObject();
            var command = new GetErrorCode0Command(optionObject.ToOptionObject2015());

            // Act
            OptionObject returnOptionObject = command.Execute().ToOptionObject();

            // Assert
            Assert.AreEqual(0, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        public void RunScript_GetErrorCode0_OptionObject2_ReturnsErrorCode0()
        {
            // Arrange
            OptionObject2 optionObject = new OptionObject2();
            var command = new GetErrorCode0Command(optionObject.ToOptionObject2015());

            // Act
            OptionObject2 returnOptionObject = command.Execute().ToOptionObject2();

            // Assert
            Assert.AreEqual(0, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        public void RunScript_GetErrorCode0_OptionObject2015_ReturnsErrorCode0()
        {
            // Arrange
            OptionObject2015 optionObject = new OptionObject2015();
            var command = new GetErrorCode0Command(optionObject);

            // Act
            OptionObject2015 returnOptionObject = command.Execute();

            // Assert
            Assert.AreEqual(0, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        public void RunScript_GetErrorCode0_OptionObject_FormCountEquals0()
        {
            // Arrange
            OptionObject optionObject = new OptionObject();
            var command = new GetErrorCode0Command(optionObject.ToOptionObject2015());

            // Act
            OptionObject returnOptionObject = command.Execute().ToOptionObject();

            // Assert
            Assert.AreEqual(0, returnOptionObject.Forms.Count);
        }

        [TestMethod]
        public void RunScript_GetErrorCode0_OptionObject2_FormCountEquals0()
        {
            // Arrange
            OptionObject2 optionObject = new OptionObject2();
            var command = new GetErrorCode0Command(optionObject.ToOptionObject2015());

            // Act
            OptionObject2 returnOptionObject = command.Execute().ToOptionObject2();

            // Assert
            Assert.AreEqual(0, returnOptionObject.Forms.Count);
        }

        [TestMethod]
        public void RunScript_GetErrorCode0_OptionObject2015_FormCountEquals0()
        {
            // Arrange
            OptionObject2015 optionObject = new OptionObject2015();
            var command = new GetErrorCode0Command(optionObject);

            // Act
            OptionObject2015 returnOptionObject = command.Execute();

            // Assert
            Assert.AreEqual(0, returnOptionObject.Forms.Count);
        }
    }
}
