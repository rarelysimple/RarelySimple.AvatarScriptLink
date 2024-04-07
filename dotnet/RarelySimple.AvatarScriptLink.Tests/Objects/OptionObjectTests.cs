using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.ObjectsTests
{
    [TestClass]
    public class OptionObjectTests
    {
        private OptionObject configuredOptionObject;

        [TestInitialize]
        public void TestInitialize()
        {
            configuredOptionObject = OptionObject.Initialize();
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

            configuredOptionObject = OptionObject.Builder()
                                                 .OptionId("OPT1234")
                                                 .Form(formObject)
                                                 .Form(miFormObject)
                                                 .Build();
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void OptionObject_HasFormObject()
        {
            OptionObject optionObject = OptionObject.Initialize();
            Assert.IsNotNull(optionObject.Forms);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void OptionObject_Forms_IsNotEmpty()
        {
            OptionObject optionObject = OptionObject.Initialize();
            var expected = new List<FormObject>();
            var actual = optionObject.Forms;
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void OptionObject_CanGetHtmlString_WithoutHtmlHeaders()
        {
            OptionObject optionObject = OptionObject.Initialize();
            var actual = optionObject.ToHtmlString(false);
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void OptionObject_CanGetHtmlString_WithHtmlHeaders()
        {
            OptionObject optionObject = OptionObject.Initialize();
            var actual = optionObject.ToHtmlString(false);
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void OptionObject_AddFormObject_FormObject()
        {
            FormObject formObject1 = FormObject.Builder()
                                               .FormId("1")
                                               .Build();
            FormObject formObject2 = FormObject.Builder()
                                               .FormId("2")
                                               .MultipleIteration()
                                               .Build();
            OptionObject optionObject = OptionObject.Initialize();
            optionObject.AddFormObject(formObject1);
            Assert.AreEqual(1, optionObject.Forms.Count);
            optionObject.AddFormObject(formObject2);
            Assert.AreEqual(2, optionObject.Forms.Count);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void OptionObject_AddFormObject_FormObject_Exception()
        {
            FormObject formObject1 = FormObject.Builder().FormId("1").Build();
            OptionObject optionObject = OptionObject.Initialize();
            optionObject.AddFormObject(formObject1);
            Assert.AreEqual(1, optionObject.Forms.Count);
            optionObject.AddFormObject(formObject1);
            Assert.AreEqual(1, optionObject.Forms.Count);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void OptionObject_AddFormObject_Properties()
        {
            OptionObject optionObject = OptionObject.Initialize();
            optionObject.AddFormObject("1", false);
            Assert.AreEqual(1, optionObject.Forms.Count);
            optionObject.AddFormObject("2", true);
            Assert.AreEqual(2, optionObject.Forms.Count);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void OptionObject_AddFormObject_Properties_Exception()
        {
            OptionObject optionObject = OptionObject.Initialize();
            optionObject.AddFormObject("1", false);
            Assert.AreEqual(1, optionObject.Forms.Count);
            optionObject.AddFormObject("1", false);
            Assert.AreEqual(1, optionObject.Forms.Count);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void OptionObject_GetCurrentRowId_Error()
        {
            OptionObject optionObject = OptionObject.Initialize();
            var actual = optionObject.GetCurrentRowId("1");
            Assert.AreEqual(null, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void OptionObject_GetCurrentRowId_AreEqual()
        {
            FormObject formObject = FormObject.Builder()
                                              .FormId("1")
                                              .CurrentRow()
                                                    .RowId("1||1")
                                                    .AddRow()
                                              .Build();
            OptionObject optionObject = OptionObject.Builder()
                                                    .OptionId("OPT1234")
                                                    .Form(formObject)
                                                    .Build();
            var actual = optionObject.GetCurrentRowId("1");
            Assert.AreEqual("1||1", actual);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void OptionObject_GetFieldValue_AreEqual()
        {
            var expected = "Value";
            var actual = configuredOptionObject.GetFieldValue("123");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void OptionObject_GetFieldValue_AreNotEqual()
        {
            OptionObject optionObject = OptionObject.Initialize();
            var expected = "Value";
            var actual = optionObject.GetFieldValue("123");
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void OptionObject_GetFieldValue_MI_AreEqual()
        {
            var expected = "MI Value";
            var actual = configuredOptionObject.GetFieldValue("234");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        [ExpectedException(typeof(ArgumentException))]
        public void OptionObject_GetFieldValue_MI_AreNotEqual()
        {
            var expected = "Value";
            var actual = configuredOptionObject.GetFieldValue("456");
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void OptionObject_GetFieldValues_AreEqual()
        {
            var expected = "Value";
            var values = configuredOptionObject.GetFieldValues("123");
            var actual = values.Count > 0 ? values[0] : null;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void OptionObject_GetFieldValues_MI_AreEqual()
        {
            var expected = "MI Value";
            var values = configuredOptionObject.GetFieldValues("234");
            var actual = values.Count > 0 ? values[0] : null;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void OptionObject_GetFieldValues_AreNotEqual()
        {
            var expected = "Value";
            var values = configuredOptionObject.GetFieldValues("456");
            var actual = values.Count > 0 ? values[0] : null;
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void OptionObject_GetMultipleIterationStatus_IsFalse()
        {
            string formId = "1";
            OptionObject optionObject = OptionObject.Builder()
                                                    .OptionId("OPT1234")
                                                    .Form()
                                                        .FormId(formId)
                                                        .AddForm()
                                                    .Build();
            var actual = optionObject.GetMultipleIterationStatus("1");
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void OptionObject_GetMultipleIterationStatus_IsNotFound()
        {
            OptionObject optionObject = OptionObject.Initialize();
            var actual = optionObject.GetMultipleIterationStatus("1");
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void OptionObject_GetMultipleIterationStatus_IsTrue()
        {
            var actual = configuredOptionObject.GetMultipleIterationStatus("2");
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void OptionObject_GetParentRowId_Error()
        {
            OptionObject optionObject = OptionObject.Initialize();
            var actual = optionObject.GetParentRowId("1");
            Assert.AreEqual(null, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void OptionObject_GetParentRowId_AreEqual()
        {
            RowObject rowObject = RowObject.Builder().RowId("1||2").ParentRowId("1||1").Build();
            OptionObject optionObject = OptionObject.Builder()
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
        [TestCategory("OptionObject")]
        public void OptionObject_IsFieldPresent_IsTrue()
        {
            var actual = configuredOptionObject.IsFieldPresent("123");
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void OptionObject_IsFieldPresent_IsFalse()
        {
            var actual = configuredOptionObject.IsFieldPresent("456");
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void OptionObject_IsFieldEnabled_IsTrue()
        {
            var actual = configuredOptionObject.IsFieldEnabled("123");
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void OptionObject_IsFieldEnabled_IsFalse()
        {
            var actual = configuredOptionObject.IsFieldEnabled("234");
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void OptionObject_IsFieldEnabled_Error()
        {
            var actual = configuredOptionObject.IsFieldEnabled("456");
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void OptionObject_SetDisabledFields_IsTrue()
        {
            List<string> disabledFields = ["123"];
            configuredOptionObject.SetDisabledFields(disabledFields);
            Assert.IsTrue(!configuredOptionObject.IsFieldEnabled("123"));
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void OptionObject_IsFieldLocked_IsTrue()
        {
            var actual = configuredOptionObject.IsFieldLocked("123");
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void OptionObject_IsFieldLocked_IsFalse()
        {
            var actual = configuredOptionObject.IsFieldLocked("234");
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void OptionObject_IsFieldLocked_Error()
        {
            var actual = configuredOptionObject.IsFieldLocked("456");
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void OptionObject_SetUnlockedFields_IsTrue()
        {
            List<string> requiredFields = ["123"];
            configuredOptionObject.SetUnlockedFields(requiredFields);
            Assert.IsTrue(!configuredOptionObject.IsFieldLocked("123"));
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void OptionObject_SetLockedFields_IsTrue()
        {
            List<string> lockedFields = ["123"];
            configuredOptionObject.SetLockedFields(lockedFields);
            Assert.IsTrue(configuredOptionObject.IsFieldLocked("123"));
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void OptionObject_IsFieldRequired_IsTrue()
        {
            var actual = configuredOptionObject.IsFieldRequired("123");
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void OptionObject_IsFieldRequired_AreNotEqual()
        {
            var actual = configuredOptionObject.IsFieldRequired("234");
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void OptionObject_IsFieldRequired_Error()
        {
            var actual = configuredOptionObject.IsFieldRequired("456");
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void OptionObject_SetOptionalFields_IsTrue()
        {
            List<string> optionalFields = ["123"];
            configuredOptionObject.SetOptionalFields(optionalFields);
            Assert.IsTrue(configuredOptionObject.IsFieldEnabled("123"));
            Assert.IsFalse(configuredOptionObject.IsFieldRequired("123"));
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void OptionObject_SetRequiredFields_AreEqual()
        {
            List<string> requiredFields = ["123"];
            configuredOptionObject.SetRequiredFields(requiredFields);
            Assert.IsTrue(configuredOptionObject.IsFieldEnabled("123"));
            Assert.IsTrue(configuredOptionObject.IsFieldRequired("123"));
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void OptionObject_Constructor_NoForms_AreEqual()
        {
            string entityId = "12345";
            double episodeNumber = 0;
            string facility = "1";
            string optionId = "USER37";
            string optionStaffId = "";
            string optionUserId = "username";
            string systemCode = "UAT";
            int formCount = 0;

            OptionObject optionObject = new(optionId, optionUserId, optionStaffId
                , facility, entityId, episodeNumber
                , systemCode);
            Assert.AreEqual(entityId, optionObject.EntityID);
            Assert.AreEqual(episodeNumber, optionObject.EpisodeNumber);
            Assert.AreEqual(facility, optionObject.Facility);
            Assert.AreEqual(optionId, optionObject.OptionId);
            Assert.AreEqual(optionStaffId, optionObject.OptionStaffId);
            Assert.AreEqual(optionUserId, optionObject.OptionUserId);
            Assert.AreEqual(systemCode, optionObject.SystemCode);
            Assert.AreEqual(formCount, optionObject.Forms.Count);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void OptionObject_Constructor_WithForms_AreEqual()
        {
            string entityId = "12345";
            double episodeNumber = 0;
            string facility = "1";
            string optionId = "USER37";
            string optionStaffId = "";
            string optionUserId = "username";
            string systemCode = "UAT";
            List<FormObject> forms =
            [
                new FormObject("1"),
                new FormObject("2")
            ];
            int formCount = 2;

            OptionObject optionObject = new(optionId, optionUserId, optionStaffId
                , facility, entityId, episodeNumber
                , systemCode
                , forms);
            Assert.AreEqual(entityId, optionObject.EntityID);
            Assert.AreEqual(episodeNumber, optionObject.EpisodeNumber);
            Assert.AreEqual(facility, optionObject.Facility);
            Assert.AreEqual(optionId, optionObject.OptionId);
            Assert.AreEqual(optionStaffId, optionObject.OptionStaffId);
            Assert.AreEqual(optionUserId, optionObject.OptionUserId);
            Assert.AreEqual(systemCode, optionObject.SystemCode);
            Assert.AreEqual(formCount, optionObject.Forms.Count);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void OptionObject_Clone_AreEqual()
        {
            List<FieldObject> fieldObjects =
            [
                new FieldObject("123", "Test")
            ];
            RowObject rowObject = new("1||1", fieldObjects);
            FormObject formObject = new("1", rowObject);
            OptionObject optionObject = new("USER00", "userId", "000111", "1", "123456", 1, "UAT");
            optionObject.AddFormObject(formObject);

            OptionObject cloneOptionObject = (OptionObject)optionObject.Clone();

            Assert.AreEqual(optionObject, cloneOptionObject);
            Assert.IsTrue(optionObject.IsFieldPresent("123"));
            Assert.IsTrue(cloneOptionObject.IsFieldPresent("123"));
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void OptionObject_ReturnOptionObject_AreNotEqual()
        {
            List<FieldObject> fieldObjects =
            [
                new FieldObject("123", "Test")
            ];
            RowObject rowObject = new("1||1", fieldObjects);
            FormObject formObject = new("1", rowObject);
            OptionObject optionObject = new("USER00", "userId", "000111", "1", "123456", 1, "UAT");
            optionObject.AddFormObject(formObject);

            OptionObject returnOptionObject = optionObject.ToReturnOptionObject();

            Assert.AreNotEqual(optionObject, returnOptionObject);
            Assert.IsTrue(optionObject.IsFieldPresent("123"));
            Assert.IsFalse(returnOptionObject.IsFieldPresent("123"));
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void OptionObject_ReturnOptionObject_ErrorCodeNotOverwritten()
        {
            double expected = 3;
            OptionObject optionObject = OptionObject.Builder().OptionId("USER123").Build();
            optionObject.ErrorCode = expected;
            OptionObject returnOptionObject = optionObject.ToReturnOptionObject();

            Assert.AreEqual(expected, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void OptionObject_ReturnOptionObject_ErrorMesgNotOverwritten()
        {
            string expected = "Preset error message";
            OptionObject optionObject = OptionObject.Builder().OptionId("USER123").Build();
            optionObject.ErrorMesg = expected;
            OptionObject returnOptionObject = optionObject.ToReturnOptionObject();

            Assert.AreEqual(expected, returnOptionObject.ErrorMesg);
        }
    }
}
