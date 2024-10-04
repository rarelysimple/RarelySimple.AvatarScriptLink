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
    [ExpectedException(typeof(ArgumentNullException))]
    public void TestFormObjectDecorator_GetCurrentRowId_Exception() {
        var expected = "456||1";
        FormObjectDecorator decorator = FormObjectDecorator.Builder().FormId("456").Build();
        Assert.AreEqual(expected, decorator.GetCurrentRowId());
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
    [ExpectedException(typeof(ArgumentNullException))]
    public void TestFormObjectDecorator_GetParentRowId_Exception() {
        var expected = "456||1";
        FormObjectDecorator decorator = FormObjectDecorator.Builder().FormId("456").Build();
        Assert.AreEqual(expected, decorator.GetParentRowId());
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
    [ExpectedException(typeof(FieldObjectNotFoundException))]
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
        Assert.IsFalse(decorator.IsFieldEnabled("678.90"));
    }

    [TestMethod]
    [ExpectedException(typeof(NullReferenceException))]
    public void IsFieldEnabled_FormObject_Null()
    {
        var decorator = new FormObjectDecorator(null);
        Assert.IsFalse(decorator.IsFieldEnabled("123.45"));
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
    [ExpectedException(typeof(FieldObjectNotFoundException))]
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
        Assert.IsFalse(decorator.IsFieldLocked("678.90"));
    }

    [TestMethod]
    [ExpectedException(typeof(NullReferenceException))]
    public void IsFieldLocked_FormObject_Null()
    {
        var decorator = new FormObjectDecorator(null);
        Assert.IsFalse(decorator.IsFieldLocked("123.45"));
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
    [ExpectedException(typeof(ArgumentNullException))]
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
        Assert.IsTrue(decorator.IsFieldModified(null));
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

    [TestMethod]
    [ExpectedException(typeof(NullReferenceException))]
    public void IsFieldPresent_FormObject_Null()
    {
        var decorator = new FormObjectDecorator(null);
        Assert.IsFalse(decorator.IsFieldPresent("123.45"));
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
    [ExpectedException(typeof(FieldObjectNotFoundException))]
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
        Assert.IsFalse(decorator.IsFieldRequired("678.90"));
    }

    [TestMethod]
    [ExpectedException(typeof(NullReferenceException))]
    public void IsFieldRequired_FormObject_Null()
    {
        var decorator = new FormObjectDecorator(null);
        Assert.IsFalse(decorator.IsFieldRequired("123.45"));
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
    [ExpectedException(typeof(ArgumentNullException))]
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
        Assert.IsTrue(decorator.IsRowMarkedForDeletion(null));
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
}
