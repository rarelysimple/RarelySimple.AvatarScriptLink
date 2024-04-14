﻿using RarelySimple.AvatarScriptLink.Net.Decorators;
using RarelySimple.AvatarScriptLink.Net.Exceptions;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Net.Tests.Decorators;

[TestClass]
public class OptionObject2DecoratorTests
{
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
    public void TestOptionObject2Decorator_GetFieldValue_FormAndRowId_Succeeds()
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
        Assert.AreEqual(expected, decorator.GetFieldValue("456", "456||1", fieldNumber));
    }

    [TestMethod]
    [ExpectedException(typeof(FieldObjectNotFoundException))]
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
        Assert.AreEqual(expected, decorator.GetFieldValue("678.90"));
    }

    [TestMethod]
    [ExpectedException(typeof(FieldObjectNotFoundException))]
    public void TestOptionObject2Decorator_GetFieldValue_FormAndRowId_NotPresent()
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
        Assert.AreEqual(expected, decorator.GetFieldValue("123", "123||1", "678.90"));
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void TestOptionObject2Decorator_GetFieldValue_FormIdEmpty_NotPresent()
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
        Assert.AreEqual(expected, decorator.GetFieldValue("", "456||1", fieldNumber));
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void TestOptionObject2Decorator_GetFieldValue_FormIdNull_NotPresent()
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
        Assert.AreEqual(expected, decorator.GetFieldValue(null, "456||1", fieldNumber));
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void TestOptionObject2Decorator_GetFieldValue_RowIdEmpty_NotPresent()
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
        Assert.AreEqual(expected, decorator.GetFieldValue("456", "", fieldNumber));
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void TestOptionObject2Decorator_GetFieldValue_RowIdNull_NotPresent()
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
        Assert.AreEqual(expected, decorator.GetFieldValue("456", null, fieldNumber));
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void TestOptionObject2Decorator_GetFieldValue_FieldNumberEmpty_NotPresent()
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
        Assert.AreEqual(expected, decorator.GetFieldValue("456", "456||1", ""));
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void TestOptionObject2Decorator_GetFieldValue_FieldNumberNull_NotPresent()
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
        Assert.AreEqual(expected, decorator.GetFieldValue("456", "456||1", null));
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
    [ExpectedException(typeof(FormObjectNotFoundException))]
    public void TestOptionObject2Decorator_GetMultipleIterationStatus_ReturnsFormObjectNotFoundException()
    {
        var formId = "456";
        var expected = true;
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
        Assert.AreEqual(expected, decorator.GetMultipleIterationStatus(formId));
    }

    [TestMethod]
    [ExpectedException(typeof(FormObjectNotFoundException))]
    public void TestOptionObject2Decorator_GetMultipleIterationStatus_NoForms_ReturnsFormObjectNotFoundException()
    {
        var formId = "456";
        var expected = true;
        var optionObject = new OptionObject2()
        {
            OptionId = "TEST123"
        };
        var decorator = new OptionObject2Decorator(optionObject);
        Assert.AreEqual(expected, decorator.GetMultipleIterationStatus(formId));
    }

    [TestMethod]
    [ExpectedException(typeof(NullReferenceException))]
    public void TestOptionObject2Decorator_GetMultipleIterationStatus_ReturnsNullReferenceException()
    {
        var formId = "456";
        var expected = true;
        var decorator = new OptionObject2Decorator(null);
        Assert.AreEqual(expected, decorator.GetMultipleIterationStatus(formId));
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void TestOptionObject2Decorator_GetMultipleIterationStatus_ReturnsArgumentNullException()
    {
        var expected = true;
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
        Assert.AreEqual(expected, decorator.GetMultipleIterationStatus(null));
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
    [ExpectedException(typeof(FieldObjectNotFoundException))]
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
        Assert.IsTrue(decorator.IsFieldEnabled("678.90"));
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void IsFieldEnabled_OptionObject2_Null_IsNotPresent()
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
        Assert.IsTrue(decorator.IsFieldEnabled(null));
    }

    [TestMethod]
    [ExpectedException(typeof(NullReferenceException))]
    public void IsFieldEnabled_OptionObject2_Null()
    {
        var decorator = new OptionObject2Decorator(null);
        Assert.IsTrue(decorator.IsFieldEnabled("123.45"));
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
    [ExpectedException(typeof(FieldObjectNotFoundException))]
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
        Assert.IsTrue(decorator.IsFieldLocked("678.90"));
    }

    [TestMethod]
    [ExpectedException(typeof(NullReferenceException))]
    public void IsFieldLocked_OptionObject2_Null()
    {
        var decorator = new OptionObject2Decorator(null);
        Assert.IsTrue(decorator.IsFieldLocked("123.45"));
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

    [TestMethod]
    [ExpectedException(typeof(NullReferenceException))]
    public void IsFieldPresent_OptionObject2_Null()
    {
        var decorator = new OptionObject2Decorator(null);
        Assert.IsTrue(decorator.IsFieldPresent("123.45"));
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
    [ExpectedException(typeof(FieldObjectNotFoundException))]
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
        Assert.IsTrue(decorator.IsFieldRequired("678.90"));
    }

    [TestMethod]
    [ExpectedException(typeof(NullReferenceException))]
    public void IsFieldRequired_OptionObject2_Null()
    {
        var decorator = new OptionObject2Decorator(null);
        Assert.IsTrue(decorator.IsFieldRequired("123.45"));
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
}
