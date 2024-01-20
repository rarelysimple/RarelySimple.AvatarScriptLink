using RarelySimple.AvatarScriptLink.Net.Decorators;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Net.Tests.Decorators;

[TestClass]
public class RowObjectDecoratorTests
{
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

    #region AddFieldObject

    [TestMethod]
    public void TestRowObjectDecorator_AddFieldObject_Succeeds()
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
            RowId = "456||1"
        };
        var decorator = new RowObjectDecorator(rowObject);
        decorator.AddFieldObject(fieldObject);
        Assert.AreEqual(expected, decorator.GetFieldValue(fieldNumber));
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

    #endregion

    #region GetFieldValue

    [TestMethod]
    public void TestRowObjectDecorator_GetFieldValue_Succeeds()
    {
        string fieldNumber = "123";
        string expected = "TEST";
        var fieldObject = new FieldObject() {
            FieldNumber = fieldNumber,
            FieldValue = expected
        };
        var rowObject = new RowObject() {
            RowId = "1||1",
            Fields = [ fieldObject ]
        };
        var decorator = new RowObjectDecorator(rowObject);
        Assert.AreEqual(expected, decorator.GetFieldValue(fieldNumber));
        Assert.AreEqual(expected.GetType(), decorator.GetFieldValue(fieldNumber).GetType());
    }

    // [TestMethod]
    // [ExpectedException(typeof(ArgumentException))]
    // public void GetFieldValueRowObjectMissingFieldReturnsError()
    // {
    //     FieldObject fieldObject1 = new FieldObject("123", "TEST");
    //     RowObject rowObject1 = new RowObject("1||1");
    //     FieldObject fieldObject2 = new FieldObject("123", "TESTED");
    //     RowObject rowObject2 = new RowObject("1||2");
    //     rowObject1.Fields.Add(fieldObject1);
    //     rowObject2.Fields.Add(fieldObject2);
    //     string expected1 = "TEST";
    //     string expected2 = "TESTED";
    //     Assert.AreEqual(expected1, rowObject1.GetFieldValue("124"));
    //     Assert.AreEqual(expected2, rowObject2.GetFieldValue("124"));
    // }

    // [TestMethod]
    // [ExpectedException(typeof(NullReferenceException))]
    // public void GetFieldValueRowObjectNullReturnsError()
    // {
    //     RowObject rowObject = null;
    //     string expected1 = "TEST";
    //     string expected2 = "TESTED";
    //     Assert.AreEqual(expected1, rowObject.GetFieldValue("124"));
    //     Assert.AreEqual(expected2, rowObject.GetFieldValue("124"));
    // }

    #endregion

    #region IsFieldPresent

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

    #endregion

    #region SetFieldValue

    [TestMethod]
    public void TestRowObjectDecorator_SetFieldValueSucceeds()
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
            Fields = [ fieldObject ],
            RowId = "456||1"
        };
        var decorator = new RowObjectDecorator(rowObject);
        decorator.SetFieldValue(fieldNumber, expected);
        Assert.AreEqual(expected, decorator.GetFieldValue(fieldNumber));
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

    #endregion
}