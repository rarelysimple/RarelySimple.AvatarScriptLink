using RarelySimple.AvatarScriptLink.Net.Decorators;
using RarelySimple.AvatarScriptLink.Net.Exceptions;
using RarelySimple.AvatarScriptLink.Objects;
using static RarelySimple.AvatarScriptLink.Objects.RowObject;

namespace RarelySimple.AvatarScriptLink.Net.Tests.Decorators;

[TestClass]
public class RowObjectDecoratorTests
{
    #region Constructor

    [TestMethod]
    public void TestRowObjectDecorator_Constructor_NullRowObject()
    {
        Assert.ThrowsException<ArgumentNullException>(() => new RowObjectDecorator(null));
    }

    #endregion

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

    #endregion

    #region IsFieldEnabled

    [TestMethod]
    public void IsFieldEnabled_RowObject_IsEnabled()
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
        Assert.IsTrue(decorator.IsFieldEnabled("123.45"));
    }

    [TestMethod]
    public void IsFieldEnabled_RowObject_IsNotEnabled()
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
        var decorator = new RowObjectDecorator(rowObject);
        Assert.IsFalse(decorator.IsFieldEnabled("123.45"));
    }

    [TestMethod]
    public void IsFieldEnabled_RowObject_IsNotPresent()
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
        Assert.ThrowsException<FieldObjectNotFoundException>(() => decorator.IsFieldEnabled("678.90"));
    }

    #endregion

    #region IsFieldLocked

    [TestMethod]
    public void IsFieldLocked_RowObject_IsLocked()
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
        var decorator = new RowObjectDecorator(rowObject);
        Assert.IsTrue(decorator.IsFieldLocked("123.45"));
    }

    [TestMethod]
    public void IsFieldLocked_RowObject_IsNotLocked()
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
        var decorator = new RowObjectDecorator(rowObject);
        Assert.IsFalse(decorator.IsFieldLocked("123.45"));
    }

    [TestMethod]
    public void IsFieldLocked_RowObject_IsNotPresent()
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
        Assert.ThrowsException<FieldObjectNotFoundException>(() => decorator.IsFieldLocked("678.90"));
    }

    #endregion

    #region IsFieldModified

    [TestMethod]
    public void IsFieldModified_RowObject_IsFalse()
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
        RowObjectDecorator rowObject01 = new(rowObject);
        Assert.IsFalse(rowObject01.IsFieldModified("123"));
    }

    [TestMethod]
    public void IsFieldModified_RowObject_IsTrue()
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
        RowObjectDecorator rowObject01 = new(rowObject);
        rowObject01.SetFieldValue("123", "MODIFIED");
        Assert.IsTrue(rowObject01.IsFieldModified("123"));
    }

    [TestMethod]
    public void IsFieldModified_RowObject_IsFalse_NullFieldNumber()
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
        RowObjectDecorator rowObject01 = new(rowObject);
        Assert.ThrowsException<ArgumentNullException>(() => rowObject01.IsFieldModified(null));
    }

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

    #region IsFieldRequired

    [TestMethod]
    public void IsFieldRequired_RowObject_IsRequired()
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
        var decorator = new RowObjectDecorator(rowObject);
        Assert.IsTrue(decorator.IsFieldRequired("123.45"));
    }

    [TestMethod]
    public void IsFieldRequired_RowObject_IsNotRequired()
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
        var decorator = new RowObjectDecorator(rowObject);
        Assert.IsFalse(decorator.IsFieldRequired("123.45"));
    }

    [TestMethod]
    public void IsFieldRequired_RowObject_IsNotPresent()
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
        Assert.ThrowsException<FieldObjectNotFoundException>(() => decorator.IsFieldRequired("678.90"));
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