using RarelySimple.AvatarScriptLink.Net.Decorators;
using RarelySimple.AvatarScriptLink.Net.Exceptions;
using RarelySimple.AvatarScriptLink.Objects;
using static RarelySimple.AvatarScriptLink.Objects.RowObject;

namespace RarelySimple.AvatarScriptLink.Net.Tests.Decorators;

[TestClass]
public class FormObjectDecoratorTests
{
    [TestMethod]
    public void TestFormObjectDecorator_ReturnsNoRows()
    {
        var fieldObject = new FieldObject()
        {
            Enabled = "1",
            FieldNumber = "123.45",
            FieldValue = "initial value",
            Lock = "0",
            Required = "0"
        };
        var rowObject = new RowObject()
        {
            Fields = [fieldObject],
            RowId = "456||1"
        };
        var formObject = new FormObject()
        {
            CurrentRow = rowObject,
            FormId = "456"
        };
        var decorator = new FormObjectDecorator(formObject);
        var actual = decorator.Return().AsFormObject();
        Assert.IsNull(actual.CurrentRow);
    }

    #region Builder

    [TestMethod]
    public void TestFormObjectDecorator_Builder_Expected()
    {
        var fieldNumber = "123.45";
        var expected = "initial value";
        var fieldObject = new FieldObject()
        {
            Enabled = "1",
            FieldNumber = fieldNumber,
            FieldValue = expected,
            Lock = "1",
            Required = "1"
        };
        var rowObject = new RowObject()
        {
            Fields = [fieldObject],
            RowId = "456||1"
        };
        var formObject = new FormObject()
        {
            CurrentRow = rowObject,
            FormId = "456"
        };
        var decorator = FormObjectDecorator.Builder(formObject).Build();
        Assert.AreEqual(expected, decorator.GetFieldValue(fieldNumber));
        Assert.IsTrue(decorator.IsFieldEnabled(fieldNumber));
        Assert.IsTrue(decorator.IsFieldLocked(fieldNumber));
        Assert.IsTrue(decorator.IsFieldRequired(fieldNumber));        
    }

    [TestMethod]
    public void TestFormObjectDecorator_Builder_CurrentRowExpected()
    {
        var expected = "456||1";
        var rowObject = new RowObject()
        {
            RowId = expected
        };
        var formObject = new FormObject()
        {
            FormId = "456"
        };
        var decorator = FormObjectDecorator.Builder(formObject).CurrentRow(rowObject).Build();
        Assert.IsTrue(decorator.IsRowPresent(expected));        
    }

    [TestMethod]
    public void TestFormObjectDecorator_Builder_OtherRowExpected()
    {
        var expected = "456||1";
        var rowObject = new RowObject()
        {
            RowId = expected
        };
        var formObject = new FormObject()
        {
            FormId = "456",
            MultipleIteration = true
        };
        var decorator = FormObjectDecorator.Builder(formObject).OtherRow(rowObject).Build();
        Assert.IsTrue(decorator.IsRowPresent(expected));        
    }

    [TestMethod]
    public void TestFormObjectDecorator_Builder_OtherRowsExpected()
    {
        var expected = "456||1";
        var rowObject = new RowObject()
        {
            RowId = expected
        };
        List<RowObject> rows = [rowObject];
        var formObject = new FormObject()
        {
            FormId = "456",
            MultipleIteration = true
        };
        var decorator = FormObjectDecorator.Builder(formObject).OtherRows(rows).Build();
        Assert.IsTrue(decorator.IsRowPresent(expected));        
    }

    #endregion

    #region GetCurrentRowId

    [TestMethod]
    public void TestFormObjectDecorator_GetCurrentRowId_Expected() {
        var expected = "456||1";
        RowObject rowObject = new() {
            RowId = expected
        };
        FormObjectDecorator decorator = FormObjectDecorator.Builder().FormId("456").CurrentRow(rowObject).Build();
        Assert.AreEqual(expected, decorator.GetCurrentRowId());
    }

    [TestMethod]
    public void TestFormObjectDecorator_GetCurrentRowId_Exception() {
        FormObjectDecorator decorator = FormObjectDecorator.Builder().FormId("456").Build();
        Assert.ThrowsException<ArgumentNullException>(() => decorator.GetCurrentRowId());
    }

    #endregion

    #region GetFieldValue

    [TestMethod]
    public void TestFormObjectDecorator_GetFieldValue_Succeeds()
    {
        var fieldNumber = "123.45";
        var expected = "initial value";
        var fieldObject = new FieldObject()
        {
            Enabled = "1",
            FieldNumber = fieldNumber,
            FieldValue = expected,
            Lock = "0",
            Required = "0"
        };
        var rowObject = new RowObject()
        {
            Fields = [fieldObject],
            RowId = "456||1"
        };
        var formObject = new FormObject()
        {
            CurrentRow = rowObject,
            FormId = "456"
        };
        var decorator = new FormObjectDecorator(formObject);
        Assert.AreEqual(expected, decorator.GetFieldValue(fieldNumber));
    }

    #endregion

    #region GetFieldValues

    [TestMethod]
    public void TestFormObjectDecorator_GetFieldValues_Succeeds()
    {
        var fieldNumber = "123.45";
        var expected = "initial value";
        var fieldObject = new FieldObject()
        {
            Enabled = "1",
            FieldNumber = fieldNumber,
            FieldValue = expected,
            Lock = "0",
            Required = "0"
        };
        var rowObject = new RowObject()
        {
            Fields = [fieldObject],
            RowId = "456||1",
            ParentRowId = "455||1"
        };
        var formObject = new FormObject()
        {
            CurrentRow = rowObject,
            FormId = "456"
        };
        var decorator = new FormObjectDecorator(formObject);
        Assert.AreEqual(1, decorator.GetFieldValues(fieldNumber).Count);
        Assert.AreEqual(expected, decorator.GetFieldValues(fieldNumber)[0]);
    }

    [TestMethod]
    public void TestFormObjectDecorator_GetFieldValues_MultipleRows_Succeeds()
    {
        var fieldNumber = "123.45";
        var expected = "initial value";
        var expected2 = "initial value 2";
        var fieldObject = new FieldObject()
        {
            Enabled = "1",
            FieldNumber = fieldNumber,
            FieldValue = expected,
            Lock = "0",
            Required = "0"
        };
        var rowObject = new RowObject()
        {
            Fields = [fieldObject],
            RowId = "456||1",
            ParentRowId = "455||1"
        };
        var fieldObject2 = new FieldObject()
        {
            Enabled = "1",
            FieldNumber = fieldNumber,
            FieldValue = expected2,
            Lock = "0",
            Required = "0"
        };
        var rowObject2 = new RowObject()
        {
            Fields = [fieldObject2],
            RowId = "456||2",
            ParentRowId = "455||1"
        };
        var formObject = new FormObject()
        {
            CurrentRow = rowObject,
            FormId = "456",
            MultipleIteration = true,
            OtherRows = [rowObject2],
        };
        var decorator = new FormObjectDecorator(formObject);
        Assert.AreEqual(2, decorator.GetFieldValues(fieldNumber).Count);
        Assert.AreEqual(expected, decorator.GetFieldValues(fieldNumber)[0]);
        Assert.AreEqual(expected2, decorator.GetFieldValues(fieldNumber)[1]);
    }

    [TestMethod]
    public void TestFormObjectDecorator_GetFieldValues_NotPresent()
    {
        var fieldNumber = "123.45";
        var expected = "initial value";
        var fieldObject = new FieldObject()
        {
            Enabled = "1",
            FieldNumber = fieldNumber,
            FieldValue = expected,
            Lock = "0",
            Required = "0"
        };
        var rowObject = new RowObject()
        {
            Fields = [fieldObject],
            RowId = "456||1",
            ParentRowId = "455||1"
        };
        var formObject = new FormObject()
        {
            CurrentRow = rowObject,
            FormId = "456"
        };
        var decorator = new FormObjectDecorator(formObject);
        Assert.AreEqual(0, decorator.GetFieldValues("457||1").Count);
    }

    [TestMethod]
    public void TestFormObjectDecorator_GetFieldValues_Empty()
    {
        var fieldNumber = "123.45";
        var expected = "initial value";
        var fieldObject = new FieldObject()
        {
            Enabled = "1",
            FieldNumber = fieldNumber,
            FieldValue = expected,
            Lock = "0",
            Required = "0"
        };
        var rowObject = new RowObject()
        {
            Fields = [fieldObject],
            RowId = "456||1",
            ParentRowId = "455||1"
        };
        var formObject = new FormObject()
        {
            CurrentRow = rowObject,
            FormId = "456"
        };
        var decorator = new FormObjectDecorator(formObject);
        Assert.ThrowsException<ArgumentNullException>(() => decorator.GetFieldValues(""));
    }

    [TestMethod]
    public void TestFormObjectDecorator_GetFieldValues_Null()
    {
        var fieldNumber = "123.45";
        var expected = "initial value";
        var fieldObject = new FieldObject()
        {
            Enabled = "1",
            FieldNumber = fieldNumber,
            FieldValue = expected,
            Lock = "0",
            Required = "0"
        };
        var rowObject = new RowObject()
        {
            Fields = [fieldObject],
            RowId = "456||1",
            ParentRowId = "455||1"
        };
        var formObject = new FormObject()
        {
            CurrentRow = rowObject,
            FormId = "456"
        };
        var decorator = new FormObjectDecorator(formObject);
        Assert.ThrowsException<ArgumentNullException>(() => decorator.GetFieldValues(null));
    }

    #endregion

    #region GetMultipleIterationStatus

    [TestMethod]
    public void TestFormObjectDecorator_GetMultipleIerationStatus_ReturnsBool()
    {
        var expected = false;
        var formObject = new FormObject()
        {
            FormId = "456"
        };
        var decorator = new FormObjectDecorator(formObject);
        Assert.AreEqual(expected.GetType(), decorator.GetMultipleIterationStatus().GetType());
    }

    [TestMethod]
    public void TestFormObjectDecorator_GetMultipleIerationStatus_ReturnsFalse()
    {
        var formObject = new FormObject()
        {
            FormId = "456"
        };
        var decorator = new FormObjectDecorator(formObject);
        Assert.IsFalse(decorator.GetMultipleIterationStatus());
    }

    [TestMethod]
    public void TestFormObjectDecorator_GetMultipleIerationStatus_ReturnsTrue()
    {
        var formObject = new FormObject()
        {
            FormId = "456",
            MultipleIteration = true
        };
        var decorator = new FormObjectDecorator(formObject);
        Assert.IsTrue(decorator.GetMultipleIterationStatus());
    }

    #endregion

    #region GetParentRowId

    [TestMethod]
    public void TestFormObjectDecorator_GetParentRowId_Expected() {
        var expected = "456||1";
        RowObject rowObject = new() {
            RowId = "456||3",
            ParentRowId = expected
        };
        FormObjectDecorator decorator = FormObjectDecorator.Builder().FormId("456").CurrentRow(rowObject).Build();
        Assert.AreEqual(expected, decorator.GetParentRowId());
    }

    [TestMethod]
    public void TestFormObjectDecorator_GetParentRowId_Exception() {
        FormObjectDecorator decorator = FormObjectDecorator.Builder().FormId("456").Build();
        Assert.ThrowsException<ArgumentNullException>(() => decorator.GetParentRowId());
    }

    [TestMethod]
    public void TestFormObjectDecorator_GetParentRowId_Null() {
        RowObject rowObject = new() {
            RowId = "456||3"
        };
        FormObjectDecorator decorator = FormObjectDecorator.Builder().FormId("456").CurrentRow(rowObject).Build();
        Assert.IsNull(decorator.GetParentRowId());
    }

    #endregion

    #region IsFieldEnabled

    [TestMethod]
    public void IsFieldEnabled_FormObject_IsEnabled()
    {
        var fieldObject = new FieldObject()
        {
            Enabled = "1",
            FieldNumber = "123.45",
            FieldValue = "initial value",
            Lock = "0",
            Required = "0"
        };
        var rowObject = new RowObject()
        {
            Fields = [fieldObject],
            RowId = "456||1"
        };
        var formObject = new FormObject()
        {
            CurrentRow = rowObject,
            FormId = "456"
        };
        var decorator = new FormObjectDecorator(formObject);
        Assert.IsTrue(decorator.IsFieldEnabled("123.45"));
    }

    [TestMethod]
    public void IsFieldEnabled_FormObject_IsNotEnabled()
    {
        var fieldObject = new FieldObject()
        {
            Enabled = "0",
            FieldNumber = "123.45",
            FieldValue = "initial value",
            Lock = "0",
            Required = "0"
        };
        var rowObject = new RowObject()
        {
            Fields = [fieldObject],
            RowId = "456||1"
        };
        var formObject = new FormObject()
        {
            CurrentRow = rowObject,
            FormId = "456"
        };
        var decorator = new FormObjectDecorator(formObject);
        Assert.IsFalse(decorator.IsFieldEnabled("123.45"));
    }

    [TestMethod]
    public void IsFieldEnabled_FormObject_IsNotPresent()
    {
        var fieldObject = new FieldObject()
        {
            Enabled = "1",
            FieldNumber = "123.45",
            FieldValue = "initial value",
            Lock = "0",
            Required = "0"
        };
        var rowObject = new RowObject()
        {
            Fields = [fieldObject],
            RowId = "456||1"
        };
        var formObject = new FormObject()
        {
            CurrentRow = rowObject,
            FormId = "456"
        };
        var decorator = new FormObjectDecorator(formObject);
        Assert.ThrowsException<FieldObjectNotFoundException>(() => decorator.IsFieldEnabled("678.90"));
    }

    #endregion

    #region IsFieldLocked

    [TestMethod]
    public void IsFieldLocked_FormObject_IsLocked()
    {
        var fieldObject = new FieldObject()
        {
            Enabled = "1",
            FieldNumber = "123.45",
            FieldValue = "initial value",
            Lock = "1",
            Required = "0"
        };
        var rowObject = new RowObject()
        {
            Fields = [fieldObject],
            RowId = "456||1"
        };
        var formObject = new FormObject()
        {
            CurrentRow = rowObject,
            FormId = "456"
        };
        var decorator = new FormObjectDecorator(formObject);
        Assert.IsTrue(decorator.IsFieldLocked("123.45"));
    }

    [TestMethod]
    public void IsFieldLocked_FormObject_IsNotLocked()
    {
        var fieldObject = new FieldObject()
        {
            Enabled = "0",
            FieldNumber = "123.45",
            FieldValue = "initial value",
            Lock = "0",
            Required = "0"
        };
        var rowObject = new RowObject()
        {
            Fields = [fieldObject],
            RowId = "456||1"
        };
        var formObject = new FormObject()
        {
            CurrentRow = rowObject,
            FormId = "456"
        };
        var decorator = new FormObjectDecorator(formObject);
        Assert.IsFalse(decorator.IsFieldLocked("123.45"));
    }

    [TestMethod]
    public void IsFieldLocked_FormObject_IsNotPresent()
    {
        var fieldObject = new FieldObject()
        {
            Enabled = "1",
            FieldNumber = "123.45",
            FieldValue = "initial value",
            Lock = "0",
            Required = "0"
        };
        var rowObject = new RowObject()
        {
            Fields = [fieldObject],
            RowId = "456||1"
        };
        var formObject = new FormObject()
        {
            CurrentRow = rowObject,
            FormId = "456"
        };
        var decorator = new FormObjectDecorator(formObject);
        Assert.ThrowsException<FieldObjectNotFoundException>(() => decorator.IsFieldLocked("678.90"));
    }

    #endregion

    #region IsFieldModified

    [TestMethod]
    public void IsFieldModified_FormObject_IsFalse()
    {
        FieldObject fieldObject01 = new()
        {
            FieldNumber = "123",
            FieldValue = ""
        };
        FieldObject fieldObject02 = new()
        {
            FieldNumber = "124",
            FieldValue = ""
        };
        FieldObject fieldObject03 = new()
        {
            FieldNumber = "125",
            FieldValue = ""
        };
        RowObject rowObject = new() {
            Fields = [fieldObject01, fieldObject02, fieldObject03]
        };
        FormObject formObject = new() {
            FormId = "1",
            CurrentRow = rowObject
        };
        FormObjectDecorator decorator = new(formObject);
        Assert.IsFalse(decorator.IsFieldModified("123"));
    }

    [TestMethod]
    public void IsFieldModified_FormObject_IsTrue()
    {
        FieldObject fieldObject01 = new()
        {
            FieldNumber = "123",
            FieldValue = ""
        };
        FieldObject fieldObject02 = new()
        {
            FieldNumber = "124",
            FieldValue = ""
        };
        FieldObject fieldObject03 = new()
        {
            FieldNumber = "125",
            FieldValue = ""
        };
        RowObject rowObject = new() {
            RowId = "1||1",
            Fields = [fieldObject01, fieldObject02, fieldObject03]
        };
        FormObject formObject = new() {
            FormId = "1",
            CurrentRow = rowObject
        };
        FormObjectDecorator decorator = new(formObject);
        decorator.SetFieldValue("123", "MODIFIED");
        Assert.IsTrue(decorator.IsFieldModified("123"));
    }

    [TestMethod]
    public void IsFieldModified_FormObject_IsTrue_NullFieldNumber()
    {
        FieldObject fieldObject01 = new()
        {
            FieldNumber = "123",
            FieldValue = ""
        };
        FieldObject fieldObject02 = new()
        {
            FieldNumber = "124",
            FieldValue = ""
        };
        FieldObject fieldObject03 = new()
        {
            FieldNumber = "125",
            FieldValue = ""
        };
        RowObject rowObject = new() {
            Fields = [fieldObject01, fieldObject02, fieldObject03]
        };
        FormObject formObject = new() {
            FormId = "1",
            CurrentRow = rowObject
        };
        FormObjectDecorator decorator = new(formObject);
        Assert.ThrowsException<ArgumentNullException>(() => decorator.IsFieldModified(null));
    }

    #endregion

    #region IsFieldPresent

    [TestMethod]
    public void TestFormObjectDecorator_FieldIsPresent()
    {
        var fieldObject = new FieldObject()
        {
            Enabled = "1",
            FieldNumber = "123.45",
            FieldValue = "initial value",
            Lock = "0",
            Required = "0"
        };
        var rowObject = new RowObject()
        {
            Fields = [fieldObject],
            RowId = "456||1"
        };
        var formObject = new FormObject()
        {
            CurrentRow = rowObject,
            FormId = "456"
        };
        var decorator = new FormObjectDecorator(formObject);
        Assert.IsTrue(decorator.IsFieldPresent("123.45"));
    }

    [TestMethod]
    public void TestFormObjectDecorator_FieldIsNotPresent()
    {
        var fieldObject = new FieldObject()
        {
            Enabled = "1",
            FieldNumber = "123.45",
            FieldValue = "initial value",
            Lock = "0",
            Required = "0"
        };
        var rowObject = new RowObject()
        {
            Fields = [fieldObject],
            RowId = "456||1"
        };
        var formObject = new FormObject()
        {
            CurrentRow = rowObject,
            FormId = "456"
        };
        var decorator = new FormObjectDecorator(formObject);
        Assert.IsFalse(decorator.IsFieldPresent("678.90"));
    }

    #endregion

    #region IsFieldRequired

    [TestMethod]
    public void IsFieldRequired_FormObject_IsRequired()
    {
        var fieldObject = new FieldObject()
        {
            Enabled = "1",
            FieldNumber = "123.45",
            FieldValue = "initial value",
            Lock = "0",
            Required = "1"
        };
        var rowObject = new RowObject()
        {
            Fields = [fieldObject],
            RowId = "456||1"
        };
        var formObject = new FormObject()
        {
            CurrentRow = rowObject,
            FormId = "456"
        };
        var decorator = new FormObjectDecorator(formObject);
        Assert.IsTrue(decorator.IsFieldRequired("123.45"));
    }

    [TestMethod]
    public void IsFieldRequired_FormObject_IsNotRequired()
    {
        var fieldObject = new FieldObject()
        {
            Enabled = "0",
            FieldNumber = "123.45",
            FieldValue = "initial value",
            Lock = "0",
            Required = "0"
        };
        var rowObject = new RowObject()
        {
            Fields = [fieldObject],
            RowId = "456||1"
        };
        var formObject = new FormObject()
        {
            CurrentRow = rowObject,
            FormId = "456"
        };
        var decorator = new FormObjectDecorator(formObject);
        Assert.IsFalse(decorator.IsFieldRequired("123.45"));
    }

    [TestMethod]
    public void IsFieldRequired_FormObject_IsNotPresent()
    {
        var fieldObject = new FieldObject()
        {
            Enabled = "1",
            FieldNumber = "123.45",
            FieldValue = "initial value",
            Lock = "0",
            Required = "0"
        };
        var rowObject = new RowObject()
        {
            Fields = [fieldObject],
            RowId = "456||1"
        };
        var formObject = new FormObject()
        {
            CurrentRow = rowObject,
            FormId = "456"
        };
        var decorator = new FormObjectDecorator(formObject);
        Assert.ThrowsException<FieldObjectNotFoundException>(() => decorator.IsFieldRequired("678.90"));
    }

    #endregion

    #region IsRowMarkedForDeletion

    [TestMethod]
    public void IsRowMarkedForDeletion_FormObject_Expected() {
        var rowObject1 = new RowObject()
        {
            RowId = "456||1"
        };
        var rowObject2 = new RowObject()
        {
            RowId = "456||2",
            RowAction = RowActions.Delete
        };
        var formObject = new FormObject()
        {
            CurrentRow = rowObject1,
            FormId = "456",
            MultipleIteration = true,
            OtherRows = [rowObject2]
        };
        var decorator = new FormObjectDecorator(formObject);
        Assert.IsFalse(decorator.IsRowMarkedForDeletion("456||1"));
        Assert.IsTrue(decorator.IsRowMarkedForDeletion("456||2"));
    }

    [TestMethod]
    public void IsRowMarkedForDeletion_FormObject_NoRowId() {
        var rowObject1 = new RowObject()
        {
            RowId = "456||1"
        };
        var rowObject2 = new RowObject()
        {
            RowId = "456||2",
            RowAction = RowActions.Delete
        };
        var formObject = new FormObject()
        {
            CurrentRow = rowObject1,
            FormId = "456",
            MultipleIteration = true,
            OtherRows = [rowObject2]
        };
        var decorator = new FormObjectDecorator(formObject);
        Assert.ThrowsException<ArgumentNullException>(() => decorator.IsRowMarkedForDeletion(null));
    }

    #endregion

    #region SetFieldValue

    [TestMethod]
    public void TestFormObjectDecorator_SetFieldValue_Succeeds()
    {
        var fieldNumber = "123.45";
        var expected = "modified value";
        var fieldObject = new FieldObject()
        {
            Enabled = "1",
            FieldNumber = fieldNumber,
            FieldValue = "initial value",
            Lock = "0",
            Required = "0"
        };
        var rowObject = new RowObject()
        {
            Fields = [fieldObject],
            RowId = "456||1"
        };
        var formObject = new FormObject()
        {
            CurrentRow = rowObject,
            FormId = "456"
        };
        var decorator = new FormObjectDecorator(formObject);
        decorator.SetFieldValue(fieldNumber, expected);
        Assert.AreEqual(expected, decorator.GetFieldValue(fieldNumber));
    }

    [TestMethod]
    public void TestFormObjectDecorator_SetFieldValue_ReturnsExpectedRows()
    {
        var fieldObject = new FieldObject()
        {
            Enabled = "1",
            FieldNumber = "123.45",
            FieldValue = "initial value",
            Lock = "0",
            Required = "0"
        };
        var rowObject = new RowObject()
        {
            Fields = [fieldObject],
            RowId = "456||1"
        };
        var formObject = new FormObject()
        {
            CurrentRow = rowObject,
            FormId = "456"
        };
        var decorator = new FormObjectDecorator(formObject);
        decorator.SetFieldValue("123.45", "modified value");
        var actual = decorator.Return().AsFormObject();
        Assert.IsNotNull(actual.CurrentRow);
        Assert.AreEqual(RowActions.Edit, actual.CurrentRow.RowAction);
        Assert.AreEqual(1, actual.CurrentRow.Fields.Count);
    }

    #endregion

    #region AddRowObject

    [TestMethod]
    public void TestFormObjectDecorator_AddRowObject_WithRowObject()
    {
        var formObject = new FormObject()
        {
            FormId = "1",
            MultipleIteration = true
        };
        var decorator = new FormObjectDecorator(formObject);
        var rowObject = new RowObject();
        decorator.AddRowObject(rowObject);
        Assert.IsNotNull(decorator.CurrentRow);
        Assert.AreEqual("1||1", decorator.CurrentRow.RowId);
    }

    [TestMethod]
    public void TestFormObjectDecorator_AddRowObject_WithRowIdAndParentRowId()
    {
        var formObject = new FormObject()
        {
            FormId = "1",
            MultipleIteration = true
        };
        var decorator = new FormObjectDecorator(formObject);
        decorator.AddRowObject("1||1", "1||1");
        Assert.IsNotNull(decorator.CurrentRow);
        Assert.AreEqual("1||1", decorator.CurrentRow.RowId);
        Assert.AreEqual("1||1", decorator.CurrentRow.ParentRowId);
    }

    [TestMethod]
    public void TestFormObjectDecorator_AddRowObject_WithRowIdParentRowIdAndAction()
    {
        var formObject = new FormObject()
        {
            FormId = "1",
            MultipleIteration = true
        };
        var decorator = new FormObjectDecorator(formObject);
        decorator.AddRowObject("1||1", "1||1", RowActions.Edit);
        Assert.IsNotNull(decorator.CurrentRow);
        Assert.AreEqual("1||1", decorator.CurrentRow.RowId);
        Assert.AreEqual("1||1", decorator.CurrentRow.ParentRowId);
        Assert.AreEqual(RowActions.Edit, decorator.CurrentRow.RowAction);
    }

    [TestMethod]
    public void TestFormObjectDecorator_AddRowObject_MultipleRows()
    {
        var formObject = new FormObject()
        {
            FormId = "1",
            MultipleIteration = true
        };
        var decorator = new FormObjectDecorator(formObject);
        var rowObject1 = new RowObject();
        decorator.AddRowObject(rowObject1);
        Assert.AreEqual("1||1", decorator.CurrentRow.RowId);
        
        var rowObject2 = new RowObject();
        decorator.AddRowObject(rowObject2);
        Assert.AreEqual(1, decorator.OtherRows.Count);
        Assert.AreEqual("1||2", decorator.OtherRows[0].RowId);
    }

    [TestMethod]
    public void TestFormObjectDecorator_AddRowObject_NullRowObject()
    {
        var formObject = new FormObject()
        {
            FormId = "1",
            MultipleIteration = true
        };
        var decorator = new FormObjectDecorator(formObject);
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
        Assert.ThrowsException<ArgumentNullException>(() => decorator.AddRowObject((RowObject)null));
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
    }

    [TestMethod]
    public void TestFormObjectDecorator_AddRowObject_NonMultipleIterationWithExistingRow()
    {
        var formObject = new FormObject()
        {
            FormId = "1",
            MultipleIteration = false,
            CurrentRow = new RowObject() { RowId = "1||1" }
        };
        var decorator = new FormObjectDecorator(formObject);
        var rowObject = new RowObject();
        Assert.ThrowsException<ArgumentException>(() => decorator.AddRowObject(rowObject));
    }

    [TestMethod]
    public void TestFormObjectDecorator_AddRowObject_DuplicateRowId()
    {
        var formObject = new FormObject()
        {
            FormId = "1",
            MultipleIteration = true,
            CurrentRow = new RowObject() { RowId = "1||1" }
        };
        var decorator = new FormObjectDecorator(formObject);
        var rowObject = new RowObject() { RowId = "1||1" };
        Assert.ThrowsException<ArgumentException>(() => decorator.AddRowObject(rowObject));
    }

    [TestMethod]
    public void TestFormObjectDecorator_GetNextAvailableRowId()
    {
        var formObject = new FormObject()
        {
            FormId = "1",
            MultipleIteration = true
        };
        var decorator = new FormObjectDecorator(formObject);
        string rowId = decorator.GetNextAvailableRowId();
        Assert.AreEqual("1||1", rowId);
    }

    [TestMethod]
    public void TestFormObjectDecorator_GetNextAvailableRowId_WithExistingRows()
    {
        var formObject = new FormObject()
        {
            FormId = "1",
            MultipleIteration = true,
            CurrentRow = new RowObject() { RowId = "1||1" }
        };
        formObject.OtherRows.Add(new RowObject() { RowId = "1||2" });
        var decorator = new FormObjectDecorator(formObject);
        string rowId = decorator.GetNextAvailableRowId();
        Assert.AreEqual("1||3", rowId);
    }

    #endregion

    #region Edge Case Tests - Regression & Coverage

    [TestMethod]
    public void TestFormObjectDecorator_Constructor_WithNullOtherRowsCollection()
    {
        var formObject = new FormObject()
        {
            FormId = "1",
            MultipleIteration = true,
            CurrentRow = new RowObject() { RowId = "1||1" },
            OtherRows = null
        };
        var decorator = new FormObjectDecorator(formObject);
        Assert.IsNotNull(decorator.OtherRows);
        Assert.AreEqual(0, decorator.OtherRows.Count);
    }

    [TestMethod]
    public void TestFormObjectDecorator_GetNextAvailableRowId_WithNullCurrentRowButExistingOtherRows()
    {
        var formObject = new FormObject()
        {
            FormId = "1",
            MultipleIteration = true
        };
        formObject.OtherRows.Add(new RowObject() { RowId = "1||1" });
        formObject.OtherRows.Add(new RowObject() { RowId = "1||2" });
        var decorator = new FormObjectDecorator(formObject);
        string rowId = decorator.GetNextAvailableRowId();
        Assert.AreEqual("1||3", rowId);
    }

    [TestMethod]
    public void TestFormObjectDecorator_GetNextAvailableRowId_WithGapInSequence()
    {
        var formObject = new FormObject()
        {
            FormId = "1",
            MultipleIteration = true,
            CurrentRow = new RowObject() { RowId = "1||1" }
        };
        formObject.OtherRows.Add(new RowObject() { RowId = "1||3" });
        formObject.OtherRows.Add(new RowObject() { RowId = "1||4" });
        var decorator = new FormObjectDecorator(formObject);
        string rowId = decorator.GetNextAvailableRowId();
        Assert.AreEqual("1||2", rowId);
    }

    [TestMethod]
    public void TestFormObjectDecorator_AddRowObject_WithEmptyRowId_IsAutoGenerated()
    {
        var formObject = new FormObject()
        {
            FormId = "1",
            MultipleIteration = true
        };
        var decorator = new FormObjectDecorator(formObject);
        var rowObject = new RowObject() { RowId = "" };
        decorator.AddRowObject(rowObject);
        Assert.IsNotNull(decorator.CurrentRow);
        // Empty row IDs are auto-generated
        Assert.AreEqual("1||1", decorator.CurrentRow.RowId);
    }

    [TestMethod]
    public void TestFormObjectDecorator_AddRowObject_WithNullOtherRows_BecomesCurrentRow()
    {
        var formObject = new FormObject()
        {
            FormId = "1",
            MultipleIteration = true,
            OtherRows = null
        };
        var decorator = new FormObjectDecorator(formObject);
        var rowObject = new RowObject();
        decorator.AddRowObject(rowObject);
        Assert.IsNotNull(decorator.OtherRows);
        // When adding first row to form with null OtherRows, it becomes CurrentRow
        Assert.AreEqual(0, decorator.OtherRows.Count);
        Assert.AreEqual("1||1", decorator.CurrentRow.RowId);
    }

    #endregion
}