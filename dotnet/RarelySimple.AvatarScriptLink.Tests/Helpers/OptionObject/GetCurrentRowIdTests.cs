using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.Helpers
{
    [TestClass]
    public class GetCurrentRowIdTests
    {
        [TestMethod]
        [TestCategory("GetCurrentRowId")]
        public void GetCurrentRowId_FromFormObject_NullFormObject()
        {
            Assert.ThrowsException<ArgumentNullException>(() => OptionObjectHelpers.GetCurrentRowId(null));
        }

        [TestMethod]
        [TestCategory("GetCurrentRowId")]
        public void GetCurrentRowId_FromFormObject_NoCurrentRow()
        {
            FormObject formObject = new();
            Assert.ThrowsException<ArgumentNullException>(() => OptionObjectHelpers.GetCurrentRowId(formObject));
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
        public void GetCurrentRowId_FromOptionObject_NullOptionObject()
        {
            Assert.ThrowsException<ArgumentNullException>(() => OptionObjectHelpers.GetCurrentRowId(null, "1"));
        }
        
        [TestMethod]
        [TestCategory("GetCurrentRowId")]
        public void GetCurrentRowId_FromOptionObject2_NullOptionObject()
        {
            Assert.ThrowsException<ArgumentNullException>(() => OptionObjectHelpers.GetCurrentRowId(null, "1"));
        }
        
        [TestMethod]
        [TestCategory("GetCurrentRowId")]
        public void GetCurrentRowId_FromOptionObject2015_NullOptionObject()
        {
            Assert.ThrowsException<ArgumentNullException>(() => OptionObjectHelpers.GetCurrentRowId(null, "1"));
        }

        [TestMethod]
        [TestCategory("GetCurrentRowId")]
        public void GetCurrentRowId_FromOptionObject_NullFormId()
        {
            RowObject rowObject = new();
            FormObject formObject = new();
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new();
            optionObject.AddFormObject(formObject);
            Assert.ThrowsException<ArgumentException>(() => OptionObjectHelpers.GetCurrentRowId(optionObject, "1"));
        }
        
        [TestMethod]
        [TestCategory("GetCurrentRowId")]
        public void GetCurrentRowId_FromOptionObject2_NullFormId()
        {
            RowObject rowObject = new();
            FormObject formObject = new();
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new();
            optionObject.AddFormObject(formObject);
            Assert.ThrowsException<ArgumentException>(() => OptionObjectHelpers.GetCurrentRowId(optionObject, "1"));
        }
        
        [TestMethod]
        [TestCategory("GetCurrentRowId")]
        public void GetCurrentRowId_FromOptionObject2015_NullFormId()
        {
            RowObject rowObject = new();
            FormObject formObject = new();
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new();
            optionObject.AddFormObject(formObject);
            Assert.ThrowsException<ArgumentException>(() => OptionObjectHelpers.GetCurrentRowId(optionObject, "1"));
        }

        [TestMethod]
        [TestCategory("GetCurrentRowId")]
        public void GetCurrentRowId_FromOptionObject_NoForms()
        {
            OptionObject optionObject = new();
            Assert.ThrowsException<ArgumentException>(() => OptionObjectHelpers.GetCurrentRowId(optionObject, "1"));
        }

        [TestMethod]
        [TestCategory("GetCurrentRowId")]
        public void GetCurrentRowId_FromOptionObject2_NoForms()
        {
            OptionObject2 optionObject = new();
            Assert.ThrowsException<ArgumentException>(() => OptionObjectHelpers.GetCurrentRowId(optionObject, "1"));
        }
        
        [TestMethod]
        [TestCategory("GetCurrentRowId")]
        public void GetCurrentRowId_FromOptionObject2015_NoForms()
        {
            OptionObject2015 optionObject = new();
            Assert.ThrowsException<ArgumentException>(() => OptionObjectHelpers.GetCurrentRowId(optionObject, "1"));
        }

        [TestMethod]
        [TestCategory("GetCurrentRowId")]
        public void GetCurrentRowId_FromOptionObject_NoMatchingForms()
        {
            RowObject rowObject = new();
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new();
            optionObject.AddFormObject(formObject);
            Assert.ThrowsException<ArgumentException>(() => OptionObjectHelpers.GetCurrentRowId(optionObject, "2"));
        }
        
        [TestMethod]
        [TestCategory("GetCurrentRowId")]
        public void GetCurrentRowId_FromOptionObject2_NoMatchingForms()
        {
            RowObject rowObject = new();
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new();
            optionObject.AddFormObject(formObject);
            Assert.ThrowsException<ArgumentException>(() => OptionObjectHelpers.GetCurrentRowId(optionObject, "2"));
        }
        
        [TestMethod]
        [TestCategory("GetCurrentRowId")]
        public void GetCurrentRowId_FromOptionObject2015_NoMatchingForms()
        {
            RowObject rowObject = new();
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new();
            optionObject.AddFormObject(formObject);
            Assert.ThrowsException<ArgumentException>(() => OptionObjectHelpers.GetCurrentRowId(optionObject, "2"));
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
        public void GetCurrentRowId_FromOptionObject_FormsNull()
        {
            OptionObject optionObject = new();
            Assert.ThrowsException<ArgumentException>(() => OptionObjectHelpers.GetCurrentRowId(optionObject, "1"));
        }

        [TestMethod]
        [TestCategory("GetCurrentRowId")]
        public void GetCurrentRowId_FromOptionObject_FormIdEmpty()
        {
            RowObject rowObject = new();
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new();
            optionObject.AddFormObject(formObject);
            Assert.ThrowsException<ArgumentNullException>(() => OptionObjectHelpers.GetCurrentRowId(optionObject, ""));
        }

        [TestMethod]
        [TestCategory("GetCurrentRowId")]
        public void GetCurrentRowId_FromOptionObject_FormIdNull()
        {
            RowObject rowObject = new();
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new();
            optionObject.AddFormObject(formObject);
            Assert.ThrowsException<ArgumentNullException>(() => OptionObjectHelpers.GetCurrentRowId(optionObject, null));
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
