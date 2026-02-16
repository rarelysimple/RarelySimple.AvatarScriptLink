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
