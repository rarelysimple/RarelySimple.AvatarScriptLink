using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.HelpersTests
{
    [TestClass]
    public class SetDisabledFieldsTests
    {
        [TestMethod]
        public void SetDisabledFields_OptionObject_ListFieldNumbers()
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
            optionObject.SetDisabledFields(fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetDisabledFields_OptionObject_Helper_ListFieldObjects()
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
            OptionObjectHelpers.SetDisabledFields(optionObject, fieldObjects);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetDisabledFields_OptionObject_Helper_ListFieldNumbers()
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
            OptionObjectHelpers.SetDisabledFields(optionObject, fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetDisabledFields_OptionObject2_ListFieldNumbers()
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
            optionObject.SetDisabledFields(fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetDisabledFields_OptionObject2_Helper_ListFieldObjects()
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
            OptionObjectHelpers.SetDisabledFields(optionObject, fieldObjects);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetDisabledFields_OptionObject2_Helper_ListFieldNumbers()
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
            OptionObjectHelpers.SetDisabledFields(optionObject, fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetDisabledFields_OptionObject2015_ListFieldNumbers()
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
            optionObject.SetDisabledFields(fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetDisabledFields_OptionObject2015_Helper_ListFieldObjects()
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
            OptionObjectHelpers.SetDisabledFields(optionObject, fieldObjects);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetDisabledFields_OptionObject2015_Helper_ListFieldNumbers()
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
            OptionObjectHelpers.SetDisabledFields(optionObject, fieldNumbers);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetDisabledFields_FormObject_ListFieldNumbers()
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
            formObject.SetDisabledFields(fieldNumbers);
            Assert.IsFalse(formObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetDisabledFields_FormObject_Helper_ListFieldNumbers()
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
            OptionObjectHelpers.SetDisabledFields(formObject, fieldNumbers);
            Assert.IsFalse(formObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetDisabledFields_RowObject_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new(fieldNumber);
            List<string> fieldNumbers =
            [
                fieldNumber
            ];
            RowObject rowObject = new();
            rowObject.AddFieldObject(fieldObject);
            rowObject.SetDisabledFields(fieldNumbers);
            Assert.IsFalse(rowObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetDisabledFields_RowObject_Helper_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new(fieldNumber);
            List<string> fieldNumbers =
            [
                fieldNumber
            ];
            RowObject rowObject = new();
            rowObject.AddFieldObject(fieldObject);
            OptionObjectHelpers.SetDisabledFields(rowObject, fieldNumbers);
            Assert.IsFalse(rowObject.IsFieldEnabled(fieldNumber));
        }
    }
}
