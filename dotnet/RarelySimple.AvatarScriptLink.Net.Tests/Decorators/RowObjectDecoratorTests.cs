using RarelySimple.AvatarScriptLink.Net.Decorators;
using RarelySimple.AvatarScriptLink.Net.Exceptions;
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
    // [ExpectedException(typeof(ArgumentNullException))]
    // public void GetFieldValueRowObjectNullReturnsError()
    // {
    //     RowObject rowObject = null;
    //     string expected1 = "TEST";
    //     string expected2 = "TESTED";
    //     Assert.AreEqual(expected1, rowObject.GetFieldValue("124"));
    //     Assert.AreEqual(expected2, rowObject.GetFieldValue("124"));
    // }

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
    [ExpectedException(typeof(FieldObjectNotFoundException))]
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
        Assert.IsFalse(decorator.IsFieldEnabled("678.90"));
    }

    [TestMethod]
    [ExpectedException(typeof(NullReferenceException))]
    public void IsFieldEnabled_RowObject_Null()
    {
        var decorator = new RowObjectDecorator(null);
        Assert.IsFalse(decorator.IsFieldEnabled("123.45"));
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
    [ExpectedException(typeof(FieldObjectNotFoundException))]
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
        Assert.IsFalse(decorator.IsFieldLocked("678.90"));
    }

    [TestMethod]
    [ExpectedException(typeof(NullReferenceException))]
    public void IsFieldLocked_RowObject_Null()
    {
        var decorator = new RowObjectDecorator(null);
        Assert.IsFalse(decorator.IsFieldLocked("123.45"));
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

    [TestMethod]
    [ExpectedException(typeof(NullReferenceException))]
    public void IsFieldPresent_RowObject_Null()
    {
        var decorator = new RowObjectDecorator(null);
        Assert.IsFalse(decorator.IsFieldPresent("123.45"));
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
    [ExpectedException(typeof(FieldObjectNotFoundException))]
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
        Assert.IsFalse(decorator.IsFieldRequired("678.90"));
    }

    [TestMethod]
    [ExpectedException(typeof(NullReferenceException))]
    public void IsFieldRequired_RowObject_Null()
    {
        var decorator = new RowObjectDecorator(null);
        Assert.IsFalse(decorator.IsFieldRequired("123.45"));
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