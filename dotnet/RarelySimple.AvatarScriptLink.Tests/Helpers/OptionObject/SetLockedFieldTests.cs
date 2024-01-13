using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.HelpersTests
{
    [TestClass]
    public class SetLockedFieldTests
    {

        [TestMethod]
        public void SetLockedField_OptionObject_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);
            optionObject.SetLockedField(fieldNumber);
            Assert.IsTrue(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetLockedField_OptionObject_FieldNumber_IsNotPresent()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);
            optionObject.SetLockedField(fieldNumber);
            Assert.IsFalse(optionObject.IsFieldLocked("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void SetLockedField_OptionObject_Null_FieldNumber()
        {
            string fieldNumber = "123";
            OptionObject optionObject = null;
            optionObject.SetLockedField(fieldNumber);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void SetLockedField_OptionObject_Helper_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);
            OptionObjectHelpers.SetLockedField(optionObject, fieldNumber);
            Assert.IsTrue(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetLockedField_OptionObject_Helper_FieldNumber_IsNotPresent()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);
            OptionObjectHelpers.SetLockedField(optionObject, fieldNumber);
            Assert.IsFalse(optionObject.IsFieldLocked("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetLockedField_OptionObject_Helper_Null_FieldNumber()
        {
            string fieldNumber = "123";
            OptionObject optionObject = null;
            OptionObjectHelpers.SetLockedField(optionObject, fieldNumber);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void SetLockedField_OptionObject2_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);
            optionObject.SetLockedField(fieldNumber);
            Assert.IsTrue(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetLockedField_OptionObject2_FieldNumber_IsNotPresent()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);
            optionObject.SetLockedField(fieldNumber);
            Assert.IsFalse(optionObject.IsFieldLocked("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void SetLockedField_OptionObject2_Null_FieldNumber()
        {
            string fieldNumber = "123";
            OptionObject2 optionObject = null;
            optionObject.SetLockedField(fieldNumber);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void SetLockedField_OptionObject2_Helper_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);
            OptionObjectHelpers.SetLockedField(optionObject, fieldNumber);
            Assert.IsTrue(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetLockedField_OptionObject2_Helper_FieldNumber_IsNotPresent()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);
            OptionObjectHelpers.SetLockedField(optionObject, fieldNumber);
            Assert.IsFalse(optionObject.IsFieldLocked("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetLockedField_OptionObject2_Helper_Null_FieldNumber()
        {
            string fieldNumber = "123";
            OptionObject2 optionObject = null;
            OptionObjectHelpers.SetLockedField(optionObject, fieldNumber);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void SetLockedField_OptionObject2015_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);
            optionObject.SetLockedField(fieldNumber);
            Assert.IsTrue(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetLockedField_OptionObject2015_FieldNumber_IsNotPresent()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);
            optionObject.SetLockedField(fieldNumber);
            Assert.IsFalse(optionObject.IsFieldLocked("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void SetLockedField_OptionObject2015_Null_FieldNumber()
        {
            string fieldNumber = "123";
            OptionObject2015 optionObject = null;
            optionObject.SetLockedField(fieldNumber);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void SetLockedField_OptionObject2015_Helper_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);
            OptionObjectHelpers.SetLockedField(optionObject, fieldNumber);
            Assert.IsTrue(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetLockedField_OptionObject2015_Helper_FieldNumber_IsNotPresent()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);
            OptionObjectHelpers.SetLockedField(optionObject, fieldNumber);
            Assert.IsFalse(optionObject.IsFieldLocked("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetLockedField_OptionObject2015_Helper_Null_FieldNumber()
        {
            string fieldNumber = "123";
            OptionObject2015 optionObject = null;
            OptionObjectHelpers.SetLockedField(optionObject, fieldNumber);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void SetLockedField_FormObject_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            formObject.SetLockedField(fieldNumber);
            Assert.IsTrue(formObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetLockedField_FormObject_FieldNumber_IsNotPresent()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            formObject.SetLockedField(fieldNumber);
            Assert.IsFalse(formObject.IsFieldLocked("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void SetLockedField_FormObject_Null_FieldNumber()
        {
            string fieldNumber = "123";
            FormObject formObject = null;
            formObject.SetLockedField(fieldNumber);
            Assert.IsFalse(formObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void SetLockedField_FormObject_Helper_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObjectHelpers.SetLockedField(formObject, fieldNumber);
            Assert.IsTrue(formObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetLockedField_FormObject_Helper_FieldNumber_IsNotPresent()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObjectHelpers.SetLockedField(formObject, fieldNumber);
            Assert.IsFalse(formObject.IsFieldLocked("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetLockedField_FormObject_Helper_Null_FieldNumber()
        {
            string fieldNumber = "123";
            FormObject formObject = null;
            OptionObjectHelpers.SetLockedField(formObject, fieldNumber);
            Assert.IsFalse(formObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void SetLockedField_RowObject_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            rowObject.SetLockedField(fieldNumber);
            Assert.IsTrue(rowObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetLockedField_RowObject_FieldNumber_IsNotPresent()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            rowObject.SetLockedField(fieldNumber);
            Assert.IsFalse(rowObject.IsFieldLocked("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void SetLockedField_RowObject_Null_FieldNumber()
        {
            string fieldNumber = "123";
            RowObject rowObject = null;
            rowObject.SetLockedField(fieldNumber);
            Assert.IsFalse(rowObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void SetLockedField_RowObject_Helper_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            OptionObjectHelpers.SetLockedField(rowObject, fieldNumber);
            Assert.IsTrue(rowObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetLockedField_RowObject_Helper_FieldNumber_IsNotPresent()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            OptionObjectHelpers.SetLockedField(rowObject, fieldNumber);
            Assert.IsFalse(rowObject.IsFieldLocked("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetLockedField_RowObject_Helper_Null_FieldNumber()
        {
            string fieldNumber = "123";
            RowObject rowObject = null;
            OptionObjectHelpers.SetLockedField(rowObject, fieldNumber);
            Assert.IsFalse(rowObject.IsFieldLocked(fieldNumber));
        }
    }
}
