using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.HelpersTests
{
    [TestClass]
    public class AddRowObjectTests
    {
        [TestMethod]
        [TestCategory("AddRowObject")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddRowObject_ToFormObject_NullFormObject()
        {
            RowObject rowObject = new();
            FormObject formObject = null;
            formObject = (FormObject)OptionObjectHelpers.AddRowObject(formObject, rowObject);
            //Assert.AreEqual(1, formObject);
        }

        [TestMethod]
        [TestCategory("AddRowObject")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddRowObject_ToFormObject_NullRowObject()
        {
            RowObject rowObject = null;
            FormObject formObject = new();
            formObject = (FormObject)OptionObjectHelpers.AddRowObject(formObject, rowObject);
            //Assert.AreEqual(1, formObject);
        }

        [TestMethod]
        [TestCategory("AddRowObject")]
        public void AddRowObject_ToFormObject_DefinedRowId_Success()
        {
            string formId = "1";
            string expected = "1||1";
            RowObject rowObject = new()
            {
                RowId = expected
            };
            FormObject formObject = new()
            {
                FormId = formId
            };
            formObject = (FormObject)OptionObjectHelpers.AddRowObject(formObject, rowObject);
            Assert.AreEqual(expected, formObject.CurrentRow.RowId);
        }

        [TestMethod]
        [TestCategory("AddRowObject")]
        public void AddRowObject_ToFormObject_UndefinedRowId_Success()
        {
            string formId = "1";
            string expected = "1||1";
            RowObject rowObject = new();
            FormObject formObject = new()
            {
                FormId = formId
            };
            formObject = (FormObject)OptionObjectHelpers.AddRowObject(formObject, rowObject);
            Assert.AreEqual(expected, formObject.CurrentRow.RowId);
        }

        [TestMethod]
        [TestCategory("AddRowObject")]
        public void AddRowObject_ToFormObject_Multiple_MI()
        {
            string formId = "1";
            string expected = "1||1";
            RowObject rowObject1 = new();
            RowObject rowObject2 = new();
            FormObject formObject = new()
            {
                FormId = formId,
                MultipleIteration = true
            };
            formObject = (FormObject)OptionObjectHelpers.AddRowObject(formObject, rowObject1);
            formObject = (FormObject)OptionObjectHelpers.AddRowObject(formObject, rowObject2);
            Assert.AreEqual(expected, formObject.CurrentRow.RowId);
        }

        [TestMethod]
        [TestCategory("AddRowObject")]
        [ExpectedException(typeof(ArgumentException))]
        public void AddRowObject_ToFormObject_Multiple_NonMI()
        {
            string formId = "1";
            string expected = "1||1";
            RowObject rowObject1 = new();
            RowObject rowObject2 = new();
            FormObject formObject = new()
            {
                FormId = formId
            };
            formObject = (FormObject)OptionObjectHelpers.AddRowObject(formObject, rowObject1);
            formObject = (FormObject)OptionObjectHelpers.AddRowObject(formObject, rowObject2);
            Assert.AreEqual(expected, formObject.CurrentRow.RowId);
        }

        [TestMethod]
        [TestCategory("AddRowObject")]
        [ExpectedException(typeof(ArgumentException))]
        public void AddRowObject_ToFormObject_Duplicate_MI()
        {
            string formId = "1";
            string expected = "1||1";
            RowObject rowObject1 = new()
            {
                RowId = expected
            };
            RowObject rowObject2 = new()
            {
                RowId = expected
            };
            FormObject formObject = new()
            {
                FormId = formId,
                MultipleIteration = true
            };
            formObject = (FormObject)OptionObjectHelpers.AddRowObject(formObject, rowObject1);
            formObject = (FormObject)OptionObjectHelpers.AddRowObject(formObject, rowObject2);
            Assert.AreEqual(expected, formObject.CurrentRow.RowId);
        }

        [TestMethod]
        [TestCategory("AddRowObject")]
        public void AddRowObject_ToFormObject_MI_Success()
        {
            string formId = "1";
            string expected1 = "1||1";
            string expected2 = "1||2";
            RowObject rowObject1 = new();
            RowObject rowObject2 = new();
            FormObject formObject = new()
            {
                FormId = formId,
                MultipleIteration = true
            };
            formObject = (FormObject)OptionObjectHelpers.AddRowObject(formObject, rowObject1);
            formObject = (FormObject)OptionObjectHelpers.AddRowObject(formObject, rowObject2);
            Assert.IsTrue(formObject.IsRowPresent(expected1));
            Assert.AreEqual(expected1, formObject.CurrentRow.RowId);
            Assert.IsTrue(formObject.IsRowPresent(expected2));
            Assert.AreEqual(expected2, formObject.OtherRows[0].RowId);
        }

        [TestMethod]
        [TestCategory("AddRowObject")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddRowObject_ToOptionObject_NullFormId()
        {
            string formId = null;
            string expected = "1||1";
            RowObject rowObject1 = new();
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            OptionObject optionObject = new();
            optionObject = (OptionObject)OptionObjectHelpers.AddFormObject(optionObject, formObject);
            optionObject = (OptionObject)OptionObjectHelpers.AddRowObject(optionObject, formId, rowObject1);
            Assert.IsTrue(optionObject.IsRowPresent(expected));
        }

        [TestMethod]
        [TestCategory("AddRowObject")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddRowObject_ToOptionObject2_NullFormId()
        {
            string formId = null;
            string expected = "1||1";
            RowObject rowObject1 = new();
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            OptionObject2 optionObject = new();
            optionObject = (OptionObject2)OptionObjectHelpers.AddFormObject(optionObject, formObject);
            optionObject = (OptionObject2)OptionObjectHelpers.AddRowObject(optionObject, formId, rowObject1);
            Assert.IsTrue(optionObject.IsRowPresent(expected));
        }

        [TestMethod]
        [TestCategory("AddRowObject")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddRowObject_ToOptionObject2015_NullFormId()
        {
            string formId = null;
            string expected = "1||1";
            RowObject rowObject1 = new();
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            OptionObject2015 optionObject = new();
            optionObject = (OptionObject2015)OptionObjectHelpers.AddFormObject(optionObject, formObject);
            optionObject = (OptionObject2015)OptionObjectHelpers.AddRowObject(optionObject, formId, rowObject1);
            Assert.IsTrue(optionObject.IsRowPresent(expected));
        }

        [TestMethod]
        [TestCategory("AddRowObject")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddRowObject_ToOptionObject_FormIdNotPresent()
        {
            string formId = "2";
            string expected = "1||1";
            RowObject rowObject1 = new();
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            OptionObject optionObject = new();
            optionObject = (OptionObject)OptionObjectHelpers.AddFormObject(optionObject, formObject);
            optionObject = (OptionObject)OptionObjectHelpers.AddRowObject(optionObject, formId, rowObject1);
            Assert.IsTrue(optionObject.IsRowPresent(expected));
        }

        [TestMethod]
        [TestCategory("AddRowObject")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddRowObject_ToOptionObject2_FormIdNotPresent()
        {
            string formId = "2";
            string expected = "1||1";
            RowObject rowObject1 = new();
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            OptionObject2 optionObject = new();
            optionObject = (OptionObject2)OptionObjectHelpers.AddFormObject(optionObject, formObject);
            optionObject = (OptionObject2)OptionObjectHelpers.AddRowObject(optionObject, formId, rowObject1);
            Assert.IsTrue(optionObject.IsRowPresent(expected));
        }

        [TestMethod]
        [TestCategory("AddRowObject")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddRowObject_ToOptionObject2015_FormIdNotPresent()
        {
            string formId = "2";
            string expected = "1||1";
            RowObject rowObject1 = new();
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            OptionObject2015 optionObject = new();
            optionObject = (OptionObject2015)OptionObjectHelpers.AddFormObject(optionObject, formObject);
            optionObject = (OptionObject2015)OptionObjectHelpers.AddRowObject(optionObject, formId, rowObject1);
            Assert.IsTrue(optionObject.IsRowPresent(expected));
        }

        [TestMethod]
        [TestCategory("AddRowObject")]
        public void AddRowObject_ToOptionObject_Success()
        {
            string formId = "1";
            string expected = "1||1";
            RowObject rowObject1 = new();
            FormObject formObject = new()
            {
                FormId = formId,
                MultipleIteration = false
            };
            OptionObject optionObject = new();
            optionObject = (OptionObject)OptionObjectHelpers.AddFormObject(optionObject, formObject);
            optionObject = (OptionObject)OptionObjectHelpers.AddRowObject(optionObject, formId, rowObject1);
            Assert.IsTrue(optionObject.IsRowPresent(expected));
        }

        [TestMethod]
        [TestCategory("AddRowObject")]
        public void AddRowObject_ToOptionObject2_Success()
        {
            string formId = "1";
            string expected = "1||1";
            RowObject rowObject1 = new();
            FormObject formObject = new()
            {
                FormId = formId,
                MultipleIteration = false
            };
            OptionObject2 optionObject = new();
            optionObject = (OptionObject2)OptionObjectHelpers.AddFormObject(optionObject, formObject);
            optionObject = (OptionObject2)OptionObjectHelpers.AddRowObject(optionObject, formId, rowObject1);
            Assert.IsTrue(optionObject.IsRowPresent(expected));
        }

        [TestMethod]
        [TestCategory("AddRowObject")]
        public void AddRowObject_ToOptionObject2015_Success()
        {
            string formId = "1";
            string expected = "1||1";
            RowObject rowObject1 = new();
            FormObject formObject = new()
            {
                FormId = formId,
                MultipleIteration = false
            };
            OptionObject2015 optionObject = new();
            optionObject = (OptionObject2015)OptionObjectHelpers.AddFormObject(optionObject, formObject);
            optionObject = (OptionObject2015)OptionObjectHelpers.AddRowObject(optionObject, formId, rowObject1);
            Assert.IsTrue(optionObject.IsRowPresent(expected));
        }

        [TestMethod]
        [TestCategory("AddRowObject")]
        public void AddRowObject_GetsExpectedRowId()
        {
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = true
            };
            formObject.CurrentRow = new RowObject("1||1");
            formObject.OtherRows.Add(new RowObject("1||2"));
            // Intentional gap in numbering
            formObject.OtherRows.Add(new RowObject("1||4"));
            formObject.OtherRows.Add(new RowObject("1||5"));
            formObject.OtherRows.Add(new RowObject("1||6"));
            formObject.OtherRows.Add(new RowObject("1||7"));
            formObject.OtherRows.Add(new RowObject("1||8"));
            formObject.OtherRows.Add(new RowObject("1||9"));
            formObject.OtherRows.Add(new RowObject("1||10"));
            formObject.OtherRows.Add(new RowObject("1||11"));
            formObject.OtherRows.Add(new RowObject("1||12"));
            formObject.OtherRows.Add(new RowObject("1||13"));
            formObject.OtherRows.Add(new RowObject("1||14"));
            formObject.OtherRows.Add(new RowObject("1||15"));

            formObject = (FormObject)OptionObjectHelpers.AddRowObject(formObject, new RowObject());   // Gap in series
            formObject = (FormObject)OptionObjectHelpers.AddRowObject(formObject, new RowObject());   // End of series

            Assert.IsTrue(formObject.IsRowPresent("1||1"));
            Assert.IsTrue(formObject.IsRowPresent("1||2"));
            Assert.IsTrue(formObject.IsRowPresent("1||3"));     // Gap in series filled
            Assert.IsTrue(formObject.IsRowPresent("1||16"));    // Added to end of series
        }

        [TestMethod]
        [TestCategory("AddRowObject")]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AddRowObject_TooManyRowsAdded()
        {
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = true
            };
            formObject.AddRowObject(new RowObject());       // Row 1 = CurrentRow

            int rowsToAdd = 9997;                           // Fill all available rows except 1
            for (int i = 0; i < rowsToAdd; ++i)
            {
                // Replace with get next RowId (if fast enough)
                string rowId = formObject.FormId + "||" + (i + 2).ToString();   
                formObject.OtherRows.Add(new RowObject(rowId));
            }

            Assert.IsTrue(formObject.IsRowPresent("1||1"));     // Beginning of series
            Assert.IsTrue(formObject.IsRowPresent("1||2"));
            Assert.IsTrue(formObject.IsRowPresent("1||3"));  
            Assert.IsTrue(formObject.IsRowPresent("1||9998"));

            formObject.AddRowObject(new RowObject());           // Add last row. Should succeed.
            Assert.IsTrue(formObject.IsRowPresent("1||9999"));  // Last of series

            formObject.AddRowObject(new RowObject());           // Add 1 row too many. Should cause error.
            Assert.IsTrue(formObject.IsRowPresent("1||10000")); // Too many rows, should have triggered Exception when added
        }
    }
}
