using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.HelpersTests
{
    [TestClass]
    public class IsFieldLockedTests
    {
        [TestMethod]
        public void IsFieldLocked_OptionObject_FirstForm_IsLocked()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, true, false));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);
            Assert.IsTrue(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void IsFieldLocked_OptionObject_SecondForm_IsLocked()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, true, false));
            FormObject formObject1 = new FormObject("1");
            FormObject formObject2 = new FormObject("2");
            formObject2.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject1);
            optionObject.AddFormObject(formObject2);
            Assert.IsTrue(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void IsFieldLocked_OptionObject_FirstForm_IsNotLocked()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void IsFieldLocked_OptionObject_SecondForm_IsNotLocked()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            FormObject formObject1 = new FormObject("1");
            FormObject formObject2 = new FormObject("2");
            formObject2.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject1);
            optionObject.AddFormObject(formObject2);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsFieldLocked_OptionObject_IsNotPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            FormObject formObject1 = new FormObject("1");
            FormObject formObject2 = new FormObject("2");
            formObject2.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject1);
            optionObject.AddFormObject(formObject2);
            Assert.IsTrue(optionObject.IsFieldLocked("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void IsFieldLocked_OptionObject_Null()
        {
            string fieldNumber = "123";
            OptionObject optionObject = null;
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsFieldLocked_OptionObject_Helper_Null()
        {
            string fieldNumber = "123";
            OptionObject optionObject = null;
            Assert.IsFalse(OptionObjectHelpers.IsFieldLocked(optionObject, fieldNumber));
        }

        [TestMethod]
        public void IsFieldLocked_OptionObject2_FirstForm_IsLocked()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, true, false));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);
            Assert.IsTrue(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void IsFieldLocked_OptionObject2_SecondForm_IsLocked()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, true, false));
            FormObject formObject1 = new FormObject("1");
            FormObject formObject2 = new FormObject("2");
            formObject2.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject1);
            optionObject.AddFormObject(formObject2);
            Assert.IsTrue(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void IsFieldLocked_OptionObject2_FirstForm_IsNotLocked()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void IsFieldLocked_OptionObject2_SecondForm_IsNotLocked()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            FormObject formObject1 = new FormObject("1");
            FormObject formObject2 = new FormObject("2");
            formObject2.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject1);
            optionObject.AddFormObject(formObject2);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsFieldLocked_OptionObject2_IsNotPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            FormObject formObject1 = new FormObject("1");
            FormObject formObject2 = new FormObject("2");
            formObject2.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject1);
            optionObject.AddFormObject(formObject2);
            Assert.IsTrue(optionObject.IsFieldLocked("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void IsFieldLocked_OptionObject2_Null()
        {
            string fieldNumber = "123";
            OptionObject2 optionObject = null;
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsFieldLocked_OptionObject2_Helper_Null()
        {
            string fieldNumber = "123";
            OptionObject2 optionObject = null;
            Assert.IsFalse(OptionObjectHelpers.IsFieldLocked(optionObject, fieldNumber));
        }

        [TestMethod]
        public void IsFieldLocked_OptionObject2015_FirstForm_IsLocked()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, true, false));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);
            Assert.IsTrue(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void IsFieldLocked_OptionObject2015_SecondForm_IsLocked()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, true, false));
            FormObject formObject1 = new FormObject("1");
            FormObject formObject2 = new FormObject("2");
            formObject2.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject1);
            optionObject.AddFormObject(formObject2);
            Assert.IsTrue(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void IsFieldLocked_OptionObject2015_FirstForm_IsNotLocked()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void IsFieldLocked_OptionObject2015_SecondForm_IsNotLocked()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            FormObject formObject1 = new FormObject("1");
            FormObject formObject2 = new FormObject("2");
            formObject2.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject1);
            optionObject.AddFormObject(formObject2);
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsFieldLocked_OptionObject2015_IsNotPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            FormObject formObject1 = new FormObject("1");
            FormObject formObject2 = new FormObject("2");
            formObject2.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject1);
            optionObject.AddFormObject(formObject2);
            Assert.IsTrue(optionObject.IsFieldLocked("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void IsFieldLocked_OptionObject2015_Null()
        {
            string fieldNumber = "123";
            OptionObject2015 optionObject = null;
            Assert.IsFalse(optionObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsFieldLocked_OptionObject2015_Helper_Null()
        {
            string fieldNumber = "123";
            OptionObject2015 optionObject = null;
            Assert.IsFalse(OptionObjectHelpers.IsFieldLocked(optionObject, fieldNumber));
        }

        [TestMethod]
        public void IsFieldLocked_FormObject_IsLocked()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, true, false));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            Assert.IsTrue(formObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void IsFieldLocked_FormObject_IsNotLocked()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            Assert.IsFalse(formObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsFieldLocked_FormObject_IsNotPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            Assert.IsTrue(formObject.IsFieldLocked("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void IsFieldLocked_FormObject_Null()
        {
            string fieldNumber = "123";
            FormObject formObject = null;
            Assert.IsFalse(formObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsFieldLocked_FormObject_Helper_Null()
        {
            string fieldNumber = "123";
            FormObject formObject = null;
            Assert.IsFalse(OptionObjectHelpers.IsFieldLocked(formObject, fieldNumber));
        }

        [TestMethod]
        public void IsFieldLocked_RowObject_IsLocked()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, true, false));
            Assert.IsTrue(rowObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        public void IsFieldLocked_RowObject_IsNotLocked()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            Assert.IsFalse(rowObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsFieldLocked_RowObject_IsNotPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            Assert.IsTrue(rowObject.IsFieldLocked("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void IsFieldLocked_RowObject_Null()
        {
            string fieldNumber = "123";
            RowObject rowObject = null;
            Assert.IsFalse(rowObject.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsFieldLocked_RowObject_Helper_Null()
        {
            string fieldNumber = "123";
            RowObject rowObject = null;
            Assert.IsFalse(OptionObjectHelpers.IsFieldLocked(rowObject, fieldNumber));
        }
    }
}
