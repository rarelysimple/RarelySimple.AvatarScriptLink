using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RarelySimple.AvatarScriptLink.Objects;
using System.Collections.Generic;

namespace RarelySimple.AvatarScriptLink.Tests.ObjectsTests
{
    [TestClass]
    public class OptionObject2023Tests
    {
        private OptionObject2023 configuredOptionObject2023;

        [TestInitialize]
        public void TestInitialize()
        {
            configuredOptionObject2023 = OptionObject2023.Initialize();
            // First Form
            FieldObject fieldObject = FieldObject.Builder()
                                                 .FieldNumber("123")
                                                 .FieldValue("Value")
                                                 .Enabled()
                                                 .Locked()
                                                 .Required()
                                                 .Build();

            FormObject formObject = FormObject.Builder()
                                              .FormId("1")
                                              .CurrentRow()
                                                    .RowId("1||1")
                                                    .Field(fieldObject)
                                                    .AddRow()
                                              .Build();
            // Second Form
            RowObject rowObject01 = RowObject.Builder()
                                             .RowId("2||1")
                                             .Field()
                                                 .FieldNumber("234")
                                                 .FieldValue("MI Value")
                                                 .AddField()
                                             .Build();

            RowObject rowObject02 = RowObject.Builder()
                                             .RowId("2||2")
                                             .Field()
                                                 .FieldNumber("234")
                                                 .FieldValue("MI Value 2")
                                                 .AddField()
                                             .Build();

            FormObject miFormObject = FormObject.Builder()
                                                .FormId("2")
                                                .CurrentRow(rowObject01)
                                                .MultipleIteration()
                                                .OtherRow(rowObject02)
                                                .Build();

            configuredOptionObject2023 = OptionObject2023.Builder()
                                                         .OptionId("OPT1234")
                                                         .Form(formObject)
                                                         .Form(miFormObject)
                                                         .Build();
        }

        [TestMethod]
        [TestCategory("OptionObject2023")]
        public void OptionObject2023_HasFormObject()
        {
            OptionObject2023 optionObject = OptionObject2023.Initialize();
            Assert.IsNotNull(optionObject.Forms);
        }

        [TestMethod]
        [TestCategory("OptionObject2023")]
        public void OptionObject2023_Forms_IsNotEmpty()
        {
            OptionObject2023 optionObject = OptionObject2023.Initialize();
            var expected = new List<FormObject>();
            var actual = optionObject.Forms;
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2023")]
        public void OptionObject2023_CanGetHtmlString_WithoutHtmlHeaders()
        {
            OptionObject2023 optionObject = OptionObject2023.Initialize();
            var actual = optionObject.ToHtmlString(false);
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2023")]
        public void OptionObject2023_CanGetHtmlString_WithHtmlHeaders()
        {
            OptionObject2023 optionObject = OptionObject2023.Initialize();
            var actual = optionObject.ToHtmlString(true);
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2023")]
        public void OptionObject2023_AddFormObject_FormObject()
        {
            FormObject formObject1 = FormObject.Builder()
                                               .FormId("1")
                                               .Build();
            FormObject formObject2 = FormObject.Builder()
                                               .FormId("2")
                                               .MultipleIteration()
                                               .Build();
            OptionObject2023 optionObject = OptionObject2023.Initialize();
            optionObject.AddFormObject(formObject1);
            Assert.AreEqual(1, optionObject.Forms.Count);
            optionObject.AddFormObject(formObject2);
            Assert.AreEqual(2, optionObject.Forms.Count);
        }

        [TestMethod]
        [TestCategory("OptionObject2023")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void OptionObject2023_AddFormObject_FormObject_Exception()
        {
            FormObject formObject1 = FormObject.Builder().FormId("1").Build();
            OptionObject2023 optionObject = OptionObject2023.Initialize();
            optionObject.AddFormObject(formObject1);
            Assert.AreEqual(1, optionObject.Forms.Count);
            optionObject.AddFormObject(formObject1);
            Assert.AreEqual(1, optionObject.Forms.Count);
        }

        [TestMethod]
        [TestCategory("OptionObject2023")]
        public void OptionObject2023_AddFormObject_Properties()
        {
            OptionObject2023 optionObject = OptionObject2023.Initialize();
            optionObject.AddFormObject("1", false);
            Assert.AreEqual(1, optionObject.Forms.Count);
            optionObject.AddFormObject("2", true);
            Assert.AreEqual(2, optionObject.Forms.Count);
        }

        [TestMethod]
        [TestCategory("OptionObject2023")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void OptionObject2023_AddFormObject_Properties_Exception()
        {
            OptionObject2023 optionObject = OptionObject2023.Initialize();
            optionObject.AddFormObject("1", false);
            Assert.AreEqual(1, optionObject.Forms.Count);
            optionObject.AddFormObject("1", false);
            Assert.AreEqual(1, optionObject.Forms.Count);
        }

        [TestMethod]
        [TestCategory("OptionObject2023")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void OptionObject2023_GetCurrentRowId_Error()
        {
            OptionObject2023 optionObject = OptionObject2023.Initialize();
            var actual = optionObject.GetCurrentRowId("1");
            Assert.AreEqual(null, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2023")]
        public void OptionObject2023_GetCurrentRowId_AreEqual()
        {
            FormObject formObject = FormObject.Builder()
                                              .FormId("1")
                                              .CurrentRow()
                                                    .RowId("1||1")
                                                    .AddRow()
                                              .Build();
            OptionObject2023 optionObject = OptionObject2023.Builder()
                                                            .OptionId("OPT1234")
                                                            .Form(formObject)
                                                            .Build();
            var actual = optionObject.GetCurrentRowId("1");
            Assert.AreEqual("1||1", actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2023")]
        public void OptionObject2023_GetFieldValue_AreEqual()
        {
            var expected = "Value";
            var actual = configuredOptionObject2023.GetFieldValue("123");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2023")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void OptionObject2023_GetFieldValue_AreNotEqual()
        {
            OptionObject2023 optionObject = OptionObject2023.Initialize();
            var expected = "Value";
            var actual = optionObject.GetFieldValue("123");
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2023")]
        public void OptionObject2023_GetFieldValue_MI_AreEqual()
        {
            var expected = "MI Value";
            var actual = configuredOptionObject2023.GetFieldValue("234");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2023")]
        [ExpectedException(typeof(ArgumentException))]
        public void OptionObject2023_GetFieldValue_MI_AreNotEqual()
        {
            var expected = "Value";
            var actual = configuredOptionObject2023.GetFieldValue("456");
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2023")]
        public void OptionObject2023_GetFieldValues_AreEqual()
        {
            var expected = "Value";
            var values = configuredOptionObject2023.GetFieldValues("123");
            var actual = values.Count > 0 ? values[0] : null;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2023")]
        public void OptionObject2023_GetFieldValues_MI_AreEqual()
        {
            var expected = "MI Value";
            var values = configuredOptionObject2023.GetFieldValues("234");
            var actual = values.Count > 0 ? values[0] : null;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2023")]
        public void OptionObject2023_GetFieldValues_AreNotEqual()
        {
            var expected = "Value";
            var values = configuredOptionObject2023.GetFieldValues("456");
            var actual = values.Count > 0 ? values[0] : null;
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2023")]
        public void OptionObject2023_GetMultipleIterationStatus_IsFalse()
        {
            string formId = "1";
            OptionObject2023 optionObject = OptionObject2023.Builder()
                                                            .OptionId("OPT1234")
                                                            .Form()
                                                                .FormId(formId)
                                                                .AddForm()
                                                            .Build();
            var actual = optionObject.GetMultipleIterationStatus(formId);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2023")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void OptionObject2023_GetMultipleIterationStatus_IsNotFound()
        {
            OptionObject2023 optionObject = OptionObject2023.Initialize();
            var actual = optionObject.GetMultipleIterationStatus("1");
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2023")]
        public void OptionObject2023_GetMultipleIterationStatus_IsTrue()
        {
            var actual = configuredOptionObject2023.GetMultipleIterationStatus("2");
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2023")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void OptionObject2023_GetParentRowId_Error()
        {
            OptionObject2023 optionObject = new OptionObject2023();
            var actual = optionObject.GetParentRowId("1");
            Assert.AreEqual(null, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2023")]
        public void OptionObject2023_GetParentRowId_AreEqual()
        {
            RowObject rowObject = RowObject.Builder().RowId("1||2").ParentRowId("1||1").Build();
            OptionObject2023 optionObject = OptionObject2023.Builder()
                                                            .OptionId("USER00")
                                                            .Form()
                                                                .FormId("1")
                                                                .CurrentRow(rowObject)
                                                                .AddForm()
                                                            .Build();
            var actual = optionObject.GetParentRowId("1");
            Assert.AreEqual(rowObject.ParentRowId, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2023")]
        public void OptionObject2023_IsFieldPresent_IsTrue()
        {
            var actual = configuredOptionObject2023.IsFieldPresent("123");
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2023")]
        public void OptionObject2023_IsFieldPresent_IsFalse()
        {
            var actual = configuredOptionObject2023.IsFieldPresent("456");
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2023")]
        public void OptionObject2023_IsFieldEnabled_IsTrue()
        {
            var actual = configuredOptionObject2023.IsFieldEnabled("123");
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2023")]
        public void OptionObject2023_IsFieldEnabled_IsFalse()
        {
            var actual = configuredOptionObject2023.IsFieldEnabled("234");
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2023")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void OptionObject2023_IsFieldEnabled_Error()
        {
            var actual = configuredOptionObject2023.IsFieldEnabled("456");
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2023")]
        public void OptionObject2023_SetDisabledFields_IsTrue()
        {
            List<string> disabledFields = new List<string> { "123" };
            configuredOptionObject2023.SetDisabledFields(disabledFields);
            Assert.IsTrue(!configuredOptionObject2023.IsFieldEnabled("123"));
        }

        [TestMethod]
        [TestCategory("OptionObject2023")]
        public void OptionObject2023_IsFieldLocked_IsTrue()
        {
            var actual = configuredOptionObject2023.IsFieldLocked("123");
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2023")]
        public void OptionObject2023_IsFieldLocked_IsFalse()
        {
            var actual = configuredOptionObject2023.IsFieldLocked("234");
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2023")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void OptionObject2023_IsFieldLocked_Error()
        {
            var actual = configuredOptionObject2023.IsFieldLocked("456");
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2023")]
        public void OptionObject2023_SetUnlockedFields_IsTrue()
        {
            List<string> requiredFields = new List<string> { "123" };
            configuredOptionObject2023.SetUnlockedFields(requiredFields);
            Assert.IsTrue(!configuredOptionObject2023.IsFieldLocked("123"));
        }

        [TestMethod]
        [TestCategory("OptionObject2023")]
        public void OptionObject2023_SetLockedFields_IsTrue()
        {
            List<string> lockedFields = new List<string> { "123" };
            configuredOptionObject2023.SetLockedFields(lockedFields);
            Assert.IsTrue(configuredOptionObject2023.IsFieldLocked("123"));
        }

        [TestMethod]
        [TestCategory("OptionObject2023")]
        public void OptionObject2023_IsFieldRequired_IsTrue()
        {
            var actual = configuredOptionObject2023.IsFieldRequired("123");
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2023")]
        public void OptionObject2023_IsFieldRequired_AreNotEqual()
        {
            var actual = configuredOptionObject2023.IsFieldRequired("234");
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2023")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void OptionObject2023_IsFieldRequired_Error()
        {
            var actual = configuredOptionObject2023.IsFieldRequired("456");
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2023")]
        public void OptionObject2023_SetOptionalFields_IsTrue()
        {
            List<string> optionalFields = new List<string> { "123" };
            configuredOptionObject2023.SetOptionalFields(optionalFields);
            Assert.IsTrue(configuredOptionObject2023.IsFieldEnabled("123"));
            Assert.IsFalse(configuredOptionObject2023.IsFieldRequired("123"));
        }

        [TestMethod]
        [TestCategory("OptionObject2023")]
        public void OptionObject2023_SetRequiredFields_AreEqual()
        {
            List<string> requiredFields = new List<string> { "123" };
            configuredOptionObject2023.SetRequiredFields(requiredFields);
            Assert.IsTrue(configuredOptionObject2023.IsFieldEnabled("123"));
            Assert.IsTrue(configuredOptionObject2023.IsFieldRequired("123"));
        }

        [TestMethod]
        [TestCategory("OptionObject2023")]
        public void OptionObject2023_Constructor_NoForms_AreEqual()
        {
            string entityId = "12345";
            double episodeNumber = 0;
            string facility = "1";
            string historicUID = "11111";
            string namespaceName = "AVPM";
            string optionId = "USER37";
            string optionStaffId = "";
            string optionUserId = "username";
            string parentNamespace = "AVPM";
            string serverName = "server";
            string sessionToken = "acb123";
            string systemCode = "UAT";
            int formCount = 0;

            OptionObject2023 optionObject = new OptionObject2023(optionId, optionUserId, optionStaffId
                , facility, entityId, episodeNumber
                , systemCode, namespaceName, parentNamespace, serverName
                , sessionToken, historicUID);
            Assert.AreEqual(entityId, optionObject.EntityID);
            Assert.AreEqual(episodeNumber, optionObject.EpisodeNumber);
            Assert.AreEqual(facility, optionObject.Facility);
            Assert.AreEqual(historicUID, optionObject.HistoricUID);
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
        [TestCategory("OptionObject2023")]
        public void OptionObject2023_Constructor_WithForms_AreEqual()
        {
            string entityId = "12345";
            double episodeNumber = 0;
            string facility = "1";
            string historicUID = "11111";
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

            OptionObject2023 optionObject = new OptionObject2023(optionId, optionUserId, optionStaffId
                , facility, entityId, episodeNumber
                , systemCode, namespaceName, parentNamespace, serverName
                , sessionToken, historicUID
                , forms);
            Assert.AreEqual(entityId, optionObject.EntityID);
            Assert.AreEqual(episodeNumber, optionObject.EpisodeNumber);
            Assert.AreEqual(facility, optionObject.Facility);
            Assert.AreEqual(historicUID, optionObject.HistoricUID);
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
        [TestCategory("OptionObject2023")]
        public void OptionObject2023_Clone_AreEqual()
        {
            List<FieldObject> fieldObjects = new List<FieldObject>
            {
                new FieldObject("123", "Test")
            };
            RowObject rowObject = new RowObject("1||1", fieldObjects);
            FormObject formObject = new FormObject("1", rowObject);
            OptionObject2023 optionObject = new OptionObject2023("USER00", "userId", "000111", "1", "123456", 1, "UAT", "AVPM", "AVPM", "SERVER", "TOKEN", "HISTORICUID");
            optionObject.AddFormObject(formObject);

            OptionObject2023 cloneOptionObject = optionObject.Clone();

            Assert.AreEqual(optionObject, cloneOptionObject);
            Assert.IsTrue(optionObject.IsFieldPresent("123"));
            Assert.IsTrue(cloneOptionObject.IsFieldPresent("123"));
        }

        [TestMethod]
        [TestCategory("OptionObject2023")]
        public void OptionObject2023_ReturnOptionObject_SessionTokenReturned()
        {
            List<FieldObject> fieldObjects = new List<FieldObject>
            {
                new FieldObject("123", "Test")
            };
            RowObject rowObject = new RowObject("1||1", fieldObjects);
            FormObject formObject = new FormObject("1", rowObject);
            OptionObject2023 optionObject = new OptionObject2023("USER00", "userId", "000111", "1", "123456", 1, "UAT", "AVPM", "AVPM", "SERVER", "TOKEN", "HISTORICUID");
            optionObject.AddFormObject(formObject);

            OptionObject2023 returnOptionObject = optionObject.ToReturnOptionObject();

            Assert.AreEqual(optionObject.SessionToken, returnOptionObject.SessionToken);
        }

        [TestMethod]
        [TestCategory("OptionObject2023")]
        public void OptionObject2023_ReturnOptionObject_AreNotEqual()
        {
            List<FieldObject> fieldObjects = new List<FieldObject>
            {
                new FieldObject("123", "Test")
            };
            RowObject rowObject = new RowObject("1||1", fieldObjects);
            FormObject formObject = new FormObject("1", rowObject);
            OptionObject2023 optionObject = new OptionObject2023("USER00", "userId", "000111", "1", "123456", 1, "UAT", "AVPM", "AVPM", "SERVER", "TOKEN", "HISTORICUID");
            optionObject.AddFormObject(formObject);

            OptionObject2023 returnOptionObject = optionObject.ToReturnOptionObject();
            
            Assert.AreNotEqual(optionObject.ToJson(), returnOptionObject.ToJson());
            Assert.IsTrue(optionObject.IsFieldPresent("123"));
            Assert.IsFalse(returnOptionObject.IsFieldPresent("123"));
        }

        [TestMethod]
        [TestCategory("OptionObject2023")]
        public void OptionObject2023_ReturnOptionObject_ErrorCodeNotOverwritten()
        {
            double expected = 3;
            OptionObject2023 optionObject = OptionObject2023.Builder().OptionId("USER123").Build();
            optionObject.ErrorCode = expected;
            OptionObject2023 returnOptionObject = optionObject.ToReturnOptionObject();

            Assert.AreEqual(expected, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        [TestCategory("OptionObject2023")]
        public void OptionObject2023_ReturnOptionObject_ErrorMesgNotOverwritten()
        {
            string expected = "Preset error message";
            OptionObject2023 optionObject = OptionObject2023.Builder().OptionId("USER123").Build();
            optionObject.ErrorMesg = expected;
            OptionObject2023 returnOptionObject = optionObject.ToReturnOptionObject();

            Assert.AreEqual(expected, returnOptionObject.ErrorMesg);
        }
    }
}
