using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.HelpersTests
{
    [TestClass]
    public class IsFieldRequiredTests
    {
        [TestMethod]
        public void IsFieldRequired_OptionObject_FirstForm_IsRequired()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, true));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);
            Assert.IsTrue(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void IsFieldRequired_OptionObject_SecondForm_IsRequired()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, true));
            FormObject formObject1 = new FormObject("1");
            FormObject formObject2 = new FormObject("2");
            formObject2.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject1);
            optionObject.AddFormObject(formObject2);
            Assert.IsTrue(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void IsFieldRequired_OptionObject_FirstForm_IsNotRequired()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void IsFieldRequired_OptionObject_SecondForm_IsNotRequired()
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
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsFieldRequired_OptionObject_IsNotPresent()
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
            Assert.IsTrue(optionObject.IsFieldRequired("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void IsFieldRequired_OptionObject_Null()
        {
            string fieldNumber = "123";
            OptionObject optionObject = null;
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsFieldRequired_OptionObject_Helper_Null()
        {
            string fieldNumber = "123";
            OptionObject optionObject = null;
            Assert.IsFalse(OptionObjectHelpers.IsFieldRequired(optionObject, fieldNumber));
        }

        [TestMethod]
        public void IsFieldRequired_OptionObject2_FirstForm_IsRequired()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, true));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);
            Assert.IsTrue(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void IsFieldRequired_OptionObject2_SecondForm_IsRequired()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, true));
            FormObject formObject1 = new FormObject("1");
            FormObject formObject2 = new FormObject("2");
            formObject2.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject1);
            optionObject.AddFormObject(formObject2);
            Assert.IsTrue(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void IsFieldRequired_OptionObject2_FirstForm_IsNotRequired()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void IsFieldRequired_OptionObject2_SecondForm_IsNotRequired()
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
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsFieldRequired_OptionObject2_IsNotPresent()
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
            Assert.IsTrue(optionObject.IsFieldRequired("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void IsFieldRequired_OptionObject2_Null()
        {
            string fieldNumber = "123";
            OptionObject2 optionObject = null;
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsFieldRequired_OptionObject2_Helper_Null()
        {
            string fieldNumber = "123";
            OptionObject2 optionObject = null;
            Assert.IsFalse(OptionObjectHelpers.IsFieldRequired(optionObject, fieldNumber));
        }

        [TestMethod]
        public void IsFieldRequired_OptionObject2015_FirstForm_IsRequired()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, true));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);
            Assert.IsTrue(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void IsFieldRequired_OptionObject2015_SecondForm_IsRequired()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, true));
            FormObject formObject1 = new FormObject("1");
            FormObject formObject2 = new FormObject("2");
            formObject2.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject1);
            optionObject.AddFormObject(formObject2);
            Assert.IsTrue(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void IsFieldRequired_OptionObject2015_FirstForm_IsNotRequired()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void IsFieldRequired_OptionObject2015_SecondForm_IsNotRequired()
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
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsFieldRequired_OptionObject2015_IsNotPresent()
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
            Assert.IsTrue(optionObject.IsFieldRequired("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void IsFieldRequired_OptionObject2015_Null()
        {
            string fieldNumber = "123";
            OptionObject2015 optionObject = null;
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsFieldRequired_OptionObject2015_Helper_Null()
        {
            string fieldNumber = "123";
            OptionObject2015 optionObject = null;
            Assert.IsFalse(OptionObjectHelpers.IsFieldRequired(optionObject, fieldNumber));
        }

        [TestMethod]
        public void IsFieldRequired_FormObject_IsRequired()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, true));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            Assert.IsTrue(formObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void IsFieldRequired_FormObject_IsNotRequired()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            Assert.IsFalse(formObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsFieldRequired_FormObject_IsNotPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            Assert.IsTrue(formObject.IsFieldRequired("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void IsFieldRequired_FormObject_Null()
        {
            string fieldNumber = "123";
            FormObject formObject = null;
            Assert.IsFalse(formObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsFieldRequired_FormObject_Helper_Null()
        {
            string fieldNumber = "123";
            FormObject formObject = null;
            Assert.IsFalse(OptionObjectHelpers.IsFieldRequired(formObject, fieldNumber));
        }

        [TestMethod]
        public void IsFieldRequired_RowObject_IsRequired()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, true));
            Assert.IsTrue(rowObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void IsFieldRequired_RowObject_IsNotRequired()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            Assert.IsFalse(rowObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsFieldRequired_RowObject_IsNotPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber, "", false, false, false));
            Assert.IsTrue(rowObject.IsFieldRequired("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void IsFieldRequired_RowObject_Null()
        {
            string fieldNumber = "123";
            RowObject rowObject = null;
            Assert.IsFalse(rowObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsFieldRequired_RowObject_Helper_Null()
        {
            string fieldNumber = "123";
            RowObject rowObject = null;
            Assert.IsFalse(OptionObjectHelpers.IsFieldRequired(rowObject, fieldNumber));
        }
    }
}
