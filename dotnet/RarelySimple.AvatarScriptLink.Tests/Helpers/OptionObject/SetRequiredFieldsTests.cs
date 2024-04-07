using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.HelpersTests
{
    [TestClass]
    public class SetRequiredFieldsTests
    {
        [TestMethod]
        public void SetRequiredFields_OptionObject_ListFieldNumbers()
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
            optionObject.SetRequiredFields(fieldNumbers);
            Assert.IsTrue(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetRequiredFields_OptionObject_Helper_ListFieldObjects()
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
            OptionObjectHelpers.SetRequiredFields(optionObject, fieldObjects);
            Assert.IsTrue(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetRequiredFields_OptionObject_Helper_ListFieldNumbers()
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
            OptionObjectHelpers.SetRequiredFields(optionObject, fieldNumbers);
            Assert.IsTrue(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetRequiredFields_OptionObject2_ListFieldNumbers()
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
            optionObject.SetRequiredFields(fieldNumbers);
            Assert.IsTrue(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetRequiredFields_OptionObject2_Helper_ListFieldObjects()
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
            OptionObjectHelpers.SetRequiredFields(optionObject, fieldObjects);
            Assert.IsTrue(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetRequiredFields_OptionObject2_Helper_ListFieldNumbers()
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
            OptionObjectHelpers.SetRequiredFields(optionObject, fieldNumbers);
            Assert.IsTrue(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetRequiredFields_OptionObject2015_ListFieldNumbers()
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
            optionObject.SetRequiredFields(fieldNumbers);
            Assert.IsTrue(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetRequiredFields_OptionObject2015_Helper_ListFieldObjects()
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
            OptionObjectHelpers.SetRequiredFields(optionObject, fieldObjects);
            Assert.IsTrue(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetRequiredFields_OptionObject2015_Helper_ListFieldNumbers()
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
            OptionObjectHelpers.SetRequiredFields(optionObject, fieldNumbers);
            Assert.IsTrue(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetRequiredFields_FormObject_ListFieldNumbers()
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
            formObject.SetRequiredFields(fieldNumbers);
            Assert.IsTrue(formObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetRequiredFields_FormObject_Helper_ListFieldNumbers()
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
            OptionObjectHelpers.SetRequiredFields(formObject, fieldNumbers);
            Assert.IsTrue(formObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetRequiredFields_RowObject_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new(fieldNumber);
            List<string> fieldNumbers =
            [
                fieldNumber
            ];
            RowObject rowObject = new();
            rowObject.AddFieldObject(fieldObject);
            rowObject.SetRequiredFields(fieldNumbers);
            Assert.IsTrue(rowObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetRequiredFields_RowObject_Helper_ListFieldNumbers()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new(fieldNumber);
            List<string> fieldNumbers =
            [
                fieldNumber
            ];
            RowObject rowObject = new();
            rowObject.AddFieldObject(fieldObject);
            OptionObjectHelpers.SetRequiredFields(rowObject, fieldNumbers);
            Assert.IsTrue(rowObject.IsFieldRequired(fieldNumber));
        }
    }
}
