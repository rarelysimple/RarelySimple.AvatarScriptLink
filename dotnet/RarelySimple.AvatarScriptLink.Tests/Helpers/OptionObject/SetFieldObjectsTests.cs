using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.Helpers
{
    [TestClass]
    public class SetFieldObjectsTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObjects_OptionObject_NullAction_FieldObjects()
        {
            string fieldNumber = "123";
            List<FieldObject> fieldObjects =
            [
                new FieldObject(fieldNumber)
            ];
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObjects(optionObject, null, fieldObjects);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObjects_OptionObject_BlankAction_FieldObjects()
        {
            string fieldNumber = "123";
            List<FieldObject> fieldObjects =
            [
                new FieldObject(fieldNumber)
            ];
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObjects(optionObject, "", fieldObjects);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetFieldObjects_OptionObject_Disabled_FieldObjects()
        {
            string fieldNumber = "123";
            List<FieldObject> fieldObjects =
            [
                new FieldObject(fieldNumber)
            ];
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObjects(optionObject, FieldAction.Disable, fieldObjects);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetFieldObjects_OptionObject_Disabled_FieldObjectsNotPresent()
        {
            string fieldNumber = "123";
            List<FieldObject> fieldObjects =
            [
                new FieldObject("234")
            ];
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObjects(optionObject, FieldAction.Disable, fieldObjects);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObjects_OptionObject_NullAction_FieldNumbers()
        {
            string fieldNumber = "123";
            List<string> fieldNumbers =
            [
                fieldNumber
            ];
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObjects(optionObject, null, fieldNumbers);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObjects_OptionObject_BlankAction_FieldNumbers()
        {
            string fieldNumber = "123";
            List<string> fieldNumbers =
            [
                fieldNumber
            ];
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObjects(optionObject, "", fieldNumbers);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetFieldObjects_OptionObject_Disabled_FieldNumbers()
        {
            string fieldNumber = "123";
            List<string> fieldNumbers =
            [
                fieldNumber
            ];
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObjects(optionObject, FieldAction.Disable, fieldNumbers);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetFieldObjects_OptionObject_Disabled_FieldNumbersNotPresent()
        {
            string fieldNumber = "123";
            List<string> fieldNumbers =
            [
                "234"
            ];
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObjects(optionObject, FieldAction.Disable, fieldNumbers);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObjects_OptionObject2_NullAction_FieldObjects()
        {
            string fieldNumber = "123";
            List<FieldObject> fieldObjects =
            [
                new FieldObject(fieldNumber)
            ];
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObjects(optionObject, null, fieldObjects);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObjects_OptionObject2_BlankAction_FieldObjects()
        {
            string fieldNumber = "123";
            List<FieldObject> fieldObjects =
            [
                new FieldObject(fieldNumber)
            ];
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObjects(optionObject, "", fieldObjects);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetFieldObjects_OptionObject2_Disabled_FieldObjects()
        {
            string fieldNumber = "123";
            List<FieldObject> fieldObjects =
            [
                new FieldObject(fieldNumber)
            ];
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObjects(optionObject, FieldAction.Disable, fieldObjects);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetFieldObjects_OptionObject2_Disabled_FieldObjectsNotPresent()
        {
            string fieldNumber = "123";
            List<FieldObject> fieldObjects =
            [
                new FieldObject("234")
            ];
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObjects(optionObject, FieldAction.Disable, fieldObjects);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObjects_OptionObject2_NullAction_FieldNumbers()
        {
            string fieldNumber = "123";
            List<string> fieldNumbers =
            [
                fieldNumber
            ];
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObjects(optionObject, null, fieldNumbers);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObjects_OptionObject2_BlankAction_FieldNumbers()
        {
            string fieldNumber = "123";
            List<string> fieldNumbers =
            [
                fieldNumber
            ];
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObjects(optionObject, "", fieldNumbers);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetFieldObjects_OptionObject2_Disabled_FieldNumbers()
        {
            string fieldNumber = "123";
            List<string> fieldNumbers =
            [
                fieldNumber
            ];
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObjects(optionObject, FieldAction.Disable, fieldNumbers);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetFieldObjects_OptionObject2_Disabled_FieldNumbersNotPresent()
        {
            string fieldNumber = "123";
            List<string> fieldNumbers =
            [
                "234"
            ];
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObjects(optionObject, FieldAction.Disable, fieldNumbers);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObjects_OptionObject2015_NullAction_FieldObjects()
        {
            string fieldNumber = "123";
            List<FieldObject> fieldObjects =
            [
                new FieldObject(fieldNumber)
            ];
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObjects(optionObject, null, fieldObjects);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObjects_OptionObject2015_BlankAction_FieldObjects()
        {
            string fieldNumber = "123";
            List<FieldObject> fieldObjects =
            [
                new FieldObject(fieldNumber)
            ];
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObjects(optionObject, "", fieldObjects);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetFieldObjects_OptionObject2015_Disabled_FieldObjects()
        {
            string fieldNumber = "123";
            List<FieldObject> fieldObjects =
            [
                new FieldObject(fieldNumber)
            ];
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObjects(optionObject, FieldAction.Disable, fieldObjects);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetFieldObjects_OptionObject2015_Disabled_FieldObjectsNotPresent()
        {
            string fieldNumber = "123";
            List<FieldObject> fieldObjects =
            [
                new FieldObject("234")
            ];
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObjects(optionObject, FieldAction.Disable, fieldObjects);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObjects_OptionObject2015_NullAction_FieldNumbers()
        {
            string fieldNumber = "123";
            List<string> fieldNumbers =
            [
                fieldNumber
            ];
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObjects(optionObject, null, fieldNumbers);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObjects_OptionObject2015_BlankAction_FieldNumbers()
        {
            string fieldNumber = "123";
            List<string> fieldNumbers =
            [
                fieldNumber
            ];
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObjects(optionObject, "", fieldNumbers);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetFieldObjects_OptionObject2015_Disabled_FieldNumbers()
        {
            string fieldNumber = "123";
            List<string> fieldNumbers =
            [
                fieldNumber
            ];
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObjects(optionObject, FieldAction.Disable, fieldNumbers);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetFieldObjects_OptionObject2015_Disabled_FieldNumbersNotPresent()
        {
            string fieldNumber = "123";
            List<string> fieldNumbers =
            [
                "234"
            ];
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new();
            optionObject.AddFormObject(formObject);

            OptionObjectHelpers.SetFieldObjects(optionObject, FieldAction.Disable, fieldNumbers);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObjects_FormObject_NullAction_FieldNumbers()
        {
            string fieldNumber = "123";
            List<string> fieldNumbers =
            [
                fieldNumber
            ];
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);

            OptionObjectHelpers.SetFieldObjects(formObject, null, fieldNumbers);

            Assert.IsFalse(formObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(formObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObjects_FormObject_BlankAction_FieldNumbers()
        {
            string fieldNumber = "123";
            List<string> fieldNumbers =
            [
                fieldNumber
            ];
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);

            OptionObjectHelpers.SetFieldObjects(formObject, "", fieldNumbers);

            Assert.IsFalse(formObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(formObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetFieldObjects_FormObject_Disabled_FieldNumbers()
        {
            string fieldNumber = "123";
            List<string> fieldNumbers =
            [
                fieldNumber
            ];
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);

            OptionObjectHelpers.SetFieldObjects(formObject, FieldAction.Disable, fieldNumbers);

            Assert.IsFalse(formObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(formObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetFieldObjects_FormObject_Disabled_FieldNumbersNotPresent()
        {
            string fieldNumber = "123";
            List<string> fieldNumbers =
            [
                "234"
            ];
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new("1");
            formObject.AddRowObject(rowObject);

            OptionObjectHelpers.SetFieldObjects(formObject, FieldAction.Disable, fieldNumbers);

            Assert.IsFalse(formObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(formObject.IsFieldRequired(fieldNumber));
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObjects_RowObject_NullAction_FieldNumbers()
        {
            string fieldNumber = "123";
            List<string> fieldNumbers =
            [
                fieldNumber
            ];
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));

            OptionObjectHelpers.SetFieldObjects(rowObject, null, fieldNumbers);

            Assert.IsFalse(rowObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(rowObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObjects_RowObject_BlankAction_FieldNumbers()
        {
            string fieldNumber = "123";
            List<string> fieldNumbers =
            [
                fieldNumber
            ];
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));

            OptionObjectHelpers.SetFieldObjects(rowObject, "", fieldNumbers);

            Assert.IsFalse(rowObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(rowObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetFieldObjects_RowObject_Disabled_FieldNumbers()
        {
            string fieldNumber = "123";
            List<string> fieldNumbers =
            [
                fieldNumber
            ];
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));

            OptionObjectHelpers.SetFieldObjects(rowObject, FieldAction.Disable, fieldNumbers);

            Assert.IsFalse(rowObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(rowObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetFieldObjects_RowObject_Disabled_FieldNumbersNotPresent()
        {
            string fieldNumber = "123";
            List<string> fieldNumbers =
            [
                "234"
            ];
            RowObject rowObject = new();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));

            OptionObjectHelpers.SetFieldObjects(rowObject, FieldAction.Disable, fieldNumbers);

            Assert.IsFalse(rowObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(rowObject.IsFieldRequired(fieldNumber));
        }
    }
}
