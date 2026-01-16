using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.HelpersTests
{
    [TestClass]
    public class SetEnabledFieldTests
    {

        [TestMethod]
        public void SetEnabledField_OptionObject_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new(fieldNumber);
            RowObject rowObject = new();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new();
            optionObject.AddFormObject(formObject);
            optionObject.SetEnabledField(fieldNumber);
            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetEnabledField_OptionObject_Helper_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new(fieldNumber);
            RowObject rowObject = new();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new();
            optionObject.AddFormObject(formObject);
            OptionObjectHelpers.SetEnabledField(optionObject, fieldNumber);
            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetEnabledField_OptionObject2_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new(fieldNumber);
            RowObject rowObject = new();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new();
            optionObject.AddFormObject(formObject);
            optionObject.SetEnabledField(fieldNumber);
            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetEnabledField_OptionObject2_Helper_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new(fieldNumber);
            RowObject rowObject = new();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new();
            optionObject.AddFormObject(formObject);
            OptionObjectHelpers.SetEnabledField(optionObject, fieldNumber);
            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetEnabledField_OptionObject2015_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new(fieldNumber);
            RowObject rowObject = new();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new();
            optionObject.AddFormObject(formObject);
            optionObject.SetEnabledField(fieldNumber);
            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetEnabledField_OptionObject2015_Helper_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new(fieldNumber);
            RowObject rowObject = new();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new();
            optionObject.AddFormObject(formObject);
            OptionObjectHelpers.SetEnabledField(optionObject, fieldNumber);
            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetEnabledField_FormObject_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new(fieldNumber);
            RowObject rowObject = new();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            formObject.SetEnabledField(fieldNumber);
            Assert.IsTrue(formObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetEnabledField_FormObject_Helper_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new(fieldNumber);
            RowObject rowObject = new();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObjectHelpers.SetEnabledField(formObject, fieldNumber);
            Assert.IsTrue(formObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetEnabledField_RowObject_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new(fieldNumber);
            RowObject rowObject = new();
            rowObject.AddFieldObject(fieldObject);
            rowObject.SetEnabledField(fieldNumber);
            Assert.IsTrue(rowObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetEnabledField_RowObject_Helper_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new(fieldNumber);
            RowObject rowObject = new();
            rowObject.AddFieldObject(fieldObject);
            OptionObjectHelpers.SetEnabledField(rowObject, fieldNumber);
            Assert.IsTrue(rowObject.IsFieldEnabled(fieldNumber));
        }
    }
}
