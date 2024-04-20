using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.ObjectsTests
{
    [TestClass]
    public class RowObjectTests
    {
        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObject_HasFieldsObject()
        {
            RowObject rowObject = new();
            Assert.IsNotNull(rowObject.Fields);
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObject_FieldsObjectIsEmpty()
        {
            RowObject rowObject = RowObject.Initialize();
            List<FieldObject> expected = [];
            var actual = rowObject.Fields;
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObjects_AreEqual()
        {
            RowObject rowObject1 = RowObject.Builder()
                .RowId("1")
                .ParentRowId("1")
                .Build();
            RowObject rowObject2 = new()
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
            RowObject rowObject1 = RowObject.Builder()
                .RowId("1")
                .ParentRowId("1")
                .Build();
            RowObject rowObject2 = new()
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
            RowObject rowObject1 = RowObject.Builder()
                .RowId("1")
                .ParentRowId("1")
                .Field().FieldNumber("123").AddField()
                .Build();

            rowObject1.SetFieldValue("123", expected);
            string actual = rowObject1.GetFieldValue("123");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObjects_GetFieldValue_AreNotEqual()
        {
            string fieldNumber = "123";
            string expected = "TEST";
            FieldObject fieldObject = FieldObject.Builder()
                .FieldNumber(fieldNumber)
                .FieldValue("")
                .Build();
            RowObject rowObject1 = RowObject.Builder()
                .RowId("1")
                .ParentRowId("1")
                .Field(fieldObject)
                .Build();

            string actual = rowObject1.GetFieldValue(fieldNumber);

            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObject_AddFieldObject_FieldObject_Succeeds()
        {
            string fieldNumber = "123";
            string expected = "TEST";
            FieldObject fieldObject = FieldObject.Builder()
                .FieldNumber(fieldNumber)
                .FieldValue(expected)
                .Enabled()
                .Build();
            RowObject rowObject = RowObject.Builder()
                .RowId("1||1")
                .Build();

            rowObject.AddFieldObject(fieldObject);

            Assert.AreEqual(expected, rowObject.GetFieldValue(fieldNumber));
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObject_AddFieldObject_Properties_Strings_Succeeds()
        {
            string fieldNumber = "123";
            string expected = "TEST";
            RowObject rowObject = RowObject.Builder().RowId("1||1").Build();
            rowObject.AddFieldObject(fieldNumber, expected, "1", "0", "0");
            Assert.AreEqual(expected, rowObject.GetFieldValue(fieldNumber));
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObject_AddFieldObject_Properties_Bools_Succeeds()
        {
            string fieldNumber = "123";
            string expected = "TEST";
            RowObject rowObject = RowObject.Builder().RowId("1||1").Build();
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
            RowObject rowObject = RowObject.Builder().RowId("1||1").Build();
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
            string fieldNumber = "123";
            RowObject rowObject1 = RowObject.Builder()
                .RowId("1")
                .ParentRowId("1")
                .Field().FieldNumber(fieldNumber).FieldValue("TEST").AddField()
                .Build();

            Assert.IsFalse(rowObject1.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObject_IsFieldEnabled_IsTrue()
        {
            string fieldNumber = "123";
            RowObject rowObject1 = RowObject.Builder()
                .RowId("1")
                .ParentRowId("1")
                .Field().FieldNumber(fieldNumber).FieldValue("TEST").Enabled().AddField()
                .Build();

            Assert.IsTrue(rowObject1.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObject_IsFieldLocked_IsFalse()
        {
            string fieldNumber = "123";
            RowObject rowObject1 = RowObject.Builder()
                .RowId("1")
                .ParentRowId("1")
                .Field().FieldNumber(fieldNumber).FieldValue("TEST").AddField()
                .Build();

            Assert.IsFalse(rowObject1.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObject_IsFieldLocked_IsTrue()
        {
            string fieldNumber = "123";
            RowObject rowObject1 = RowObject.Builder()
                .RowId("1")
                .ParentRowId("1")
                .Field().FieldNumber(fieldNumber).FieldValue("TEST").Locked().AddField()
                .Build();

            Assert.IsTrue(rowObject1.IsFieldLocked(fieldNumber));
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObject_IsFieldPresent_IsFalse()
        {
            string fieldNumber = "123";
            RowObject rowObject1 = RowObject.Builder()
                .RowId("1")
                .ParentRowId("1")
                .Field().FieldNumber(fieldNumber).FieldValue("TEST").AddField()
                .Build();

            Assert.IsFalse(rowObject1.IsFieldPresent("234"));
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObject_IsFieldPresent_IsTrue()
        {
            string fieldNumber = "123";
            RowObject rowObject1 = RowObject.Builder()
                .RowId("1")
                .ParentRowId("1")
                .Field().FieldNumber(fieldNumber).FieldValue("TEST").AddField()
                .Build();

            Assert.IsTrue(rowObject1.IsFieldPresent(fieldNumber));
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObject_IsFieldRequired_IsFalse()
        {
            string fieldNumber = "123";
            RowObject rowObject1 = RowObject.Builder()
                .RowId("1")
                .ParentRowId("1")
                .Field().FieldNumber(fieldNumber).FieldValue("TEST").AddField()
                .Build();

            Assert.IsFalse(rowObject1.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObject_IsFieldRequired_IsTrue()
        {
            string fieldNumber = "123";
            RowObject rowObject1 = RowObject.Builder()
                .RowId("1")
                .ParentRowId("1")
                .Field().FieldNumber(fieldNumber).FieldValue("TEST").Required().AddField()
                .Build();

            Assert.IsTrue(rowObject1.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObject_RemoveFieldObject_ByObject()
        {
            FieldObject fieldObject2 = FieldObject.Builder()
                .FieldNumber("124").FieldValue("TEST")
                .Enabled().Required()
                .Build();
            RowObject rowObject1 = RowObject.Builder()
                .RowId("1")
                .ParentRowId("1")
                .Field().FieldNumber("123").FieldValue("TEST").Enabled().Required().AddField()
                .Field(fieldObject2)
                .Field().FieldNumber("125").FieldValue("TEST").Enabled().Required().AddField()
                .Build();
            
            rowObject1.RemoveFieldObject(fieldObject2);

            Assert.AreEqual(2, rowObject1.Fields.Count);
            Assert.IsFalse(rowObject1.Fields.Contains(fieldObject2));
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObject_RemoveFieldObject_ByFieldNumber()
        {
            FieldObject fieldObject2 = FieldObject.Builder()
                .FieldNumber("124").FieldValue("TEST")
                .Enabled().Required()
                .Build();
            RowObject rowObject1 = RowObject.Builder()
                .RowId("1")
                .ParentRowId("1")
                .Field().FieldNumber("123").FieldValue("TEST").Enabled().Required().AddField()
                .Field(fieldObject2)
                .Field().FieldNumber("125").FieldValue("TEST").Enabled().Required().AddField()
                .Build();

            rowObject1.RemoveFieldObject(fieldObject2.FieldNumber);

            Assert.AreEqual(2, rowObject1.Fields.Count);
            Assert.IsFalse(rowObject1.Fields.Contains(fieldObject2));
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObject_CanGetHtmlString_WithoutHtmlHeaders()
        {
            RowObject rowObject = new();
            var actual = rowObject.ToHtmlString(false);
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObject_CanGetHtmlString_WithHtmlHeaders()
        {
            RowObject rowObject = new();
            var actual = rowObject.ToHtmlString(false);
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObject_Constructor_1Parameter_NoError()
        {
            string rowId = "1||1";
            RowObject rowObject = new(rowId);
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
            RowObject rowObject = new(rowId);
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
            RowObject rowObject = new(rowId, parentRowId);
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
            RowObject rowObject = new(rowId, parentRowId);
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
            RowObject rowObject = new(rowId, parentRowId, rowAction);
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
            RowObject rowObject = new(rowId, parentRowId, rowAction);
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
            FieldObject fieldObject1 = new("123.45");
            FieldObject fieldObject2 = new("123.46");
            List<FieldObject> fieldObjects =
            [
                fieldObject1,
                fieldObject2
            ];
            RowObject rowObject = new(rowId, fieldObjects);
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
            FieldObject fieldObject1 = new("123.45");
            FieldObject fieldObject2 = new("123.46");
            List<FieldObject> fieldObjects =
            [
                fieldObject1,
                fieldObject2
            ];
            RowObject rowObject = new(rowId, fieldObjects);
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
            FieldObject fieldObject1 = new("123.45");
            FieldObject fieldObject2 = new("123.46");
            List<FieldObject> fieldObjects =
            [
                fieldObject1,
                fieldObject2
            ];
            RowObject rowObject = new(rowId, fieldObjects, parentRowId);
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
            FieldObject fieldObject1 = new("123.45");
            FieldObject fieldObject2 = new("123.46");
            List<FieldObject> fieldObjects =
            [
                fieldObject1,
                fieldObject2
            ];
            RowObject rowObject = new(rowId, fieldObjects, parentRowId);
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
            FieldObject fieldObject1 = new("123.45");
            FieldObject fieldObject2 = new("123.46");
            List<FieldObject> fieldObjects =
            [
                fieldObject1,
                fieldObject2
            ];
            RowObject rowObject = new(rowId, fieldObjects, parentRowId, rowAction);
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
            FieldObject fieldObject1 = new("123.45");
            FieldObject fieldObject2 = new("123.46");
            List<FieldObject> fieldObjects =
            [
                fieldObject1,
                fieldObject2
            ];
            RowObject rowObject = new(rowId, fieldObjects, parentRowId, rowAction);
            Assert.AreEqual(rowId, rowObject.RowId);
            Assert.AreEqual(parentRowId, rowObject.ParentRowId);
            Assert.AreEqual(rowAction, rowObject.RowAction);
            Assert.AreEqual(0, rowObject.Fields.Count);
        }

        [TestMethod]
        public void RowObject_Clone_AreEqual()
        {
            RowObject rowObject = RowObject.Builder()
                .RowId("1||1")
                .Field().FieldNumber("123").FieldValue("Test").AddField()
                .Field().FieldNumber("124").FieldValue("Test 2").AddField()
                .Build();

            RowObject cloneObject = rowObject.Clone();

            Assert.AreEqual(rowObject.ToJson(), cloneObject.ToJson());
            Assert.AreEqual(rowObject, cloneObject);
            Assert.IsTrue(rowObject.IsFieldPresent("123"));
            Assert.IsTrue(cloneObject.IsFieldPresent("123"));
        }

        [TestMethod]
        public void RowObject_Clone_AreNotEqual()
        {
            RowObject rowObject = RowObject.Builder()
                .RowId("1||1")
                .Field().FieldNumber("123").FieldValue("Test").AddField()
                .Field().FieldNumber("124").FieldValue("Test 2").AddField()
                .Build();

            RowObject cloneObject = rowObject.Clone();
            rowObject.RemoveFieldObject("123");

            Assert.AreNotEqual(rowObject.ToJson(), cloneObject.ToJson());
            Assert.AreNotEqual(rowObject, cloneObject);
            Assert.IsFalse(rowObject.IsFieldPresent("123"));
            Assert.IsTrue(cloneObject.IsFieldPresent("123"));
        }

        [TestMethod]
        public void RowObject_Builder_ActionIsAdd()
        {
            RowObject rowObject = RowObject.Builder()
                .RowId("1||1")
                .Add()
                .Build();
            Assert.AreEqual(RowAction.Add, rowObject.RowAction);
        }

        [TestMethod]
        public void RowObject_Builder_ActionIsDelete()
        {
            RowObject rowObject = RowObject.Builder()
                .RowId("1||1")
                .Delete()
                .Build();
            Assert.AreEqual(RowAction.Delete, rowObject.RowAction);
        }

        [TestMethod]
        public void RowObject_Builder_ActionIsEdit()
        {
            RowObject rowObject = RowObject.Builder()
                .RowId("1||1")
                .Edit()
                .Build();
            Assert.AreEqual(RowAction.Edit, rowObject.RowAction);
        }

        [TestMethod]
        public void RowObject_Builder_ActionIsNone()
        {
            RowObject rowObject = RowObject.Builder()
                .RowId("1||1")
                .Build();
            Assert.AreEqual(RowAction.None, rowObject.RowAction);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void RowObject_Builder_RowIdNull()
        {
            _ = RowObject.Builder().RowId(null).Build();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void RowObject_Builder_FieldNumberNull()
        {
            _ = RowObject.Builder().RowId("1||1").Field().FieldNumber(null).AddField().Build();
        }

        [TestMethod]
        public void RowObject_Builder_FieldIsModified()
        {
            string fieldNumber = "123.45";
            RowObject rowObject = RowObject.Builder().RowId("1||1").Field().FieldNumber(fieldNumber).Modified().AddField().Build();
            Assert.IsTrue(rowObject.IsFieldModified(fieldNumber));
        }
    }
}
