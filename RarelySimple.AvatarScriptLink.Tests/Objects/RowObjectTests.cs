using Microsoft.VisualStudio.TestTools.UnitTesting;
using RarelySimple.AvatarScriptLink.Objects;
using System.Collections.Generic;

namespace RarelySimple.AvatarScriptLink.Tests.ObjectsTests
{
    [TestClass]
    public class RowObjectTests
    {
        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObject_HasFieldsObject()
        {
            RowObject rowObject = new RowObject();
            Assert.IsNotNull(rowObject.Fields);
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObject_FieldsObjectIsNotEmpty()
        {
            RowObject rowObject = new RowObject();
            List<FieldObject> expected = new List<FieldObject>();
            var actual = rowObject.Fields;
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObjects_AreEqual()
        {
            RowObject rowObject1 = new RowObject
            {
                ParentRowId = "1",
                RowAction = "",
                RowId = "1"
            };
            RowObject rowObject2 = new RowObject
            {
                ParentRowId = "1",
                RowAction = "",
                RowId = "1"
            };
            Assert.IsTrue(rowObject1.Equals(rowObject2));
            Assert.IsTrue(rowObject1 == rowObject2);
            Assert.IsFalse(rowObject1 != rowObject2);
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObjects_AreNotEqual()
        {
            RowObject rowObject1 = new RowObject
            {
                ParentRowId = "1",
                RowAction = "",
                RowId = "1"
            };
            RowObject rowObject2 = new RowObject
            {
                ParentRowId = "1",
                RowAction = "",
                RowId = "3"
            };
            Assert.IsFalse(rowObject1.Equals(rowObject2));
            Assert.IsFalse(rowObject1 == rowObject2);
            Assert.IsTrue(rowObject1 != rowObject2);
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObjects_GetFieldValue_AreEqual()
        {
            string expected = "TEST";
            FieldObject fieldObject = new FieldObject
            {
                FieldNumber = "123",
                FieldValue = ""
            };
            RowObject rowObject1 = new RowObject
            {
                ParentRowId = "1",
                RowAction = "",
                RowId = "1"
            };
            rowObject1.Fields.Add(fieldObject);

            rowObject1.SetFieldValue("123", expected);
            string actual = rowObject1.GetFieldValue("123");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObjects_GetFieldValue_AreNotEqual()
        {
            string expected = "TEST";
            FieldObject fieldObject = new FieldObject
            {
                FieldNumber = "123",
                FieldValue = ""
            };
            RowObject rowObject1 = new RowObject
            {
                ParentRowId = "1",
                RowAction = "",
                RowId = "1"
            };
            rowObject1.Fields.Add(fieldObject);

            string actual = rowObject1.GetFieldValue("123");

            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObject_AddFieldObject_FieldObject_Succeeds()
        {
            string fieldNumber = "123";
            string expected = "TEST";
            FieldObject fieldObject = new FieldObject
            {
                Enabled = "1",
                FieldNumber = fieldNumber,
                FieldValue = expected,
                Lock = "0",
                Required = "0"
            };
            RowObject rowObject = new RowObject
            {
                ParentRowId = "",
                RowAction = "",
                RowId = "1||1"
            };
            rowObject.AddFieldObject(fieldObject);
            Assert.AreEqual(expected, rowObject.GetFieldValue(fieldNumber));
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObject_AddFieldObject_Properties_Strings_Succeeds()
        {
            string fieldNumber = "123";
            string expected = "TEST";
            RowObject rowObject = new RowObject
            {
                ParentRowId = "",
                RowAction = "",
                RowId = "1||1"
            };
            rowObject.AddFieldObject(fieldNumber, expected, "1", "0", "0");
            Assert.AreEqual(expected, rowObject.GetFieldValue(fieldNumber));
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObject_AddFieldObject_Properties_Bools_Succeeds()
        {
            string fieldNumber = "123";
            string expected = "TEST";
            RowObject rowObject = new RowObject
            {
                ParentRowId = "",
                RowAction = "",
                RowId = "1||1"
            };
            rowObject.AddFieldObject(fieldNumber, expected, true, false, false);
            Assert.AreEqual(expected, rowObject.GetFieldValue(fieldNumber));
        }

        [TestMethod]
        [TestCategory("RowObject")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void RowObject_AddFieldObject_DoesNotDuplicate()
        {
            string fieldNumber = "123";
            int expected = 1;
            RowObject rowObject = new RowObject
            {
                ParentRowId = "",
                RowAction = "",
                RowId = "1||1"
            };
            rowObject.AddFieldObject(fieldNumber, "TEST", "1", "0", "0");
            Assert.AreEqual("TEST", rowObject.GetFieldValue(fieldNumber));

            rowObject.AddFieldObject(fieldNumber, "TEST", "1", "0", "0");
            int actual = rowObject.Fields.FindAll(f => f.FieldNumber == fieldNumber).Count;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObject_IsFieldEnabled_IsFalse()
        {
            FieldObject fieldObject = new FieldObject
            {
                Enabled = "0",
                FieldNumber = "123",
                FieldValue = "TEST",
                Lock = "0",
                Required = "0"
            };
            RowObject rowObject1 = new RowObject
            {
                ParentRowId = "1",
                RowAction = "",
                RowId = "1"
            };
            rowObject1.Fields.Add(fieldObject);

            Assert.IsFalse(rowObject1.IsFieldEnabled("123"));
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObject_IsFieldEnabled_IsTrue()
        {
            FieldObject fieldObject = new FieldObject
            {
                Enabled = "1",
                FieldNumber = "123",
                FieldValue = "TEST",
                Lock = "0",
                Required = "0"
            };
            RowObject rowObject1 = new RowObject
            {
                ParentRowId = "1",
                RowAction = "",
                RowId = "1"
            };
            rowObject1.Fields.Add(fieldObject);

            Assert.IsTrue(rowObject1.IsFieldEnabled("123"));
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObject_IsFieldLocked_IsFalse()
        {
            FieldObject fieldObject = new FieldObject
            {
                Enabled = "0",
                FieldNumber = "123",
                FieldValue = "TEST",
                Lock = "0",
                Required = "0"
            };
            RowObject rowObject1 = new RowObject
            {
                ParentRowId = "1",
                RowAction = "",
                RowId = "1"
            };
            rowObject1.Fields.Add(fieldObject);

            Assert.IsFalse(rowObject1.IsFieldLocked("123"));
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObject_IsFieldLocked_IsTrue()
        {
            FieldObject fieldObject = new FieldObject
            {
                Enabled = "1",
                FieldNumber = "123",
                FieldValue = "TEST",
                Lock = "1",
                Required = "0"
            };
            RowObject rowObject1 = new RowObject
            {
                ParentRowId = "1",
                RowAction = "",
                RowId = "1"
            };
            rowObject1.Fields.Add(fieldObject);

            Assert.IsTrue(rowObject1.IsFieldLocked("123"));
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObject_IsFieldPresent_IsFalse()
        {
            FieldObject fieldObject = new FieldObject
            {
                Enabled = "0",
                FieldNumber = "123",
                FieldValue = "TEST",
                Lock = "0",
                Required = "0"
            };
            RowObject rowObject1 = new RowObject
            {
                ParentRowId = "1",
                RowAction = "",
                RowId = "1"
            };
            rowObject1.Fields.Add(fieldObject);

            Assert.IsFalse(rowObject1.IsFieldPresent("234"));
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObject_IsFieldPresent_IsTrue()
        {
            FieldObject fieldObject = new FieldObject
            {
                Enabled = "1",
                FieldNumber = "123",
                FieldValue = "TEST",
                Lock = "0",
                Required = "0"
            };
            RowObject rowObject1 = new RowObject
            {
                ParentRowId = "1",
                RowAction = "",
                RowId = "1"
            };
            rowObject1.Fields.Add(fieldObject);

            Assert.IsTrue(rowObject1.IsFieldPresent("123"));
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObject_IsFieldRequired_IsFalse()
        {
            FieldObject fieldObject = new FieldObject
            {
                Enabled = "0",
                FieldNumber = "123",
                FieldValue = "TEST",
                Lock = "0",
                Required = "0"
            };
            RowObject rowObject1 = new RowObject
            {
                ParentRowId = "1",
                RowAction = "",
                RowId = "1"
            };
            rowObject1.Fields.Add(fieldObject);

            Assert.IsFalse(rowObject1.IsFieldRequired("123"));
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObject_IsFieldRequired_IsTrue()
        {
            FieldObject fieldObject = new FieldObject
            {
                Enabled = "1",
                FieldNumber = "123",
                FieldValue = "TEST",
                Lock = "0",
                Required = "1"
            };
            RowObject rowObject1 = new RowObject
            {
                ParentRowId = "1",
                RowAction = "",
                RowId = "1"
            };
            rowObject1.Fields.Add(fieldObject);

            Assert.IsTrue(rowObject1.IsFieldRequired("123"));
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObject_RemoveFieldObject_ByObject()
        {
            FieldObject fieldObject1 = new FieldObject
            {
                Enabled = "1",
                FieldNumber = "123",
                FieldValue = "TEST",
                Lock = "0",
                Required = "1"
            };
            FieldObject fieldObject2 = new FieldObject
            {
                Enabled = "1",
                FieldNumber = "124",
                FieldValue = "TEST",
                Lock = "0",
                Required = "1"
            };
            FieldObject fieldObject3 = new FieldObject
            {
                Enabled = "1",
                FieldNumber = "125",
                FieldValue = "TEST",
                Lock = "0",
                Required = "1"
            };
            RowObject rowObject1 = new RowObject
            {
                ParentRowId = "1",
                RowAction = "",
                RowId = "1"
            };
            rowObject1.Fields.Add(fieldObject1);
            rowObject1.Fields.Add(fieldObject2);
            rowObject1.Fields.Add(fieldObject3);
            
            rowObject1.RemoveFieldObject(fieldObject2);

            Assert.AreEqual(2, rowObject1.Fields.Count);
            Assert.IsFalse(rowObject1.Fields.Contains(fieldObject2));
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObject_RemoveFieldObject_ByFieldNumber()
        {
            FieldObject fieldObject1 = new FieldObject
            {
                Enabled = "1",
                FieldNumber = "123",
                FieldValue = "TEST",
                Lock = "0",
                Required = "1"
            };
            FieldObject fieldObject2 = new FieldObject
            {
                Enabled = "1",
                FieldNumber = "124",
                FieldValue = "TEST",
                Lock = "0",
                Required = "1"
            };
            FieldObject fieldObject3 = new FieldObject
            {
                Enabled = "1",
                FieldNumber = "125",
                FieldValue = "TEST",
                Lock = "0",
                Required = "1"
            };
            RowObject rowObject1 = new RowObject
            {
                ParentRowId = "1",
                RowAction = "",
                RowId = "1"
            };
            rowObject1.Fields.Add(fieldObject1);
            rowObject1.Fields.Add(fieldObject2);
            rowObject1.Fields.Add(fieldObject3);

            rowObject1.RemoveFieldObject(fieldObject2.FieldNumber);

            Assert.AreEqual(2, rowObject1.Fields.Count);
            Assert.IsFalse(rowObject1.Fields.Contains(fieldObject2));
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObject_CanGetHtmlString_WithoutHtmlHeaders()
        {
            RowObject rowObject = new RowObject();
            var actual = rowObject.ToHtmlString(false);
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObject_CanGetHtmlString_WithHtmlHeaders()
        {
            RowObject rowObject = new RowObject();
            var actual = rowObject.ToHtmlString(false);
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObject_Constructor_1Parameter_NoError()
        {
            string rowId = "1||1";
            RowObject rowObject = new RowObject(rowId);
            Assert.AreEqual(rowId, rowObject.RowId);
            Assert.AreEqual("", rowObject.ParentRowId);
            Assert.AreEqual("", rowObject.RowAction);
            Assert.AreEqual(0, rowObject.Fields.Count);
        }

        [TestMethod]
        [TestCategory("RowObject")]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void RowObject_Constructor_1Parameter_Error()
        {
            string rowId = "";
            RowObject rowObject = new RowObject(rowId);
            Assert.AreEqual(rowId, rowObject.RowId);
            Assert.AreEqual("", rowObject.ParentRowId);
            Assert.AreEqual("", rowObject.RowAction);
            Assert.AreEqual(0, rowObject.Fields.Count);
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObject_Constructor_2Parameter_NoError()
        {
            string rowId = "1||1";
            string parentRowId = "2||1";
            RowObject rowObject = new RowObject(rowId, parentRowId);
            Assert.AreEqual(rowId, rowObject.RowId);
            Assert.AreEqual(parentRowId, rowObject.ParentRowId);
            Assert.AreEqual("", rowObject.RowAction);
            Assert.AreEqual(0, rowObject.Fields.Count);
        }

        [TestMethod]
        [TestCategory("RowObject")]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void RowObject_Constructor_2Parameter_Error()
        {
            string rowId = "";
            string parentRowId = "2||1";
            RowObject rowObject = new RowObject(rowId, parentRowId);
            Assert.AreEqual(rowId, rowObject.RowId);
            Assert.AreEqual(parentRowId, rowObject.ParentRowId);
            Assert.AreEqual("", rowObject.RowAction);
            Assert.AreEqual(0, rowObject.Fields.Count);
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObject_Constructor_3Parameter_NoError()
        {
            string rowId = "1||1";
            string parentRowId = "2||1";
            string rowAction = RowAction.Delete;
            RowObject rowObject = new RowObject(rowId, parentRowId, rowAction);
            Assert.AreEqual(rowId, rowObject.RowId);
            Assert.AreEqual(parentRowId, rowObject.ParentRowId);
            Assert.AreEqual(rowAction, rowObject.RowAction);
            Assert.AreEqual(0, rowObject.Fields.Count);
        }

        [TestMethod]
        [TestCategory("RowObject")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void RowObject_Constructor_3Parameter_Error()
        {
            string rowId = "1||1";
            string parentRowId = "2||1";
            string rowAction = "NONE";
            RowObject rowObject = new RowObject(rowId, parentRowId, rowAction);
            Assert.AreEqual(rowId, rowObject.RowId);
            Assert.AreEqual(parentRowId, rowObject.ParentRowId);
            Assert.AreEqual("", rowObject.RowAction);
            Assert.AreEqual(0, rowObject.Fields.Count);
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObject_Constructor_2Parameter_List_NoError()
        {
            string rowId = "1||1";
            FieldObject fieldObject1 = new FieldObject("123.45");
            FieldObject fieldObject2 = new FieldObject("123.46");
            List<FieldObject> fieldObjects = new List<FieldObject>
            {
                fieldObject1,
                fieldObject2
            };
            RowObject rowObject = new RowObject(rowId, fieldObjects);
            Assert.AreEqual(rowId, rowObject.RowId);
            Assert.AreEqual("", rowObject.ParentRowId);
            Assert.AreEqual("", rowObject.RowAction);
            Assert.AreEqual(2, rowObject.Fields.Count);
        }

        [TestMethod]
        [TestCategory("RowObject")]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void RowObject_Constructor_2Parameter_List_Error()
        {
            string rowId = "";
            FieldObject fieldObject1 = new FieldObject("123.45");
            FieldObject fieldObject2 = new FieldObject("123.46");
            List<FieldObject> fieldObjects = new List<FieldObject>
            {
                fieldObject1,
                fieldObject2
            };
            RowObject rowObject = new RowObject(rowId, fieldObjects);
            Assert.AreEqual(rowId, rowObject.RowId);
            Assert.AreEqual("", rowObject.ParentRowId);
            Assert.AreEqual("", rowObject.RowAction);
            Assert.AreEqual(0, rowObject.Fields.Count);
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObject_Constructor_3Parameter_List_NoError()
        {
            string rowId = "1||1";
            string parentRowId = "2||1";
            FieldObject fieldObject1 = new FieldObject("123.45");
            FieldObject fieldObject2 = new FieldObject("123.46");
            List<FieldObject> fieldObjects = new List<FieldObject>
            {
                fieldObject1,
                fieldObject2
            };
            RowObject rowObject = new RowObject(rowId, fieldObjects, parentRowId);
            Assert.AreEqual(rowId, rowObject.RowId);
            Assert.AreEqual(parentRowId, rowObject.ParentRowId);
            Assert.AreEqual("", rowObject.RowAction);
            Assert.AreEqual(2, rowObject.Fields.Count);
        }

        [TestMethod]
        [TestCategory("RowObject")]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void RowObject_Constructor_3Parameter_List_Error()
        {
            string rowId = "";
            string parentRowId = "2||1";
            FieldObject fieldObject1 = new FieldObject("123.45");
            FieldObject fieldObject2 = new FieldObject("123.46");
            List<FieldObject> fieldObjects = new List<FieldObject>
            {
                fieldObject1,
                fieldObject2
            };
            RowObject rowObject = new RowObject(rowId, fieldObjects, parentRowId);
            Assert.AreEqual(rowId, rowObject.RowId);
            Assert.AreEqual(parentRowId, rowObject.ParentRowId);
            Assert.AreEqual("", rowObject.RowAction);
            Assert.AreEqual(0, rowObject.Fields.Count);
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObject_Constructor_4Parameter_List_NoError()
        {
            string rowId = "1||1";
            string parentRowId = "2||1";
            string rowAction = RowAction.Delete;
            FieldObject fieldObject1 = new FieldObject("123.45");
            FieldObject fieldObject2 = new FieldObject("123.46");
            List<FieldObject> fieldObjects = new List<FieldObject>
            {
                fieldObject1,
                fieldObject2
            };
            RowObject rowObject = new RowObject(rowId, fieldObjects, parentRowId, rowAction);
            Assert.AreEqual(rowId, rowObject.RowId);
            Assert.AreEqual(parentRowId, rowObject.ParentRowId);
            Assert.AreEqual(rowAction, rowObject.RowAction);
            Assert.AreEqual(2, rowObject.Fields.Count);
        }

        [TestMethod]
        [TestCategory("RowObject")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void RowObject_Constructor_4Parameter_List_Error()
        {
            string rowId = "1||1";
            string parentRowId = "2||1";
            string rowAction = "NONE";
            FieldObject fieldObject1 = new FieldObject("123.45");
            FieldObject fieldObject2 = new FieldObject("123.46");
            List<FieldObject> fieldObjects = new List<FieldObject>
            {
                fieldObject1,
                fieldObject2
            };
            RowObject rowObject = new RowObject(rowId, fieldObjects, parentRowId, rowAction);
            Assert.AreEqual(rowId, rowObject.RowId);
            Assert.AreEqual(parentRowId, rowObject.ParentRowId);
            Assert.AreEqual(rowAction, rowObject.RowAction);
            Assert.AreEqual(0, rowObject.Fields.Count);
        }

        [TestMethod]
        public void RowObject_Clone_AreEqual()
        {
            List<FieldObject> fieldObjects = new List<FieldObject>
            {
                new FieldObject("123", "Test")
            };
            RowObject rowObject = new RowObject("1||1", fieldObjects);

            RowObject cloneObject = rowObject.Clone();

            Assert.AreEqual(rowObject.ToJson(), cloneObject.ToJson());
            Assert.AreEqual(rowObject, cloneObject);
            Assert.IsTrue(rowObject.IsFieldPresent("123"));
            Assert.IsTrue(cloneObject.IsFieldPresent("123"));
        }

        [TestMethod]
        public void RowObject_Clone_AreNotEqual()
        {
            List<FieldObject> fieldObjects = new List<FieldObject>
            {
                new FieldObject("123", "Test")
            };
            RowObject rowObject = new RowObject("1||1", fieldObjects);

            RowObject cloneObject = rowObject.Clone();
            rowObject.RemoveFieldObject("123");

            Assert.AreNotEqual(rowObject.ToJson(), cloneObject.ToJson());
            Assert.AreNotEqual(rowObject, cloneObject);
            Assert.IsFalse(rowObject.IsFieldPresent("123"));
            Assert.IsTrue(cloneObject.IsFieldPresent("123"));
        }
    }
}
