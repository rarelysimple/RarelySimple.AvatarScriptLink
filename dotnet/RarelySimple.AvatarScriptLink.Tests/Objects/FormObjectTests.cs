using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.ObjectsTests
{
    [TestClass]
    public class FormObjectTests
    {
        [TestMethod]
        [TestCategory("FormObject")]
        public void FormObject_HasOtherRowsObject()
        {
            FormObject formObject = FormObject.Initialize();
            Assert.IsNotNull(formObject.OtherRows);
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void FormObject_OtherRowsObject_IsNotEmpty()
        {
            FormObject formObject = FormObject.Initialize();
            List<RowObject> expected = new List<RowObject>();
            var actual = formObject.OtherRows;
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void FormObject_Default_MultipleIteration_IsFalse()
        {
            FormObject formObject = FormObject.Initialize();
            Assert.IsFalse(formObject.MultipleIteration);
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void FormObject_CanSetMultipleIteration()
        {
            var formObject = FormObject.Builder()
                .FormId("1")
                .MultipleIteration()
                .Build();
            Assert.IsTrue(formObject.MultipleIteration);
            formObject.MultipleIteration = false;
            Assert.IsFalse(formObject.MultipleIteration);
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void FormObject_AddRowObject_NoMI_RowObject()
        {
            RowObject rowObject1 = RowObject.Builder()
                .RowId("1||1")
                .Build();
            FormObject formObject = FormObject.Initialize();

            formObject.AddRowObject(rowObject1);
            Assert.AreEqual(rowObject1, formObject.CurrentRow);
            Assert.IsFalse(formObject.OtherRows.Contains(rowObject1));
        }

        [TestMethod]
        [TestCategory("FormObject")]
        [ExpectedException(typeof(ArgumentException))]
        public void FormObject_AddRowObject_NoMI_RowObject_Exception()
        {
            RowObject rowObject1 = RowObject.Builder()
                .RowId("1||1")
                .Build();
            RowObject rowObject2 = RowObject.Builder()
                .RowId("1||2")
                .Build();
            FormObject formObject = FormObject.Initialize();

            formObject.AddRowObject(rowObject1);
            formObject.AddRowObject(rowObject2);
            Assert.AreNotEqual(rowObject2, formObject.CurrentRow);
            Assert.IsFalse(formObject.OtherRows.Contains(rowObject2));
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void FormObject_AddRowObject_MI_RowObject()
        {
            RowObject rowObject1 = RowObject.Builder()
                .RowId("1||1")
                .Build();
            RowObject rowObject2 = RowObject.Builder()
                .RowId("1||2")
                .Build();
            FormObject formObject = FormObject.Builder()
                .FormId("1")
                .MultipleIteration()
                .Build();

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
            FormObject formObject = FormObject.Builder().FormId("1").Build();

            formObject.AddRowObject("1||1", "");
            Assert.AreEqual("1||1", formObject.CurrentRow.RowId);
            Assert.AreEqual("", formObject.CurrentRow.ParentRowId);
            Assert.AreEqual(RowAction.Add, formObject.CurrentRow.RowAction);
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void FormObject_AddRowObject_Properties_with_RowAction()
        {
            FormObject formObject = FormObject.Builder().FormId("1").Build();

            formObject.AddRowObject("1||1", "", "");
            Assert.AreEqual("1||1", formObject.CurrentRow.RowId);
            Assert.AreEqual("", formObject.CurrentRow.ParentRowId);
            Assert.AreEqual("", formObject.CurrentRow.RowAction);
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void FormObject_CanGetHtmlString_WithoutHtmlHeaders()
        {
            FormObject formObject = FormObject.Initialize();
            var actual = formObject.ToHtmlString(false);
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void FormObject_CanGetHtmlString_WithHtmlHeaders()
        {
            FormObject formObject = FormObject.Initialize();
            var actual = formObject.ToHtmlString(false);
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        [TestCategory("FormObject")]
        [ExpectedException(typeof(NullReferenceException))]
        public void FormObject_GetCurrentRowId_IsError()
        {
            FormObject formObject = FormObject.Initialize();
            var actual = formObject.GetCurrentRowId();
            Assert.AreEqual(null, actual);
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void FormObject_GetCurrentRowId_AreEqual()
        {
            string expected = "1||1";
            FormObject formObject = FormObject.Builder()
                .FormId("1")
                .CurrentRow()
                    .RowId(expected)
                    .AddRow()
                .Build();
            var actual = formObject.GetCurrentRowId();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("FormObject")]
        [ExpectedException(typeof(NullReferenceException))]
        public void FormObject_GetParentRowId_IsError()
        {
            FormObject formObject = FormObject.Initialize();
            var actual = formObject.GetParentRowId();
            Assert.AreEqual(null, actual);
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void FormObject_GetParentRowId_AreEqual()
        {
            string expected = "1||1";
            FormObject formObject = FormObject.Builder()
                .FormId("1")
                .CurrentRow()
                    .RowId("1||2")
                    .ParentRowId(expected)
                    .AddRow()
                .Build();
            var actual = formObject.GetParentRowId();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void FormObject_IsFieldEnabled_IsTrue()
        {
            FieldObject fieldObject = FieldObject.Builder()
                .FieldNumber("123")
                .FieldValue("TEST")
                .Enabled()
                .Build();
            FormObject formObject = FormObject.Builder()
                .FormId("1")
                .CurrentRow()
                    .RowId("1||1")
                    .Field(fieldObject)
                    .AddRow()
                .Build();

            Assert.IsTrue(formObject.IsFieldEnabled("123"));
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void FormObject_IsFieldEnabled_IsFalse()
        {
            FieldObject fieldObject = FieldObject.Builder()
                .FieldNumber("123")
                .FieldValue("TEST")
                .Build();
            FormObject formObject = FormObject.Builder()
                .FormId("1")
                .CurrentRow()
                    .RowId("1||1")
                    .Field(fieldObject)
                    .AddRow()
                .Build();

            Assert.IsFalse(formObject.IsFieldEnabled("123"));
        }

        [TestMethod]
        [TestCategory("FormObject")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void FormObject_IsFieldEnabled_NotPresent_Error()
        {
            FieldObject fieldObject = FieldObject.Builder()
                .FieldNumber("123")
                .FieldValue("TEST")
                .Enabled()
                .Build();
            FormObject formObject = FormObject.Builder()
                .FormId("1")
                .CurrentRow()
                    .RowId("1||1")
                    .Field(fieldObject)
                    .AddRow()
                .Build();

            Assert.IsFalse(formObject.IsFieldEnabled("124"));
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void FormObject_IsFieldLocked_IsTrue()
        {
            FieldObject fieldObject = FieldObject.Builder()
                .FieldNumber("123")
                .FieldValue("TEST")
                .Locked()
                .Build();
            FormObject formObject = FormObject.Builder()
                .FormId("1")
                .CurrentRow()
                    .RowId("1||1")
                    .Field(fieldObject)
                    .AddRow()
                .Build();

            Assert.IsTrue(formObject.IsFieldLocked("123"));
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void FormObject_IsFieldLocked_IsFalse()
        {
            FieldObject fieldObject = FieldObject.Builder()
                .FieldNumber("123")
                .FieldValue("TEST")
                .Build();
            FormObject formObject = FormObject.Builder()
                .FormId("1")
                .CurrentRow()
                    .RowId("1||1")
                    .Field(fieldObject)
                    .AddRow()
                .Build();

            Assert.IsFalse(formObject.IsFieldLocked("123"));
        }

        [TestMethod]
        [TestCategory("FormObject")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void FormObject_IsFieldLocked_NotPresent_Error()
        {
            FieldObject fieldObject = FieldObject.Builder()
                .FieldNumber("123")
                .FieldValue("TEST")
                .Locked()
                .Build();
            FormObject formObject = FormObject.Builder()
                .FormId("1")
                .CurrentRow()
                    .RowId("1||1")
                    .Field(fieldObject)
                    .AddRow()
                .Build();

            Assert.IsFalse(formObject.IsFieldLocked("124"));
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void FormObject_IsFieldPresent_IsTrue()
        {
            FieldObject fieldObject = FieldObject.Builder()
                .FieldNumber("123")
                .FieldValue("TEST")
                .Build();
            FormObject formObject = FormObject.Builder()
                .FormId("1")
                .CurrentRow()
                    .RowId("1||1")
                    .Field(fieldObject)
                    .AddRow()
                .Build();

            Assert.IsTrue(formObject.IsFieldPresent("123"));
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void FormObject_IsFieldPresent_IsFalse()
        {
            FieldObject fieldObject = FieldObject.Builder()
                .FieldNumber("123")
                .FieldValue("TEST")
                .Build();
            FormObject formObject = FormObject.Builder()
                .FormId("1")
                .CurrentRow()
                    .RowId("1||1")
                    .Field(fieldObject)
                    .AddRow()
                .Build();

            Assert.IsFalse(formObject.IsFieldPresent("124"));
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void FormObject_IsFieldRequired_IsTrue()
        {
            FieldObject fieldObject = FieldObject.Builder()
                .FieldNumber("123")
                .FieldValue("TEST")
                .Required()
                .Build();
            FormObject formObject = FormObject.Builder()
                .FormId("1")
                .CurrentRow()
                    .RowId("1||1")
                    .Field(fieldObject)
                    .AddRow()
                .Build();

            Assert.IsTrue(formObject.IsFieldRequired("123"));
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void FormObject_IsFieldRequired_IsFalse()
        {
            FieldObject fieldObject = FieldObject.Builder()
                .FieldNumber("123")
                .FieldValue("TEST")
                .Build();
            FormObject formObject = FormObject.Builder()
                .FormId("1")
                .CurrentRow()
                    .RowId("1||1")
                    .Field(fieldObject)
                    .AddRow()
                .Build();

            Assert.IsFalse(formObject.IsFieldRequired("123"));
        }

        [TestMethod]
        [TestCategory("FormObject")]
        [ExpectedException(typeof(ArgumentException))]
        public void FormObject_IsFieldRequired_NotPresent_IsFalse()
        {
            FieldObject fieldObject = FieldObject.Builder()
                .FieldNumber("123")
                .FieldValue("TEST")
                .Required()
                .Build();
            FormObject formObject = FormObject.Builder()
                .FormId("1")
                .CurrentRow()
                    .RowId("1||1")
                    .Field(fieldObject)
                    .AddRow()
                .Build();

            Assert.IsFalse(formObject.IsFieldRequired("124"));
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void FormObject_SetFieldValue_NoMI_AreEqual()
        {
            FieldObject fieldObject = FieldObject.Builder()
                .FieldNumber("123")
                .FieldValue("TEST")
                .Enabled()
                .Build();
            FormObject formObject = FormObject.Builder()
                .FormId("1")
                .CurrentRow()
                    .RowId("1||1")
                    .Field(fieldObject)
                    .AddRow()
                .Build();

            formObject.SetFieldValue("123", "MODIFIED");
            Assert.AreEqual("MODIFIED", formObject.GetFieldValue("123"));
            formObject.SetFieldValue("1||1", "123", "MODIFIED AGAIN");
            Assert.AreEqual("MODIFIED AGAIN", formObject.GetFieldValue("123"));
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void FormObject_SetFieldValue_MI_AreEqual()
        {
            FieldObject fieldObject1 = FieldObject.Builder()
                .FieldNumber("123")
                .FieldValue("TEST")
                .Build();
            FieldObject fieldObject2 = FieldObject.Builder()
                .FieldNumber("123")
                .FieldValue("TEST2")
                .Build();
            FormObject formObject = FormObject.Builder()
                .FormId("1")
                .CurrentRow().RowId("1||1").Field(fieldObject1).AddRow()
                .MultipleIteration()
                .OtherRow().RowId("1||2").Field(fieldObject2).AddRow()
                .Build();

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
            FieldObject fieldObject1 = FieldObject.Builder()
                .FieldNumber("123")
                .FieldValue("TEST")
                .Build();
            FieldObject fieldObject2 = FieldObject.Builder()
                .FieldNumber("123")
                .FieldValue("TEST2")
                .Build();
            FormObject formObject = FormObject.Builder()
                .FormId("1")
                .CurrentRow().RowId("1||1").Field(fieldObject1).AddRow()
                .MultipleIteration()
                .OtherRow().RowId("1||2").Field(fieldObject2).AddRow()
                .Build();

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
            FieldObject fieldObject = FieldObject.Builder()
                .FieldNumber("123")
                .FieldValue("Test")
                .Build();
            FormObject formObject = FormObject.Builder()
                .FormId("1")
                .CurrentRow().RowId("1||1").Field(fieldObject).AddRow()
                .Build();

            FormObject cloneObject = formObject.Clone();

            Assert.AreEqual(formObject, cloneObject);
            Assert.IsTrue(formObject.IsFieldPresent("123"));
            Assert.IsTrue(cloneObject.IsFieldPresent("123"));
        }

        [TestMethod]
        public void FormObject_Clone_AreNotEqual()
        {
            RowObject rowObject = RowObject.Builder()
                .RowId("1||1")
                .Field().FieldNumber("123").FieldValue("Test").AddField()
                .Build();
            FormObject formObject = FormObject.Builder()
                .FormId("1")
                .CurrentRow(rowObject)
                .Build();

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
