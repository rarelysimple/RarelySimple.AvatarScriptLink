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
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetCurrentRowId_FromFormObject_NoCurrentRow()
        {
            string expected = "1||1";
            FormObject formObject = new();
            string actual = OptionObjectHelpers.GetCurrentRowId(formObject);
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("GetCurrentRowId")]
        public void GetCurrentRowId_FromFormObject_Success()
        {
            string expected = "1||1";
            RowObject rowObject = new();
            FormObject formObject = new()
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
            RowObject rowObject = new();
            FormObject formObject = new();
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new();
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
            RowObject rowObject = new();
            FormObject formObject = new();
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new();
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
            RowObject rowObject = new();
            FormObject formObject = new();
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new();
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
            OptionObject optionObject = new();
            string actual = OptionObjectHelpers.GetCurrentRowId(optionObject, "1");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [TestCategory("GetCurrentRowId")]
        [ExpectedException(typeof(ArgumentException))]
        public void GetCurrentRowId_FromOptionObject2_NoForms()
        {
            string expected = "1||1";
            OptionObject2 optionObject = new();
            string actual = OptionObjectHelpers.GetCurrentRowId(optionObject, "1");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [TestCategory("GetCurrentRowId")]
        [ExpectedException(typeof(ArgumentException))]
        public void GetCurrentRowId_FromOptionObject2015_NoForms()
        {
            string expected = "1||1";
            OptionObject2015 optionObject = new();
            string actual = OptionObjectHelpers.GetCurrentRowId(optionObject, "1");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("GetCurrentRowId")]
        [ExpectedException(typeof(ArgumentException))]
        public void GetCurrentRowId_FromOptionObject_NoMatchingForms()
        {
            string expected = "1||1";
            RowObject rowObject = new();
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new();
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
            RowObject rowObject = new();
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new();
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
            RowObject rowObject = new();
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new();
            optionObject.AddFormObject(formObject);
            string actual = OptionObjectHelpers.GetCurrentRowId(optionObject, "2");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("GetCurrentRowId")]
        public void GetCurrentRowId_FromOptionObject_Success()
        {
            string expected = "1||1";
            RowObject rowObject = new();
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new();
            optionObject.AddFormObject(formObject);
            string actual = OptionObjectHelpers.GetCurrentRowId(optionObject, "1");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [TestCategory("GetCurrentRowId")]
        public void GetCurrentRowId_FromOptionObject2_Success()
        {
            string expected = "1||1";
            RowObject rowObject = new();
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new();
            optionObject.AddFormObject(formObject);
            string actual = OptionObjectHelpers.GetCurrentRowId(optionObject, "1");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [TestCategory("GetCurrentRowId")]
        public void GetCurrentRowId_FromOptionObject2015_Success()
        {
            string expected = "1||1";
            RowObject rowObject = new();
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new();
            optionObject.AddFormObject(formObject);
            string actual = OptionObjectHelpers.GetCurrentRowId(optionObject, "1");
            Assert.AreEqual(expected, actual);
        }
    }
}
