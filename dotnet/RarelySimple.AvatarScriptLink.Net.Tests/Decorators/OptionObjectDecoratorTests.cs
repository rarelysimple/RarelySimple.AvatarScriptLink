using RarelySimple.AvatarScriptLink.Net.Decorators;
using RarelySimple.AvatarScriptLink.Net.Exceptions;
using RarelySimple.AvatarScriptLink.Objects;
using static RarelySimple.AvatarScriptLink.Objects.RowObject;

namespace RarelySimple.AvatarScriptLink.Net.Tests.Decorators;

[TestClass]
public class OptionObjectDecoratorTests
{
    [TestMethod]
    public void TestOptionObjectDecorator_ReturnsNoForms()
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
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObjectDecorator(optionObject);
        var actual = decorator.Return().AsOptionObject();
        Assert.AreEqual(0, actual.Forms.Count);
    }

    #region AddFormObject

    [TestMethod]
    public void AddFormObject_Expected() {
        var expected = new FormObject() {
            FormId = "1"
        };
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123"
        };
        var decorator = new OptionObjectDecorator(optionObject);
        decorator.AddFormObject(expected);
        Assert.IsTrue(decorator.IsFormPresent("1"));
    }

    [TestMethod]
    public void AddFormObjectDecorator_Expected() {
        var expected = FormObjectDecorator.Builder().FormId("1").Build();
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123"
        };
        var decorator = new OptionObjectDecorator(optionObject);
        decorator.AddFormObject(expected);
        Assert.IsTrue(decorator.IsFormPresent("1"));
    }

    [TestMethod]
    public void AddFormObjectById_Expected() {
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123"
        };
        var decorator = new OptionObjectDecorator(optionObject);
        decorator.AddFormObject("1");
        Assert.IsTrue(decorator.IsFormPresent("1"));
    }

    [TestMethod]
    public void AddFormObjectByIdAndMI_Expected() {
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123"
        };
        var decorator = new OptionObjectDecorator(optionObject);
        decorator.AddFormObject("1", false);
        Assert.IsTrue(decorator.IsFormPresent("1"));
    }

    [TestMethod]
    public void AddFormObjectByIdAndMI_ArgumentNullException() {
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123"
        };
        var decorator = new OptionObjectDecorator(optionObject);
        Assert.ThrowsException<ArgumentNullException>(() => decorator.AddFormObject(null, false));
    }

    [TestMethod]
    public void AddFormObject_MICannotBeFirst() {
        var expected = new FormObject() {
            FormId = "1",
            MultipleIteration = true
        };
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123"
        };
        var decorator = new OptionObjectDecorator(optionObject);
        Assert.ThrowsException<ArgumentException>(() => decorator.AddFormObject(expected));
    }

    [TestMethod]
    public void AddFormObjectDecorator_MICannotBeFirst() {
        var expected = FormObjectDecorator.Builder().FormId("1").MultipleIteration().Build();
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123"
        };
        var decorator = new OptionObjectDecorator(optionObject);
        Assert.ThrowsException<ArgumentException>(() => decorator.AddFormObject(expected));
    }

    [TestMethod]
    public void AddFormObjectByIdAndMI_MICannotBeFirst() {
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123"
        };
        var decorator = new OptionObjectDecorator(optionObject);
        Assert.ThrowsException<ArgumentException>(() => decorator.AddFormObject("1", true));
    }

    [TestMethod]
    public void AddFormObject_DuplicateForms() {
        var expected = new FormObject() {
            FormId = "1"
        };
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123"
        };
        var decorator = new OptionObjectDecorator(optionObject);
        decorator.AddFormObject(expected);
        Assert.ThrowsException<ArgumentException>(() => decorator.AddFormObject(expected));
    }

    [TestMethod]
    public void AddFormObjectDecorator_DuplicateForms() {
        var expected = FormObjectDecorator.Builder().FormId("1").Build();
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123"
        };
        var decorator = new OptionObjectDecorator(optionObject);
        decorator.AddFormObject(expected);
        Assert.ThrowsException<ArgumentException>(() => decorator.AddFormObject(expected));
    }

    [TestMethod]
    public void AddFormObjectById_DuplicateForms() {
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123"
        };
        var decorator = new OptionObjectDecorator(optionObject);
        decorator.AddFormObject("1");
        Assert.ThrowsException<ArgumentException>(() => decorator.AddFormObject("1"));
    }

    [TestMethod]
    public void AddFormObjectByIdAndMI_DuplicateForms() {
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123"
        };
        var decorator = new OptionObjectDecorator(optionObject);
        decorator.AddFormObject("1", false);
        Assert.ThrowsException<ArgumentException>(() => decorator.AddFormObject("1", false));
    }

    #endregion

    #region GetCurrentRowId

    [TestMethod]
    public void TestOptionObjectDecorator_GetCurrentRowId_Expected() {
        var expected = "456||1";
        RowObject rowObject = new() {
            RowId = expected
        };
        FormObject formObject = new() {
            FormId = "456",
            CurrentRow = rowObject
        };
        OptionObject optionObject = new() {
            OptionId = "USER123",
            Forms = [formObject]
        };
        OptionObjectDecorator decorator = new(optionObject);
        Assert.AreEqual(expected, decorator.GetCurrentRowId("456"));
    }

    [TestMethod]
    public void TestOptionObjectDecorator_GetCurrentRowId_Exception() {
        FormObject formObject = new() {
            FormId = "456"
        };
        OptionObject optionObject = new() {
            OptionId = "USER123",
            Forms = [formObject]
        };
        OptionObjectDecorator decorator = new(optionObject);
        Assert.ThrowsException<ArgumentNullException>(() => decorator.GetCurrentRowId("456"));
    }

    #endregion

    #region GetFieldValue


    [TestMethod]
    public void TestOptionObjectDecorator_GetFieldValue_Succeeds()
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
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObjectDecorator(optionObject);
        Assert.AreEqual(expected, decorator.GetFieldValue(fieldNumber));
    }

    [TestMethod]
    public void TestOptionObjectDecorator_GetFieldValue_NotPresent()
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
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObjectDecorator(optionObject);
        Assert.ThrowsException<FieldObjectNotFoundException>(() => decorator.GetFieldValue("678.90"));
    }

    #endregion

    #region GetFieldValues

    [TestMethod]
    public void TestOptionObjectDecorator_GetFieldValues_Succeeds()
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
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObjectDecorator(optionObject);
        Assert.AreEqual(1, decorator.GetFieldValues(fieldNumber).Count);
        Assert.AreEqual(expected, decorator.GetFieldValues(fieldNumber)[0]);
    }

    [TestMethod]
    public void TestOptionObjectDecorator_GetFieldValues_MultipleRows_Succeeds()
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
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObjectDecorator(optionObject);
        Assert.AreEqual(2, decorator.GetFieldValues(fieldNumber).Count);
        Assert.AreEqual(expected, decorator.GetFieldValues(fieldNumber)[0]);
        Assert.AreEqual(expected2, decorator.GetFieldValues(fieldNumber)[1]);
    }

    [TestMethod]
    public void TestOptionObjectDecorator_GetFieldValues_NotPresent()
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
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObjectDecorator(optionObject);
        Assert.AreEqual(0, decorator.GetFieldValues("457||1").Count);
    }

    [TestMethod]
    public void TestOptionObjectDecorator_GetFieldValues_Empty()
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
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObjectDecorator(optionObject);
        Assert.ThrowsException<ArgumentNullException>(() => decorator.GetFieldValues(""));
    }

    [TestMethod]
    public void TestOptionObjectDecorator_GetFieldValues_Null()
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
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObjectDecorator(optionObject);
        Assert.ThrowsException<ArgumentNullException>(() => decorator.GetFieldValues(null));
    }

    #endregion

    #region GetMultipleIterationStatus

    [TestMethod]
    public void TestOptionObjectDecorator_GetMultipleIterationStatus_ReturnsBool()
    {
        var formId = "456";
        var expected = false;
        var formObject = new FormObject()
        {
            FormId = formId
        };
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObjectDecorator(optionObject);
        Assert.AreEqual(expected.GetType(), decorator.GetMultipleIterationStatus(formId).GetType());
    }

    [TestMethod]
    public void TestOptionObjectDecorator_GetMultipleIterationStatus_ReturnsFalse()
    {
        var formId = "456";
        var formObject = new FormObject()
        {
            FormId = formId
        };
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObjectDecorator(optionObject);
        Assert.IsFalse(decorator.GetMultipleIterationStatus(formId));
    }

    [TestMethod]
    public void TestOptionObjectDecorator_GetMultipleIterationStatus_ReturnsTrue()
    {
        var formId = "456";
        var formObject = new FormObject()
        {
            FormId = formId,
            MultipleIteration = true
        };
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObjectDecorator(optionObject);
        Assert.IsTrue(decorator.GetMultipleIterationStatus(formId));
    }

    [TestMethod]
    public void TestOptionObjectDecorator_GetMultipleIterationStatus_ReturnsFormObjectNotFoundException()
    {
        var formId = "456";
        var formObject = new FormObject()
        {
            FormId = "123",
            MultipleIteration = true
        };
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObjectDecorator(optionObject);
        Assert.ThrowsException<FormObjectNotFoundException>(() => decorator.GetMultipleIterationStatus(formId));
    }

    [TestMethod]
    public void TestOptionObjectDecorator_GetMultipleIterationStatus_NoForms_ReturnsFormObjectNotFoundException()
    {
        var formId = "456";
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123"
        };
        var decorator = new OptionObjectDecorator(optionObject);
        Assert.ThrowsException<FormObjectNotFoundException>(() => decorator.GetMultipleIterationStatus(formId));
    }

    #endregion

    #region GetParentRowId

    [TestMethod]
    public void TestOptionObjectDecorator_GetParentRowId_Expected() {
        var expected = "456||1";
        RowObject rowObject = new() {
            RowId = "456||3",
            ParentRowId = expected
        };
        FormObject formObject = new() {
            FormId = "456",
            CurrentRow = rowObject
        };
        OptionObject optionObject = new() {
            OptionId = "USER123",
            Forms = [formObject]
        };
        OptionObjectDecorator decorator = new(optionObject);
        Assert.AreEqual(expected, decorator.GetParentRowId("456"));
    }

    [TestMethod]
    public void TestOptionObjectDecorator_GetParentRowId_Exception() {
        FormObject formObject = new() {
            FormId = "456"
        };
        OptionObject optionObject = new() {
            OptionId = "USER123",
            Forms = [formObject]
        };
        OptionObjectDecorator decorator = new(optionObject);
        Assert.ThrowsException<ArgumentNullException>(() => decorator.GetParentRowId("456"));
    }

    [TestMethod]
    public void TestOptionObjectDecorator_GetParentRowId_Null() {
        RowObject rowObject = new() {
            RowId = "456||3",
        };
        FormObject formObject = new() {
            FormId = "456",
            CurrentRow = rowObject
        };
        OptionObject optionObject = new() {
            OptionId = "USER123",
            Forms = [formObject]
        };
        OptionObjectDecorator decorator = new(optionObject);
        Assert.IsNull(decorator.GetParentRowId("456"));
    }

    #endregion

    #region IsFieldEnabled

    [TestMethod]
    public void IsFieldEnabled_OptionObject_FirstForm_IsEnabled()
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
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObjectDecorator(optionObject);
        Assert.IsTrue(decorator.IsFieldEnabled("123.45"));
    }

    [TestMethod]
    public void IsFieldEnabled_OptionObject_SecondForm_IsEnabled()
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
            FormId = "123"
        };
        var formObject2 = new FormObject()
        {
            CurrentRow = rowObject,
            FormId = "456"
        };
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123",
            Forms = [formObject,formObject2]
        };
        var decorator = new OptionObjectDecorator(optionObject);
        Assert.IsTrue(decorator.IsFieldEnabled("123.45"));
    }

    [TestMethod]
    public void IsFieldEnabled_OptionObject_FirstForm_IsNotEnabled()
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
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObjectDecorator(optionObject);
        Assert.IsFalse(decorator.IsFieldEnabled("123.45"));
    }

    [TestMethod]
    public void IsFieldEnabled_OptionObject_SecondForm_IsNotEnabled()
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
            FormId = "123"
        };
        var formObject2 = new FormObject()
        {
            CurrentRow = rowObject,
            FormId = "456"
        };
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123",
            Forms = [formObject,formObject2]
        };
        var decorator = new OptionObjectDecorator(optionObject);
        Assert.IsFalse(decorator.IsFieldEnabled("123.45"));
    }

    [TestMethod]
    public void IsFieldEnabled_OptionObject_IsNotPresent()
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
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObjectDecorator(optionObject);
        Assert.ThrowsException<FieldObjectNotFoundException>(() => decorator.IsFieldEnabled("678.90"));
    }

    #endregion

    #region IsFieldLocked

    [TestMethod]
    public void IsFieldLocked_OptionObject_FirstForm_IsLocked()
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
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObjectDecorator(optionObject);
        Assert.IsTrue(decorator.IsFieldLocked("123.45"));
    }

    [TestMethod]
    public void IsFieldLocked_OptionObject_SecondForm_IsLocked()
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
            FormId = "123"
        };
        var formObject2 = new FormObject()
        {
            CurrentRow = rowObject,
            FormId = "456"
        };
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123",
            Forms = [formObject,formObject2]
        };
        var decorator = new OptionObjectDecorator(optionObject);
        Assert.IsTrue(decorator.IsFieldLocked("123.45"));
    }

    [TestMethod]
    public void IsFieldLocked_OptionObject_FirstForm_IsNotLocked()
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
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObjectDecorator(optionObject);
        Assert.IsFalse(decorator.IsFieldLocked("123.45"));
    }

    [TestMethod]
    public void IsFieldLocked_OptionObject_SecondForm_IsNotLocked()
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
            FormId = "123"
        };
        var formObject2 = new FormObject()
        {
            CurrentRow = rowObject,
            FormId = "456"
        };
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123",
            Forms = [formObject,formObject2]
        };
        var decorator = new OptionObjectDecorator(optionObject);
        Assert.IsFalse(decorator.IsFieldLocked("123.45"));
    }

    [TestMethod]
    public void IsFieldLocked_OptionObject_IsNotPresent()
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
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObjectDecorator(optionObject);
        Assert.ThrowsException<FieldObjectNotFoundException>(() => decorator.IsFieldLocked("678.90"));
    }

    #endregion

    #region IsFieldModified

    [TestMethod]
    public void IsFieldModified_OptionObject_IsFalse()
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
        OptionObject optionObject = new() {
            Forms = [formObject]
        };
        OptionObjectDecorator decorator = new(optionObject);
        Assert.IsFalse(decorator.IsFieldModified("123"));
    }

    [TestMethod]
    public void IsFieldModified_OptionObject_IsTrue()
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
        OptionObject optionObject = new() {
            Forms = [formObject]
        };
        OptionObjectDecorator decorator = new(optionObject);
        decorator.SetFieldValue("123", "MODIFIED");
        Assert.IsTrue(decorator.IsFieldModified("123"));
    }

    [TestMethod]
    public void IsFieldModified_OptionObject_IsFalse_NullFieldNumber()
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
        OptionObject optionObject = new() {
            Forms = [formObject]
        };
        OptionObjectDecorator decorator = new(optionObject);
        Assert.ThrowsException<ArgumentNullException>(() => decorator.IsFieldModified(null));
    }

    #endregion

    #region IsFieldPresent

    [TestMethod]
    public void TestOptionObjectDecorator_FieldIsPresent()
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
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObjectDecorator(optionObject);
        Assert.IsTrue(decorator.IsFieldPresent("123.45"));
    }

    [TestMethod]
    public void TestOptionObjectDecorator_FieldIsNotPresent()
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
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObjectDecorator(optionObject);
        Assert.IsFalse(decorator.IsFieldPresent("678.90"));
    }

    #endregion

    #region IsFieldRequired

    [TestMethod]
    public void IsFieldRequired_OptionObject_FirstForm_IsRequired()
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
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObjectDecorator(optionObject);
        Assert.IsTrue(decorator.IsFieldRequired("123.45"));
    }

    [TestMethod]
    public void IsFieldRequired_OptionObject_SecondForm_IsRequired()
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
            FormId = "123"
        };
        var formObject2 = new FormObject()
        {
            CurrentRow = rowObject,
            FormId = "456"
        };
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123",
            Forms = [formObject,formObject2]
        };
        var decorator = new OptionObjectDecorator(optionObject);
        Assert.IsTrue(decorator.IsFieldRequired("123.45"));
    }

    [TestMethod]
    public void IsFieldRequired_OptionObject_FirstForm_IsNotRequired()
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
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObjectDecorator(optionObject);
        Assert.IsFalse(decorator.IsFieldRequired("123.45"));
    }

    [TestMethod]
    public void IsFieldRequired_OptionObject_SecondForm_IsNotRequired()
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
            FormId = "123"
        };
        var formObject2 = new FormObject()
        {
            CurrentRow = rowObject,
            FormId = "456"
        };
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123",
            Forms = [formObject,formObject2]
        };
        var decorator = new OptionObjectDecorator(optionObject);
        Assert.IsFalse(decorator.IsFieldRequired("123.45"));
    }

    [TestMethod]
    public void IsFieldRequired_OptionObject_IsNotPresent()
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
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObjectDecorator(optionObject);
        Assert.ThrowsException<FieldObjectNotFoundException>(() => decorator.IsFieldRequired("678.90"));
    }

    #endregion

    #region IsFormPresent

    [TestMethod]
    public void IsFormPresent_Expected()
    {
        var formObject = new FormObject()
        {
            FormId = "123"
        };
        var formObject2 = new FormObject()
        {
            FormId = "456"
        };
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123",
            Forms = [formObject,formObject2]
        };
        var decorator = new OptionObjectDecorator(optionObject);
        Assert.IsTrue(decorator.IsFormPresent("123"));
        Assert.IsTrue(decorator.IsFormPresent("456"));
        Assert.IsFalse(decorator.IsFormPresent("789"));
    }

    [TestMethod]
    public void IsFormPresent_NoForms_Expected()
    {
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123"
        };
        var decorator = new OptionObjectDecorator(optionObject);
        Assert.IsFalse(decorator.IsFormPresent("123"));
    }

    [TestMethod]
    public void IsFormPresent_Null()
    {
        var formObject = new FormObject()
        {
            FormId = "123"
        };
        var formObject2 = new FormObject()
        {
            FormId = "456"
        };
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123",
            Forms = [formObject,formObject2]
        };
        var decorator = new OptionObjectDecorator(optionObject);
        Assert.ThrowsException<ArgumentNullException>(() => decorator.IsFormPresent(null));
    }

    #endregion

    #region IsRowMarkedForDeletion

    [TestMethod]
    public void IsRowMarkedForDeletion_Expected()
    {
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
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObjectDecorator(optionObject);
        Assert.IsFalse(decorator.IsRowMarkedForDeletion("456||1"));
        Assert.IsTrue(decorator.IsRowMarkedForDeletion("456||2"));
    }

    [TestMethod]
    public void IsRowMarkedForDeletion_NullRowId()
    {
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
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObjectDecorator(optionObject);
        Assert.ThrowsException<ArgumentNullException>(() => decorator.IsRowMarkedForDeletion(null));
    }

    #endregion

    #region IsRowPresent

    [TestMethod]
    public void IsRowPresent_Expected()
    {
        var rowObject = new RowObject()
        {
            RowId = "456||1"
        };
        var formObject = new FormObject()
        {
            FormId = "456",
            CurrentRow = rowObject
        };
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObjectDecorator(optionObject);
        Assert.IsTrue(decorator.IsRowPresent("456||1"));
    }

    [TestMethod]
    public void IsRowPresent_NoForms_Expected()
    {
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123"
        };
        var decorator = new OptionObjectDecorator(optionObject);
        Assert.IsFalse(decorator.IsRowPresent("123||1"));
    }

    [TestMethod]
    public void IsRowPresent_Null()
    {
        var rowObject = new RowObject()
        {
            RowId = "456||1"
        };
        var formObject = new FormObject()
        {
            FormId = "456",
            CurrentRow = rowObject
        };
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObjectDecorator(optionObject);
        Assert.ThrowsException<ArgumentNullException>(() => decorator.IsRowPresent(null));
    }

    #endregion

    #region SetFieldValue

    [TestMethod]
    public void TestOptionObjectDecorator_SetFieldValue_Succeeds()
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
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObjectDecorator(optionObject);
        decorator.SetFieldValue(fieldNumber, expected);
        Assert.AreEqual(expected, decorator.GetFieldValue(fieldNumber));
    }

    [TestMethod]
    public void TestOptionObjectDecorator_SetFieldValue_ReturnsExpectedForms()
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
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObjectDecorator(optionObject);
        decorator.SetFieldValue("123.45", "modified value");
        var actual = decorator.Return().AsOptionObject();
        Assert.AreEqual(1, actual.Forms.Count);
    }

    [TestMethod]
    public void TestOptionObjectDecorator_SetFieldValue_WithFormAndRowIds_ReturnsExpectedForms()
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
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObjectDecorator(optionObject);
        decorator.SetFieldValue("456", "456||1", "123.45", "modified value");
        var actual = decorator.Return().AsOptionObject();
        Assert.AreEqual(1, actual.Forms.Count);
    }

    #endregion

    #region AddRowObject

    [TestMethod]
    public void TestOptionObjectDecorator_AddRowObject_Success()
    {
        var formObject = new FormObject()
        {
            FormId = "1",
            MultipleIteration = true
        };
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObjectDecorator(optionObject);
        var rowObject = new RowObject();
        decorator.AddRowObject("1", rowObject);
        Assert.IsNotNull(decorator.Forms[0].CurrentRow);
        Assert.AreEqual("1||1", decorator.Forms[0].CurrentRow.RowId);
    }

    [TestMethod]
    public void TestOptionObjectDecorator_AddRowObject_FormNotFound()
    {
        var formObject = new FormObject()
        {
            FormId = "1",
            MultipleIteration = true
        };
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObjectDecorator(optionObject);
        var rowObject = new RowObject();
        Assert.ThrowsException<ArgumentException>(() => decorator.AddRowObject("99", rowObject));
    }

    [TestMethod]
    public void TestOptionObjectDecorator_AddRowObject_NullRowObject()
    {
        var formObject = new FormObject()
        {
            FormId = "1",
            MultipleIteration = true
        };
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObjectDecorator(optionObject);
        Assert.ThrowsException<ArgumentNullException>(() => decorator.AddRowObject("1", null));
    }

    [TestMethod]
    public void TestOptionObjectDecorator_AddRowObject_NullFormId()
    {
        var formObject = new FormObject()
        {
            FormId = "1",
            MultipleIteration = true
        };
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObjectDecorator(optionObject);
        var rowObject = new RowObject();
        Assert.ThrowsException<ArgumentNullException>(() => decorator.AddRowObject(null, rowObject));
    }

    [TestMethod]
    public void TestOptionObjectDecorator_AddRowObject_WithMultipleRows()
    {
        var formObject = new FormObject()
        {
            FormId = "1",
            MultipleIteration = true
        };
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObjectDecorator(optionObject);
        decorator.AddRowObject("1", new RowObject());
        decorator.AddRowObject("1", new RowObject());
        Assert.AreEqual(1, decorator.Forms[0].OtherRows.Count);
        Assert.AreEqual("1||2", decorator.Forms[0].OtherRows[0].RowId);
    }

    #endregion

    #region Edge Case Tests - Regression & Coverage

    [TestMethod]
    public void TestOptionObjectDecorator_Constructor_WithEmptyFormsCollection()
    {
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123",
            Forms = new List<FormObject>()
        };
        var decorator = new OptionObjectDecorator(optionObject);
        Assert.IsNotNull(decorator.Forms);
        Assert.AreEqual(0, decorator.Forms.Count);
    }

    [TestMethod]
    public void TestOptionObjectDecorator_AddRowObject_RegressionNullFormIdHandling()
    {
        var formObject = new FormObject() { FormId = "1", MultipleIteration = true };
        var optionObject = new OptionObject() { OptionId = "TEST123", Forms = [formObject] };
        var decorator = new OptionObjectDecorator(optionObject);
        var rowObject = new RowObject();
        Assert.ThrowsException<ArgumentNullException>(() => decorator.AddRowObject(null, rowObject));
    }

    #endregion
}
