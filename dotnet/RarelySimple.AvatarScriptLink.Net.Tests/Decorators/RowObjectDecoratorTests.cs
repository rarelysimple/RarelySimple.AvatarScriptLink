using RarelySimple.AvatarScriptLink.Net.Decorators;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Net.Tests.Decorators;

[TestClass]
public class RowObjectDecoratorTests
{
    [TestMethod]
    public void TestRowObjectDecorator_FieldIsPresent()
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
        var decorator = new RowObjectDecorator(rowObject);
        Assert.IsTrue(decorator.IsFieldPresent("123.45"));
    }

    [TestMethod]
    public void TestRowObjectDecorator_FieldIsNotPresent()
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
        var decorator = new RowObjectDecorator(rowObject);
        Assert.IsFalse(decorator.IsFieldPresent("678.90"));
    }
    
    [TestMethod]
    public void TestRowObjectDecorator_ReturnsNoFields()
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
        var decorator = new RowObjectDecorator(rowObject);
        var actual = decorator.Return().AsRowObject();
        Assert.AreEqual(RowActions.None, actual.RowAction);
        Assert.AreEqual(0, actual.Fields.Count);
    }

    [TestMethod]
    public void TestRowObjectDecorator_AddFieldObject_ReturnsExpectedFields()
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
        var decorator = new RowObjectDecorator(rowObject);
        var fieldObject2 = new FieldObject()
        {
            Enabled = "1",
            FieldNumber = "123.46",
            FieldValue = "another field",
            Lock = "0",
            Required = "0"
        };
        decorator.AddFieldObject(fieldObject2);
        var actual = decorator.Return().AsRowObject();
        Assert.AreEqual(RowActions.Edit, actual.RowAction);
        Assert.AreEqual(1, actual.Fields.Count);
    }

    [TestMethod]
    public void TestRowObjectDecorator_SetFieldValue_ReturnsExpectedFields()
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
        var decorator = new RowObjectDecorator(rowObject);
        decorator.SetFieldValue("123.45", "modified value");
        var actual = decorator.Return().AsRowObject();
        Assert.AreEqual(RowActions.Edit, actual.RowAction);
        Assert.AreEqual(1, actual.Fields.Count);
    }
}