using Microsoft.VisualStudio.TestTools.UnitTesting;
using RarelySimple.AvatarScriptLink.Examples.Soap.v5.Shared;
using RarelySimple.AvatarScriptLink.Objects;
using System.Collections.Generic;

namespace RarelySimple.AvatarScriptLink.Examples.Tests.v5
{
    [TestClass]
    public class GetFieldValueTests
    {
        [TestMethod]
        public void RunScript_GetFieldValue_OptionObject_ReturnsErrorCode0()
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
            string parameter = "GetFieldValue,123";
            var command = new GetFieldValueCommand(optionObject.ToOptionObject2015(), parameter);

            // Act
            OptionObject returnOptionObject = command.Execute().ToOptionObject();

            // Assert
            Assert.AreEqual(3, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        public void RunScript_GetFieldValue_OptionObject2_ReturnsErrorCode0()
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
            string parameter = "GetFieldValue,123";
            var command = new GetFieldValueCommand(optionObject.ToOptionObject2015(), parameter);

            // Act
            OptionObject2 returnOptionObject = command.Execute().ToOptionObject2();

            // Assert
            Assert.AreEqual(3, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        public void RunScript_GetFieldValue_OptionObject2015_ReturnsErrorCode0()
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
            string parameter = "GetFieldValue,123";
            var command = new GetFieldValueCommand(optionObject, parameter);

            // Act
            OptionObject2015 returnOptionObject = command.Execute();

            // Assert
            Assert.AreEqual(3, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        public void RunScript_GetFieldValue_OptionObject_FormCountEquals0()
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
            string parameter = "GetFieldValue,123";
            var command = new GetFieldValueCommand(optionObject.ToOptionObject2015(), parameter);

            // Act
            OptionObject returnOptionObject = command.Execute().ToOptionObject();

            // Assert
            Assert.AreEqual(0, returnOptionObject.Forms.Count);
        }

        [TestMethod]
        public void RunScript_GetFieldValue_OptionObject2_FormCountEquals0()
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
            string parameter = "GetFieldValue,123";
            var command = new GetFieldValueCommand(optionObject.ToOptionObject2015(), parameter);

            // Act
            OptionObject2 returnOptionObject = command.Execute().ToOptionObject2();

            // Assert
            Assert.AreEqual(0, returnOptionObject.Forms.Count);
        }

        [TestMethod]
        public void RunScript_GetFieldValue_OptionObject2015_FormCountEquals0()
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
            string parameter = "GetFieldValue,123";
            var command = new GetFieldValueCommand(optionObject, parameter);

            // Act
            OptionObject2015 returnOptionObject = command.Execute();

            // Assert
            Assert.AreEqual(0, returnOptionObject.Forms.Count);
        }
    }
}
