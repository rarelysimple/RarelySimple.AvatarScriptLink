﻿using RarelySimple.AvatarScriptLink.Net.Decorators;
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
}
