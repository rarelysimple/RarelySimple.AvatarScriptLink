﻿using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced;

namespace RarelySimple.AvatarScriptLink.Tests.Helpers
{
    [TestClass]
    public class DisableAllFieldObjectsTests
    {
        private OptionObject optionObject = new();
        private OptionObject2 optionObject2 = new();

        [TestInitialize]
        public void TestInitialize()
        {
            IFieldObject addField = new FieldObject
            {
                Enabled = "1",
                FieldNumber = "100",
                FieldValue = "TEST",
                Lock = "0",
                Required = "1"
            };

            IRowObject currentRow = new RowObject();
            currentRow.Fields.Add((FieldObject)addField);
            currentRow.Fields.Add((FieldObject)addField);
            currentRow.Fields.Add((FieldObject)addField);
            currentRow.ParentRowId = "";
            currentRow.RowAction = "";
            currentRow.RowId = "1";

            IRowObject otherRow1 = new RowObject();
            otherRow1.Fields.Add((FieldObject)addField);
            otherRow1.Fields.Add((FieldObject)addField);
            otherRow1.Fields.Add((FieldObject)addField);
            otherRow1.Fields.Add((FieldObject)addField);
            otherRow1.Fields.Add((FieldObject)addField);
            otherRow1.ParentRowId = "1";
            otherRow1.RowAction = "";
            otherRow1.RowId = "2";

            IRowObject otherRow2 = new RowObject();
            otherRow2.Fields.Add((FieldObject)addField);
            otherRow2.Fields.Add((FieldObject)addField);
            otherRow2.Fields.Add((FieldObject)addField);
            otherRow2.Fields.Add((FieldObject)addField);
            otherRow2.Fields.Add((FieldObject)addField);
            otherRow2.ParentRowId = "1";
            otherRow2.RowAction = "";
            otherRow2.RowId = "3";

            IFormObject primaryForm = new FormObject
            {
                CurrentRow = (RowObject)currentRow,
                FormId = "1",
                MultipleIteration = false
            };

            IFormObject multipleIterationForm = new FormObject
            {
                CurrentRow = null,
                FormId = "2",
                MultipleIteration = true
            };
            multipleIterationForm.OtherRows.Add((RowObject)otherRow1);
            multipleIterationForm.OtherRows.Add((RowObject)otherRow2);

            optionObject = new OptionObject
            {
                EntityID = "123456",
                EpisodeNumber = 1,
                Facility = "1",
                OptionId = "USER00",
                OptionStaffId = "1234",
                OptionUserId = "username",
                SystemCode = "UAT"
            };
            optionObject.Forms.Add((FormObject)primaryForm);
            optionObject.Forms.Add((FormObject)multipleIterationForm);

            optionObject2 = new OptionObject2
            {
                EntityID = "123456",
                EpisodeNumber = 1,
                Facility = "1",
                NamespaceName = "NAMESPACE",
                OptionId = "USER00",
                OptionStaffId = "1234",
                OptionUserId = "username",
                ParentNamespace = "PARENTNAMESPACE",
                ServerName = "SERVERNAME",
                SystemCode = "UAT"
            };
            optionObject2.Forms.Add((FormObject)primaryForm);
            optionObject2.Forms.Add((FormObject)multipleIterationForm);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DisableAllFieldObjects_OptionObject_Null()
        {
            OptionObject returnOptionObject = (OptionObject)OptionObjectHelpers.DisableAllFieldObjects(null);
            Assert.AreEqual(optionObject.EntityID, returnOptionObject.EntityID);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void DisableAllFieldObjects_OptionObject_EntityID_AreEqual()
        {
            OptionObject returnOptionObject = (OptionObject)OptionObjectHelpers.DisableAllFieldObjects(optionObject);
            Assert.AreEqual(optionObject.EntityID, returnOptionObject.EntityID);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void DisableAllFieldObjects_OptionObject2_EntityID_AreEqual()
        {
            OptionObject2 returnOptionObject = (OptionObject2)OptionObjectHelpers.DisableAllFieldObjects(optionObject2);
            Assert.AreEqual(optionObject2.EntityID, returnOptionObject.EntityID);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void DisableAllFieldObjects_OptionObject_EpisodeNumber_AreEqual()
        {
            OptionObject returnOptionObject = (OptionObject)OptionObjectHelpers.DisableAllFieldObjects(optionObject);
            Assert.AreEqual(optionObject.EpisodeNumber, returnOptionObject.EpisodeNumber);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void DisableAllFieldObjects_OptionObject2_EpisodeNumber_AreEqual()
        {
            OptionObject2 returnOptionObject = (OptionObject2)OptionObjectHelpers.DisableAllFieldObjects(optionObject2);
            Assert.AreEqual(optionObject2.EpisodeNumber, returnOptionObject.EpisodeNumber);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void DisableAllFieldObjects_OptionObject_Facility_AreEqual()
        {
            OptionObject returnOptionObject = (OptionObject)OptionObjectHelpers.DisableAllFieldObjects(optionObject);
            Assert.AreEqual(optionObject.Facility, returnOptionObject.Facility);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void DisableAllFieldObjects_OptionObject2_Facility_AreEqual()
        {
            OptionObject2 returnOptionObject = (OptionObject2)OptionObjectHelpers.DisableAllFieldObjects(optionObject2);
            Assert.AreEqual(optionObject2.Facility, returnOptionObject.Facility);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void DisableAllFieldObjects_OptionObject2_NamespaceName_AreEqual()
        {
            OptionObject2 returnOptionObject = (OptionObject2)OptionObjectHelpers.DisableAllFieldObjects(optionObject2);
            Assert.AreEqual(optionObject2.NamespaceName, returnOptionObject.NamespaceName);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void DisableAllFieldObjects_OptionObject_OptionID_AreEqual()
        {
            OptionObject returnOptionObject = (OptionObject)OptionObjectHelpers.DisableAllFieldObjects(optionObject);
            Assert.AreEqual(optionObject.OptionId, returnOptionObject.OptionId);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void DisableAllFieldObjects_OptionObject2_OptionID_AreEqual()
        {
            OptionObject2 returnOptionObject = (OptionObject2)OptionObjectHelpers.DisableAllFieldObjects(optionObject2);
            Assert.AreEqual(optionObject2.OptionId, returnOptionObject.OptionId);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void DisableAllFieldObjects_OptionObject_OptionStaffID_AreEqual()
        {
            OptionObject returnOptionObject = (OptionObject)OptionObjectHelpers.DisableAllFieldObjects(optionObject);
            Assert.AreEqual(optionObject.OptionStaffId, returnOptionObject.OptionStaffId);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void DisableAllFieldObjects_OptionObject2_OptionStaffID_AreEqual()
        {
            OptionObject2 returnOptionObject = (OptionObject2)OptionObjectHelpers.DisableAllFieldObjects(optionObject2);
            Assert.AreEqual(optionObject2.OptionStaffId, returnOptionObject.OptionStaffId);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void DisableAllFieldObjects_OptionObject_OptionUserID_AreEqual()
        {
            OptionObject returnOptionObject = (OptionObject)OptionObjectHelpers.DisableAllFieldObjects(optionObject);
            Assert.AreEqual(optionObject.OptionUserId, returnOptionObject.OptionUserId);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void DisableAllFieldObjects_OptionObject2_OptionUserID_AreEqual()
        {
            OptionObject2 returnOptionObject = (OptionObject2)OptionObjectHelpers.DisableAllFieldObjects(optionObject2);
            Assert.AreEqual(optionObject2.OptionUserId, returnOptionObject.OptionUserId);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void DisableAllFieldObjects_OptionObject2_ParentNamespace_AreEqual()
        {
            OptionObject2 returnOptionObject = (OptionObject2)OptionObjectHelpers.DisableAllFieldObjects(optionObject2);
            Assert.AreEqual(optionObject2.ParentNamespace, returnOptionObject.ParentNamespace);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void DisableAllFieldObjects_OptionObject2_ServerName_AreEqual()
        {
            OptionObject2 returnOptionObject = (OptionObject2)OptionObjectHelpers.DisableAllFieldObjects(optionObject2);
            Assert.AreEqual(optionObject2.ServerName, returnOptionObject.ServerName);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void DisableAllFieldObjects_OptionObject_SystemCode_AreEqual()
        {
            OptionObject returnOptionObject = (OptionObject)OptionObjectHelpers.DisableAllFieldObjects(optionObject);
            Assert.AreEqual(optionObject.SystemCode, returnOptionObject.SystemCode);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void DisableAllFieldObjects_OptionObject2_SystemCode_AreEqual()
        {
            OptionObject2 returnOptionObject = (OptionObject2)OptionObjectHelpers.DisableAllFieldObjects(optionObject2);
            Assert.AreEqual(optionObject2.SystemCode, returnOptionObject.SystemCode);
        }




        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void DisableAllFieldObjects_OptionObject_FormCount_AreEqual()
        {
            OptionObject returnOptionObject = (OptionObject)OptionObjectHelpers.DisableAllFieldObjects(optionObject);
            Assert.AreEqual(optionObject.Forms.Count, returnOptionObject.Forms.Count);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void DisableAllFieldObjects_OptionObject2_FormCount_AreEqual()
        {
            OptionObject2 returnOptionObject = (OptionObject2)OptionObjectHelpers.DisableAllFieldObjects(optionObject2);
            Assert.AreEqual(optionObject2.Forms.Count, returnOptionObject.Forms.Count);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void DisableAllFieldObjects_OptionObject2015_MissingProperties_IsDisabled()
        {
            FieldObject fieldObject1 = new() { FieldNumber = "1", FieldValue = "1" };
            FieldObject fieldObject2 = new() { FieldNumber = "2", FieldValue = "2" };
            FieldObject fieldObject3 = new() { FieldNumber = "3", FieldValue = "3" };
            FieldObject fieldObject4 = new() { FieldNumber = "4", FieldValue = "4" };
            FieldObject fieldObject5 = new() { FieldNumber = "5", FieldValue = "5" };
            List<FieldObject> fieldObjects =
            [
                fieldObject1,
                fieldObject2,
                fieldObject3,
                fieldObject4,
                fieldObject5
            ];
            RowObject rowObject = new("1||1", fieldObjects);
            FormObject formObject = new("1", rowObject);
            List<FormObject> formObjects =
            [
                formObject
            ];
            OptionObject2015 optionObject2015 = new()
            {
                Forms = formObjects
            };

            OptionObject2015 returnOptionObject = (OptionObject2015)OptionObjectHelpers.DisableAllFieldObjects(optionObject2015);

            Assert.IsFalse(returnOptionObject.IsFieldEnabled("1"));
            Assert.IsFalse(returnOptionObject.IsFieldEnabled("2"));
            Assert.IsFalse(returnOptionObject.IsFieldEnabled("3"));
            Assert.IsFalse(returnOptionObject.IsFieldEnabled("4"));
            Assert.IsFalse(returnOptionObject.IsFieldEnabled("5"));
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void DisableAllFieldObjects_OptionObject2015_IsModified()
        {
            FieldObject fieldObject1 = new() { FieldNumber = "1", FieldValue = "1" };
            FieldObject fieldObject2 = new() { FieldNumber = "2", FieldValue = "2" };
            FieldObject fieldObject3 = new() { FieldNumber = "3", FieldValue = "3" };
            FieldObject fieldObject4 = new() { FieldNumber = "4", FieldValue = "4" };
            FieldObject fieldObject5 = new() { FieldNumber = "5", FieldValue = "5" };
            List<FieldObject> fieldObjects =
            [
                fieldObject1,
                fieldObject2,
                fieldObject3,
                fieldObject4,
                fieldObject5
            ];
            RowObject rowObject = new("1||1", fieldObjects);
            FormObject formObject = new("1", rowObject);
            List<FormObject> formObjects =
            [
                formObject
            ];
            OptionObject2015 optionObject2015 = new()
            {
                Forms = formObjects
            };

            OptionObject2015 returnOptionObject = (OptionObject2015)OptionObjectHelpers.DisableAllFieldObjects(optionObject2015);

            Assert.IsTrue(returnOptionObject.IsFieldModified("1"));
            Assert.IsTrue(returnOptionObject.IsFieldModified("2"));
            Assert.IsTrue(returnOptionObject.IsFieldModified("3"));
            Assert.IsTrue(returnOptionObject.IsFieldModified("4"));
            Assert.IsTrue(returnOptionObject.IsFieldModified("5"));
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void DisableAllFieldObjects_OptionObject2015_ExcludesFields()
        {
            FieldObject fieldObject1 = new("1", "1", true, false, false);
            FieldObject fieldObject2 = new("2", "2", true, false, false);
            FieldObject fieldObject3 = new("3", "3", true, false, false);
            FieldObject fieldObject4 = new("4", "4", true, false, false);
            FieldObject fieldObject5 = new("5", "5", true, false, false);
            List<FieldObject> fieldObjects =
            [
                fieldObject1,
                fieldObject2,
                fieldObject3,
                fieldObject4,
                fieldObject5
            ];
            RowObject rowObject = new("1||1", fieldObjects);
            FormObject formObject = new("1", rowObject);
            List<FormObject> formObjects =
            [
                formObject
            ];
            OptionObject2015 optionObject2015 = new()
            {
                Forms = formObjects
            };

            List<string> excludedFields =
            [
                "2",
                "4"
            ];
            OptionObject2015 returnOptionObject = (OptionObject2015)OptionObjectHelpers.DisableAllFieldObjects(optionObject2015, excludedFields);

            Assert.IsFalse(returnOptionObject.IsFieldEnabled("1"));
            Assert.AreEqual("1", returnOptionObject.GetFieldValue("1"));
            Assert.IsTrue(returnOptionObject.IsFieldEnabled("2"));
            Assert.IsFalse(returnOptionObject.IsFieldEnabled("3"));
            Assert.IsTrue(returnOptionObject.IsFieldEnabled("4"));
            Assert.IsFalse(returnOptionObject.IsFieldEnabled("5"));
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DisableAllFieldObjects_OptionObject2015_Null_ExcludesFields()
        {
            List<string> excludedFields =
            [
                "2",
                "4"
            ];
            OptionObject2015 returnOptionObject = (OptionObject2015)OptionObjectHelpers.DisableAllFieldObjects(null, excludedFields);

            Assert.IsFalse(returnOptionObject.IsFieldEnabled("1"));
            Assert.AreEqual("1", returnOptionObject.GetFieldValue("1"));
            Assert.IsTrue(returnOptionObject.IsFieldEnabled("2"));
            Assert.IsFalse(returnOptionObject.IsFieldEnabled("3"));
            Assert.IsTrue(returnOptionObject.IsFieldEnabled("4"));
            Assert.IsFalse(returnOptionObject.IsFieldEnabled("5"));
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DisableAllFieldObjects_OptionObject2015_ExcludesFields_Null()
        {
            FieldObject fieldObject1 = new("1", "1", true, false, false);
            FieldObject fieldObject2 = new("2", "2", true, false, false);
            FieldObject fieldObject3 = new("3", "3", true, false, false);
            FieldObject fieldObject4 = new("4", "4", true, false, false);
            FieldObject fieldObject5 = new("5", "5", true, false, false);
            List<FieldObject> fieldObjects =
            [
                fieldObject1,
                fieldObject2,
                fieldObject3,
                fieldObject4,
                fieldObject5
            ];
            RowObject rowObject = new("1||1", fieldObjects);
            FormObject formObject = new("1", rowObject);
            List<FormObject> formObjects =
            [
                formObject
            ];
            OptionObject2015 optionObject2015 = new()
            {
                Forms = formObjects
            };

            OptionObject2015 returnOptionObject = (OptionObject2015)OptionObjectHelpers.DisableAllFieldObjects(optionObject2015, null);

            Assert.IsFalse(returnOptionObject.IsFieldEnabled("1"));
            Assert.AreEqual("1", returnOptionObject.GetFieldValue("1"));
            Assert.IsTrue(returnOptionObject.IsFieldEnabled("2"));
            Assert.IsFalse(returnOptionObject.IsFieldEnabled("3"));
            Assert.IsTrue(returnOptionObject.IsFieldEnabled("4"));
            Assert.IsFalse(returnOptionObject.IsFieldEnabled("5"));
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DisableAllFieldObjects_OptionObject2015_ExcludesFields_NoForms()
        {
            OptionObject2015 optionObject2015 = new();

            List<string> excludedFields =
            [
                "2",
                "4"
            ];
            OptionObject2015 returnOptionObject = (OptionObject2015)OptionObjectHelpers.DisableAllFieldObjects(optionObject2015, excludedFields);

            Assert.IsFalse(returnOptionObject.IsFieldEnabled("1"));
            Assert.AreEqual("1", returnOptionObject.GetFieldValue("1"));
            Assert.IsTrue(returnOptionObject.IsFieldEnabled("2"));
            Assert.IsFalse(returnOptionObject.IsFieldEnabled("3"));
            Assert.IsTrue(returnOptionObject.IsFieldEnabled("4"));
            Assert.IsFalse(returnOptionObject.IsFieldEnabled("5"));
        }
    }
}
