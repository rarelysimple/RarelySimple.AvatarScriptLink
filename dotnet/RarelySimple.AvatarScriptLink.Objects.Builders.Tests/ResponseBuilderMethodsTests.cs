namespace RarelySimple.AvatarScriptLink.Objects.Builders.Tests
{
    [TestClass]
    public class OptionObjectResponseBuildersTests
    {
        [TestMethod]
        public void CreateSuccessResponse_SetsSuccessFields()
        {
            // Arrange
            string entityId = "Patient123";

            // Act
            OptionObject response = OptionObjectResponseBuilders.CreateSuccessResponse(entityId);

            // Assert
            Assert.AreEqual(entityId, response.EntityID);
            Assert.AreEqual(0d, response.ErrorCode);
            Assert.AreEqual(string.Empty, response.ErrorMesg);
        }

        [TestMethod]
        public void CreateErrorResponse_SetsErrorFields()
        {
            // Arrange
            string entityId = "Patient123";
            double errorCode = 2;
            string errorMessage = "Response error";

            // Act
            OptionObject response = OptionObjectResponseBuilders.CreateErrorResponse(entityId, errorCode, errorMessage);

            // Assert
            Assert.AreEqual(entityId, response.EntityID);
            Assert.AreEqual(errorCode, response.ErrorCode);
            Assert.AreEqual(errorMessage, response.ErrorMesg);
        }

        [TestMethod]
        public void CreateSuccessResponse2_SetsSuccessFields()
        {
            // Arrange
            string entityId = "Patient456";

            // Act
            OptionObject2 response = OptionObject2ResponseBuilders.CreateSuccessResponse(entityId);

            // Assert
            Assert.AreEqual(entityId, response.EntityID);
            Assert.AreEqual(0d, response.ErrorCode);
            Assert.AreEqual(string.Empty, response.ErrorMesg);
        }

        [TestMethod]
        public void CreateErrorResponse2015_SetsErrorFields()
        {
            // Arrange
            string entityId = "Patient789";
            double errorCode = 4;
            string errorMessage = "Response error";

            // Act
            OptionObject2015 response = OptionObject2015ResponseBuilders.CreateErrorResponse(entityId, errorCode, errorMessage);

            // Assert
            Assert.AreEqual(entityId, response.EntityID);
            Assert.AreEqual(errorCode, response.ErrorCode);
            Assert.AreEqual(errorMessage, response.ErrorMesg);
        }

        [TestMethod]
        public void CreateSuccessResponse2015_WithSessionDetails_SetsSessionFields()
        {
            // Arrange
            string entityId = "Patient999";
            string sessionToken = "SESSION-123";
            string optionUserId = "USER-456";

            // Act
            OptionObject2015 response = OptionObject2015ResponseBuilders.CreateSuccessResponse(entityId, sessionToken, optionUserId);

            // Assert
            Assert.AreEqual(entityId, response.EntityID);
            Assert.AreEqual(0d, response.ErrorCode);
            Assert.AreEqual(string.Empty, response.ErrorMesg);
            Assert.AreEqual(sessionToken, response.SessionToken);
            Assert.AreEqual(optionUserId, response.OptionUserId);
        }

        [TestMethod]
        public void CreateErrorResponse2015_WithSessionToken_SetsSessionFields()
        {
            // Arrange
            string entityId = "Patient888";
            double errorCode = 3;
            string errorMessage = "Session error";
            string sessionToken = "SESSION-999";

            // Act
            OptionObject2015 response = OptionObject2015ResponseBuilders.CreateErrorResponse(entityId, errorCode, errorMessage, sessionToken);

            // Assert
            Assert.AreEqual(entityId, response.EntityID);
            Assert.AreEqual(errorCode, response.ErrorCode);
            Assert.AreEqual(errorMessage, response.ErrorMesg);
            Assert.AreEqual(sessionToken, response.SessionToken);
        }

        [TestMethod]
        public void AddResponseForm_AddsFormAndSetsMultipleIteration()
        {
            // Arrange
            var response = OptionObjectResponseBuilders.CreateSuccessResponse("Patient123");

            // Act
            FormObject form = response.AddResponseForm("FORM1", true);

            // Assert
            Assert.AreEqual(1, response.Forms.Count);
            Assert.AreSame(form, response.Forms[0]);
            Assert.IsTrue(form.MultipleIteration);
        }

        [TestMethod]
        public void ToReturnOptionObject_RemovesRowsWithoutValidAction_AndPreservesValidRows()
        {
            // Arrange
            var response = OptionObjectBuilders.CreateOptionObject("Patient123");
            var form = FormObjectBuilders.CreateFormObject("FORM1");
            form.WithCurrentRow(RowObjectBuilders.CreateRowObject("FORM1||1"));
            form.AddRow(RowObjectBuilders.CreateRowObject("FORM1||2").WithRowAction(RowObject.RowActions.Edit));
            response.AddForm(form);

            // Act
            OptionObject finalized = response.ToReturnOptionObject();

            // Assert
            Assert.AreEqual(1, finalized.Forms.Count);
            Assert.IsNull(finalized.Forms[0].CurrentRow);
            Assert.AreEqual(1, finalized.Forms[0].OtherRows.Count);
            Assert.AreEqual(RowObject.RowActions.Edit, finalized.Forms[0].OtherRows[0].RowAction);
        }

        [TestMethod]
        public void ToReturnOptionObject_DoesNotMutateSourceObject()
        {
            // Arrange
            var response = OptionObjectBuilders.CreateOptionObject("Patient123");
            var form = FormObjectBuilders.CreateFormObject("FORM1");
            form.WithCurrentRow(RowObjectBuilders.CreateRowObject("FORM1||1"));
            response.AddForm(form);

            // Act
            OptionObject finalized = response.ToReturnOptionObject();

            // Assert
            Assert.IsNotNull(response.Forms[0].CurrentRow);
            Assert.AreEqual(0, finalized.Forms.Count);
        }

        [TestMethod]
        public void ToReturnOptionObject_WithErrorDetails_SetsErrorFieldsOnReturnPayload()
        {
            // Arrange
            var response = OptionObjectBuilders.CreateOptionObject("Patient123");

            // Act
            OptionObject finalized = response.ToReturnOptionObject(4, "Error message");

            // Assert
            Assert.AreEqual(4d, finalized.ErrorCode);
            Assert.AreEqual("Error message", finalized.ErrorMesg);
        }

        [TestMethod]
        public void ToReturnOptionObject2_RemovesFormsWithoutReturnRows()
        {
            // Arrange
            var response = OptionObject2Builders.CreateOptionObject2("Patient456");
            var form = FormObjectBuilders.CreateFormObject("FORM2");
            form.WithCurrentRow(RowObjectBuilders.CreateRowObject("FORM2||1"));
            response.AddForm(form);

            // Act
            OptionObject2 finalized = response.ToReturnOptionObject();

            // Assert
            Assert.AreEqual(0, finalized.Forms.Count);
            Assert.AreEqual(1, response.Forms.Count);
        }

        [TestMethod]
        public void ToReturnOptionObject2015_WithErrorDetails_PreservesSessionToken()
        {
            // Arrange
            var response = OptionObject2015Builders.CreateOptionObject2015("Patient789")
                .WithSessionToken("SESSION-123");

            // Act
            OptionObject2015 finalized = response.ToReturnOptionObject(2, "Validation error");

            // Assert
            Assert.AreEqual("SESSION-123", finalized.SessionToken);
            Assert.AreEqual(2d, finalized.ErrorCode);
            Assert.AreEqual("Validation error", finalized.ErrorMesg);
        }

        [TestMethod]
        public void ToReturnOptionObject_Null_ThrowsArgumentNullException()
        {
            // Arrange
            OptionObject? response = null;

            // Act / Assert
            Assert.ThrowsException<ArgumentNullException>(() => response.ToReturnOptionObject());
        }

        [TestMethod]
        public void ToReturnOptionObject2_Null_ThrowsArgumentNullException()
        {
            // Arrange
            OptionObject2? response = null;

            // Act / Assert
            Assert.ThrowsException<ArgumentNullException>(() => response.ToReturnOptionObject());
        }

        [TestMethod]
        public void ToReturnOptionObject2015_Null_ThrowsArgumentNullException()
        {
            // Arrange
            OptionObject2015? response = null;

            // Act / Assert
            Assert.ThrowsException<ArgumentNullException>(() => response.ToReturnOptionObject());
        }

        [TestMethod]
        public void GetReturnOptionObject_Alias_MatchesToReturnOptionObjectBehavior()
        {
            // Arrange
            var response = OptionObjectBuilders.CreateOptionObject("Patient123");
            var form = FormObjectBuilders.CreateFormObject("FORM1");
            form.WithCurrentRow(RowObjectBuilders.CreateRowObject("FORM1||1"));
            form.AddRow(RowObjectBuilders.CreateRowObject("FORM1||2").WithRowAction(RowObject.RowActions.Delete));
            response.AddForm(form);

            // Act
            OptionObject finalizedByAlias = response.GetReturnOptionObject();
            OptionObject finalizedByPrimary = response.ToReturnOptionObject();

            // Assert
            Assert.AreEqual(finalizedByPrimary.Forms.Count, finalizedByAlias.Forms.Count);
            Assert.AreEqual(finalizedByPrimary.Forms[0].OtherRows.Count, finalizedByAlias.Forms[0].OtherRows.Count);
            Assert.AreEqual(finalizedByPrimary.Forms[0].OtherRows[0].RowAction, finalizedByAlias.Forms[0].OtherRows[0].RowAction);
        }

        [TestMethod]
        public void GetReturnOptionObject_WithErrorDetails_Alias_MatchesPrimaryBehavior()
        {
            // Arrange
            var response = OptionObjectBuilders.CreateOptionObject("Patient123");

            // Act
            OptionObject finalizedByAlias = response.GetReturnOptionObject(6, "Open form text");
            OptionObject finalizedByPrimary = response.ToReturnOptionObject(6, "Open form text");

            // Assert
            Assert.AreEqual(finalizedByPrimary.ErrorCode, finalizedByAlias.ErrorCode);
            Assert.AreEqual(finalizedByPrimary.ErrorMesg, finalizedByAlias.ErrorMesg);
        }

        [TestMethod]
        public void ToReturnOptionObject_RemovesNullFormsAndNullRows()
        {
            // Arrange
            var response = OptionObjectBuilders.CreateOptionObject("Patient123");

            var formWithNullCurrentRow = FormObjectBuilders.CreateFormObject("FORM1");
            formWithNullCurrentRow.WithCurrentRow(null);
            formWithNullCurrentRow.AddRow(null);
            formWithNullCurrentRow.AddRow(RowObjectBuilders.CreateRowObject("FORM1||2").WithRowAction(RowObject.RowActions.Add));

            response.Forms.Add(null);
            response.AddForm(formWithNullCurrentRow);

            // Act
            OptionObject finalized = response.ToReturnOptionObject();

            // Assert
            Assert.AreEqual(1, finalized.Forms.Count);
            Assert.IsNotNull(finalized.Forms[0]);
            Assert.IsNull(finalized.Forms[0].CurrentRow);
            Assert.AreEqual(1, finalized.Forms[0].OtherRows.Count);
            Assert.AreEqual(RowObject.RowActions.Add, finalized.Forms[0].OtherRows[0].RowAction);
        }

        [TestMethod]
        public void ToReturnOptionObject_MixedRowActions_PreservesAddEditDeleteOnly()
        {
            // Arrange
            var response = OptionObjectBuilders.CreateOptionObject("Patient123");
            var form = FormObjectBuilders.CreateFormObject("FORM1");
            form.WithCurrentRow(RowObjectBuilders.CreateRowObject("FORM1||1").WithRowAction("INVALID"));
            form.AddRow(RowObjectBuilders.CreateRowObject("FORM1||2").WithRowAction(RowObject.RowActions.Add));
            form.AddRow(RowObjectBuilders.CreateRowObject("FORM1||3").WithRowAction(RowObject.RowActions.Edit));
            form.AddRow(RowObjectBuilders.CreateRowObject("FORM1||4").WithRowAction(RowObject.RowActions.Delete));
            form.AddRow(RowObjectBuilders.CreateRowObject("FORM1||5"));
            response.AddForm(form);

            // Act
            OptionObject finalized = response.ToReturnOptionObject();

            // Assert
            Assert.AreEqual(1, finalized.Forms.Count);
            Assert.IsNull(finalized.Forms[0].CurrentRow);
            Assert.AreEqual(3, finalized.Forms[0].OtherRows.Count);
            CollectionAssert.AreEquivalent(
                new[] { RowObject.RowActions.Add, RowObject.RowActions.Edit, RowObject.RowActions.Delete },
                new[]
                {
                    finalized.Forms[0].OtherRows[0].RowAction,
                    finalized.Forms[0].OtherRows[1].RowAction,
                    finalized.Forms[0].OtherRows[2].RowAction
                });
        }

        [TestMethod]
        public void ToReturnOptionObject_PreservesOptionMetadataOnClone()
        {
            // Arrange
            var response = OptionObjectBuilders.CreateOptionObject("Patient123");
            response.EpisodeNumber = 12;
            response.Facility = "FAC";
            response.OptionId = "OPT-1";
            response.OptionStaffId = "STAFF-1";
            response.OptionUserId = "USER-1";
            response.SystemCode = "UAT";

            var form = FormObjectBuilders.CreateFormObject("FORM1");
            form.AddRow(RowObjectBuilders.CreateRowObject("FORM1||2").WithRowAction(RowObject.RowActions.Edit));
            response.AddForm(form);

            // Act
            OptionObject finalized = response.ToReturnOptionObject();

            // Assert
            Assert.AreEqual(response.EntityID, finalized.EntityID);
            Assert.AreEqual(response.EpisodeNumber, finalized.EpisodeNumber);
            Assert.AreEqual(response.Facility, finalized.Facility);
            Assert.AreEqual(response.OptionId, finalized.OptionId);
            Assert.AreEqual(response.OptionStaffId, finalized.OptionStaffId);
            Assert.AreEqual(response.OptionUserId, finalized.OptionUserId);
            Assert.AreEqual(response.SystemCode, finalized.SystemCode);
        }

        [TestMethod]
        public void ToReturnOptionObject2_MixedRows_PrunesInvalidAndPreservesValid()
        {
            // Arrange
            var response = OptionObject2Builders.CreateOptionObject2("Patient456");
            var form = FormObjectBuilders.CreateFormObject("FORM2");
            form.WithCurrentRow(RowObjectBuilders.CreateRowObject("FORM2||1").WithRowAction(RowObject.RowActions.Edit));
            form.AddRow(RowObjectBuilders.CreateRowObject("FORM2||2"));
            form.AddRow(RowObjectBuilders.CreateRowObject("FORM2||3").WithRowAction(RowObject.RowActions.Delete));
            response.AddForm(form);

            // Act
            OptionObject2 finalized = response.ToReturnOptionObject();

            // Assert
            Assert.AreEqual(1, finalized.Forms.Count);
            Assert.IsNotNull(finalized.Forms[0].CurrentRow);
            Assert.AreEqual(RowObject.RowActions.Edit, finalized.Forms[0].CurrentRow.RowAction);
            Assert.AreEqual(1, finalized.Forms[0].OtherRows.Count);
            Assert.AreEqual(RowObject.RowActions.Delete, finalized.Forms[0].OtherRows[0].RowAction);
        }

        [TestMethod]
        public void ToReturnOptionObject2015_Preserves2015SpecificMetadata()
        {
            // Arrange
            var response = OptionObject2015Builders.CreateOptionObject2015("Patient789")
                .WithSessionToken("SESSION-XYZ")
                .WithOptionUserId("USER-XYZ")
                .WithEntityId("Patient789");
            response.NamespaceName = "NS";
            response.ParentNamespace = "PNS";
            response.ServerName = "SRV";

            var form = FormObjectBuilders.CreateFormObject("FORM2015");
            form.AddRow(RowObjectBuilders.CreateRowObject("FORM2015||1").WithRowAction(RowObject.RowActions.Add));
            response.AddForm(form);

            // Act
            OptionObject2015 finalized = response.ToReturnOptionObject();

            // Assert
            Assert.AreEqual("SESSION-XYZ", finalized.SessionToken);
            Assert.AreEqual("USER-XYZ", finalized.OptionUserId);
            Assert.AreEqual("NS", finalized.NamespaceName);
            Assert.AreEqual("PNS", finalized.ParentNamespace);
            Assert.AreEqual("SRV", finalized.ServerName);
            Assert.AreEqual(1, finalized.Forms.Count);
        }

        [TestMethod]
        public void ToReturnOptionObject_WithBaseline_PrunesUnchangedEditFields()
        {
            // Arrange
            var baseline = OptionObjectBuilders.CreateOptionObject("Patient123");
            var baselineForm = FormObjectBuilders.CreateFormObject("FORM1");
            baselineForm.AddRow(
                RowObjectBuilders.CreateRowObject("FORM1||1")
                    .WithRowAction(RowObject.RowActions.Edit)
                    .AddField(FieldObjectBuilders.CreateFieldObject("100").WithFieldValue("A"))
                    .AddField(FieldObjectBuilders.CreateFieldObject("200").WithFieldValue("B")));
            baseline.AddForm(baselineForm);

            var working = baseline.Clone();
            working.Forms[0].OtherRows[0].Fields[1].FieldValue = "B-CHANGED";

            // Act
            OptionObject finalized = working.ToReturnOptionObject(baseline);

            // Assert
            Assert.AreEqual(1, finalized.Forms.Count);
            Assert.AreEqual(1, finalized.Forms[0].OtherRows.Count);
            Assert.AreEqual(1, finalized.Forms[0].OtherRows[0].Fields.Count);
            Assert.AreEqual("200", finalized.Forms[0].OtherRows[0].Fields[0].FieldNumber);
            Assert.AreEqual("B-CHANGED", finalized.Forms[0].OtherRows[0].Fields[0].FieldValue);
        }

        [TestMethod]
        public void ToReturnOptionObject_WithoutBaseline_DoesNotPruneEditFields()
        {
            // Arrange
            var working = OptionObjectBuilders.CreateOptionObject("Patient123");
            var form = FormObjectBuilders.CreateFormObject("FORM1");
            form.AddRow(
                RowObjectBuilders.CreateRowObject("FORM1||1")
                    .WithRowAction(RowObject.RowActions.Edit)
                    .AddField(FieldObjectBuilders.CreateFieldObject("100").WithFieldValue("A"))
                    .AddField(FieldObjectBuilders.CreateFieldObject("200").WithFieldValue("B")));
            working.AddForm(form);

            // Act
            OptionObject finalized = working.ToReturnOptionObject();

            // Assert
            Assert.AreEqual(1, finalized.Forms.Count);
            Assert.AreEqual(1, finalized.Forms[0].OtherRows.Count);
            Assert.AreEqual(2, finalized.Forms[0].OtherRows[0].Fields.Count);
        }

        [TestMethod]
        public void ToReturnOptionObject_WithBaselineNull_FallsBackToNoBaselineBehavior()
        {
            // Arrange
            var working = OptionObjectBuilders.CreateOptionObject("Patient123");
            var form = FormObjectBuilders.CreateFormObject("FORM1");
            form.AddRow(
                RowObjectBuilders.CreateRowObject("FORM1||1")
                    .WithRowAction(RowObject.RowActions.Edit)
                    .AddField(FieldObjectBuilders.CreateFieldObject("100").WithFieldValue("A"))
                    .AddField(FieldObjectBuilders.CreateFieldObject("200").WithFieldValue("B")));
            working.AddForm(form);

            // Act
            OptionObject? baseline = null;
            OptionObject finalized = working.ToReturnOptionObject(baseline);

            // Assert
            Assert.AreEqual(2, finalized.Forms[0].OtherRows[0].Fields.Count);
        }

        [TestMethod]
        public void ToReturnOptionObject_WithBaseline_PreservesAddAndDeleteRowsWithoutFieldPruning()
        {
            // Arrange
            var baseline = OptionObjectBuilders.CreateOptionObject("Patient123");
            var baselineForm = FormObjectBuilders.CreateFormObject("FORM1");
            baselineForm.AddRow(
                RowObjectBuilders.CreateRowObject("FORM1||1")
                    .WithRowAction(RowObject.RowActions.Edit)
                    .AddField(FieldObjectBuilders.CreateFieldObject("100").WithFieldValue("A")));
            baseline.AddForm(baselineForm);

            var working = OptionObjectBuilders.CreateOptionObject("Patient123");
            var workingForm = FormObjectBuilders.CreateFormObject("FORM1");
            workingForm.AddRow(
                RowObjectBuilders.CreateRowObject("FORM1||2")
                    .WithRowAction(RowObject.RowActions.Add)
                    .AddField(FieldObjectBuilders.CreateFieldObject("300").WithFieldValue("NEW"))
                    .AddField(FieldObjectBuilders.CreateFieldObject("301").WithFieldValue("NEW2")));
            workingForm.AddRow(
                RowObjectBuilders.CreateRowObject("FORM1||3")
                    .WithRowAction(RowObject.RowActions.Delete)
                    .AddField(FieldObjectBuilders.CreateFieldObject("400").WithFieldValue("OLD")));
            working.AddForm(workingForm);

            // Act
            OptionObject finalized = working.ToReturnOptionObject(baseline);

            // Assert
            Assert.AreEqual(2, finalized.Forms[0].OtherRows.Count);
            Assert.AreEqual(RowObject.RowActions.Add, finalized.Forms[0].OtherRows[0].RowAction);
            Assert.AreEqual(2, finalized.Forms[0].OtherRows[0].Fields.Count);
            Assert.AreEqual(RowObject.RowActions.Delete, finalized.Forms[0].OtherRows[1].RowAction);
            Assert.AreEqual(1, finalized.Forms[0].OtherRows[1].Fields.Count);
        }

        [TestMethod]
        public void ToReturnOptionObject_WithBaseline_MissingIdentifiers_DoesNotPruneFields()
        {
            // Arrange
            var baseline = OptionObjectBuilders.CreateOptionObject("Patient123");
            var baselineForm = FormObjectBuilders.CreateFormObject("FORM1");
            baselineForm.AddRow(
                RowObjectBuilders.CreateRowObject("FORM1||1")
                    .WithRowAction(RowObject.RowActions.Edit)
                    .AddField(FieldObjectBuilders.CreateFieldObject("100").WithFieldValue("A")));
            baselineForm.FormId = null;
            baselineForm.OtherRows[0].RowId = null;
            baseline.AddForm(baselineForm);

            var working = baseline.Clone();

            // Act
            OptionObject finalized = working.ToReturnOptionObject(baseline);

            // Assert
            Assert.AreEqual(1, finalized.Forms.Count);
            Assert.AreEqual(1, finalized.Forms[0].OtherRows.Count);
            Assert.AreEqual(1, finalized.Forms[0].OtherRows[0].Fields.Count);
            Assert.AreEqual("100", finalized.Forms[0].OtherRows[0].Fields[0].FieldNumber);
        }

        [TestMethod]
        public void ToReturnOptionObject2_WithBaseline_PrunesUnchangedEditFields()
        {
            // Arrange
            var baseline = OptionObject2Builders.CreateOptionObject2("Patient456");
            var baselineForm = FormObjectBuilders.CreateFormObject("FORM2");
            baselineForm.AddRow(
                RowObjectBuilders.CreateRowObject("FORM2||1")
                    .WithRowAction(RowObject.RowActions.Edit)
                    .AddField(FieldObjectBuilders.CreateFieldObject("100").WithFieldValue("A"))
                    .AddField(FieldObjectBuilders.CreateFieldObject("200").WithFieldValue("B")));
            baseline.AddForm(baselineForm);

            var working = baseline.Clone();
            working.Forms[0].OtherRows[0].Fields[0].FieldValue = "A-CHANGED";

            // Act
            OptionObject2 finalized = working.ToReturnOptionObject(baseline);

            // Assert
            Assert.AreEqual(1, finalized.Forms[0].OtherRows[0].Fields.Count);
            Assert.AreEqual("100", finalized.Forms[0].OtherRows[0].Fields[0].FieldNumber);
        }

        [TestMethod]
        public void ToReturnOptionObject2015_WithBaseline_PrunesUnchangedEditFields()
        {
            // Arrange
            var baseline = OptionObject2015Builders.CreateOptionObject2015("Patient789")
                .WithSessionToken("SESSION");
            var baselineForm = FormObjectBuilders.CreateFormObject("FORM2015");
            baselineForm.AddRow(
                RowObjectBuilders.CreateRowObject("FORM2015||1")
                    .WithRowAction(RowObject.RowActions.Edit)
                    .AddField(FieldObjectBuilders.CreateFieldObject("100").WithFieldValue("A"))
                    .AddField(FieldObjectBuilders.CreateFieldObject("200").WithFieldValue("B")));
            baseline.AddForm(baselineForm);

            var working = baseline.Clone();
            working.Forms[0].OtherRows[0].Fields[1].Required = FieldObject.RequiredStatus.Required;

            // Act
            OptionObject2015 finalized = working.ToReturnOptionObject(baseline);

            // Assert
            Assert.AreEqual(1, finalized.Forms[0].OtherRows[0].Fields.Count);
            Assert.AreEqual("200", finalized.Forms[0].OtherRows[0].Fields[0].FieldNumber);
            Assert.AreEqual(FieldObject.RequiredStatus.Required, finalized.Forms[0].OtherRows[0].Fields[0].Required);
        }

        [TestMethod]
        public void ToReturnOptionObject_WithBaseline_RepeatedCalls_ProducesDeterministicPayload()
        {
            // Arrange
            var baseline = OptionObjectBuilders.CreateOptionObject("Patient123");
            var baselineForm = FormObjectBuilders.CreateFormObject("FORM1");
            baselineForm.AddRow(
                RowObjectBuilders.CreateRowObject("FORM1||1")
                    .WithRowAction(RowObject.RowActions.Edit)
                    .AddField(FieldObjectBuilders.CreateFieldObject("100").WithFieldValue("A"))
                    .AddField(FieldObjectBuilders.CreateFieldObject("200").WithFieldValue("B")));
            baseline.AddForm(baselineForm);

            var working = baseline.Clone();
            working.Forms[0].OtherRows[0].Fields[1].FieldValue = "B-UPDATED";

            // Act
            OptionObject first = working.ToReturnOptionObject(baseline);
            OptionObject second = working.ToReturnOptionObject(baseline);

            // Assert
            Assert.AreEqual(1, first.Forms.Count);
            Assert.AreEqual(1, second.Forms.Count);
            Assert.AreEqual(1, first.Forms[0].OtherRows.Count);
            Assert.AreEqual(1, second.Forms[0].OtherRows.Count);
            Assert.AreEqual(1, first.Forms[0].OtherRows[0].Fields.Count);
            Assert.AreEqual(1, second.Forms[0].OtherRows[0].Fields.Count);
            Assert.AreEqual(first.Forms[0].OtherRows[0].Fields[0].FieldNumber, second.Forms[0].OtherRows[0].Fields[0].FieldNumber);
            Assert.AreEqual(first.Forms[0].OtherRows[0].Fields[0].FieldValue, second.Forms[0].OtherRows[0].Fields[0].FieldValue);
        }

        [TestMethod]
        public void ToReturnOptionObject_WithBaseline_ClonePath_ProducesDeterministicPayload()
        {
            // Arrange
            var baseline = OptionObjectBuilders.CreateOptionObject("Patient123");
            var baselineForm = FormObjectBuilders.CreateFormObject("FORM1");
            baselineForm.AddRow(
                RowObjectBuilders.CreateRowObject("FORM1||1")
                    .WithRowAction(RowObject.RowActions.Edit)
                    .AddField(FieldObjectBuilders.CreateFieldObject("100").WithFieldValue("A"))
                    .AddField(FieldObjectBuilders.CreateFieldObject("200").WithFieldValue("B")));
            baseline.AddForm(baselineForm);

            var working = baseline.Clone();
            working.Forms[0].OtherRows[0].Fields[0].Enabled = FieldObject.EnabledStatus.Disabled;
            var workingClone = working.Clone();

            // Act
            OptionObject fromWorking = working.ToReturnOptionObject(baseline);
            OptionObject fromWorkingClone = workingClone.ToReturnOptionObject(baseline);

            // Assert
            Assert.AreEqual(1, fromWorking.Forms.Count);
            Assert.AreEqual(1, fromWorkingClone.Forms.Count);
            Assert.AreEqual(1, fromWorking.Forms[0].OtherRows.Count);
            Assert.AreEqual(1, fromWorkingClone.Forms[0].OtherRows.Count);
            Assert.AreEqual(1, fromWorking.Forms[0].OtherRows[0].Fields.Count);
            Assert.AreEqual(1, fromWorkingClone.Forms[0].OtherRows[0].Fields.Count);
            Assert.AreEqual(fromWorking.Forms[0].OtherRows[0].Fields[0].FieldNumber, fromWorkingClone.Forms[0].OtherRows[0].Fields[0].FieldNumber);
            Assert.AreEqual(fromWorking.Forms[0].OtherRows[0].Fields[0].Enabled, fromWorkingClone.Forms[0].OtherRows[0].Fields[0].Enabled);
        }

        [TestMethod]
        public void ToReturnOptionObject_WithBaseline_BuilderEquivalentInputs_ProduceDeterministicPayload()
        {
            // Arrange
            var baseline = OptionObjectBuilders.CreateOptionObject("Patient123");
            var baselineForm = FormObjectBuilders.CreateFormObject("FORM1");
            baselineForm.AddRow(
                RowObjectBuilders.CreateRowObject("FORM1||1")
                    .WithRowAction(RowObject.RowActions.Edit)
                    .AddField(FieldObjectBuilders.CreateFieldObject("100").WithFieldValue("A"))
                    .AddField(FieldObjectBuilders.CreateFieldObject("200").WithFieldValue("B")));
            baseline.AddForm(baselineForm);

            var workingA = OptionObjectBuilders.CreateOptionObject("Patient123");
            var formA = FormObjectBuilders.CreateFormObject("FORM1");
            formA.AddRow(
                RowObjectBuilders.CreateRowObject("FORM1||1")
                    .WithRowAction(RowObject.RowActions.Edit)
                    .AddField(FieldObjectBuilders.CreateFieldObject("100").WithFieldValue("A"))
                    .AddField(FieldObjectBuilders.CreateFieldObject("200").WithFieldValue("B-UPDATED")));
            workingA.AddForm(formA);

            var workingB = OptionObjectBuilders.CreateOptionObject("Patient123");
            var formB = FormObjectBuilders.CreateFormObject("FORM1");
            formB.AddRow(
                RowObjectBuilders.CreateRowObject("FORM1||1")
                    .WithRowAction(RowObject.RowActions.Edit)
                    .AddField(FieldObjectBuilders.CreateFieldObject("100").WithFieldValue("A"))
                    .AddField(FieldObjectBuilders.CreateFieldObject("200").WithFieldValue("B-UPDATED")));
            workingB.AddForm(formB);

            // Act
            OptionObject finalizedA = workingA.ToReturnOptionObject(baseline);
            OptionObject finalizedB = workingB.ToReturnOptionObject(baseline);

            // Assert
            Assert.AreEqual(1, finalizedA.Forms.Count);
            Assert.AreEqual(1, finalizedB.Forms.Count);
            Assert.AreEqual(1, finalizedA.Forms[0].OtherRows.Count);
            Assert.AreEqual(1, finalizedB.Forms[0].OtherRows.Count);
            Assert.AreEqual(1, finalizedA.Forms[0].OtherRows[0].Fields.Count);
            Assert.AreEqual(1, finalizedB.Forms[0].OtherRows[0].Fields.Count);
            Assert.AreEqual(finalizedA.Forms[0].OtherRows[0].Fields[0].FieldNumber, finalizedB.Forms[0].OtherRows[0].Fields[0].FieldNumber);
            Assert.AreEqual(finalizedA.Forms[0].OtherRows[0].Fields[0].FieldValue, finalizedB.Forms[0].OtherRows[0].Fields[0].FieldValue);
        }
    }

    [TestClass]
    public class FormObjectResponseBuildersTests
    {
        [TestMethod]
        public void CreateResponseCurrentRow_SetsRowActionToEdit()
        {
            // Arrange
            var form = FormObjectBuilders.CreateFormObject("FORM1");

            // Act
            RowObject row = form.CreateResponseCurrentRow("1");

            // Assert
            Assert.AreSame(row, form.CurrentRow);
            Assert.AreEqual(RowObject.RowActions.Edit, row.RowAction);
        }

        [TestMethod]
        public void AddResponseRow_DefaultsRowActionToEdit()
        {
            // Arrange
            var form = FormObjectBuilders.CreateFormObject("FORM1");

            // Act
            RowObject row = form.AddResponseRow("2");

            // Assert
            Assert.AreEqual(RowObject.RowActions.Edit, row.RowAction);
            Assert.AreEqual(1, form.OtherRows.Count);
        }

        [TestMethod]
        public void AddResponseRow_RespectsProvidedRowAction()
        {
            // Arrange
            var form = FormObjectBuilders.CreateFormObject("FORM1");

            // Act
            RowObject row = form.AddResponseRow("3", RowObject.RowActions.Add);

            // Assert
            Assert.AreEqual(RowObject.RowActions.Add, row.RowAction);
        }
    }

    [TestClass]
    public class RowObjectResponseBuildersTests
    {
        [TestMethod]
        public void AddResponseField_AddsFieldAndSetsRowActionToEdit()
        {
            // Arrange
            var row = RowObjectBuilders.CreateRowObject("1");

            // Act
            FieldObject field = row.AddResponseField("100", "value");

            // Assert
            Assert.AreEqual(RowObject.RowActions.Edit, row.RowAction);
            Assert.AreEqual(1, row.Fields.Count);
            Assert.AreSame(field, row.Fields[0]);
        }

        [TestMethod]
        public void AddResponseField_PreservesExistingRowAction()
        {
            // Arrange
            var row = RowObjectBuilders.CreateRowObject("1")
                .WithRowAction(RowObject.RowActions.Add);

            // Act
            FieldObject field = row.AddResponseField("200", "value");

            // Assert
            Assert.AreEqual(RowObject.RowActions.Add, row.RowAction);
            Assert.AreSame(field, row.Fields[0]);
        }
    }
}
