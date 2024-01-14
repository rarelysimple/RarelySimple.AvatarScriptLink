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
}
