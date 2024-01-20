﻿using RarelySimple.AvatarScriptLink.Net.Decorators;
using RarelySimple.AvatarScriptLink.Objects;

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
