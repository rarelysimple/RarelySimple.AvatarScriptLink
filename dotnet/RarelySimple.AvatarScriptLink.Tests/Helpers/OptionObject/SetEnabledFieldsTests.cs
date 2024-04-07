using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.HelpersTests
{
    [TestClass]
    public class SetEnabledFieldsTests
    {
        [TestMethod]
        public void SetEnabledFields_OptionObject_ListFieldNumbers()
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
            optionObject.SetEnabledFields(fieldNumbers);
            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetEnabledFields_OptionObject_Helper_ListFieldObjects()
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
            OptionObjectHelpers.SetEnabledFields(optionObject, fieldObjects);
            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetEnabledFields_OptionObject_Helper_ListFieldNumbers()
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
            OptionObjectHelpers.SetEnabledFields(optionObject, fieldNumbers);
            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetEnabledFields_OptionObject2_ListFieldNumbers()
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
            optionObject.SetEnabledFields(fieldNumbers);
            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetEnabledFields_OptionObject2_Helper_ListFieldObjects()
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
            OptionObjectHelpers.SetEnabledFields(optionObject, fieldObjects);
            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetEnabledFields_OptionObject2_Helper_ListFieldNumbers()
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
            OptionObjectHelpers.SetEnabledFields(optionObject, fieldNumbers);
            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetEnabledFields_OptionObject2015_ListFieldNumbers()
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
            optionObject.SetEnabledFields(fieldNumbers);
            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetEnabledFields_OptionObject2015_Helper_ListFieldObjects()
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
            OptionObjectHelpers.SetEnabledFields(optionObject, fieldObjects);
            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetEnabledFields_OptionObject2015_Helper_ListFieldNumbers()
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
            OptionObjectHelpers.SetEnabledFields(optionObject, fieldNumbers);
            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetEnabledFields_FormObject_ListFieldNumbers()
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
            formObject.SetEnabledFields(fieldNumbers);
            Assert.IsTrue(formObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetEnabledFields_FormObject_Helper_ListFieldNumbers()
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
            OptionObjectHelpers.SetEnabledFields(formObject, fieldNumbers);
            Assert.IsTrue(formObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetEnabledFields_RowObject_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new(fieldNumber);
            List<string> fieldNumbers =
            [
                fieldNumber
            ];
            RowObject rowObject = new();
            rowObject.AddFieldObject(fieldObject);
            rowObject.SetEnabledFields(fieldNumbers);
            Assert.IsTrue(rowObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetEnabledFields_RowObject_Helper_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new(fieldNumber);
            List<string> fieldNumbers =
            [
                fieldNumber
            ];
            RowObject rowObject = new();
            rowObject.AddFieldObject(fieldObject);
            OptionObjectHelpers.SetEnabledFields(rowObject, fieldNumbers);
            Assert.IsTrue(rowObject.IsFieldEnabled(fieldNumber));
        }
    }
}
