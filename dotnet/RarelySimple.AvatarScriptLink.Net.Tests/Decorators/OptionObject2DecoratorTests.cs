using RarelySimple.AvatarScriptLink.Net.Decorators;
using RarelySimple.AvatarScriptLink.Net.Exceptions;
using RarelySimple.AvatarScriptLink.Objects;
using static RarelySimple.AvatarScriptLink.Objects.RowObject;

namespace RarelySimple.AvatarScriptLink.Net.Tests.Decorators;

[TestClass]
public class OptionObject2DecoratorTests
{
    #region Constructor

    [TestMethod]
    public void TestOptionObject2Decorator_Constructor_NullOptionObject()
    {
        Assert.ThrowsException<ArgumentNullException>(() => new OptionObject2Decorator(null));
    }

    #endregion

    [TestMethod]
    public void TestOptionObject2Decorator_ReturnsNoForms()
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
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObject2Decorator(optionObject);
        var actual = decorator.Return().AsOptionObject2();
        Assert.AreEqual(0, actual.Forms.Count);
    }

    #region AddFormObject

    [TestMethod]
    public void AddFormObject_Expected() {
        var expected = new FormObject() {
            FormId = "1"
        };
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123"
        };
        var decorator = new OptionObject2Decorator(optionObject);
        decorator.AddFormObject(expected);
        Assert.IsTrue(decorator.IsFormPresent("1"));
    }

    [TestMethod]
    public void AddFormObjectDecorator_Expected() {
        var expected = FormObjectDecorator.Builder().FormId("1").Build();
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123"
        };
        var decorator = new OptionObject2Decorator(optionObject);
        decorator.AddFormObject(expected);
        Assert.IsTrue(decorator.IsFormPresent("1"));
    }

    [TestMethod]
    public void AddFormObjectById_Expected() {
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123"
        };
        var decorator = new OptionObject2Decorator(optionObject);
        decorator.AddFormObject("1");
        Assert.IsTrue(decorator.IsFormPresent("1"));
    }

    [TestMethod]
    public void AddFormObjectByIdAndMI_Expected() {
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123"
        };
        var decorator = new OptionObject2Decorator(optionObject);
        decorator.AddFormObject("1", false);
        Assert.IsTrue(decorator.IsFormPresent("1"));
    }

    [TestMethod]
    public void AddFormObjectByIdAndMI_ArgumentNullException() {
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123"
        };
        var decorator = new OptionObject2Decorator(optionObject);
        Assert.ThrowsException<ArgumentNullException>(() => decorator.AddFormObject(null, false));
    }

    [TestMethod]
    public void AddFormObject_MICannotBeFirst() {
        var expected = new FormObject() {
            FormId = "1",
            MultipleIteration = true
        };
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123"
        };
        var decorator = new OptionObject2Decorator(optionObject);
        Assert.ThrowsException<ArgumentException>(() => decorator.AddFormObject(expected));
    }

    [TestMethod]
    public void AddFormObjectDecorator_MICannotBeFirst() {
        var expected = FormObjectDecorator.Builder().FormId("1").MultipleIteration().Build();
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123"
        };
        var decorator = new OptionObject2Decorator(optionObject);
        Assert.ThrowsException<ArgumentException>(() => decorator.AddFormObject(expected));
    }

    [TestMethod]
    public void AddFormObjectByIdAndMI_MICannotBeFirst() {
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123"
        };
        var decorator = new OptionObject2Decorator(optionObject);
        Assert.ThrowsException<ArgumentException>(() => decorator.AddFormObject("1", true));
    }

    [TestMethod]
    public void AddFormObject_DuplicateForms() {
        var expected = new FormObject() {
            FormId = "1"
        };
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123"
        };
        var decorator = new OptionObject2Decorator(optionObject);
        decorator.AddFormObject(expected);
        Assert.ThrowsException<ArgumentException>(() => decorator.AddFormObject(expected));
    }

    [TestMethod]
    public void AddFormObjectDecorator_DuplicateForms() {
        var expected = FormObjectDecorator.Builder().FormId("1").Build();
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123"
        };
        var decorator = new OptionObject2Decorator(optionObject);
        decorator.AddFormObject(expected);
        Assert.ThrowsException<ArgumentException>(() => decorator.AddFormObject(expected));
    }

    [TestMethod]
    public void AddFormObjectById_DuplicateForms() {
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123"
        };
        var decorator = new OptionObject2Decorator(optionObject);
        decorator.AddFormObject("1");
        Assert.ThrowsException<ArgumentException>(() => decorator.AddFormObject("1"));
    }

    [TestMethod]
    public void AddFormObjectByIdAndMI_DuplicateForms() {
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123"
        };
        var decorator = new OptionObject2Decorator(optionObject);
        decorator.AddFormObject("1", false);
        Assert.ThrowsException<ArgumentException>(() => decorator.AddFormObject("1", false));
    }

    #endregion

    #region GetCurrentRowId

    [TestMethod]
    public void TestOptionObject2Decorator_GetCurrentRowId_Expected() {
        var expected = "456||1";
        RowObject rowObject = new() {
            RowId = expected
        };
        FormObject formObject = new() {
            FormId = "456",
            CurrentRow = rowObject
        };
        OptionObject2 optionObject = new() {
            OptionId = "USER123",
            Forms = [formObject]
        };
        OptionObject2Decorator decorator = new(optionObject);
        Assert.AreEqual(expected, decorator.GetCurrentRowId("456"));
    }

    [TestMethod]
    public void TestOptionObject2Decorator_GetCurrentRowId_Exception() {
        FormObject formObject = new() {
            FormId = "456"
        };
        OptionObject2 optionObject = new() {
            OptionId = "USER123",
            Forms = [formObject]
        };
        OptionObject2Decorator decorator = new(optionObject);
        Assert.ThrowsException<ArgumentNullException>(() => decorator.GetCurrentRowId("456"));
    }

    #endregion

    #region GetFieldValue


    [TestMethod]
    public void TestOptionObject2Decorator_GetFieldValue_Succeeds()
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
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObject2Decorator(optionObject);
        Assert.AreEqual(expected, decorator.GetFieldValue(fieldNumber));
    }

    [TestMethod]
    public void TestOptionObject2Decorator_GetFieldValue_NotPresent()
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
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObject2Decorator(optionObject);
        Assert.ThrowsException<FieldObjectNotFoundException>(() => decorator.GetFieldValue("678.90"));
    }

    #endregion

    #region GetFieldValues

    [TestMethod]
    public void TestOptionObject2Decorator_GetFieldValues_Succeeds()
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
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObject2Decorator(optionObject);
        Assert.AreEqual(1, decorator.GetFieldValues(fieldNumber).Count);
        Assert.AreEqual(expected, decorator.GetFieldValues(fieldNumber)[0]);
    }

    [TestMethod]
    public void TestOptionObject2Decorator_GetFieldValues_MultipleRows_Succeeds()
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
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObject2Decorator(optionObject);
        Assert.AreEqual(2, decorator.GetFieldValues(fieldNumber).Count);
        Assert.AreEqual(expected, decorator.GetFieldValues(fieldNumber)[0]);
        Assert.AreEqual(expected2, decorator.GetFieldValues(fieldNumber)[1]);
    }

    [TestMethod]
    public void TestOptionObject2Decorator_GetFieldValues_NotPresent()
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
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObject2Decorator(optionObject);
        Assert.AreEqual(0, decorator.GetFieldValues("457||1").Count);
    }

    [TestMethod]
    public void TestOptionObject2Decorator_GetFieldValues_Empty()
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
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObject2Decorator(optionObject);
        Assert.ThrowsException<ArgumentNullException>(() => decorator.GetFieldValues(""));
    }

    [TestMethod]
    public void TestOptionObject2Decorator_GetFieldValues_Null()
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
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObject2Decorator(optionObject);
        Assert.ThrowsException<ArgumentNullException>(() => decorator.GetFieldValues(null));
    }

    #endregion

    #region GetMultipleIterationStatus

    [TestMethod]
    public void TestOptionObject2Decorator_GetMultipleIterationStatus_ReturnsBool()
    {
        var formId = "456";
        var expected = false;
        var formObject = new FormObject()
        {
            FormId = formId
        };
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObject2Decorator(optionObject);
        Assert.AreEqual(expected.GetType(), decorator.GetMultipleIterationStatus(formId).GetType());
    }

    [TestMethod]
    public void TestOptionObject2Decorator_GetMultipleIterationStatus_ReturnsFalse()
    {
        var formId = "456";
        var formObject = new FormObject()
        {
            FormId = formId
        };
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObject2Decorator(optionObject);
        Assert.IsFalse(decorator.GetMultipleIterationStatus(formId));
    }

    [TestMethod]
    public void TestOptionObject2Decorator_GetMultipleIterationStatus_ReturnsTrue()
    {
        var formId = "456";
        var formObject = new FormObject()
        {
            FormId = formId,
            MultipleIteration = true
        };
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObject2Decorator(optionObject);
        Assert.IsTrue(decorator.GetMultipleIterationStatus(formId));
    }

    [TestMethod]
    public void TestOptionObject2Decorator_GetMultipleIterationStatus_ReturnsFormObjectNotFoundException()
    {
        var formId = "456";
        var formObject = new FormObject()
        {
            FormId = "123",
            MultipleIteration = true
        };
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObject2Decorator(optionObject);
        Assert.ThrowsException<FormObjectNotFoundException>(() => decorator.GetMultipleIterationStatus(formId));
    }

    [TestMethod]
    public void TestOptionObject2Decorator_GetMultipleIterationStatus_NoForms_ReturnsFormObjectNotFoundException()
    {
        var formId = "456";
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123"
        };
        var decorator = new OptionObject2Decorator(optionObject);
        Assert.ThrowsException<FormObjectNotFoundException>(() => decorator.GetMultipleIterationStatus(formId));
    }

    [TestMethod]
    public void TestOptionObject2Decorator_GetMultipleIterationStatus_ReturnsArgumentNullException()
    {
        var formObject = new FormObject()
        {
            FormId = "123",
            MultipleIteration = true
        };
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObject2Decorator(optionObject);
        Assert.ThrowsException<ArgumentNullException>(() => decorator.GetMultipleIterationStatus(null));
    }

    #endregion

    #region GetParentRowId

    [TestMethod]
    public void TestOptionObject2Decorator_GetParentRowId_Expected() {
        var expected = "456||1";
        RowObject rowObject = new() {
            RowId = "456||3",
            ParentRowId = expected
        };
        FormObject formObject = new() {
            FormId = "456",
            CurrentRow = rowObject
        };
        OptionObject2 optionObject = new() {
            OptionId = "USER123",
            Forms = [formObject]
        };
        OptionObject2Decorator decorator = new(optionObject);
        Assert.AreEqual(expected, decorator.GetParentRowId("456"));
    }

    [TestMethod]
    public void TestOptionObject2Decorator_GetParentRowId_Exception() {
        FormObject formObject = new() {
            FormId = "456"
        };
        OptionObject2 optionObject = new() {
            OptionId = "USER123",
            Forms = [formObject]
        };
        OptionObject2Decorator decorator = new(optionObject);
        Assert.ThrowsException<ArgumentNullException>(() => decorator.GetParentRowId("456"));
    }

    [TestMethod]
    public void TestOptionObject2Decorator_GetParentRowId_Null() {
        RowObject rowObject = new() {
            RowId = "456||3",
        };
        FormObject formObject = new() {
            FormId = "456",
            CurrentRow = rowObject
        };
        OptionObject2 optionObject = new() {
            OptionId = "USER123",
            Forms = [formObject]
        };
        OptionObject2Decorator decorator = new(optionObject);
        Assert.IsNull(decorator.GetParentRowId("456"));
    }

    #endregion

    #region IsFieldEnabled

    [TestMethod]
    public void IsFieldEnabled_OptionObject2_FirstForm_IsEnabled()
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
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObject2Decorator(optionObject);
        Assert.IsTrue(decorator.IsFieldEnabled("123.45"));
    }

    [TestMethod]
    public void IsFieldEnabled_OptionObject2_SecondForm_IsEnabled()
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
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = [formObject,formObject2]
        };
        var decorator = new OptionObject2Decorator(optionObject);
        Assert.IsTrue(decorator.IsFieldEnabled("123.45"));
    }

    [TestMethod]
    public void IsFieldEnabled_OptionObject2_FirstForm_IsNotEnabled()
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
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObject2Decorator(optionObject);
        Assert.IsFalse(decorator.IsFieldEnabled("123.45"));
    }

    [TestMethod]
    public void IsFieldEnabled_OptionObject2_SecondForm_IsNotEnabled()
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
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = [formObject,formObject2]
        };
        var decorator = new OptionObject2Decorator(optionObject);
        Assert.IsFalse(decorator.IsFieldEnabled("123.45"));
    }

    [TestMethod]
    public void IsFieldEnabled_OptionObject2_IsNotPresent()
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
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObject2Decorator(optionObject);
        Assert.ThrowsException<FieldObjectNotFoundException>(() => decorator.IsFieldEnabled("678.90"));
    }

    #endregion

    #region IsFieldLocked

    [TestMethod]
    public void IsFieldLocked_OptionObject2_FirstForm_IsLocked()
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
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObject2Decorator(optionObject);
        Assert.IsTrue(decorator.IsFieldLocked("123.45"));
    }

    [TestMethod]
    public void IsFieldLocked_OptionObject2_SecondForm_IsLocked()
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
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = [formObject,formObject2]
        };
        var decorator = new OptionObject2Decorator(optionObject);
        Assert.IsTrue(decorator.IsFieldLocked("123.45"));
    }

    [TestMethod]
    public void IsFieldLocked_OptionObject2_FirstForm_IsNotLocked()
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
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObject2Decorator(optionObject);
        Assert.IsFalse(decorator.IsFieldLocked("123.45"));
    }

    [TestMethod]
    public void IsFieldLocked_OptionObject2_SecondForm_IsNotLocked()
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
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = [formObject,formObject2]
        };
        var decorator = new OptionObject2Decorator(optionObject);
        Assert.IsFalse(decorator.IsFieldLocked("123.45"));
    }

    [TestMethod]
    public void IsFieldLocked_OptionObject2_IsNotPresent()
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
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObject2Decorator(optionObject);
        Assert.ThrowsException<FieldObjectNotFoundException>(() => decorator.IsFieldLocked("678.90"));
    }

    #endregion

    #region IsFieldModified

    [TestMethod]
    public void IsFieldModified_OptionObject2_IsFalse()
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
        OptionObject2 optionObject = new() {
            Forms = [formObject]
        };
        OptionObject2Decorator decorator = new(optionObject);
        Assert.IsFalse(decorator.IsFieldModified("123"));
    }

    [TestMethod]
    public void IsFieldModified_OptionObject2_IsTrue()
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
        OptionObject2 optionObject = new() {
            Forms = [formObject]
        };
        OptionObject2Decorator decorator = new(optionObject);
        decorator.SetFieldValue("123", "MODIFIED");
        Assert.IsTrue(decorator.IsFieldModified("123"));
    }

    [TestMethod]
    public void IsFieldModified_OptionObject2_IsFalse_NullFieldNumber()
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
        OptionObject2 optionObject = new() {
            Forms = [formObject]
        };
        OptionObject2Decorator decorator = new(optionObject);
        Assert.ThrowsException<ArgumentNullException>(() => decorator.IsFieldModified(null));
    }

    #endregion

    #region IsFieldPresent

    [TestMethod]
    public void TestOptionObject2Decorator_FieldIsPresent()
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
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObject2Decorator(optionObject);
        Assert.IsTrue(decorator.IsFieldPresent("123.45"));
    }

    [TestMethod]
    public void TestOptionObject2Decorator_FieldIsNotPresent()
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
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObject2Decorator(optionObject);
        Assert.IsFalse(decorator.IsFieldPresent("678.90"));
    }

    #endregion

    #region IsFieldRequired

    [TestMethod]
    public void IsFieldRequired_OptionObject2_FirstForm_IsRequired()
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
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObject2Decorator(optionObject);
        Assert.IsTrue(decorator.IsFieldRequired("123.45"));
    }

    [TestMethod]
    public void IsFieldRequired_OptionObject2_SecondForm_IsRequired()
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
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = [formObject,formObject2]
        };
        var decorator = new OptionObject2Decorator(optionObject);
        Assert.IsTrue(decorator.IsFieldRequired("123.45"));
    }

    [TestMethod]
    public void IsFieldRequired_OptionObject2_FirstForm_IsNotRequired()
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
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObject2Decorator(optionObject);
        Assert.IsFalse(decorator.IsFieldRequired("123.45"));
    }

    [TestMethod]
    public void IsFieldRequired_OptionObject2_SecondForm_IsNotRequired()
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
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = [formObject,formObject2]
        };
        var decorator = new OptionObject2Decorator(optionObject);
        Assert.IsFalse(decorator.IsFieldRequired("123.45"));
    }

    [TestMethod]
    public void IsFieldRequired_OptionObject2_IsNotPresent()
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
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObject2Decorator(optionObject);
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
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = [formObject,formObject2]
        };
        var decorator = new OptionObject2Decorator(optionObject);
        Assert.IsTrue(decorator.IsFormPresent("123"));
        Assert.IsTrue(decorator.IsFormPresent("456"));
        Assert.IsFalse(decorator.IsFormPresent("789"));
    }

    [TestMethod]
    public void IsFormPresent_NoForms_Expected()
    {
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123"
        };
        var decorator = new OptionObject2Decorator(optionObject);
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
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = [formObject,formObject2]
        };
        var decorator = new OptionObject2Decorator(optionObject);
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
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObject2Decorator(optionObject);
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
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObject2Decorator(optionObject);
        Assert.ThrowsException<ArgumentNullException>(() => decorator.IsRowMarkedForDeletion(null));
    }

    #endregion

    #region DeleteRowObject

    [TestMethod]
    public void TestOptionObject2Decorator_DeleteRowObject_CurrentRow()
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
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObject2Decorator(optionObject);
        decorator.DeleteRowObject("456", "456||1");
        Assert.AreEqual(RowActions.Delete, decorator.Forms[0].CurrentRow.RowAction);
    }

    [TestMethod]
    public void TestOptionObject2Decorator_DeleteRowObject_Errors()
    {
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123"
        };
        var decorator = new OptionObject2Decorator(optionObject);
        Assert.ThrowsException<ArgumentNullException>(() => decorator.DeleteRowObject(null, "1||1"));
        Assert.ThrowsException<ArgumentNullException>(() => decorator.DeleteRowObject("456", null));
        Assert.ThrowsException<ArgumentException>(() => decorator.DeleteRowObject("999", "1||1"));
    }

    [TestMethod]
    public void TestOptionObject2Decorator_DeleteRowObject_OtherRow()
    {
        var row1 = new RowObject() { RowId = "456||1" };
        var row2 = new RowObject() { RowId = "456||2" };
        var formObject = new FormObject()
        {
            FormId = "456",
            CurrentRow = row1,
            MultipleIteration = true,
            OtherRows = [row2]
        };
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObject2Decorator(optionObject);
        decorator.DeleteRowObject("456", "456||2");
        Assert.AreEqual(RowActions.Delete, decorator.Forms[0].OtherRows[0].RowAction);
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
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObject2Decorator(optionObject);
        Assert.IsTrue(decorator.IsRowPresent("456||1"));
    }

    [TestMethod]
    public void IsRowPresent_NoForms_Expected()
    {
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123"
        };
        var decorator = new OptionObject2Decorator(optionObject);
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
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObject2Decorator(optionObject);
        Assert.ThrowsException<ArgumentNullException>(() => decorator.IsRowPresent(null));
    }

    #endregion

    #region SetFieldValue

    [TestMethod]
    public void TestOptionObject2Decorator_SetFieldValue_Succeeds()
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
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObject2Decorator(optionObject);
        decorator.SetFieldValue(fieldNumber, expected);
        Assert.AreEqual(expected, decorator.GetFieldValue(fieldNumber));
    }

    [TestMethod]
    public void TestOptionObject2Decorator_SetFieldValue_ReturnsExpectedForms()
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
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObject2Decorator(optionObject);
        decorator.SetFieldValue("123.45", "modified value");
        var actual = decorator.Return().AsOptionObject2();
        Assert.AreEqual(1, actual.Forms.Count);
    }

    [TestMethod]
    public void TestOptionObject2Decorator_SetFieldValue_WithFormAndRowIds_ReturnsExpectedForms()
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
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObject2Decorator(optionObject);
        decorator.SetFieldValue("456", "456||1", "123.45", "modified value");
        var actual = decorator.Return().AsOptionObject2();
        Assert.AreEqual(1, actual.Forms.Count);
    }

    #endregion

    #region AddRowObject

    [TestMethod]
    public void TestOptionObject2Decorator_AddRowObject_Success()
    {
        var formObject = new FormObject()
        {
            FormId = "1",
            MultipleIteration = true
        };
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObject2Decorator(optionObject);
        var rowObject = new RowObject();
        decorator.AddRowObject("1", rowObject);
        Assert.IsNotNull(decorator.Forms[0].CurrentRow);
        Assert.AreEqual("1||1", decorator.Forms[0].CurrentRow.RowId);
    }

    [TestMethod]
    public void TestOptionObject2Decorator_AddRowObject_FormNotFound()
    {
        var formObject = new FormObject()
        {
            FormId = "1",
            MultipleIteration = true
        };
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObject2Decorator(optionObject);
        var rowObject = new RowObject();
        Assert.ThrowsException<ArgumentException>(() => decorator.AddRowObject("99", rowObject));
    }

    [TestMethod]
    public void TestOptionObject2Decorator_AddRowObject_NullRowObject()
    {
        var formObject = new FormObject()
        {
            FormId = "1",
            MultipleIteration = true
        };
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObject2Decorator(optionObject);
        Assert.ThrowsException<ArgumentNullException>(() => decorator.AddRowObject("1", null));
    }

    [TestMethod]
    public void TestOptionObject2Decorator_AddRowObject_WithMultipleRows()
    {
        var formObject = new FormObject()
        {
            FormId = "1",
            MultipleIteration = true
        };
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObject2Decorator(optionObject);
        decorator.AddRowObject("1", new RowObject());
        decorator.AddRowObject("1", new RowObject());
        Assert.AreEqual(1, decorator.Forms[0].OtherRows.Count);
        Assert.AreEqual("1||2", decorator.Forms[0].OtherRows[0].RowId);
    }

    #endregion

    #region Edge Case Tests - Regression & Coverage

    [TestMethod]
    public void TestOptionObject2Decorator_Constructor_WithEmptyFormsCollection()
    {
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = new List<FormObject>()
        };
        var decorator = new OptionObject2Decorator(optionObject);
        Assert.IsNotNull(decorator.Forms);
        Assert.AreEqual(0, decorator.Forms.Count);
    }

    #endregion

    #region DisableAllFieldObjects

    [TestMethod]
    public void DisableAllFieldObjects_AllFieldsDisabled()
    {
        var fieldObject = new FieldObject()
        {
            Enabled = "1",
            FieldNumber = "123",
            FieldValue = "test",
            Lock = "0",
            Required = "0"
        };
        var rowObject = new RowObject()
        {
            Fields = [fieldObject],
            RowId = "1"
        };
        var formObject = new FormObject()
        {
            FormId = "1",
            CurrentRow = rowObject
        };
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObject2Decorator(optionObject);
        decorator.DisableAllFieldObjects();
        Assert.IsFalse(decorator.Forms[0].CurrentRow.Fields[0].Enabled);
    }

    [TestMethod]
    public void DisableAllFieldObjects_WithExcludedFields()
    {
        var fieldObject1 = new FieldObject()
        {
            Enabled = "1",
            FieldNumber = "123",
            FieldValue = "test",
            Lock = "0",
            Required = "0"
        };
        var fieldObject2 = new FieldObject()
        {
            Enabled = "1",
            FieldNumber = "124",
            FieldValue = "test",
            Lock = "0",
            Required = "0"
        };
        var rowObject = new RowObject()
        {
            Fields = [fieldObject1, fieldObject2],
            RowId = "1"
        };
        var formObject = new FormObject()
        {
            FormId = "1",
            CurrentRow = rowObject
        };
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObject2Decorator(optionObject);
        decorator.DisableAllFieldObjects(new List<string> { "123" });
        Assert.IsTrue(decorator.Forms[0].CurrentRow.Fields[0].Enabled);
        Assert.IsFalse(decorator.Forms[0].CurrentRow.Fields[1].Enabled);
    }

    [TestMethod]
    public void DisableAllFieldObjects_NullExcludedFieldsList_ThrowsException()
    {
        var fieldObject = new FieldObject()
        {
            Enabled = "1",
            FieldNumber = "123",
            FieldValue = "test",
            Lock = "0",
            Required = "0"
        };
        var rowObject = new RowObject()
        {
            Fields = [fieldObject],
            RowId = "1"
        };
        var formObject = new FormObject()
        {
            FormId = "1",
            CurrentRow = rowObject
        };
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObject2Decorator(optionObject);
        Assert.ThrowsException<ArgumentNullException>(() => decorator.DisableAllFieldObjects(null));
    }

    [TestMethod]
    public void DisableAllFieldObjects_EmptyForms_ThrowsException()
    {
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = new List<FormObject>()
        };
        var decorator = new OptionObject2Decorator(optionObject);
        Assert.ThrowsException<ArgumentException>(() => decorator.DisableAllFieldObjects());
    }

    [TestMethod]
    public void DisableAllFieldObjects_NullForms_ThrowsException()
    {
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = new List<FormObject>()
        };
        var decorator = new OptionObject2Decorator(optionObject);
        decorator.Forms = null;
        Assert.ThrowsException<ArgumentNullException>(() => decorator.DisableAllFieldObjects());
    }

    [TestMethod]
    public void DisableAllFieldObjects_NullForms_WithExclusionList_ThrowsException()
    {
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = new List<FormObject>()
        };
        var decorator = new OptionObject2Decorator(optionObject);
        decorator.Forms = null;
        Assert.ThrowsException<ArgumentNullException>(() => decorator.DisableAllFieldObjects(new List<string>()));
    }

    [TestMethod]
    public void DisableAllFieldObjects_EmptyExclusionList()
    {
        var fieldObject = new FieldObject()
        {
            Enabled = "1",
            FieldNumber = "123",
            FieldValue = "test",
            Lock = "0",
            Required = "0"
        };
        var rowObject = new RowObject()
        {
            Fields = [fieldObject],
            RowId = "1"
        };
        var formObject = new FormObject()
        {
            FormId = "1",
            CurrentRow = rowObject
        };
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObject2Decorator(optionObject);
        decorator.DisableAllFieldObjects(new List<string>());
        Assert.IsFalse(decorator.Forms[0].CurrentRow.Fields[0].Enabled);
    }

    [TestMethod]
    public void DisableAllFieldObjects_PreservesNamespaceName()
    {
        var fieldObject = new FieldObject()
        {
            Enabled = "1",
            FieldNumber = "123",
            FieldValue = "test",
            Lock = "0",
            Required = "0"
        };
        var rowObject = new RowObject()
        {
            Fields = [fieldObject],
            RowId = "1"
        };
        var formObject = new FormObject()
        {
            FormId = "1",
            CurrentRow = rowObject
        };
        var optionObject = new OptionObject2()
        {
            NamespaceName = "NAMESPACE",
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObject2Decorator(optionObject);
        decorator.DisableAllFieldObjects();
        Assert.AreEqual("NAMESPACE", decorator.NamespaceName);
    }

    [TestMethod]
    public void DisableAllFieldObjects_PreservesServerName()
    {
        var fieldObject = new FieldObject()
        {
            Enabled = "1",
            FieldNumber = "123",
            FieldValue = "test",
            Lock = "0",
            Required = "0"
        };
        var rowObject = new RowObject()
        {
            Fields = [fieldObject],
            RowId = "1"
        };
        var formObject = new FormObject()
        {
            FormId = "1",
            CurrentRow = rowObject
        };
        var optionObject = new OptionObject2()
        {
            ServerName = "SERVERNAME",
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObject2Decorator(optionObject);
        decorator.DisableAllFieldObjects();
        Assert.AreEqual("SERVERNAME", decorator.ServerName);
    }

    [TestMethod]
    public void DisableAllFieldObjects_MultipleIterationForm()
    {
        var fieldObject = new FieldObject()
        {
            Enabled = "1",
            FieldNumber = "123",
            FieldValue = "test",
            Lock = "0",
            Required = "0"
        };
        var otherRow = new RowObject()
        {
            Fields = [fieldObject],
            RowId = "2",
            ParentRowId = "1"
        };
        var formObject = new FormObject()
        {
            FormId = "1",
            MultipleIteration = true,
            OtherRows = [otherRow]
        };
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObject2Decorator(optionObject);
        decorator.DisableAllFieldObjects();
        Assert.IsFalse(decorator.Forms[0].OtherRows[0].Fields[0].Enabled);
    }

    [TestMethod]
    public void DisableAllFieldObjects_SetsRowActionToEdit()
    {
        var fieldObject = new FieldObject()
        {
            Enabled = "1",
            FieldNumber = "123",
            FieldValue = "test",
            Lock = "0",
            Required = "0"
        };
        var rowObject = new RowObject()
        {
            Fields = [fieldObject],
            RowId = "1",
            RowAction = ""
        };
        var formObject = new FormObject()
        {
            FormId = "1",
            CurrentRow = rowObject
        };
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObject2Decorator(optionObject);
        decorator.DisableAllFieldObjects();
        Assert.AreEqual("EDIT", decorator.Forms[0].CurrentRow.RowAction);
    }

    [TestMethod]
    public void DisableAllFieldObjects_PreservesExistingRowAction()
    {
        var fieldObject = new FieldObject()
        {
            Enabled = "1",
            FieldNumber = "123",
            FieldValue = "test",
            Lock = "0",
            Required = "0"
        };
        var rowObject = new RowObject()
        {
            Fields = [fieldObject],
            RowId = "1",
            RowAction = "DELETE"
        };
        var formObject = new FormObject()
        {
            FormId = "1",
            CurrentRow = rowObject
        };
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObject2Decorator(optionObject);
        decorator.DisableAllFieldObjects();
        Assert.AreEqual("DELETE", decorator.Forms[0].CurrentRow.RowAction);
    }

    [TestMethod]
    public void DisableAllFieldObjects_WithNullCurrentRow()
    {
        var formObject = new FormObject()
        {
            FormId = "1"
        };
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObject2Decorator(optionObject);
        decorator.DisableAllFieldObjects();
        Assert.IsNull(decorator.Forms[0].CurrentRow);
    }

    [TestMethod]
    public void DisableAllFieldObjects_NonMultipleIterationForm()
    {
        var fieldObject = new FieldObject()
        {
            Enabled = "1",
            FieldNumber = "123",
            FieldValue = "test",
            Lock = "0",
            Required = "0"
        };
        var rowObject = new RowObject()
        {
            Fields = [fieldObject],
            RowId = "1"
        };
        var otherRow = new RowObject()
        {
            Fields = [fieldObject],
            RowId = "2",
            ParentRowId = "1"
        };
        var formObject = new FormObject()
        {
            FormId = "1",
            CurrentRow = rowObject,
            MultipleIteration = false,
            OtherRows = [otherRow]
        };
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123",
            Forms = [formObject]
        };
        var decorator = new OptionObject2Decorator(optionObject);
        decorator.DisableAllFieldObjects();
        Assert.IsFalse(decorator.Forms[0].CurrentRow.Fields[0].Enabled);
        Assert.IsFalse(decorator.Forms[0].OtherRows[0].Fields[0].Enabled);
    }

    #endregion
}
