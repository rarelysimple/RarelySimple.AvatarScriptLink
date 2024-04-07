using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.HelpersTests
{
    [TestClass]
    public class SetOptionalFieldsTests
    {
        [TestMethod]
        public void SetOptionalFields_OptionObject_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new(fieldNumber);
            List<string> fieldNumbers =
            [
                fieldNumber
            ];
            RowObject rowObject = new();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new();
            optionObject.AddFormObject(formObject);
            optionObject.SetOptionalFields(fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetOptionalFields_OptionObject_Helper_ListFieldObjects()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new(fieldNumber);
            List<FieldObject> fieldObjects =
            [
                fieldObject
            ];
            RowObject rowObject = new();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new();
            optionObject.AddFormObject(formObject);
            OptionObjectHelpers.SetOptionalFields(optionObject, fieldObjects);
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetOptionalFields_OptionObject_Helper_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new(fieldNumber);
            List<string> fieldNumbers =
            [
                fieldNumber
            ];
            RowObject rowObject = new();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new();
            optionObject.AddFormObject(formObject);
            OptionObjectHelpers.SetOptionalFields(optionObject, fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetOptionalFields_OptionObject2_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new(fieldNumber);
            List<string> fieldNumbers =
            [
                fieldNumber
            ];
            RowObject rowObject = new();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new();
            optionObject.AddFormObject(formObject);
            optionObject.SetOptionalFields(fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetOptionalFields_OptionObject2_Helper_ListFieldObjects()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new(fieldNumber);
            List<FieldObject> fieldObjects =
            [
                fieldObject
            ];
            RowObject rowObject = new();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new();
            optionObject.AddFormObject(formObject);
            OptionObjectHelpers.SetOptionalFields(optionObject, fieldObjects);
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetOptionalFields_OptionObject2015_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new(fieldNumber);
            List<string> fieldNumbers =
            [
                fieldNumber
            ];
            RowObject rowObject = new();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new();
            optionObject.AddFormObject(formObject);
            optionObject.SetOptionalFields(fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetOptionalFields_OptionObject2015_Helper_ListFieldObjects()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new(fieldNumber);
            List<FieldObject> fieldObjects =
            [
                fieldObject
            ];
            RowObject rowObject = new();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new();
            optionObject.AddFormObject(formObject);
            OptionObjectHelpers.SetOptionalFields(optionObject, fieldObjects);
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetOptionalFields_OptionObject2015_Helper_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new(fieldNumber);
            List<string> fieldNumbers =
            [
                fieldNumber
            ];
            RowObject rowObject = new();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new();
            optionObject.AddFormObject(formObject);
            OptionObjectHelpers.SetOptionalFields(optionObject, fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetOptionalFields_FormObject_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new(fieldNumber);
            List<string> fieldNumbers =
            [
                fieldNumber
            ];
            RowObject rowObject = new();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            formObject.SetOptionalFields(fieldNumbers);
            Assert.IsFalse(formObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetOptionalFields_FormObject_Helper_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new(fieldNumber);
            List<string> fieldNumbers =
            [
                fieldNumber
            ];
            RowObject rowObject = new();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObjectHelpers.SetOptionalFields(formObject, fieldNumbers);
            Assert.IsFalse(formObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetOptionalFields_RowObject_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new(fieldNumber);
            List<string> fieldNumbers =
            [
                fieldNumber
            ];
            RowObject rowObject = new();
            rowObject.AddFieldObject(fieldObject);
            rowObject.SetOptionalFields(fieldNumbers);
            Assert.IsFalse(rowObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetOptionalFields_RowObject_Helper_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new(fieldNumber);
            List<string> fieldNumbers =
            [
                fieldNumber
            ];
            RowObject rowObject = new();
            rowObject.AddFieldObject(fieldObject);
            OptionObjectHelpers.SetOptionalFields(rowObject, fieldNumbers);
            Assert.IsFalse(rowObject.IsFieldRequired(fieldNumber));
        }
    }
}
