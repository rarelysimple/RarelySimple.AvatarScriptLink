using Microsoft.VisualStudio.TestTools.UnitTesting;
using RarelySimple.AvatarScriptLink.Objects;
using System;
using System.Collections.Generic;

namespace RarelySimple.AvatarScriptLink.Tests.ObjectsTests
{
    [TestClass]
    public class FormObjectTests
    {
        [TestMethod]
        [TestCategory("FormObject")]
        public void FormObject_HasOtherRowsObject()
        {
            FormObject formObject = new FormObject();
            Assert.IsNotNull(formObject.OtherRows);
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void FormObject_OtherRowsObject_IsNotEmpty()
        {
            FormObject formObject = new FormObject();
            List<RowObject> expected = new List<RowObject>();
            var actual = formObject.OtherRows;
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void FormObject_Default_MultipleIteration_IsFalse()
        {
            FormObject formObject = new FormObject();
            Assert.IsFalse(formObject.MultipleIteration);
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void FormObject_CanSetMultipleIteration()
        {
            var formObject = new FormObject
            {
                MultipleIteration = true
            };
            Assert.IsTrue(formObject.MultipleIteration);
            formObject.MultipleIteration = false;
            Assert.IsFalse(formObject.MultipleIteration);
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void FormObject_AddRowObject_NoMI_RowObject()
        {
            RowObject rowObject1 = new RowObject
            {
                RowId = "1||1"
            };
            RowObject rowObject2 = new RowObject
            {
                RowId = "1||2"
            };
            FormObject formObject = new FormObject
            {
                MultipleIteration = false
            };

            formObject.AddRowObject(rowObject1);
            Assert.AreEqual(rowObject1, formObject.CurrentRow);
            Assert.IsFalse(formObject.OtherRows.Contains(rowObject1));
        }

        [TestMethod]
        [TestCategory("FormObject")]
        [ExpectedException(typeof(ArgumentException))]
        public void FormObject_AddRowObject_NoMI_RowObject_Exception()
        {
            RowObject rowObject1 = new RowObject
            {
                RowId = "1||1"
            };
            RowObject rowObject2 = new RowObject
            {
                RowId = "1||2"
            };
            FormObject formObject = new FormObject
            {
                MultipleIteration = false
            };

            formObject.AddRowObject(rowObject1);
            formObject.AddRowObject(rowObject2);
            Assert.AreNotEqual(rowObject2, formObject.CurrentRow);
            Assert.IsFalse(formObject.OtherRows.Contains(rowObject2));
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void FormObject_AddRowObject_MI_RowObject()
        {
            RowObject rowObject1 = new RowObject
            {
                RowId = "1||1"
            };
            RowObject rowObject2 = new RowObject
            {
                RowId = "1||2"
            };
            FormObject formObject = new FormObject
            {
                MultipleIteration = true
            };

            formObject.AddRowObject(rowObject1);
            Assert.AreEqual(rowObject1, formObject.CurrentRow);
            Assert.IsFalse(formObject.OtherRows.Contains(rowObject1));

            formObject.AddRowObject(rowObject2);
            Assert.AreNotEqual(rowObject2, formObject.CurrentRow);
            Assert.IsTrue(formObject.OtherRows.Contains(rowObject2));
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void FormObject_AddRowObject_Properties_NoRowAction()
        {
            FormObject formObject = new FormObject
            {
                FormId = "1",
                MultipleIteration = false
            };

            formObject.AddRowObject("1||1", "");
            Assert.AreEqual("1||1", formObject.CurrentRow.RowId);
            Assert.AreEqual("", formObject.CurrentRow.ParentRowId);
            Assert.AreEqual(RowAction.Add, formObject.CurrentRow.RowAction);
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void FormObject_AddRowObject_Properties_with_RowAction()
        {
            FormObject formObject = new FormObject
            {
                FormId = "1",
                MultipleIteration = false
            };

            formObject.AddRowObject("1||1", "", "");
            Assert.AreEqual("1||1", formObject.CurrentRow.RowId);
            Assert.AreEqual("", formObject.CurrentRow.ParentRowId);
            Assert.AreEqual("", formObject.CurrentRow.RowAction);
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void FormObject_CanGetHtmlString_WithoutHtmlHeaders()
        {
            FormObject formObject = new FormObject();
            var actual = formObject.ToHtmlString(false);
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void FormObject_CanGetHtmlString_WithHtmlHeaders()
        {
            FormObject formObject = new FormObject();
            var actual = formObject.ToHtmlString(false);
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        [TestCategory("FormObject")]
        [ExpectedException(typeof(NullReferenceException))]
        public void FormObject_GetCurrentRowId_IsError()
        {
            FormObject formObject = new FormObject();
            var actual = formObject.GetCurrentRowId();
            Assert.AreEqual(null, actual);
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void FormObject_GetCurrentRowId_AreEqual()
        {
            string expected = "1||1";
            FormObject formObject = new FormObject
            {
                CurrentRow = new RowObject()
            };
            formObject.CurrentRow.RowId = expected;
            var actual = formObject.GetCurrentRowId();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("FormObject")]
        [ExpectedException(typeof(NullReferenceException))]
        public void FormObject_GetParentRowId_IsError()
        {
            FormObject formObject = new FormObject();
            var actual = formObject.GetParentRowId();
            Assert.AreEqual(null, actual);
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void FormObject_GetParentRowId_AreEqual()
        {
            string expected = "1||1";
            FormObject formObject = new FormObject
            {
                CurrentRow = new RowObject()
            };
            formObject.CurrentRow.ParentRowId = expected;
            var actual = formObject.GetParentRowId();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void FormObject_IsFieldEnabled_IsTrue()
        {
            FieldObject fieldObject = new FieldObject
            {
                Enabled = "1",
                FieldNumber = "123",
                FieldValue = "TEST",
                Lock = "0",
                Required = "0"
            };
            RowObject rowObject = new RowObject();
            rowObject.Fields.Add(fieldObject);
            FormObject formObject = new FormObject
            {
                CurrentRow = rowObject
            };

            Assert.IsTrue(formObject.IsFieldEnabled("123"));
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void FormObject_IsFieldEnabled_IsFalse()
        {
            FieldObject fieldObject = new FieldObject
            {
                Enabled = "0",
                FieldNumber = "123",
                FieldValue = "TEST",
                Lock = "0",
                Required = "0"
            };
            RowObject rowObject = new RowObject();
            rowObject.Fields.Add(fieldObject);
            FormObject formObject = new FormObject
            {
                CurrentRow = rowObject
            };

            Assert.IsFalse(formObject.IsFieldEnabled("123"));
        }

        [TestMethod]
        [TestCategory("FormObject")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void FormObject_IsFieldEnabled_NotPresent_Error()
        {
            FieldObject fieldObject = new FieldObject
            {
                Enabled = "1",
                FieldNumber = "123",
                FieldValue = "TEST",
                Lock = "0",
                Required = "0"
            };
            RowObject rowObject = new RowObject();
            rowObject.Fields.Add(fieldObject);
            FormObject formObject = new FormObject
            {
                CurrentRow = rowObject
            };

            Assert.IsFalse(formObject.IsFieldEnabled("124"));
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void FormObject_IsFieldLocked_IsTrue()
        {
            FieldObject fieldObject = new FieldObject
            {
                Enabled = "0",
                FieldNumber = "123",
                FieldValue = "TEST",
                Lock = "1",
                Required = "0"
            };
            RowObject rowObject = new RowObject();
            rowObject.Fields.Add(fieldObject);
            FormObject formObject = new FormObject
            {
                CurrentRow = rowObject
            };

            Assert.IsTrue(formObject.IsFieldLocked("123"));
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void FormObject_IsFieldLocked_IsFalse()
        {
            FieldObject fieldObject = new FieldObject
            {
                Enabled = "0",
                FieldNumber = "123",
                FieldValue = "TEST",
                Lock = "0",
                Required = "0"
            };
            RowObject rowObject = new RowObject();
            rowObject.Fields.Add(fieldObject);
            FormObject formObject = new FormObject
            {
                CurrentRow = rowObject
            };

            Assert.IsFalse(formObject.IsFieldLocked("123"));
        }

        [TestMethod]
        [TestCategory("FormObject")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void FormObject_IsFieldLocked_NotPresent_Error()
        {
            FieldObject fieldObject = new FieldObject
            {
                Enabled = "0",
                FieldNumber = "123",
                FieldValue = "TEST",
                Lock = "1",
                Required = "0"
            };
            RowObject rowObject = new RowObject();
            rowObject.Fields.Add(fieldObject);
            FormObject formObject = new FormObject
            {
                CurrentRow = rowObject
            };

            Assert.IsFalse(formObject.IsFieldLocked("124"));
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void FormObject_IsFieldPresent_IsTrue()
        {
            FieldObject fieldObject = new FieldObject
            {
                Enabled = "0",
                FieldNumber = "123",
                FieldValue = "TEST",
                Lock = "0",
                Required = "0"
            };
            RowObject rowObject = new RowObject();
            rowObject.Fields.Add(fieldObject);
            FormObject formObject = new FormObject
            {
                CurrentRow = rowObject
            };

            Assert.IsTrue(formObject.IsFieldPresent("123"));
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void FormObject_IsFieldPresent_IsFalse()
        {
            FieldObject fieldObject = new FieldObject
            {
                Enabled = "0",
                FieldNumber = "123",
                FieldValue = "TEST",
                Lock = "0",
                Required = "0"
            };
            RowObject rowObject = new RowObject();
            rowObject.Fields.Add(fieldObject);
            FormObject formObject = new FormObject
            {
                CurrentRow = rowObject
            };

            Assert.IsFalse(formObject.IsFieldPresent("124"));
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void FormObject_IsFieldRequired_IsTrue()
        {
            FieldObject fieldObject = new FieldObject
            {
                Enabled = "0",
                FieldNumber = "123",
                FieldValue = "TEST",
                Lock = "0",
                Required = "1"
            };
            RowObject rowObject = new RowObject();
            rowObject.Fields.Add(fieldObject);
            FormObject formObject = new FormObject
            {
                CurrentRow = rowObject
            };

            Assert.IsTrue(formObject.IsFieldRequired("123"));
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void FormObject_IsFieldRequired_IsFalse()
        {
            FieldObject fieldObject = new FieldObject
            {
                Enabled = "0",
                FieldNumber = "123",
                FieldValue = "TEST",
                Lock = "0",
                Required = "0"
            };
            RowObject rowObject = new RowObject();
            rowObject.Fields.Add(fieldObject);
            FormObject formObject = new FormObject
            {
                CurrentRow = rowObject
            };

            Assert.IsFalse(formObject.IsFieldRequired("123"));
        }

        [TestMethod]
        [TestCategory("FormObject")]
        [ExpectedException(typeof(ArgumentException))]
        public void FormObject_IsFieldRequired_NotPresent_IsFalse()
        {
            FieldObject fieldObject = new FieldObject
            {
                Enabled = "0",
                FieldNumber = "123",
                FieldValue = "TEST",
                Lock = "0",
                Required = "1"
            };
            RowObject rowObject = new RowObject();
            rowObject.Fields.Add(fieldObject);
            FormObject formObject = new FormObject
            {
                CurrentRow = rowObject
            };

            Assert.IsFalse(formObject.IsFieldRequired("124"));
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void FormObject_SetFieldValue_NoMI_AreEqual()
        {
            FieldObject fieldObject = new FieldObject
            {
                Enabled = "1",
                FieldNumber = "123",
                FieldValue = "TEST",
                Lock = "0",
                Required = "0"
            };
            RowObject rowObject = new RowObject
            {
                RowId = "1||1"
            };
            rowObject.Fields.Add(fieldObject);
            FormObject formObject = new FormObject
            {
                CurrentRow = rowObject,
                MultipleIteration = false
            };

            formObject.SetFieldValue("123", "MODIFIED");
            Assert.AreEqual("MODIFIED", formObject.GetFieldValue("123"));
            formObject.SetFieldValue("1||1", "123", "MODIFIED AGAIN");
            Assert.AreEqual("MODIFIED AGAIN", formObject.GetFieldValue("123"));
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void FormObject_SetFieldValue_MI_AreEqual()
        {
            FieldObject fieldObject1 = new FieldObject
            {
                Enabled = "0",
                FieldNumber = "123",
                FieldValue = "TEST",
                Lock = "0",
                Required = "0"
            };
            RowObject rowObject1 = new RowObject
            {
                RowId = "1||1"
            };
            rowObject1.Fields.Add(fieldObject1);
            FieldObject fieldObject2 = new FieldObject
            {
                Enabled = "0",
                FieldNumber = "123",
                FieldValue = "TEST2",
                Lock = "0",
                Required = "0"
            };
            RowObject rowObject2 = new RowObject
            {
                RowId = "1||2"
            };
            rowObject2.Fields.Add(fieldObject2);
            FormObject formObject = new FormObject
            {
                CurrentRow = rowObject1,
                MultipleIteration = true
            };
            formObject.OtherRows.Add(rowObject2);

            formObject.SetFieldValue("1||2", "123", "MODIFIED");
            Assert.AreNotEqual("MODIFIED", formObject.GetFieldValue("123"));
            Assert.AreNotEqual("MODIFIED", formObject.GetFieldValue("1||1", "123"));
            Assert.AreEqual("MODIFIED", formObject.GetFieldValue("1||2", "123"));
        }

        [TestMethod]
        [TestCategory("FormObject")]
        [ExpectedException(typeof(ArgumentException))]
        public void FormObject_SetFieldValue_MI_Error()
        {
            FieldObject fieldObject1 = new FieldObject
            {
                Enabled = "0",
                FieldNumber = "123",
                FieldValue = "TEST",
                Lock = "0",
                Required = "0"
            };
            RowObject rowObject1 = new RowObject
            {
                RowId = "1||1"
            };
            rowObject1.Fields.Add(fieldObject1);
            FieldObject fieldObject2 = new FieldObject
            {
                Enabled = "0",
                FieldNumber = "123",
                FieldValue = "TEST2",
                Lock = "0",
                Required = "0"
            };
            RowObject rowObject2 = new RowObject
            {
                RowId = "1||2"
            };
            rowObject2.Fields.Add(fieldObject2);
            FormObject formObject = new FormObject
            {
                CurrentRow = rowObject1,
                MultipleIteration = true
            };
            formObject.OtherRows.Add(rowObject2);

            formObject.SetFieldValue("123", "MODIFIED");
            Assert.AreNotEqual("MODIFIED", formObject.GetFieldValue("123"));
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void FormObject_Constructor_1Parameter_NoError()
        {
            string formId = "1";
            FormObject formObject = new FormObject(formId);
            Assert.AreEqual(formId, formObject.FormId);
            Assert.AreEqual(null, formObject.CurrentRow);
            Assert.AreEqual(false, formObject.MultipleIteration);
            Assert.AreEqual(0, formObject.OtherRows.Count);
        }

        [TestMethod]
        [TestCategory("FormObject")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FormObject_Constructor_1Parameter_Error()
        {
            string formId = "";
            FormObject formObject = new FormObject(formId);
            Assert.AreEqual(formId, formObject.FormId);
            Assert.AreEqual(null, formObject.CurrentRow);
            Assert.AreEqual(false, formObject.MultipleIteration);
            Assert.AreEqual(0, formObject.OtherRows.Count);
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void FormObject_Constructor_2Parameter_NoError()
        {
            string formId = "1";
            RowObject currentRow = new RowObject();
            FormObject formObject = new FormObject(formId, currentRow);
            Assert.AreEqual(formId, formObject.FormId);
            Assert.AreEqual(currentRow, formObject.CurrentRow);
            Assert.AreEqual(false, formObject.MultipleIteration);
            Assert.AreEqual(0, formObject.OtherRows.Count);
        }

        [TestMethod]
        [TestCategory("FormObject")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FormObject_Constructor_2Parameter_Error()
        {
            string formId = "";
            RowObject currentRow = new RowObject();
            FormObject formObject = new FormObject(formId, currentRow);
            Assert.AreEqual(formId, formObject.FormId);
            Assert.AreEqual(currentRow, formObject.CurrentRow);
            Assert.AreEqual(false, formObject.MultipleIteration);
            Assert.AreEqual(0, formObject.OtherRows.Count);
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void FormObject_Constructor_3Parameter_NoError()
        {
            string formId = "1";
            RowObject currentRow = new RowObject();
            bool multipleIteration = true;
            FormObject formObject = new FormObject(formId, currentRow, multipleIteration);
            Assert.AreEqual(formId, formObject.FormId);
            Assert.AreEqual(currentRow, formObject.CurrentRow);
            Assert.AreEqual(multipleIteration, formObject.MultipleIteration);
            Assert.AreEqual(0, formObject.OtherRows.Count);
        }

        [TestMethod]
        [TestCategory("FormObject")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FormObject_Constructor_3Parameter_Error()
        {
            string formId = "";
            RowObject currentRow = new RowObject();
            bool multipleIteration = true;
            FormObject formObject = new FormObject(formId, currentRow, multipleIteration);
            Assert.AreEqual(formId, formObject.FormId);
            Assert.AreEqual(currentRow, formObject.CurrentRow);
            Assert.AreEqual(multipleIteration, formObject.MultipleIteration);
            Assert.AreEqual(0, formObject.OtherRows.Count);
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void FormObject_Constructor_4Parameter_NoError()
        {
            string formId = "1";
            RowObject currentRow = new RowObject();
            bool multipleIteration = true;
            RowObject otherRow = new RowObject();
            List<RowObject> otherRows = new List<RowObject>
            {
                otherRow
            };
            FormObject formObject = new FormObject(formId, currentRow, multipleIteration, otherRows);
            Assert.AreEqual(formId, formObject.FormId);
            Assert.AreEqual(currentRow, formObject.CurrentRow);
            Assert.AreEqual(multipleIteration, formObject.MultipleIteration);
            Assert.AreEqual(otherRows.Count, formObject.OtherRows.Count);
        }

        [TestMethod]
        [TestCategory("FormObject")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FormObject_Constructor_4Parameter_Error()
        {
            string formId = "";
            RowObject currentRow = new RowObject();
            bool multipleIteration = true;
            RowObject otherRow = new RowObject();
            List<RowObject> otherRows = new List<RowObject>
            {
                otherRow
            };
            FormObject formObject = new FormObject(formId, currentRow, multipleIteration, otherRows);
            Assert.AreEqual(formId, formObject.FormId);
            Assert.AreEqual(currentRow, formObject.CurrentRow);
            Assert.AreEqual(multipleIteration, formObject.MultipleIteration);
            Assert.AreEqual(otherRows.Count, formObject.OtherRows.Count);
        }

        [TestMethod]
        public void FormObject_Clone_AreEqual()
        {
            List<FieldObject> fieldObjects = new List<FieldObject>
            {
                new FieldObject("123", "Test")
            };
            RowObject rowObject = new RowObject("1||1", fieldObjects);
            FormObject formObject = new FormObject("1", rowObject);

            FormObject cloneObject = formObject.Clone();

            Assert.AreEqual(formObject, cloneObject);
            Assert.IsTrue(formObject.IsFieldPresent("123"));
            Assert.IsTrue(cloneObject.IsFieldPresent("123"));
        }

        [TestMethod]
        public void FormObject_Clone_AreNotEqual()
        {
            List<FieldObject> fieldObjects = new List<FieldObject>
            {
                new FieldObject("123", "Test")
            };
            RowObject rowObject = new RowObject("1||1", fieldObjects);
            FormObject formObject = new FormObject("1", rowObject);

            FormObject cloneObject = formObject.Clone();
            formObject.DeleteRowObject(rowObject);

            Assert.AreNotEqual(formObject.ToJson(), cloneObject.ToJson());
            Assert.AreNotEqual(formObject, cloneObject);
            Assert.IsTrue(formObject.IsFieldPresent("123"));
            Assert.IsTrue(formObject.IsRowMarkedForDeletion("1||1"));
            Assert.IsTrue(cloneObject.IsFieldPresent("123"));
            Assert.IsFalse(cloneObject.IsRowMarkedForDeletion("1||1"));
        }
    }
}
