using Microsoft.VisualStudio.TestTools.UnitTesting;
using RarelySimple.AvatarScriptLink.Objects;
using System;
using System.Collections.Generic;

namespace RarelySimple.AvatarScriptLink.Tests.ObjectsTests
{
    [TestClass]
    public class OptionObject2Tests
    {
        private OptionObject2 configuredOptionObject2;

        [TestInitialize]
        public void TestInitialize()
        {
            this.configuredOptionObject2 = new OptionObject2();

            FieldObject addField = new FieldObject
            {
                FieldNumber = "123",
                FieldValue = "Value",
                Enabled = "1",
                Lock = "1",
                Required = "1"
            };
            RowObject addRow = new RowObject
            {
                RowId = "1||1"
            };
            addRow.Fields.Add(addField);
            FormObject addForm = new FormObject
            {
                FormId = "1",
                CurrentRow = addRow
            };
            configuredOptionObject2.Forms.Add(addForm);

            FieldObject addMiField01 = new FieldObject
            {
                FieldNumber = "234",
                FieldValue = "MI Value"
            };
            FieldObject addMiField02 = new FieldObject
            {
                FieldNumber = "234",
                FieldValue = "MI Value 2"
            };
            RowObject addMiRow01 = new RowObject
            {
                RowId = "2||1"
            };
            addMiRow01.Fields.Add(addMiField01);
            RowObject addMiRow02 = new RowObject
            {
                RowId = "2||2"
            };
            addMiRow02.Fields.Add(addMiField01);
            FormObject addMiForm = new FormObject
            {
                FormId = "2",
                CurrentRow = addMiRow01,
                MultipleIteration = true
            };
            addMiForm.OtherRows.Add(addMiRow02);
            configuredOptionObject2.Forms.Add(addMiForm);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_HasFormObject()
        {
            OptionObject2 optionObject = new OptionObject2();
            Assert.IsNotNull(optionObject.Forms);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_Forms_IsNotEmpty()
        {
            OptionObject2 optionObject = new OptionObject2();
            var expected = new List<FormObject>();
            var actual = optionObject.Forms;
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_CanGetHtmlString_WithoutHtmlHeaders()
        {
            OptionObject2 optionObject = new OptionObject2();
            var actual = optionObject.ToHtmlString(false);
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_CanGetHtmlString_WithHtmlHeaders()
        {
            OptionObject2 optionObject = new OptionObject2();
            var actual = optionObject.ToHtmlString(false);
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_AddFormObject_FormObject()
        {
            FormObject formObject1 = new FormObject
            {
                FormId = "1",
                MultipleIteration = false
            };
            FormObject formObject2 = new FormObject
            {
                FormId = "2",
                MultipleIteration = true
            };
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject1);
            Assert.AreEqual(1, optionObject.Forms.Count);
            optionObject.AddFormObject(formObject2);
            Assert.AreEqual(2, optionObject.Forms.Count);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void OptionObject2_AddFormObject_FormObject_Exception()
        {
            FormObject formObject1 = new FormObject
            {
                FormId = "1",
                MultipleIteration = false
            };
            FormObject formObject2 = new FormObject
            {
                FormId = "2",
                MultipleIteration = true
            };
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject1);
            Assert.AreEqual(1, optionObject.Forms.Count);
            optionObject.AddFormObject(formObject1);
            Assert.AreEqual(1, optionObject.Forms.Count);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_AddFormObject_Properties()
        {
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject("1", false);
            Assert.AreEqual(1, optionObject.Forms.Count);
            optionObject.AddFormObject("2", true);
            Assert.AreEqual(2, optionObject.Forms.Count);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void OptionObject2_AddFormObject_Properties_Exception()
        {
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject("1", false);
            Assert.AreEqual(1, optionObject.Forms.Count);
            optionObject.AddFormObject("1", false);
            Assert.AreEqual(1, optionObject.Forms.Count);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void OptionObject2_GetCurrentRowId_Error()
        {
            OptionObject2 optionObject = new OptionObject2();
            var actual = optionObject.GetCurrentRowId("1");
            Assert.AreEqual(null, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_GetCurrentRowId_AreEqual()
        {
            RowObject rowObject = new RowObject
            {
                RowId = "1||1"
            };
            FormObject formObject = new FormObject
            {
                FormId = "1",
                CurrentRow = rowObject
            };
            OptionObject2 optionObject = new OptionObject2();
            optionObject.Forms.Add(formObject);
            var actual = optionObject.GetCurrentRowId("1");
            Assert.AreEqual("1||1", actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_GetFieldValue_AreEqual()
        {
            var expected = "Value";
            var actual = configuredOptionObject2.GetFieldValue("123");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void OptionObject2_GetFieldValue_AreNotEqual()
        {
            OptionObject2 optionObject = new OptionObject2();
            var expected = "Value";
            var actual = optionObject.GetFieldValue("123");
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_GetFieldValue_MI_AreEqual()
        {
            var expected = "MI Value";
            var actual = configuredOptionObject2.GetFieldValue("234");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        [ExpectedException(typeof(ArgumentException))]
        public void OptionObject2_GetFieldValue_MI_AreNotEqual()
        {
            var expected = "Value";
            var actual = configuredOptionObject2.GetFieldValue("456");
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_GetFieldValues_AreEqual()
        {
            var expected = "Value";
            var values = configuredOptionObject2.GetFieldValues("123");
            var actual = values.Count > 0 ? values[0] : null;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_GetFieldValues_MI_AreEqual()
        {
            var expected = "MI Value";
            var values = configuredOptionObject2.GetFieldValues("234");
            var actual = values.Count > 0 ? values[0] : null;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_GetFieldValues_AreNotEqual()
        {
            var expected = "Value";
            var values = configuredOptionObject2.GetFieldValues("456");
            var actual = values.Count > 0 ? values[0] : null;
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_GetMultipleIterationStatus_IsFalse()
        {
            OptionObject2 optionObject = new OptionObject2();
            FormObject formObject = new FormObject
            {
                FormId = "1",
                MultipleIteration = false
            };
            optionObject.Forms.Add(formObject);
            var actual = optionObject.GetMultipleIterationStatus("1");
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void OptionObject2_GetMultipleIterationStatus_IsNotFound()
        {
            OptionObject2 optionObject = new OptionObject2();
            var actual = optionObject.GetMultipleIterationStatus("1");
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_GetMultipleIterationStatus_IsTrue()
        {
            var actual = configuredOptionObject2.GetMultipleIterationStatus("2");
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void OptionObject2_GetParentRowId_Error()
        {
            OptionObject2 optionObject = new OptionObject2();
            var actual = optionObject.GetParentRowId("1");
            Assert.AreEqual(null, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_GetParentRowId_AreEqual()
        {
            RowObject rowObject = new RowObject
            {
                ParentRowId = "1||1"
            };
            FormObject formObject = new FormObject
            {
                FormId = "1",
                CurrentRow = rowObject
            };
            OptionObject2 optionObject = new OptionObject2();
            optionObject.Forms.Add(formObject);
            var actual = optionObject.GetParentRowId("1");
            Assert.AreEqual(rowObject.ParentRowId, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_IsFieldPresent_IsTrue()
        {
            var actual = configuredOptionObject2.IsFieldPresent("123");
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_IsFieldPresent_IsFalse()
        {
            var actual = configuredOptionObject2.IsFieldPresent("456");
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_IsFieldEnabled_IsTrue()
        {
            var actual = configuredOptionObject2.IsFieldEnabled("123");
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_IsFieldEnabled_IsFalse()
        {
            var actual = configuredOptionObject2.IsFieldEnabled("234");
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void OptionObject2_IsFieldEnabled_Error()
        {
            var actual = configuredOptionObject2.IsFieldEnabled("456");
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_SetDisabledFields_IsTrue()
        {
            List<string> disabledFields = new List<string> { "123" };
            configuredOptionObject2.SetDisabledFields(disabledFields);
            Assert.IsTrue(!configuredOptionObject2.IsFieldEnabled("123"));
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_IsFieldLocked_IsTrue()
        {
            var actual = configuredOptionObject2.IsFieldLocked("123");
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_IsFieldLocked_IsFalse()
        {
            var actual = configuredOptionObject2.IsFieldLocked("234");
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void OptionObject2_IsFieldLocked_Error()
        {
            var actual = configuredOptionObject2.IsFieldLocked("456");
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_SetUnlockedFields_IsTrue()
        {
            List<string> requiredFields = new List<string> { "123" };
            configuredOptionObject2.SetUnlockedFields(requiredFields);
            Assert.IsTrue(!configuredOptionObject2.IsFieldLocked("123"));
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_SetLockedFields_IsTrue()
        {
            List<string> lockedFields = new List<string> { "123" };
            configuredOptionObject2.SetLockedFields(lockedFields);
            Assert.IsTrue(configuredOptionObject2.IsFieldLocked("123"));
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_IsFieldRequired_IsTrue()
        {
            var actual = configuredOptionObject2.IsFieldRequired("123");
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_IsFieldRequired_AreNotEqual()
        {
            var actual = configuredOptionObject2.IsFieldRequired("234");
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void OptionObject2_IsFieldRequired_Error()
        {
            var actual = configuredOptionObject2.IsFieldRequired("456");
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_SetOptionalFields_IsTrue()
        {
            List<string> optionalFields = new List<string> { "123" };
            configuredOptionObject2.SetOptionalFields(optionalFields);
            Assert.IsTrue(configuredOptionObject2.IsFieldEnabled("123"));
            Assert.IsFalse(configuredOptionObject2.IsFieldRequired("123"));
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_SetRequiredFields_AreEqual()
        {
            List<string> requiredFields = new List<string> { "123" };
            configuredOptionObject2.SetRequiredFields(requiredFields);
            Assert.IsTrue(configuredOptionObject2.IsFieldEnabled("123"));
            Assert.IsTrue(configuredOptionObject2.IsFieldRequired("123"));
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_Constructor_NoForms_AreEqual()
        {
            string entityId = "12345";
            double episodeNumber = 0;
            string facility = "1";
            string namespaceName = "AVPM";
            string optionId = "USER37";
            string optionStaffId = "";
            string optionUserId = "username";
            string parentNamespace = "AVPM";
            string serverName = "server";
            string systemCode = "UAT";
            int formCount = 0;

            OptionObject2 optionObject = new OptionObject2(optionId, optionUserId, optionStaffId
                , facility, entityId, episodeNumber
                , systemCode, namespaceName, parentNamespace, serverName);
            Assert.AreEqual(entityId, optionObject.EntityID);
            Assert.AreEqual(episodeNumber, optionObject.EpisodeNumber);
            Assert.AreEqual(facility, optionObject.Facility);
            Assert.AreEqual(namespaceName, optionObject.NamespaceName);
            Assert.AreEqual(optionId, optionObject.OptionId);
            Assert.AreEqual(optionStaffId, optionObject.OptionStaffId);
            Assert.AreEqual(optionUserId, optionObject.OptionUserId);
            Assert.AreEqual(parentNamespace, optionObject.ParentNamespace);
            Assert.AreEqual(serverName, optionObject.ServerName);
            Assert.AreEqual(systemCode, optionObject.SystemCode);
            Assert.AreEqual(formCount, optionObject.Forms.Count);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_Constructor_WithForms_AreEqual()
        {
            string entityId = "12345";
            double episodeNumber = 0;
            string facility = "1";
            string namespaceName = "AVPM";
            string optionId = "USER37";
            string optionStaffId = "";
            string optionUserId = "username";
            string parentNamespace = "AVPM";
            string serverName = "server";
            string systemCode = "UAT";
            List<FormObject> forms = new List<FormObject>
            {
                new FormObject("1"),
                new FormObject("2")
            };
            int formCount = 2;

            OptionObject2 optionObject = new OptionObject2(optionId, optionUserId, optionStaffId
                , facility, entityId, episodeNumber
                , systemCode, namespaceName, parentNamespace, serverName
                , forms);
            Assert.AreEqual(entityId, optionObject.EntityID);
            Assert.AreEqual(episodeNumber, optionObject.EpisodeNumber);
            Assert.AreEqual(facility, optionObject.Facility);
            Assert.AreEqual(namespaceName, optionObject.NamespaceName);
            Assert.AreEqual(optionId, optionObject.OptionId);
            Assert.AreEqual(optionStaffId, optionObject.OptionStaffId);
            Assert.AreEqual(optionUserId, optionObject.OptionUserId);
            Assert.AreEqual(parentNamespace, optionObject.ParentNamespace);
            Assert.AreEqual(serverName, optionObject.ServerName);
            Assert.AreEqual(systemCode, optionObject.SystemCode);
            Assert.AreEqual(formCount, optionObject.Forms.Count);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_Clone_AreEqual()
        {
            List<FieldObject> fieldObjects = new List<FieldObject>
            {
                new FieldObject("123", "Test")
            };
            RowObject rowObject = new RowObject("1||1", fieldObjects);
            FormObject formObject = new FormObject("1", rowObject);
            OptionObject2 optionObject = new OptionObject2("USER00", "userId", "000111", "1", "123456", 1, "UAT", "AVPM", "AVPM", "SERVER");
            optionObject.AddFormObject(formObject);

            OptionObject2 cloneOptionObject = optionObject.Clone();

            Assert.AreEqual(optionObject, cloneOptionObject);
            Assert.IsTrue(optionObject.IsFieldPresent("123"));
            Assert.IsTrue(cloneOptionObject.IsFieldPresent("123"));
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_ReturnOptionObject_ServerNameReturned()
        {
            List<FieldObject> fieldObjects = new List<FieldObject>
            {
                new FieldObject("123", "Test")
            };
            RowObject rowObject = new RowObject("1||1", fieldObjects);
            FormObject formObject = new FormObject("1", rowObject);
            OptionObject2 optionObject = new OptionObject2("USER00", "userId", "000111", "1", "123456", 1, "UAT", "AVPM", "AVPM", "SERVER");
            optionObject.AddFormObject(formObject);

            OptionObject2 returnOptionObject = optionObject.ToReturnOptionObject();

            Assert.AreEqual(optionObject.ServerName, returnOptionObject.ServerName);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_ReturnOptionObject_AreNotEqual()
        {
            List<FieldObject> fieldObjects = new List<FieldObject>
            {
                new FieldObject("123", "Test")
            };
            RowObject rowObject = new RowObject("1||1", fieldObjects);
            FormObject formObject = new FormObject("1", rowObject);
            OptionObject2 optionObject = new OptionObject2("USER00", "userId", "000111", "1", "123456", 1, "UAT", "AVPM", "AVPM", "SERVER");
            optionObject.AddFormObject(formObject);

            OptionObject2 returnOptionObject = optionObject.ToReturnOptionObject();

            Assert.AreNotEqual(optionObject, returnOptionObject);
            Assert.IsTrue(optionObject.IsFieldPresent("123"));
            Assert.IsFalse(returnOptionObject.IsFieldPresent("123"));
        }
    }
}
