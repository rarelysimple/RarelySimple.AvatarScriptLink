using Microsoft.VisualStudio.TestTools.UnitTesting;
using RarelySimple.AvatarScriptLink.Examples.Soap.v6.Shared;
using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;
using System.Collections.Generic;

namespace RarelySimple.AvatarScriptLink.Examples.Tests.v6
{
    [TestClass]
    public class SetFieldValueTests
    {
        [TestMethod]
        public void RunScript_SetFieldValue_OptionObject_ReturnsErrorCode0()
        {
            // Arrange
            FieldObject fieldObject = new FieldObject()
            {
                FieldNumber = "123",
                FieldValue = "TESTING"
            };
            RowObject rowObject = new RowObject()
            {
                Fields = new List<FieldObject>()
                {
                    fieldObject
                },
                RowId = "1||1"
            };
            FormObject formObject = new FormObject()
            {
                CurrentRow = rowObject,
                FormId = "1"
            };
            OptionObject optionObject = new OptionObject()
            {
                Forms = new List<FormObject>()
                {
                    formObject
                }
            };
            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);
            IParameter parameter = new Parameter("SetFieldValue,123");
            var command = new SetFieldValueCommand(optionObjectDecorator, parameter);

            // Act
            OptionObject returnOptionObject = (OptionObject)command.Execute();

            // Assert
            Assert.AreEqual(0, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        public void RunScript_SetFieldValue_OptionObject2_ReturnsErrorCode0()
        {
            // Arrange
            FieldObject fieldObject = new FieldObject()
            {
                FieldNumber = "123",
                FieldValue = "TESTING"
            };
            RowObject rowObject = new RowObject()
            {
                Fields = new List<FieldObject>()
                {
                    fieldObject
                },
                RowId = "1||1"
            };
            FormObject formObject = new FormObject()
            {
                CurrentRow = rowObject,
                FormId = "1"
            };
            OptionObject2 optionObject = new OptionObject2()
            {
                Forms = new List<FormObject>()
                {
                    formObject
                }
            };
            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);
            IParameter parameter = new Parameter("SetFieldValue,123");
            var command = new SetFieldValueCommand(optionObjectDecorator, parameter);

            // Act
            OptionObject2 returnOptionObject = (OptionObject2)command.Execute();

            // Assert
            Assert.AreEqual(0, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        public void RunScript_SetFieldValue_OptionObject2015_ReturnsErrorCode0()
        {
            // Arrange
            FieldObject fieldObject = new FieldObject()
            {
                FieldNumber = "123",
                FieldValue = "TESTING"
            };
            RowObject rowObject = new RowObject()
            {
                Fields = new List<FieldObject>()
                {
                    fieldObject
                },
                RowId = "1||1"
            };
            FormObject formObject = new FormObject()
            {
                CurrentRow = rowObject,
                FormId = "1"
            };
            OptionObject2015 optionObject = new OptionObject2015()
            {
                Forms = new List<FormObject>()
                {
                    formObject
                }
            };
            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);
            IParameter parameter = new Parameter("SetFieldValue,123");
            var command = new SetFieldValueCommand(optionObjectDecorator, parameter);

            // Act
            OptionObject2015 returnOptionObject = (OptionObject2015)command.Execute();

            // Assert
            Assert.AreEqual(0, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        public void RunScript_SetFieldValue_OptionObject_FormCountEquals1()
        {
            // Arrange
            FieldObject fieldObject = new FieldObject()
            {
                FieldNumber = "123",
                FieldValue = "TESTING"
            };
            RowObject rowObject = new RowObject()
            {
                Fields = new List<FieldObject>()
                {
                    fieldObject
                },
                RowId = "1||1"
            };
            FormObject formObject = new FormObject()
            {
                CurrentRow = rowObject,
                FormId = "1"
            };
            OptionObject optionObject = new OptionObject()
            {
                Forms = new List<FormObject>()
                {
                    formObject
                }
            };
            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);
            IParameter parameter = new Parameter("SetFieldValue,123");
            var command = new SetFieldValueCommand(optionObjectDecorator, parameter);

            // Act
            OptionObject returnOptionObject = (OptionObject)command.Execute();

            // Assert
            Assert.AreEqual(1, returnOptionObject.Forms.Count);
        }

        [TestMethod]
        public void RunScript_SetFieldValue_OptionObject2_FormCountEquals1()
        {
            // Arrange
            FieldObject fieldObject = new FieldObject()
            {
                FieldNumber = "123",
                FieldValue = "TESTING"
            };
            RowObject rowObject = new RowObject()
            {
                Fields = new List<FieldObject>()
                {
                    fieldObject
                },
                RowId = "1||1"
            };
            FormObject formObject = new FormObject()
            {
                CurrentRow = rowObject,
                FormId = "1"
            };
            OptionObject2 optionObject = new OptionObject2()
            {
                Forms = new List<FormObject>()
                {
                    formObject
                }
            };
            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);
            IParameter parameter = new Parameter("SetFieldValue,123");
            var command = new SetFieldValueCommand(optionObjectDecorator, parameter);

            // Act
            OptionObject2 returnOptionObject = (OptionObject2)command.Execute();

            // Assert
            Assert.AreEqual(1, returnOptionObject.Forms.Count);
        }

        [TestMethod]
        public void RunScript_SetFieldValue_OptionObject2015_FormCountEquals1()
        {
            // Arrange
            FieldObject fieldObject = new FieldObject()
            {
                FieldNumber = "123",
                FieldValue = "TESTING"
            };
            RowObject rowObject = new RowObject()
            {
                Fields = new List<FieldObject>()
                {
                    fieldObject
                },
                RowId = "1||1"
            };
            FormObject formObject = new FormObject()
            {
                CurrentRow = rowObject,
                FormId = "1"
            };
            OptionObject2015 optionObject = new OptionObject2015()
            {
                Forms = new List<FormObject>()
                {
                    formObject
                }
            };
            IOptionObjectDecorator optionObjectDecorator = new OptionObjectDecorator(optionObject);
            IParameter parameter = new Parameter("SetFieldValue,123");
            var command = new SetFieldValueCommand(optionObjectDecorator, parameter);

            // Act
            OptionObject2015 returnOptionObject = (OptionObject2015)command.Execute();

            // Assert
            Assert.AreEqual(1, returnOptionObject.Forms.Count);
        }
    }
}
