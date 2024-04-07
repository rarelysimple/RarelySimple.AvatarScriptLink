using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.Helpers
{
    [TestClass]
    public class RemoveFieldObjectTests
    {
        [TestMethod]
        public void RemoveFieldObject_RowObject_ByFieldObject()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new(fieldNumber);
            RowObject rowObject = new("1||1");
            rowObject.AddFieldObject(fieldObject);

            rowObject.RemoveFieldObject(fieldObject);

            Assert.IsFalse(rowObject.IsFieldPresent(fieldNumber));
        }

        [TestMethod]
        public void RemoveFieldObject_RowObject_ByFieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new(fieldNumber);
            RowObject rowObject = new("1||1");
            rowObject.AddFieldObject(fieldObject);

            rowObject.RemoveFieldObject(fieldNumber);

            Assert.IsFalse(rowObject.IsFieldPresent(fieldNumber));
        }

        [TestMethod]
        public void RemoveFieldObject_RowObject_ByFieldObject_NotPresent()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new(fieldNumber);
            RowObject rowObject = new("1||1");

            rowObject.RemoveFieldObject(fieldObject);

            Assert.IsFalse(rowObject.IsFieldPresent(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void RemoveFieldObject_RowObject_ByFieldNumber_NotPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new("1||1");

            rowObject.RemoveFieldObject(fieldNumber);

            Assert.IsTrue(rowObject.IsFieldPresent(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void RemoveFieldObject_RowObject_ByFieldObject_Null()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = null;
            RowObject rowObject = new("1||1");

            rowObject.RemoveFieldObject(fieldObject);

            Assert.IsTrue(rowObject.IsFieldPresent(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void RemoveFieldObject_RowObject_ByFieldNumber_Null()
        {
            string fieldNumber = null;
            RowObject rowObject = new("1||1");

            rowObject.RemoveFieldObject(fieldNumber);

            Assert.IsTrue(rowObject.IsFieldPresent(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void RemoveFieldObject_RowObject_Null_ByFieldObject()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new(fieldNumber);
            RowObject rowObject = null;

            rowObject.RemoveFieldObject(fieldObject);

            Assert.IsTrue(rowObject.IsFieldPresent(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void RemoveFieldObject_RowObject_Null_ByFieldNumber()
        {
            string fieldNumber = "123";
            RowObject rowObject = null;

            rowObject.RemoveFieldObject(fieldNumber);

            Assert.IsTrue(rowObject.IsFieldPresent(fieldNumber));
        }

        [TestMethod]
        public void RemoveFieldObject_OptionObjectHelpers_ByFieldObject()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new(fieldNumber);
            RowObject rowObject = new("1||1");
            rowObject.AddFieldObject(fieldObject);

            OptionObjectHelpers.RemoveFieldObject(rowObject, fieldObject);

            Assert.IsFalse(rowObject.IsFieldPresent(fieldNumber));
        }

        [TestMethod]
        public void RemoveFieldObject_OptionObjectHelpers_ByFieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new(fieldNumber);
            RowObject rowObject = new("1||1");
            rowObject.AddFieldObject(fieldObject);

            OptionObjectHelpers.RemoveFieldObject(rowObject, fieldNumber);

            Assert.IsFalse(rowObject.IsFieldPresent(fieldNumber));
        }

        [TestMethod]
        public void RemoveFieldObject_OptionObjectHelpers_ByFieldObject_NotPresent()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new(fieldNumber);
            RowObject rowObject = new("1||1");

            OptionObjectHelpers.RemoveFieldObject(rowObject, fieldObject);

            Assert.IsFalse(rowObject.IsFieldPresent(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void RemoveFieldObject_OptionObjectHelpers_ByFieldNumber_NotPresent()
        {
            string fieldNumber = "123";
            RowObject rowObject = new("1||1");

            OptionObjectHelpers.RemoveFieldObject(rowObject, fieldNumber);

            Assert.IsTrue(rowObject.IsFieldPresent(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void RemoveFieldObject_OptionObjectHelpers_ByFieldObject_Null()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = null;
            RowObject rowObject = new("1||1");

            OptionObjectHelpers.RemoveFieldObject(rowObject, fieldObject);

            Assert.IsTrue(rowObject.IsFieldPresent(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void RemoveFieldObject_OptionObjectHelpers_ByFieldNumber_Null()
        {
            string fieldNumber = null;
            RowObject rowObject = new("1||1");

            OptionObjectHelpers.RemoveFieldObject(rowObject, fieldNumber);

            Assert.IsTrue(rowObject.IsFieldPresent(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void RemoveFieldObject_OptionObjectHelpers_Null_ByFieldObject()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new(fieldNumber);
            RowObject rowObject = null;

            OptionObjectHelpers.RemoveFieldObject(rowObject, fieldObject);

            Assert.IsTrue(rowObject.IsFieldPresent(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void RemoveFieldObject_OptionObjectHelpers_Null_ByFieldNumber()
        {
            string fieldNumber = "123";
            RowObject rowObject = null;

            OptionObjectHelpers.RemoveFieldObject(rowObject, fieldNumber);

            Assert.IsTrue(rowObject.IsFieldPresent(fieldNumber));
        }
    }
}
