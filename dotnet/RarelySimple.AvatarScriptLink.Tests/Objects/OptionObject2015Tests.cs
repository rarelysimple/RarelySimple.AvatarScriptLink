using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Tests.Objects
{
    [TestClass]
    public class OptionObject2015Tests
    {
        private OptionObject2015 configuredOptionObject2015 = new();

        [TestInitialize]
        public void TestInitialize()
        {
            configuredOptionObject2015 = OptionObject2015.Initialize();
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

            configuredOptionObject2015 = OptionObject2015.Builder()
                                                         .OptionId("OPT1234")
                                                         .Form(formObject)
                                                         .Form(miFormObject)
                                                         .Build();
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015_HasFormObject()
        {
            OptionObject2015 optionObject = OptionObject2015.Initialize();
            Assert.IsNotNull(optionObject.Forms);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015_Forms_IsNotEmpty()
        {
            OptionObject2015 optionObject = OptionObject2015.Initialize();
            var expected = new List<FormObject>();
            var actual = optionObject.Forms;
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015_CanGetHtmlString_WithoutHtmlHeaders()
        {
            OptionObject2015 optionObject = OptionObject2015.Initialize();
            var actual = optionObject.ToHtmlString(false);
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015_CanGetHtmlString_WithHtmlHeaders()
        {
            OptionObject2015 optionObject = OptionObject2015.Initialize();
            var actual = optionObject.ToHtmlString(true);
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015_AddFormObject_FormObject()
        {
            FormObject formObject1 = FormObject.Builder()
                                               .FormId("1")
                                               .Build();
            FormObject formObject2 = FormObject.Builder()
                                               .FormId("2")
                                               .MultipleIteration()
                                               .Build();
            OptionObject2015 optionObject = OptionObject2015.Initialize();
            optionObject.AddFormObject(formObject1);
            Assert.AreEqual(1, optionObject.Forms.Count);
            optionObject.AddFormObject(formObject2);
            Assert.AreEqual(2, optionObject.Forms.Count);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015_AddFormObject_FormObject_Exception()
        {
            FormObject formObject1 = FormObject.Builder().FormId("1").Build();
            OptionObject2015 optionObject = OptionObject2015.Initialize();
            optionObject.AddFormObject(formObject1);
            Assert.AreEqual(1, optionObject.Forms.Count);
            Assert.ThrowsException<ArgumentException>(() => optionObject.AddFormObject(formObject1));
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015_AddFormObject_Properties()
        {
            OptionObject2015 optionObject = OptionObject2015.Initialize();
            optionObject.AddFormObject("1", false);
            Assert.AreEqual(1, optionObject.Forms.Count);
            optionObject.AddFormObject("2", true);
            Assert.AreEqual(2, optionObject.Forms.Count);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015_AddFormObject_Properties_Exception()
        {
            OptionObject2015 optionObject = OptionObject2015.Initialize();
            optionObject.AddFormObject("1", false);
            Assert.AreEqual(1, optionObject.Forms.Count);
            Assert.ThrowsException<ArgumentException>(() => optionObject.AddFormObject("1", false));
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015_GetCurrentRowId_Error()
        {
            OptionObject2015 optionObject = OptionObject2015.Initialize();
            Assert.ThrowsException<ArgumentException>(() => optionObject.GetCurrentRowId("1"));
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015_GetCurrentRowId_AreEqual()
        {
            FormObject formObject = FormObject.Builder()
                                              .FormId("1")
                                              .CurrentRow()
                                                    .RowId("1||1")
                                                    .AddRow()
                                              .Build();
            OptionObject2015 optionObject = OptionObject2015.Builder()
                                                            .OptionId("OPT1234")
                                                            .Form(formObject)
                                                            .Build();
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
        public void OptionObject2015_GetFieldValue_AreNotEqual()
        {
            OptionObject2015 optionObject = OptionObject2015.Initialize();
            Assert.ThrowsException<ArgumentException>(() => optionObject.GetFieldValue("123"));
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
        public void OptionObject2015_GetFieldValue_MI_AreNotEqual()
        {
            Assert.ThrowsException<ArgumentException>(() => configuredOptionObject2015.GetFieldValue("456"));
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
            string formId = "1";
            OptionObject2015 optionObject = OptionObject2015.Builder()
                                                            .OptionId("OPT1234")
                                                            .Form()
                                                                .FormId(formId)
                                                                .AddForm()
                                                            .Build();
            var actual = optionObject.GetMultipleIterationStatus(formId);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015_GetMultipleIterationStatus_IsNotFound()
        {
            OptionObject2015 optionObject = OptionObject2015.Initialize();
            Assert.ThrowsException<ArgumentException>(() => optionObject.GetMultipleIterationStatus("1"));
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
        public void OptionObject2015_GetParentRowId_Error()
        {
            OptionObject2015 optionObject = new();
            Assert.ThrowsException<ArgumentException>(() => optionObject.GetParentRowId("1"));
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015_GetParentRowId_AreEqual()
        {
            RowObject rowObject = RowObject.Builder().RowId("1||2").ParentRowId("1||1").Build();
            OptionObject2015 optionObject = OptionObject2015.Builder()
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
        public void OptionObject2015_IsFieldEnabled_Error()
        {
            Assert.ThrowsException<ArgumentException>(() => configuredOptionObject2015.IsFieldEnabled("456"));
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015_SetDisabledFields_IsTrue()
        {
            List<string> disabledFields = ["123"];
            configuredOptionObject2015.SetDisabledFields(disabledFields);
            Assert.IsFalse(configuredOptionObject2015.IsFieldEnabled("123"));
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
        public void OptionObject2015_IsFieldLocked_Error()
        {
            Assert.ThrowsException<ArgumentException>(() => configuredOptionObject2015.IsFieldLocked("456"));
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015_SetUnlockedFields_IsTrue()
        {
            List<string> requiredFields = ["123"];
            configuredOptionObject2015.SetUnlockedFields(requiredFields);
            Assert.IsTrue(!configuredOptionObject2015.IsFieldLocked("123"));
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015_SetLockedFields_IsTrue()
        {
            List<string> lockedFields = ["123"];
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
        public void OptionObject2015_IsFieldRequired_Error()
        {
            Assert.ThrowsException<ArgumentException>(() => configuredOptionObject2015.IsFieldRequired("456"));
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015_SetOptionalFields_IsTrue()
        {
            List<string> optionalFields = ["123"];
            configuredOptionObject2015.SetOptionalFields(optionalFields);
            Assert.IsTrue(configuredOptionObject2015.IsFieldEnabled("123"));
            Assert.IsFalse(configuredOptionObject2015.IsFieldRequired("123"));
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015_SetRequiredFields_AreEqual()
        {
            List<string> requiredFields = ["123"];
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

            OptionObject2015 optionObject = new(optionId, optionUserId, optionStaffId
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
            List<FormObject> forms =
            [
                new FormObject("1"),
                new FormObject("2")
            ];
            int formCount = 2;

            OptionObject2015 optionObject = new(optionId, optionUserId, optionStaffId
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
            List<FieldObject> fieldObjects =
            [
                new FieldObject("123", "Test")
            ];
            RowObject rowObject = new("1||1", fieldObjects);
            FormObject formObject = new("1", rowObject);
            OptionObject2015 optionObject = new("USER00", "userId", "000111", "1", "123456", 1, "UAT", "AVPM", "AVPM", "SERVER", "TOKEN");
            optionObject.AddFormObject(formObject);

            OptionObject2015 cloneOptionObject = optionObject.Clone();

            Assert.AreEqual(optionObject, cloneOptionObject);
            Assert.IsTrue(optionObject.IsFieldPresent("123"));
            Assert.IsTrue(cloneOptionObject.IsFieldPresent("123"));
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015_ReturnOptionObject_SessionTokenReturned()
        {
            List<FieldObject> fieldObjects =
            [
                new FieldObject("123", "Test")
            ];
            RowObject rowObject = new("1||1", fieldObjects);
            FormObject formObject = new("1", rowObject);
            OptionObject2015 optionObject = new("USER00", "userId", "000111", "1", "123456", 1, "UAT", "AVPM", "AVPM", "SERVER", "TOKEN");
            optionObject.AddFormObject(formObject);

            OptionObject2015 returnOptionObject = optionObject.ToReturnOptionObject();

            Assert.AreEqual(optionObject.SessionToken, returnOptionObject.SessionToken);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015_ReturnOptionObject_AreNotEqual()
        {
            List<FieldObject> fieldObjects =
            [
                new FieldObject("123", "Test")
            ];
            RowObject rowObject = new("1||1", fieldObjects);
            FormObject formObject = new("1", rowObject);
            OptionObject2015 optionObject = new("USER00", "userId", "000111", "1", "123456", 1, "UAT", "AVPM", "AVPM", "SERVER", "TOKEN");
            optionObject.AddFormObject(formObject);

            OptionObject2015 returnOptionObject = optionObject.ToReturnOptionObject();
            
            Assert.AreNotEqual(optionObject.ToJson(), returnOptionObject.ToJson());
            Assert.IsTrue(optionObject.IsFieldPresent("123"));
            Assert.IsFalse(returnOptionObject.IsFieldPresent("123"));
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015_ReturnOptionObject_ErrorCodeNotOverwritten()
        {
            double expected = 3;
            OptionObject2015 optionObject = OptionObject2015.Builder().OptionId("USER123").Build();
            optionObject.ErrorCode = expected;
            OptionObject2015 returnOptionObject = optionObject.ToReturnOptionObject();

            Assert.AreEqual(expected, returnOptionObject.ErrorCode);
        }

        [TestMethod]
        [TestCategory("OptionObject2015")]
        public void OptionObject2015_ReturnOptionObject_ErrorMesgNotOverwritten()
        {
            string expected = "Preset error message";
            OptionObject2015 optionObject = OptionObject2015.Builder().OptionId("USER123").Build();
            optionObject.ErrorMesg = expected;
            OptionObject2015 returnOptionObject = optionObject.ToReturnOptionObject();

            Assert.AreEqual(expected, returnOptionObject.ErrorMesg);
        }

        [TestMethod]
        public void OptionObject2015_ReturnOptionObject_ErrorCodeAndMesgAreEqual()
        {
            string expected = "message";
            OptionObject2015 optionObject = OptionObject2015.Builder().OptionId("USER123").Build();
            OptionObject2015 returnOptionObject = optionObject.ToReturnOptionObject(ErrorCode.Success, expected);

            Assert.AreEqual(ErrorCode.Success, returnOptionObject.ErrorCode);
            Assert.AreEqual(expected, returnOptionObject.ErrorMesg);
        }

        [TestMethod]
        public void OptionObject2015_ToOptionObject2015_AreEqual() {
            OptionObject2015 optionObject = OptionObject2015.Builder().OptionId("USER123").Build();
            OptionObject2015 clone = optionObject.ToOptionObject2015();
            Assert.AreEqual(optionObject, clone);
        }

        [TestMethod]
        public void OptionObject2015_Builder_OptionIdIsNull() {
            Assert.ThrowsException<ArgumentNullException>(() => OptionObject2015.Builder().OptionId(null).Build());
        }

        [TestMethod]
        public void OptionObject2015_Builder_EntityIdIsNull() {
            Assert.ThrowsException<ArgumentNullException>(() => OptionObject2015.Builder().OptionId("USER123").EntityId(null).Build());
        }

        [TestMethod]
        public void OptionObject2015_Builder_FacilityIsNull() {
            Assert.ThrowsException<ArgumentNullException>(() => OptionObject2015.Builder().OptionId("USER123").Facility(null).Build());
        }

        [TestMethod]
        public void OptionObject2015_Builder_NamespaceNameIsNull() {
            Assert.ThrowsException<ArgumentNullException>(() => OptionObject2015.Builder().OptionId("USER123").NamespaceName(null).Build());
        }

        [TestMethod]
        public void OptionObject2015_Builder_OptionStaffIdIsNull() {
            Assert.ThrowsException<ArgumentNullException>(() => OptionObject2015.Builder().OptionId("USER123").OptionStaffId(null).Build());
        }

        [TestMethod]
        public void OptionObject2015_Builder_OptionUserIdIsNull() {
            Assert.ThrowsException<ArgumentNullException>(() => OptionObject2015.Builder().OptionId("USER123").OptionUserId(null).Build());
        }

        [TestMethod]
        public void OptionObject2015_Builder_ParentNamespaceIsNull() {
            Assert.ThrowsException<ArgumentNullException>(() => OptionObject2015.Builder().OptionId("USER123").ParentNamespace(null).Build());
        }

        [TestMethod]
        public void OptionObject2015_Builder_ServerNameIsNull() {
            Assert.ThrowsException<ArgumentNullException>(() => OptionObject2015.Builder().OptionId("USER123").ServerName(null).Build());
        }

        [TestMethod]
        public void OptionObject2015_Builder_SessionTokenIsNull() {
            Assert.ThrowsException<ArgumentNullException>(() => OptionObject2015.Builder().OptionId("USER123").SessionToken(null).Build());
        }

        [TestMethod]
        public void OptionObject2015_Builder_SystemCodeIsNull() {
            Assert.ThrowsException<ArgumentNullException>(() => OptionObject2015.Builder().OptionId("USER123").SystemCode(null).Build());
        }
    }
}
