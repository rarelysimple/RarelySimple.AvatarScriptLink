using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.HelpersTests
{
    [TestClass]
    public class AddRowObjectTests
    {
        [TestMethod]
        [TestCategory("AddRowObject")]
        public void AddRowObject_ToFormObject_NullFormObject()
        {
            RowObject rowObject = new();
            Assert.ThrowsException<ArgumentNullException>(() => OptionObjectHelpers.AddRowObject(null, rowObject));
        }

        [TestMethod]
        [TestCategory("AddRowObject")]
        public void AddRowObject_ToFormObject_NullRowObject()
        {
            FormObject formObject = new();
            Assert.ThrowsException<ArgumentNullException>(() => OptionObjectHelpers.AddRowObject(formObject, null));
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
        public void AddRowObject_ToFormObject_Multiple_NonMI()
        {
            string formId = "1";
            RowObject rowObject1 = new();
            RowObject rowObject2 = new();
            FormObject formObject = new()
            {
                FormId = formId
            };
            formObject = (FormObject)OptionObjectHelpers.AddRowObject(formObject, rowObject1);
            Assert.ThrowsException<ArgumentException>(() => OptionObjectHelpers.AddRowObject(formObject, rowObject2));
        }

        [TestMethod]
        [TestCategory("AddRowObject")]
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
            Assert.ThrowsException<ArgumentException>(() => OptionObjectHelpers.AddRowObject(formObject, rowObject2));
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
        public void AddRowObject_ToOptionObject_NullFormId()
        {
            RowObject rowObject1 = new();
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            OptionObject optionObject = new();
            optionObject = (OptionObject)OptionObjectHelpers.AddFormObject(optionObject, formObject);
            Assert.ThrowsException<ArgumentNullException>(() => OptionObjectHelpers.AddRowObject(optionObject, null, rowObject1));
        }

        [TestMethod]
        [TestCategory("AddRowObject")]
        public void AddRowObject_ToOptionObject2_NullFormId()
        {
            RowObject rowObject1 = new();
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            OptionObject2 optionObject = new();
            optionObject = (OptionObject2)OptionObjectHelpers.AddFormObject(optionObject, formObject);
            Assert.ThrowsException<ArgumentNullException>(() => OptionObjectHelpers.AddRowObject(optionObject, null, rowObject1));
        }

        [TestMethod]
        [TestCategory("AddRowObject")]
        public void AddRowObject_ToOptionObject2015_NullFormId()
        {
            RowObject rowObject1 = new();
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            OptionObject2015 optionObject = new();
            optionObject = (OptionObject2015)OptionObjectHelpers.AddFormObject(optionObject, formObject);
            Assert.ThrowsException<ArgumentNullException>(() => OptionObjectHelpers.AddRowObject(optionObject, null, rowObject1));
        }

        [TestMethod]
        [TestCategory("AddRowObject")]
        public void AddRowObject_ToOptionObject_FormIdNotPresent()
        {
            string formId = "2";
            RowObject rowObject1 = new();
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            OptionObject optionObject = new();
            optionObject = (OptionObject)OptionObjectHelpers.AddFormObject(optionObject, formObject);
            var result = (OptionObject)OptionObjectHelpers.AddRowObject(optionObject, formId, rowObject1);
            // When FormId is not found, the method should return null or handle gracefully
            Assert.IsNotNull(result);
        }

        [TestMethod]
        [TestCategory("AddRowObject")]
        public void AddRowObject_ToOptionObject2_FormIdNotPresent()
        {
            string formId = "2";
            RowObject rowObject1 = new();
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            OptionObject2 optionObject = new();
            optionObject = (OptionObject2)OptionObjectHelpers.AddFormObject(optionObject, formObject);
            var result = (OptionObject2)OptionObjectHelpers.AddRowObject(optionObject, formId, rowObject1);
            // When FormId is not found, the method should return the optionObject unchanged
            Assert.IsNotNull(result);
        }

        [TestMethod]
        [TestCategory("AddRowObject")]
        public void AddRowObject_ToOptionObject2015_FormIdNotPresent()
        {
            string formId = "2";
            RowObject rowObject1 = new();
            FormObject formObject = new()
            {
                FormId = "1",
                MultipleIteration = false
            };
            OptionObject2015 optionObject = new();
            optionObject = (OptionObject2015)OptionObjectHelpers.AddFormObject(optionObject, formObject);
            var result = (OptionObject2015)OptionObjectHelpers.AddRowObject(optionObject, formId, rowObject1);
            // When FormId is not found, the method should return the optionObject unchanged
            Assert.IsNotNull(result);
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
                MultipleIteration = true,
                CurrentRow = new RowObject("1||1")
            };
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

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => formObject.AddRowObject(new RowObject()));
        }

        [TestMethod]
        public void AddRowObject_OptionObject_NullOptionObject()
        {
            Assert.ThrowsException<ArgumentNullException>(() => OptionObjectHelpers.AddRowObject((OptionObject)null, "1", new RowObject()));
        }

        [TestMethod]
        public void AddRowObject_OptionObject_NullForms()
        {
            OptionObject optionObject = new() { Forms = null };
            Assert.ThrowsException<ArgumentNullException>(() => optionObject.AddRowObject("1", new RowObject()));
        }
    }
}
