using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RarelySimple.AvatarScriptLink.Objects;
using System.Collections.Generic;

namespace RarelySimple.AvatarScriptLink.Tests.ObjectsTests
{
    [TestClass]
    public class OptionObject2015Tests
    {
        private OptionObject2015 configuredOptionObject2015;

        [TestInitialize]
        public void TestInitialize()
        {
            this.configuredOptionObject2015 = new OptionObject2015();

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
            configuredOptionObject2015.Forms.Add(addForm);

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
            configuredOptionObject2015.Forms.Add(addMiForm);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015_HasFormObject()
        {
            OptionObject2015 optionObject = new OptionObject2015();
            Assert.IsNotNull(optionObject.Forms);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015_Forms_IsNotEmpty()
        {
            OptionObject2015 optionObject = new OptionObject2015();
            var expected = new List<FormObject>();
            var actual = optionObject.Forms;
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015_CanGetHtmlString_WithoutHtmlHeaders()
        {
            OptionObject2015 optionObject = new OptionObject2015();
            var actual = optionObject.ToHtmlString(false);
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015_CanGetHtmlString_WithHtmlHeaders()
        {
            OptionObject2015 optionObject = new OptionObject2015();
            var actual = optionObject.ToHtmlString(false);
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015_AddFormObject_FormObject()
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
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject1);
            Assert.AreEqual(1, optionObject.Forms.Count);
            optionObject.AddFormObject(formObject2);
            Assert.AreEqual(2, optionObject.Forms.Count);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void OptionObject2015_AddFormObject_FormObject_Exception()
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
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject1);
            Assert.AreEqual(1, optionObject.Forms.Count);
            optionObject.AddFormObject(formObject1);
            Assert.AreEqual(1, optionObject.Forms.Count);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015_AddFormObject_Properties()
        {
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject("1", false);
            Assert.AreEqual(1, optionObject.Forms.Count);
            optionObject.AddFormObject("2", true);
            Assert.AreEqual(2, optionObject.Forms.Count);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void OptionObject2015_AddFormObject_Properties_Exception()
        {
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject("1", false);
            Assert.AreEqual(1, optionObject.Forms.Count);
            optionObject.AddFormObject("1", false);
            Assert.AreEqual(1, optionObject.Forms.Count);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void OptionObject2015_GetCurrentRowId_Error()
        {
            OptionObject2015 optionObject = new OptionObject2015();
            var actual = optionObject.GetCurrentRowId("1");
            Assert.AreEqual(null, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015_GetCurrentRowId_AreEqual()
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
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.Forms.Add(formObject);
            var actual = optionObject.GetCurrentRowId("1");
            Assert.AreEqual("1||1", actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015_GetFieldValue_AreEqual()
        {
            var expected = "Value";
            var actual = configuredOptionObject2015.GetFieldValue("123");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void OptionObject2015_GetFieldValue_AreNotEqual()
        {
            OptionObject2015 optionObject = new OptionObject2015();
            var expected = "Value";
            var actual = optionObject.GetFieldValue("123");
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015_GetFieldValue_MI_AreEqual()
        {
            var expected = "MI Value";
            var actual = configuredOptionObject2015.GetFieldValue("234");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        [ExpectedException(typeof(ArgumentException))]
        public void OptionObject2015_GetFieldValue_MI_AreNotEqual()
        {
            var expected = "Value";
            var actual = configuredOptionObject2015.GetFieldValue("456");
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015_GetFieldValues_AreEqual()
        {
            var expected = "Value";
            var values = configuredOptionObject2015.GetFieldValues("123");
            var actual = values.Count > 0 ? values[0] : null;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015_GetFieldValues_MI_AreEqual()
        {
            var expected = "MI Value";
            var values = configuredOptionObject2015.GetFieldValues("234");
            var actual = values.Count > 0 ? values[0] : null;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015_GetFieldValues_AreNotEqual()
        {
            var expected = "Value";
            var values = configuredOptionObject2015.GetFieldValues("456");
            var actual = values.Count > 0 ? values[0] : null;
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015_GetMultipleIterationStatus_IsFalse()
        {
            OptionObject2015 optionObject = new OptionObject2015();
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
        [TestCategory("OptionObject2015")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void OptionObject2015_GetMultipleIterationStatus_IsNotFound()
        {
            OptionObject2015 optionObject = new OptionObject2015();
            var actual = optionObject.GetMultipleIterationStatus("1");
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015_GetMultipleIterationStatus_IsTrue()
        {
            var actual = configuredOptionObject2015.GetMultipleIterationStatus("2");
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void OptionObject2015_GetParentRowId_Error()
        {
            OptionObject2015 optionObject = new OptionObject2015();
            var actual = optionObject.GetParentRowId("1");
            Assert.AreEqual(null, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015_GetParentRowId_AreEqual()
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
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.Forms.Add(formObject);
            var actual = optionObject.GetParentRowId("1");
            Assert.AreEqual(rowObject.ParentRowId, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015_IsFieldPresent_IsTrue()
        {
            var actual = configuredOptionObject2015.IsFieldPresent("123");
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015_IsFieldPresent_IsFalse()
        {
            var actual = configuredOptionObject2015.IsFieldPresent("456");
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015_IsFieldEnabled_IsTrue()
        {
            var actual = configuredOptionObject2015.IsFieldEnabled("123");
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015_IsFieldEnabled_IsFalse()
        {
            var actual = configuredOptionObject2015.IsFieldEnabled("234");
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void OptionObject2015_IsFieldEnabled_Error()
        {
            var actual = configuredOptionObject2015.IsFieldEnabled("456");
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015_SetDisabledFields_IsTrue()
        {
            List<string> disabledFields = new List<string> { "123" };
            configuredOptionObject2015.SetDisabledFields(disabledFields);
            Assert.IsTrue(!configuredOptionObject2015.IsFieldEnabled("123"));
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015_IsFieldLocked_IsTrue()
        {
            var actual = configuredOptionObject2015.IsFieldLocked("123");
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015_IsFieldLocked_IsFalse()
        {
            var actual = configuredOptionObject2015.IsFieldLocked("234");
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void OptionObject2015_IsFieldLocked_Error()
        {
            var actual = configuredOptionObject2015.IsFieldLocked("456");
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015_SetUnlockedFields_IsTrue()
        {
            List<string> requiredFields = new List<string> { "123" };
            configuredOptionObject2015.SetUnlockedFields(requiredFields);
            Assert.IsTrue(!configuredOptionObject2015.IsFieldLocked("123"));
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015_SetLockedFields_IsTrue()
        {
            List<string> lockedFields = new List<string> { "123" };
            configuredOptionObject2015.SetLockedFields(lockedFields);
            Assert.IsTrue(configuredOptionObject2015.IsFieldLocked("123"));
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015_IsFieldRequired_IsTrue()
        {
            var actual = configuredOptionObject2015.IsFieldRequired("123");
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015_IsFieldRequired_AreNotEqual()
        {
            var actual = configuredOptionObject2015.IsFieldRequired("234");
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void OptionObject2015_IsFieldRequired_Error()
        {
            var actual = configuredOptionObject2015.IsFieldRequired("456");
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015_SetOptionalFields_IsTrue()
        {
            List<string> optionalFields = new List<string> { "123" };
            configuredOptionObject2015.SetOptionalFields(optionalFields);
            Assert.IsTrue(configuredOptionObject2015.IsFieldEnabled("123"));
            Assert.IsFalse(configuredOptionObject2015.IsFieldRequired("123"));
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015_SetRequiredFields_AreEqual()
        {
            List<string> requiredFields = new List<string> { "123" };
            configuredOptionObject2015.SetRequiredFields(requiredFields);
            Assert.IsTrue(configuredOptionObject2015.IsFieldEnabled("123"));
            Assert.IsTrue(configuredOptionObject2015.IsFieldRequired("123"));
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015_Constructor_NoForms_AreEqual()
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
            string sessionToken = "acb123";
            string systemCode = "UAT";
            int formCount = 0;

            OptionObject2015 optionObject = new OptionObject2015(optionId, optionUserId, optionStaffId
                , facility, entityId, episodeNumber
                , systemCode, namespaceName, parentNamespace, serverName
                , sessionToken);
            Assert.AreEqual(entityId, optionObject.EntityID);
            Assert.AreEqual(episodeNumber, optionObject.EpisodeNumber);
            Assert.AreEqual(facility, optionObject.Facility);
            Assert.AreEqual(namespaceName, optionObject.NamespaceName);
            Assert.AreEqual(optionId, optionObject.OptionId);
            Assert.AreEqual(optionStaffId, optionObject.OptionStaffId);
            Assert.AreEqual(optionUserId, optionObject.OptionUserId);
            Assert.AreEqual(parentNamespace, optionObject.ParentNamespace);
            Assert.AreEqual(serverName, optionObject.ServerName);
            Assert.AreEqual(sessionToken, optionObject.SessionToken);
            Assert.AreEqual(systemCode, optionObject.SystemCode);
            Assert.AreEqual(formCount, optionObject.Forms.Count);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015_Constructor_WithForms_AreEqual()
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
            string sessionToken = "acb123";
            string systemCode = "UAT";
            List<FormObject> forms = new List<FormObject>
            {
                new FormObject("1"),
                new FormObject("2")
            };
            int formCount = 2;

            OptionObject2015 optionObject = new OptionObject2015(optionId, optionUserId, optionStaffId
                , facility, entityId, episodeNumber
                , systemCode, namespaceName, parentNamespace, serverName
                , sessionToken
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
            Assert.AreEqual(sessionToken, optionObject.SessionToken);
            Assert.AreEqual(systemCode, optionObject.SystemCode);
            Assert.AreEqual(formCount, optionObject.Forms.Count);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015_Clone_AreEqual()
        {
            List<FieldObject> fieldObjects = new List<FieldObject>
            {
                new FieldObject("123", "Test")
            };
            RowObject rowObject = new RowObject("1||1", fieldObjects);
            FormObject formObject = new FormObject("1", rowObject);
            OptionObject2015 optionObject = new OptionObject2015("USER00", "userId", "000111", "1", "123456", 1, "UAT", "AVPM", "AVPM", "SERVER", "TOKEN");
            optionObject.AddFormObject(formObject);

            OptionObject2015 cloneOptionObject = (OptionObject2015)optionObject.Clone();

            Assert.AreEqual(optionObject, cloneOptionObject);
            Assert.IsTrue(optionObject.IsFieldPresent("123"));
            Assert.IsTrue(cloneOptionObject.IsFieldPresent("123"));
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015_ReturnOptionObject_SessionTokenReturned()
        {
            List<FieldObject> fieldObjects = new List<FieldObject>
            {
                new FieldObject("123", "Test")
            };
            RowObject rowObject = new RowObject("1||1", fieldObjects);
            FormObject formObject = new FormObject("1", rowObject);
            OptionObject2015 optionObject = new OptionObject2015("USER00", "userId", "000111", "1", "123456", 1, "UAT", "AVPM", "AVPM", "SERVER", "TOKEN");
            optionObject.AddFormObject(formObject);

            OptionObject2015 returnOptionObject = optionObject.ToReturnOptionObject();

            Assert.AreEqual(optionObject.SessionToken, returnOptionObject.SessionToken);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015_ReturnOptionObject_AreNotEqual()
        {
            List<FieldObject> fieldObjects = new List<FieldObject>
            {
                new FieldObject("123", "Test")
            };
            RowObject rowObject = new RowObject("1||1", fieldObjects);
            FormObject formObject = new FormObject("1", rowObject);
            OptionObject2015 optionObject = new OptionObject2015("USER00", "userId", "000111", "1", "123456", 1, "UAT", "AVPM", "AVPM", "SERVER", "TOKEN");
            optionObject.AddFormObject(formObject);

            OptionObject2015 returnOptionObject = optionObject.ToReturnOptionObject();
            
            Assert.AreNotEqual(optionObject.ToJson(), returnOptionObject.ToJson());
            Assert.IsTrue(optionObject.IsFieldPresent("123"));
            Assert.IsFalse(returnOptionObject.IsFieldPresent("123"));
        }
    }
}
