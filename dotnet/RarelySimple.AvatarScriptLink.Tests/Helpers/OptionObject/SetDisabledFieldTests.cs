using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.HelpersTests
{
    [TestClass]
    public class SetDisabledFieldTests
    {

        [TestMethod]
        public void SetDisabledField_OptionObject_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);
            optionObject.SetDisabledField(fieldNumber);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetDisabledField_OptionObject_FieldNumber_IsNotPresent()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);
            optionObject.SetDisabledField(fieldNumber);
            Assert.IsFalse(optionObject.IsFieldEnabled("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void SetDisabledField_OptionObject_Null_FieldNumber()
        {
            string fieldNumber = "123";
            OptionObject optionObject = null;
            optionObject.SetDisabledField(fieldNumber);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetDisabledField_OptionObject_Helper_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);
            OptionObjectHelpers.SetDisabledField(optionObject, fieldNumber);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetDisabledField_OptionObject_Helper_FieldNumber_IsNotPresent()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);
            OptionObjectHelpers.SetDisabledField(optionObject, fieldNumber);
            Assert.IsFalse(optionObject.IsFieldEnabled("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetDisabledField_OptionObject_Helper_Null_FieldNumber()
        {
            string fieldNumber = "123";
            OptionObject optionObject = null;
            OptionObjectHelpers.SetDisabledField(optionObject, fieldNumber);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetDisabledField_OptionObject2_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);
            optionObject.SetDisabledField(fieldNumber);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetDisabledField_OptionObject2_FieldNumber_IsNotPresent()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);
            optionObject.SetDisabledField(fieldNumber);
            Assert.IsFalse(optionObject.IsFieldEnabled("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void SetDisabledField_OptionObject2_Null_FieldNumber()
        {
            string fieldNumber = "123";
            OptionObject2 optionObject = null;
            optionObject.SetDisabledField(fieldNumber);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetDisabledField_OptionObject2_Helper_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);
            OptionObjectHelpers.SetDisabledField(optionObject, fieldNumber);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetDisabledField_OptionObject2_Helper_FieldNumber_IsNotPresent()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);
            OptionObjectHelpers.SetDisabledField(optionObject, fieldNumber);
            Assert.IsFalse(optionObject.IsFieldEnabled("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetDisabledField_OptionObject2_Helper_Null_FieldNumber()
        {
            string fieldNumber = "123";
            OptionObject2 optionObject = null;
            OptionObjectHelpers.SetDisabledField(optionObject, fieldNumber);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetDisabledField_OptionObject2015_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);
            optionObject.SetDisabledField(fieldNumber);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetDisabledField_OptionObject2015_FieldNumber_IsNotPresent()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);
            optionObject.SetDisabledField(fieldNumber);
            Assert.IsFalse(optionObject.IsFieldEnabled("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void SetDisabledField_OptionObject2015_Null_FieldNumber()
        {
            string fieldNumber = "123";
            OptionObject2015 optionObject = null;
            optionObject.SetDisabledField(fieldNumber);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetDisabledField_OptionObject2015_Helper_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);
            OptionObjectHelpers.SetDisabledField(optionObject, fieldNumber);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetDisabledField_OptionObject2015_Helper_FieldNumber_IsNotPresent()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);
            OptionObjectHelpers.SetDisabledField(optionObject, fieldNumber);
            Assert.IsFalse(optionObject.IsFieldEnabled("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetDisabledField_OptionObject2015_Helper_Null_FieldNumber()
        {
            string fieldNumber = "123";
            OptionObject2015 optionObject = null;
            OptionObjectHelpers.SetDisabledField(optionObject, fieldNumber);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetDisabledField_FormObject_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            formObject.SetDisabledField(fieldNumber);
            Assert.IsFalse(formObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetDisabledField_FormObject_FieldNumber_IsNotPresent()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            formObject.SetDisabledField(fieldNumber);
            Assert.IsFalse(formObject.IsFieldEnabled("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void SetDisabledField_FormObject_Null_FieldNumber()
        {
            string fieldNumber = "123";
            FormObject formObject = null;
            formObject.SetDisabledField(fieldNumber);
            Assert.IsFalse(formObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetDisabledField_FormObject_Helper_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObjectHelpers.SetDisabledField(formObject, fieldNumber);
            Assert.IsFalse(formObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetDisabledField_FormObject_Helper_FieldNumber_IsNotPresent()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObjectHelpers.SetDisabledField(formObject, fieldNumber);
            Assert.IsFalse(formObject.IsFieldEnabled("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetDisabledField_FormObject_Helper_Null_FieldNumber()
        {
            string fieldNumber = "123";
            FormObject formObject = null;
            OptionObjectHelpers.SetDisabledField(formObject, fieldNumber);
            Assert.IsFalse(formObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetDisabledField_RowObject_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            rowObject.SetDisabledField(fieldNumber);
            Assert.IsFalse(rowObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetDisabledField_RowObject_FieldNumber_IsNotPresent()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            rowObject.SetDisabledField(fieldNumber);
            Assert.IsFalse(rowObject.IsFieldEnabled("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void SetDisabledField_RowObject_Null_FieldNumber()
        {
            string fieldNumber = "123";
            RowObject rowObject = null;
            rowObject.SetDisabledField(fieldNumber);
            Assert.IsFalse(rowObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetDisabledField_RowObject_Helper_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            OptionObjectHelpers.SetDisabledField(rowObject, fieldNumber);
            Assert.IsFalse(rowObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetDisabledField_RowObject_Helper_FieldNumber_IsNotPresent()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            OptionObjectHelpers.SetDisabledField(rowObject, fieldNumber);
            Assert.IsFalse(rowObject.IsFieldEnabled("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetDisabledField_RowObject_Helper_Null_FieldNumber()
        {
            string fieldNumber = "123";
            RowObject rowObject = null;
            OptionObjectHelpers.SetDisabledField(rowObject, fieldNumber);
            Assert.IsFalse(rowObject.IsFieldEnabled(fieldNumber));
        }
    }
}
