using RarelySimple.AvatarScriptLink.Net.Decorators;
using RarelySimple.AvatarScriptLink.Net.Exceptions;
using RarelySimple.AvatarScriptLink.Objects;

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
    [ExpectedException(typeof(ArgumentNullException))]
    public void AddFormObjectByIdAndMI_ArgumentNullException() {
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123"
        };
        var decorator = new OptionObjectDecorator(optionObject);
        decorator.AddFormObject(null, false);
        Assert.IsTrue(decorator.IsFormPresent("1"));
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
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
        decorator.AddFormObject(expected);
        Assert.IsTrue(decorator.IsFormPresent("1"));
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void AddFormObjectDecorator_MICannotBeFirst() {
        var expected = FormObjectDecorator.Builder().FormId("1").MultipleIteration().Build();
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123"
        };
        var decorator = new OptionObjectDecorator(optionObject);
        decorator.AddFormObject(expected);
        Assert.IsTrue(decorator.IsFormPresent("1"));
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void AddFormObjectByIdAndMI_MICannotBeFirst() {
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123"
        };
        var decorator = new OptionObjectDecorator(optionObject);
        decorator.AddFormObject("1", true);
        Assert.IsTrue(decorator.IsFormPresent("1"));
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
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
        decorator.AddFormObject(expected);
        Assert.IsTrue(decorator.IsFormPresent("1"));
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void AddFormObjectDecorator_DuplicateForms() {
        var expected = FormObjectDecorator.Builder().FormId("1").Build();
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123"
        };
        var decorator = new OptionObjectDecorator(optionObject);
        decorator.AddFormObject(expected);
        decorator.AddFormObject(expected);
        Assert.IsTrue(decorator.IsFormPresent("1"));
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void AddFormObjectById_DuplicateForms() {
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123"
        };
        var decorator = new OptionObjectDecorator(optionObject);
        decorator.AddFormObject("1");
        decorator.AddFormObject("1");
        Assert.IsTrue(decorator.IsFormPresent("1"));
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void AddFormObjectByIdAndMI_DuplicateForms() {
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123"
        };
        var decorator = new OptionObjectDecorator(optionObject);
        decorator.AddFormObject("1", false);
        decorator.AddFormObject("1", false);
        Assert.IsTrue(decorator.IsFormPresent("1"));
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
    [ExpectedException(typeof(FieldObjectNotFoundException))]
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
        Assert.AreEqual(expected, decorator.GetFieldValue("678.90"));
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
    [ExpectedException(typeof(FormObjectNotFoundException))]
    public void TestOptionObjectDecorator_GetMultipleIterationStatus_ReturnsFormObjectNotFoundException()
    {
        var formId = "456";
        var expected = true;
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
        Assert.AreEqual(expected, decorator.GetMultipleIterationStatus(formId));
    }

    [TestMethod]
    [ExpectedException(typeof(FormObjectNotFoundException))]
    public void TestOptionObjectDecorator_GetMultipleIterationStatus_NoForms_ReturnsFormObjectNotFoundException()
    {
        var formId = "456";
        var expected = true;
        var optionObject = new OptionObject()
        {
            OptionId = "TEST123"
        };
        var decorator = new OptionObjectDecorator(optionObject);
        Assert.AreEqual(expected, decorator.GetMultipleIterationStatus(formId));
    }

    [TestMethod]
    [ExpectedException(typeof(NullReferenceException))]
    public void TestOptionObjectDecorator_GetMultipleIterationStatus_ReturnsNullReferenceException()
    {
        var formId = "456";
        var expected = true;
        var decorator = new OptionObjectDecorator(null);
        Assert.AreEqual(expected, decorator.GetMultipleIterationStatus(formId));
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void TestOptionObjectDecorator_GetMultipleIterationStatus_ReturnsArgumentNullException()
    {
        var expected = true;
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
        Assert.AreEqual(expected, decorator.GetMultipleIterationStatus(null));
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
    [ExpectedException(typeof(FieldObjectNotFoundException))]
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
        Assert.IsTrue(decorator.IsFieldEnabled("678.90"));
    }

    [TestMethod]
    [ExpectedException(typeof(NullReferenceException))]
    public void IsFieldEnabled_OptionObject_Null()
    {
        var decorator = new OptionObjectDecorator(null);
        Assert.IsTrue(decorator.IsFieldEnabled("123.45"));
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
    [ExpectedException(typeof(FieldObjectNotFoundException))]
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
        Assert.IsTrue(decorator.IsFieldLocked("678.90"));
    }

    [TestMethod]
    [ExpectedException(typeof(NullReferenceException))]
    public void IsFieldLocked_OptionObject_Null()
    {
        var decorator = new OptionObjectDecorator(null);
        Assert.IsTrue(decorator.IsFieldLocked("123.45"));
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

    [TestMethod]
    [ExpectedException(typeof(NullReferenceException))]
    public void IsFieldPresent_OptionObject_Null()
    {
        var decorator = new OptionObjectDecorator(null);
        Assert.IsTrue(decorator.IsFieldPresent("123.45"));
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
    [ExpectedException(typeof(FieldObjectNotFoundException))]
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
        Assert.IsTrue(decorator.IsFieldRequired("678.90"));
    }

    [TestMethod]
    [ExpectedException(typeof(NullReferenceException))]
    public void IsFieldRequired_OptionObject_Null()
    {
        var decorator = new OptionObjectDecorator(null);
        Assert.IsTrue(decorator.IsFieldRequired("123.45"));
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
}
