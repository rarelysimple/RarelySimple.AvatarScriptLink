using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.Helpers
{
    [TestClass]
    public class IsFieldModifiedTests
    {
        [TestMethod]
        public void IsFieldModified_OptionObject_IsFalse()
        {
            // Arrange
            FieldObject fieldObject01 = new FieldObject("123", "");
            FieldObject fieldObject02 = new FieldObject("124", "");
            FieldObject fieldObject03 = new FieldObject("125", "");
            RowObject rowObject01 = new RowObject("1||1", new List<FieldObject>() { fieldObject01, fieldObject02, fieldObject03 });
            FormObject formObject = new FormObject("1", rowObject01);
            OptionObject optionObject = new OptionObject()
            {
                Forms = new List<FormObject>()
                {
                    formObject
                }
            };

            // Act

            // Assert
            Assert.IsFalse(optionObject.IsFieldModified("123"));
        }

        [TestMethod]
        public void IsFieldModified_OptionObject_IsTrue()
        {
            // Arrange
            FieldObject fieldObject01 = new FieldObject("123", "");
            FieldObject fieldObject02 = new FieldObject("124", "");
            FieldObject fieldObject03 = new FieldObject("125", "");
            RowObject rowObject01 = new RowObject("1||1", new List<FieldObject>() { fieldObject01, fieldObject02, fieldObject03 });
            FormObject formObject = new FormObject("1", rowObject01);
            OptionObject optionObject = new OptionObject()
            {
                Forms = new List<FormObject>()
                {
                    formObject
                }
            };

            // Act
            optionObject.SetFieldValue("123", "MODIFIED");

            // Assert
            Assert.IsTrue(optionObject.IsFieldModified("123"));
        }

        [TestMethod]
        public void IsFieldModified_OptionObject2_IsFalse()
        {
            // Arrange
            FieldObject fieldObject01 = new FieldObject("123", "");
            FieldObject fieldObject02 = new FieldObject("124", "");
            FieldObject fieldObject03 = new FieldObject("125", "");
            RowObject rowObject01 = new RowObject("1||1", new List<FieldObject>() { fieldObject01, fieldObject02, fieldObject03 });
            FormObject formObject = new FormObject("1", rowObject01);
            OptionObject2 optionObject = new OptionObject2()
            {
                Forms = new List<FormObject>()
                {
                    formObject
                }
            };

            // Act

            // Assert
            Assert.IsFalse(optionObject.IsFieldModified("123"));
        }

        [TestMethod]
        public void IsFieldModified_OptionObject2_IsTrue()
        {
            // Arrange
            FieldObject fieldObject01 = new FieldObject("123", "");
            FieldObject fieldObject02 = new FieldObject("124", "");
            FieldObject fieldObject03 = new FieldObject("125", "");
            RowObject rowObject01 = new RowObject("1||1", new List<FieldObject>() { fieldObject01, fieldObject02, fieldObject03 });
            FormObject formObject = new FormObject("1", rowObject01);
            OptionObject2 optionObject = new OptionObject2()
            {
                Forms = new List<FormObject>()
                {
                    formObject
                }
            };

            // Act
            optionObject.SetFieldValue("123", "MODIFIED");

            // Assert
            Assert.IsTrue(optionObject.IsFieldModified("123"));
        }

        [TestMethod]
        public void IsFieldModified_OptionObject2015_IsFalse()
        {
            // Arrange
            FieldObject fieldObject01 = new FieldObject("123", "");
            FieldObject fieldObject02 = new FieldObject("124", "");
            FieldObject fieldObject03 = new FieldObject("125", "");
            RowObject rowObject01 = new RowObject("1||1", new List<FieldObject>() { fieldObject01, fieldObject02, fieldObject03 });
            FormObject formObject = new FormObject("1", rowObject01);
            OptionObject2015 optionObject = new OptionObject2015()
            {
                Forms = new List<FormObject>()
                {
                    formObject
                }
            };

            // Act

            // Assert
            Assert.IsFalse(optionObject.IsFieldModified("123"));
        }

        [TestMethod]
        public void IsFieldModified_OptionObject2015_IsTrue()
        {
            // Arrange
            FieldObject fieldObject01 = new FieldObject("123", "");
            FieldObject fieldObject02 = new FieldObject("124", "");
            FieldObject fieldObject03 = new FieldObject("125", "");
            RowObject rowObject01 = new RowObject("1||1", new List<FieldObject>() { fieldObject01, fieldObject02, fieldObject03 });
            FormObject formObject = new FormObject("1", rowObject01);
            OptionObject2015 optionObject = new OptionObject2015()
            {
                Forms = new List<FormObject>()
                {
                    formObject
                }
            };

            // Act
            optionObject.SetFieldValue("123", "MODIFIED");

            // Assert
            Assert.IsTrue(optionObject.IsFieldModified("123"));
        }

        [TestMethod]
        public void IsFieldModified_FormObject_IsFalse()
        {
            // Arrange
            FieldObject fieldObject01 = new FieldObject("123", "");
            FieldObject fieldObject02 = new FieldObject("124", "");
            FieldObject fieldObject03 = new FieldObject("125", "");
            RowObject rowObject01 = new RowObject("1||1", new List<FieldObject>() { fieldObject01, fieldObject02, fieldObject03 });
            FormObject formObject = new FormObject("1", rowObject01);

            // Act

            // Assert
            Assert.IsFalse(formObject.IsFieldModified("123"));
        }

        [TestMethod]
        public void IsFieldModified_FormObject_IsTrue()
        {
            // Arrange
            FieldObject fieldObject01 = new FieldObject("123", "");
            FieldObject fieldObject02 = new FieldObject("124", "");
            FieldObject fieldObject03 = new FieldObject("125", "");
            RowObject rowObject01 = new RowObject("1||1", new List<FieldObject>() { fieldObject01, fieldObject02, fieldObject03 });
            FormObject formObject = new FormObject("1", rowObject01);

            // Act
            formObject.SetFieldValue("123", "MODIFIED");

            // Assert
            Assert.IsTrue(formObject.IsFieldModified("123"));
        }

        [TestMethod]
        public void IsFieldModified_RowObject_IsFalse()
        {
            // Arrange
            FieldObject fieldObject01 = new FieldObject("123", "");
            FieldObject fieldObject02 = new FieldObject("124", "");
            FieldObject fieldObject03 = new FieldObject("125", "");
            RowObject rowObject01 = new RowObject("1||1", new List<FieldObject>() { fieldObject01, fieldObject02, fieldObject03 });

            // Act

            // Assert
            Assert.IsFalse(rowObject01.IsFieldModified("123"));
        }

        [TestMethod]
        public void IsFieldModified_RowObject_IsTrue()
        {
            // Arrange
            FieldObject fieldObject01 = new FieldObject("123", "");
            FieldObject fieldObject02 = new FieldObject("124", "");
            FieldObject fieldObject03 = new FieldObject("125", "");
            RowObject rowObject01 = new RowObject("1||1", new List<FieldObject>() { fieldObject01, fieldObject02, fieldObject03 });

            // Act
            rowObject01.SetFieldValue("123", "MODIFIED");

            // Assert
            Assert.IsTrue(rowObject01.IsFieldModified("123"));
        }
    }
}
