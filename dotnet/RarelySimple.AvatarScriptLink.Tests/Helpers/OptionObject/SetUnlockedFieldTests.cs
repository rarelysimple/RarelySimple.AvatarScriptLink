using Microsoft.VisualStudio.TestTools.UnitTesting;
using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;
using System;

namespace RarelySimple.AvatarScriptLink.Tests.HelpersTests
{
    [TestClass]
    public class SetUnlockedFieldTests
    {

        [TestMethod]
        public void SetUnlockedField_OptionObject_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);
            optionObject.SetUnlockedField(fieldNumber);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetUnlockedField_OptionObject_FieldNumber_IsNotPresent()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);
            optionObject.SetUnlockedField(fieldNumber);
            Assert.IsFalse(optionObject.IsFieldLocked("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void SetUnlockedField_OptionObject_Null_FieldNumber()
        {
            string fieldNumber = "123";
            OptionObject optionObject = null;
            optionObject.SetUnlockedField(fieldNumber);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void SetUnlockedField_OptionObject_Helper_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);
            OptionObjectHelpers.SetUnlockedField(optionObject, fieldNumber);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetUnlockedField_OptionObject_Helper_FieldNumber_IsNotPresent()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);
            OptionObjectHelpers.SetUnlockedField(optionObject, fieldNumber);
            Assert.IsFalse(optionObject.IsFieldLocked("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetUnlockedField_OptionObject_Helper_Null_FieldNumber()
        {
            string fieldNumber = "123";
            OptionObject optionObject = null;
            OptionObjectHelpers.SetUnlockedField(optionObject, fieldNumber);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void SetUnlockedField_OptionObject2_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);
            optionObject.SetUnlockedField(fieldNumber);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetUnlockedField_OptionObject2_FieldNumber_IsNotPresent()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);
            optionObject.SetUnlockedField(fieldNumber);
            Assert.IsFalse(optionObject.IsFieldLocked("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void SetUnlockedField_OptionObject2_Null_FieldNumber()
        {
            string fieldNumber = "123";
            OptionObject2 optionObject = null;
            optionObject.SetUnlockedField(fieldNumber);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void SetUnlockedField_OptionObject2_Helper_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);
            OptionObjectHelpers.SetUnlockedField(optionObject, fieldNumber);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetUnlockedField_OptionObject2_Helper_FieldNumber_IsNotPresent()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);
            OptionObjectHelpers.SetUnlockedField(optionObject, fieldNumber);
            Assert.IsFalse(optionObject.IsFieldLocked("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetUnlockedField_OptionObject2_Helper_Null_FieldNumber()
        {
            string fieldNumber = "123";
            OptionObject2 optionObject = null;
            OptionObjectHelpers.SetUnlockedField(optionObject, fieldNumber);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void SetUnlockedField_OptionObject2015_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);
            optionObject.SetUnlockedField(fieldNumber);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetUnlockedField_OptionObject2015_FieldNumber_IsNotPresent()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);
            optionObject.SetUnlockedField(fieldNumber);
            Assert.IsFalse(optionObject.IsFieldLocked("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void SetUnlockedField_OptionObject2015_Null_FieldNumber()
        {
            string fieldNumber = "123";
            OptionObject2015 optionObject = null;
            optionObject.SetUnlockedField(fieldNumber);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void SetUnlockedField_OptionObject2015_Helper_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);
            OptionObjectHelpers.SetUnlockedField(optionObject, fieldNumber);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetUnlockedField_OptionObject2015_Helper_FieldNumber_IsNotPresent()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);
            OptionObjectHelpers.SetUnlockedField(optionObject, fieldNumber);
            Assert.IsFalse(optionObject.IsFieldLocked("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetUnlockedField_OptionObject2015_Helper_Null_FieldNumber()
        {
            string fieldNumber = "123";
            OptionObject2015 optionObject = null;
            OptionObjectHelpers.SetUnlockedField(optionObject, fieldNumber);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void SetUnlockedField_FormObject_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            formObject.SetUnlockedField(fieldNumber);
            Assert.IsFalse(formObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetUnlockedField_FormObject_FieldNumber_IsNotPresent()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            formObject.SetUnlockedField(fieldNumber);
            Assert.IsFalse(formObject.IsFieldLocked("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void SetUnlockedField_FormObject_Null_FieldNumber()
        {
            string fieldNumber = "123";
            FormObject formObject = null;
            formObject.SetUnlockedField(fieldNumber);
            Assert.IsFalse(formObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void SetUnlockedField_FormObject_Helper_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObjectHelpers.SetUnlockedField(formObject, fieldNumber);
            Assert.IsFalse(formObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetUnlockedField_FormObject_Helper_FieldNumber_IsNotPresent()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObjectHelpers.SetUnlockedField(formObject, fieldNumber);
            Assert.IsFalse(formObject.IsFieldLocked("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetUnlockedField_FormObject_Helper_Null_FieldNumber()
        {
            string fieldNumber = "123";
            FormObject formObject = null;
            OptionObjectHelpers.SetUnlockedField(formObject, fieldNumber);
            Assert.IsFalse(formObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void SetUnlockedField_RowObject_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            rowObject.SetUnlockedField(fieldNumber);
            Assert.IsFalse(rowObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetUnlockedField_RowObject_FieldNumber_IsNotPresent()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            rowObject.SetUnlockedField(fieldNumber);
            Assert.IsFalse(rowObject.IsFieldLocked("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void SetUnlockedField_RowObject_Null_FieldNumber()
        {
            string fieldNumber = "123";
            RowObject rowObject = null;
            rowObject.SetUnlockedField(fieldNumber);
            Assert.IsFalse(rowObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void SetUnlockedField_RowObject_Helper_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            OptionObjectHelpers.SetUnlockedField(rowObject, fieldNumber);
            Assert.IsFalse(rowObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetUnlockedField_RowObject_Helper_FieldNumber_IsNotPresent()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            OptionObjectHelpers.SetUnlockedField(rowObject, fieldNumber);
            Assert.IsFalse(rowObject.IsFieldLocked("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetUnlockedField_RowObject_Helper_Null_FieldNumber()
        {
            string fieldNumber = "123";
            RowObject rowObject = null;
            OptionObjectHelpers.SetUnlockedField(rowObject, fieldNumber);
            Assert.IsFalse(rowObject.IsFieldLocked(fieldNumber));
        }
    }
}
