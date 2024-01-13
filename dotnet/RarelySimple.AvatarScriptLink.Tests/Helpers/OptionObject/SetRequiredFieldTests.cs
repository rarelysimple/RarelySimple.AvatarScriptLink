﻿using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.HelpersTests
{
    [TestClass]
    public class SetRequiredFieldTests
    {

        [TestMethod]
        public void SetRequiredField_OptionObject_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);
            optionObject.SetRequiredField(fieldNumber);
            Assert.IsTrue(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetRequiredField_OptionObject_FieldNumber_IsNotPresent()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);
            optionObject.SetRequiredField(fieldNumber);
            Assert.IsFalse(optionObject.IsFieldEnabled("234"));
            Assert.IsFalse(optionObject.IsFieldRequired("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void SetRequiredField_OptionObject_Null_FieldNumber()
        {
            string fieldNumber = "123";
            OptionObject optionObject = null;
            optionObject.SetRequiredField(fieldNumber);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetRequiredField_OptionObject_Helper_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);
            OptionObjectHelpers.SetRequiredField(optionObject, fieldNumber);
            Assert.IsTrue(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetRequiredField_OptionObject_Helper_FieldNumber_IsNotPresent()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);
            OptionObjectHelpers.SetRequiredField(optionObject, fieldNumber);
            Assert.IsFalse(optionObject.IsFieldEnabled("234"));
            Assert.IsFalse(optionObject.IsFieldRequired("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetRequiredField_OptionObject_Helper_Null_FieldNumber()
        {
            string fieldNumber = "123";
            OptionObject optionObject = null;
            OptionObjectHelpers.SetRequiredField(optionObject, fieldNumber);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetRequiredField_OptionObject2_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);
            optionObject.SetRequiredField(fieldNumber);
            Assert.IsTrue(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetRequiredField_OptionObject2_FieldNumber_IsNotPresent()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);
            optionObject.SetRequiredField(fieldNumber);
            Assert.IsFalse(optionObject.IsFieldEnabled("234"));
            Assert.IsFalse(optionObject.IsFieldRequired("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void SetRequiredField_OptionObject2_Null_FieldNumber()
        {
            string fieldNumber = "123";
            OptionObject2 optionObject = null;
            optionObject.SetRequiredField(fieldNumber);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetRequiredField_OptionObject2_Helper_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);
            OptionObjectHelpers.SetRequiredField(optionObject, fieldNumber);
            Assert.IsTrue(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetRequiredField_OptionObject2_Helper_FieldNumber_IsNotPresent()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);
            OptionObjectHelpers.SetRequiredField(optionObject, fieldNumber);
            Assert.IsFalse(optionObject.IsFieldEnabled("234"));
            Assert.IsFalse(optionObject.IsFieldRequired("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetRequiredField_OptionObject2_Helper_Null_FieldNumber()
        {
            string fieldNumber = "123";
            OptionObject2 optionObject = null;
            OptionObjectHelpers.SetRequiredField(optionObject, fieldNumber);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetRequiredField_OptionObject2015_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);
            optionObject.SetRequiredField(fieldNumber);
            Assert.IsTrue(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetRequiredField_OptionObject2015_FieldNumber_IsNotPresent()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);
            optionObject.SetRequiredField(fieldNumber);
            Assert.IsFalse(optionObject.IsFieldEnabled("234"));
            Assert.IsFalse(optionObject.IsFieldRequired("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void SetRequiredField_OptionObject2015_Null_FieldNumber()
        {
            string fieldNumber = "123";
            OptionObject2015 optionObject = null;
            optionObject.SetRequiredField(fieldNumber);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetRequiredField_OptionObject2015_Helper_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);
            OptionObjectHelpers.SetRequiredField(optionObject, fieldNumber);
            Assert.IsTrue(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetRequiredField_OptionObject2015_Helper_FieldNumber_IsNotPresent()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);
            OptionObjectHelpers.SetRequiredField(optionObject, fieldNumber);
            Assert.IsFalse(optionObject.IsFieldEnabled("234"));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetRequiredField_OptionObject2015_Helper_Null_FieldNumber()
        {
            string fieldNumber = "123";
            OptionObject2015 optionObject = null;
            OptionObjectHelpers.SetRequiredField(optionObject, fieldNumber);
            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetRequiredField_FormObject_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            formObject.SetRequiredField(fieldNumber);
            Assert.IsTrue(formObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetRequiredField_FormObject_FieldNumber_IsNotPresent()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            formObject.SetRequiredField(fieldNumber);
            Assert.IsFalse(formObject.IsFieldEnabled("234"));
            Assert.IsFalse(formObject.IsFieldRequired("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void SetRequiredField_FormObject_Null_FieldNumber()
        {
            string fieldNumber = "123";
            FormObject formObject = null;
            formObject.SetRequiredField(fieldNumber);
            Assert.IsFalse(formObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(formObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetRequiredField_FormObject_Helper_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObjectHelpers.SetRequiredField(formObject, fieldNumber);
            Assert.IsTrue(formObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetRequiredField_FormObject_Helper_FieldNumber_IsNotPresent()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObjectHelpers.SetRequiredField(formObject, fieldNumber);
            Assert.IsFalse(formObject.IsFieldEnabled("234"));
            Assert.IsFalse(formObject.IsFieldRequired("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetRequiredField_FormObject_Helper_Null_FieldNumber()
        {
            string fieldNumber = "123";
            FormObject formObject = null;
            OptionObjectHelpers.SetRequiredField(formObject, fieldNumber);
            Assert.IsFalse(formObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(formObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetRequiredField_RowObject_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            rowObject.SetRequiredField(fieldNumber);
            Assert.IsTrue(rowObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetRequiredField_RowObject_FieldNumber_IsNotPresent()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            rowObject.SetRequiredField(fieldNumber);
            Assert.IsFalse(rowObject.IsFieldEnabled("234"));
            Assert.IsFalse(rowObject.IsFieldRequired("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void SetRequiredField_RowObject_Null_FieldNumber()
        {
            string fieldNumber = "123";
            RowObject rowObject = null;
            rowObject.SetRequiredField(fieldNumber);
            Assert.IsFalse(rowObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(rowObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetRequiredField_RowObject_Helper_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            OptionObjectHelpers.SetRequiredField(rowObject, fieldNumber);
            Assert.IsTrue(rowObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetRequiredField_RowObject_Helper_FieldNumber_IsNotPresent()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            OptionObjectHelpers.SetRequiredField(rowObject, fieldNumber);
            Assert.IsFalse(rowObject.IsFieldEnabled("234"));
            Assert.IsFalse(rowObject.IsFieldRequired("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetRequiredField_RowObject_Helper_Null_FieldNumber()
        {
            string fieldNumber = "123";
            RowObject rowObject = null;
            OptionObjectHelpers.SetRequiredField(rowObject, fieldNumber);
            Assert.IsFalse(rowObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(rowObject.IsFieldRequired(fieldNumber));
        }
    }
}
