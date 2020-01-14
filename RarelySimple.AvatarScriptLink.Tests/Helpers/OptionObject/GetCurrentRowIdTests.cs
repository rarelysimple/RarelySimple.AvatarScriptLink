using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.HelpersTests
{
    [TestClass]
    public class GetCurrentRowIdTests
    {
        [TestMethod]
        [TestCategory("GetCurrentRowId")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetCurrentRowId_FromFormObject_NullFormObject()
        {
            string expected = "1||1";
            FormObject formObject = null;
            string actual = OptionObjectHelpers.GetCurrentRowId(formObject);
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("GetCurrentRowId")]
        [ExpectedException(typeof(NullReferenceException))]
        public void GetCurrentRowId_FromFormObject_NoCurrentRow()
        {
            string expected = "1||1";
            FormObject formObject = new FormObject();
            string actual = OptionObjectHelpers.GetCurrentRowId(formObject);
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("GetCurrentRowId")]
        public void GetCurrentRowId_FromFormObject_Success()
        {
            string expected = "1||1";
            RowObject rowObject = new RowObject();
            FormObject formObject = new FormObject()
            {
                FormId = "1",
                MultipleIteration = false
            };
            formObject.AddRowObject(rowObject);
            string actual = OptionObjectHelpers.GetCurrentRowId(formObject);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("GetCurrentRowId")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetCurrentRowId_FromOptionObject_NullOptionObject()
        {
            string expected = "1||1";
            OptionObject optionObject = null;
            string actual = OptionObjectHelpers.GetCurrentRowId(optionObject, "1");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [TestCategory("GetCurrentRowId")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetCurrentRowId_FromOptionObject2_NullOptionObject()
        {
            string expected = "1||1";
            OptionObject2 optionObject = null;
            string actual = OptionObjectHelpers.GetCurrentRowId(optionObject, "1");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [TestCategory("GetCurrentRowId")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetCurrentRowId_FromOptionObject2015_NullOptionObject()
        {
            string expected = "1||1";
            OptionObject2015 optionObject = null;
            string actual = OptionObjectHelpers.GetCurrentRowId(optionObject, "1");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("GetCurrentRowId")]
        [ExpectedException(typeof(ArgumentException))]
        public void GetCurrentRowId_FromOptionObject_NullFormId()
        {
            string expected = "1||1";
            RowObject rowObject = new RowObject();
            FormObject formObject = new FormObject();
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);
            string actual = OptionObjectHelpers.GetCurrentRowId(optionObject, "1");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [TestCategory("GetCurrentRowId")]
        [ExpectedException(typeof(ArgumentException))]
        public void GetCurrentRowId_FromOptionObject2_NullFormId()
        {
            string expected = "1||1";
            RowObject rowObject = new RowObject();
            FormObject formObject = new FormObject();
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);
            string actual = OptionObjectHelpers.GetCurrentRowId(optionObject, "1");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [TestCategory("GetCurrentRowId")]
        [ExpectedException(typeof(ArgumentException))]
        public void GetCurrentRowId_FromOptionObject2015_NullFormId()
        {
            string expected = "1||1";
            RowObject rowObject = new RowObject();
            FormObject formObject = new FormObject();
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);
            string actual = OptionObjectHelpers.GetCurrentRowId(optionObject, "1");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("GetCurrentRowId")]
        [ExpectedException(typeof(ArgumentException))]
        public void GetCurrentRowId_FromOptionObject_NoForms()
        {
            string expected = "1||1";
            OptionObject optionObject = new OptionObject();
            string actual = OptionObjectHelpers.GetCurrentRowId(optionObject, "1");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [TestCategory("GetCurrentRowId")]
        [ExpectedException(typeof(ArgumentException))]
        public void GetCurrentRowId_FromOptionObject2_NoForms()
        {
            string expected = "1||1";
            OptionObject2 optionObject = new OptionObject2();
            string actual = OptionObjectHelpers.GetCurrentRowId(optionObject, "1");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [TestCategory("GetCurrentRowId")]
        [ExpectedException(typeof(ArgumentException))]
        public void GetCurrentRowId_FromOptionObject2015_NoForms()
        {
            string expected = "1||1";
            OptionObject2015 optionObject = new OptionObject2015();
            string actual = OptionObjectHelpers.GetCurrentRowId(optionObject, "1");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("GetCurrentRowId")]
        [ExpectedException(typeof(ArgumentException))]
        public void GetCurrentRowId_FromOptionObject_NoMatchingForms()
        {
            string expected = "1||1";
            RowObject rowObject = new RowObject();
            FormObject formObject = new FormObject()
            {
                FormId = "1",
                MultipleIteration = false
            };
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);
            string actual = OptionObjectHelpers.GetCurrentRowId(optionObject, "2");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [TestCategory("GetCurrentRowId")]
        [ExpectedException(typeof(ArgumentException))]
        public void GetCurrentRowId_FromOptionObject2_NoMatchingForms()
        {
            string expected = "1||1";
            RowObject rowObject = new RowObject();
            FormObject formObject = new FormObject()
            {
                FormId = "1",
                MultipleIteration = false
            };
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);
            string actual = OptionObjectHelpers.GetCurrentRowId(optionObject, "2");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [TestCategory("GetCurrentRowId")]
        [ExpectedException(typeof(ArgumentException))]
        public void GetCurrentRowId_FromOptionObject2015_NoMatchingForms()
        {
            string expected = "1||1";
            RowObject rowObject = new RowObject();
            FormObject formObject = new FormObject()
            {
                FormId = "1",
                MultipleIteration = false
            };
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);
            string actual = OptionObjectHelpers.GetCurrentRowId(optionObject, "2");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("GetCurrentRowId")]
        public void GetCurrentRowId_FromOptionObject_Success()
        {
            string expected = "1||1";
            RowObject rowObject = new RowObject();
            FormObject formObject = new FormObject()
            {
                FormId = "1",
                MultipleIteration = false
            };
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);
            string actual = OptionObjectHelpers.GetCurrentRowId(optionObject, "1");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [TestCategory("GetCurrentRowId")]
        public void GetCurrentRowId_FromOptionObject2_Success()
        {
            string expected = "1||1";
            RowObject rowObject = new RowObject();
            FormObject formObject = new FormObject()
            {
                FormId = "1",
                MultipleIteration = false
            };
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);
            string actual = OptionObjectHelpers.GetCurrentRowId(optionObject, "1");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [TestCategory("GetCurrentRowId")]
        public void GetCurrentRowId_FromOptionObject2015_Success()
        {
            string expected = "1||1";
            RowObject rowObject = new RowObject();
            FormObject formObject = new FormObject()
            {
                FormId = "1",
                MultipleIteration = false
            };
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);
            string actual = OptionObjectHelpers.GetCurrentRowId(optionObject, "1");
            Assert.AreEqual(expected, actual);
        }
    }
}
