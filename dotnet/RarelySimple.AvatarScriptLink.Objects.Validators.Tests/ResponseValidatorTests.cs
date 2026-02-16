namespace RarelySimple.AvatarScriptLink.Objects.Validators.Tests
{
    [TestClass]
    public class OptionObjectResponseValidatorsTests
    {
        [TestMethod]
        public void ValidateResponse_ReturnsError_WhenOptionObjectIsNull()
        {
            // Arrange
            OptionObject? optionObject = null;

            // Act
            ResponseValidationResult result = optionObject.ValidateResponse();

            // Assert
            Assert.IsFalse(result.IsValid);
            CollectionAssert.Contains(result.Errors.ToList(), "OptionObject is null.");
        }

        [TestMethod]
        public void ValidateResponse_ReturnsError_WhenEntityIdIsMissing()
        {
            // Arrange
            var optionObject = new OptionObject { ErrorCode = 0, ErrorMesg = string.Empty };

            // Act
            ResponseValidationResult result = optionObject.ValidateResponse();

            // Assert
            Assert.IsFalse(result.IsValid);
            CollectionAssert.Contains(result.Errors.ToList(), "EntityID is required.");
        }

        [TestMethod]
        public void ValidateResponse_ReturnsError_WhenErrorCodeIsInvalid()
        {
            // Arrange
            var optionObject = new OptionObject { EntityID = "PATID", ErrorCode = 7, ErrorMesg = string.Empty };

            // Act
            ResponseValidationResult result = optionObject.ValidateResponse();

            // Assert
            Assert.IsFalse(result.IsValid);
            CollectionAssert.Contains(result.Errors.ToList(), "ErrorCode must be between 0 and 6.");
        }

        [TestMethod]
        public void ValidateResponse_ReturnsError_WhenErrorCodeIsNonInteger()
        {
            // Arrange
            var optionObject = new OptionObject { EntityID = "PATID", ErrorCode = 2.5, ErrorMesg = "Message" };

            // Act
            ResponseValidationResult result = optionObject.ValidateResponse();

            // Assert
            Assert.IsFalse(result.IsValid);
            CollectionAssert.Contains(result.Errors.ToList(), "ErrorCode must be an integer between 0 and 6.");
        }

        [TestMethod]
        public void ValidateResponse_ReturnsError_WhenErrorMessagePresentForSuccess()
        {
            // Arrange
            var optionObject = new OptionObject { EntityID = "PATID", ErrorCode = 0, ErrorMesg = "Unexpected" };

            // Act
            ResponseValidationResult result = optionObject.ValidateResponse();

            // Assert
            Assert.IsFalse(result.IsValid);
            CollectionAssert.Contains(result.Errors.ToList(), "ErrorMesg must be empty when ErrorCode is 0.");
        }

        [TestMethod]
        public void ValidateResponse_ReturnsError_WhenErrorMessageMissingForError()
        {
            // Arrange
            var optionObject = new OptionObject { EntityID = "PATID", ErrorCode = 3, ErrorMesg = string.Empty };

            // Act
            ResponseValidationResult result = optionObject.ValidateResponse();

            // Assert
            Assert.IsFalse(result.IsValid);
            CollectionAssert.Contains(result.Errors.ToList(), "ErrorMesg is required when ErrorCode is between 1 and 4.");
        }

        [TestMethod]
        public void ValidateResponse_ReturnsError_WhenOpenUrlMessageIsInvalid()
        {
            // Arrange
            var optionObject = new OptionObject { EntityID = "PATID", ErrorCode = 5, ErrorMesg = "not-a-url" };

            // Act
            ResponseValidationResult result = optionObject.ValidateResponse();

            // Assert
            Assert.IsFalse(result.IsValid);
            CollectionAssert.Contains(result.Errors.ToList(), "ErrorMesg must be a valid absolute URL when ErrorCode is 5.");
        }

        [TestMethod]
        public void ValidateResponse_ReturnsError_WhenOpenFormMessageIsInvalid()
        {
            // Arrange
            var optionObject = new OptionObject { EntityID = "PATID", ErrorCode = 6, ErrorMesg = "invalid form" };

            // Act
            ResponseValidationResult result = optionObject.ValidateResponse();

            // Assert
            Assert.IsFalse(result.IsValid);
            CollectionAssert.Contains(result.Errors.ToList(), "ErrorMesg must be a valid OpenForm string when ErrorCode is 6.");
        }

        [TestMethod]
        public void ValidateResponse_ReturnsSuccess_WhenResponseIsValid()
        {
            // Arrange
            var optionObject = new OptionObject { EntityID = "PATID", ErrorCode = 1, ErrorMesg = "Message" };

            // Act
            ResponseValidationResult result = optionObject.ValidateResponse();

            // Assert
            Assert.IsTrue(result.IsValid);
            Assert.AreEqual(0, result.Errors.Count);
        }

        [TestMethod]
        public void IsValidResponse_ReturnsTrue_ForValidOptionObject2()
        {
            // Arrange
            var optionObject = new OptionObject2 { EntityID = "PATID", ErrorCode = 0, ErrorMesg = string.Empty };

            // Act
            bool result = optionObject.IsValidResponse();

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidateResponsePayload_ReturnsErrors_ForInvalidForm()
        {
            // Arrange
            var optionObject = new OptionObject { EntityID = "PATID", ErrorCode = 0, ErrorMesg = string.Empty };
            optionObject.Forms.Add(new FormObject());

            // Act
            ResponseValidationResult result = optionObject.ValidateResponsePayload();

            // Assert
            Assert.IsFalse(result.IsValid);
            Assert.IsTrue(result.Errors.Any(error => error.Contains("Forms[0]: FormId is required.")));
        }
    }

    [TestClass]
    public class FormObjectResponseValidatorsTests
    {
        [TestMethod]
        public void ValidateResponse_ReturnsError_WhenMultipleIterationFalseAndOtherRowsPresent()
        {
            // Arrange
            var form = new FormObject { FormId = "FORM1", MultipleIteration = false };
            form.OtherRows.Add(new RowObject { RowId = "1" });

            // Act
            ResponseValidationResult result = form.ValidateResponse();

            // Assert
            Assert.IsFalse(result.IsValid);
            CollectionAssert.Contains(result.Errors.ToList(), "OtherRows must be empty when MultipleIteration is false.");
        }
    }

    [TestClass]
    public class RowObjectResponseValidatorsTests
    {
        [TestMethod]
        public void ValidateResponse_ReturnsError_WhenRowActionMissingWithFields()
        {
            // Arrange
            var row = new RowObject { RowId = "1", RowAction = string.Empty };
            row.Fields.Add(new FieldObject { FieldNumber = "100" });

            // Act
            ResponseValidationResult result = row.ValidateResponse();

            // Assert
            Assert.IsFalse(result.IsValid);
            CollectionAssert.Contains(result.Errors.ToList(), "RowAction is required when row contains fields.");
        }

        [TestMethod]
        public void ValidateResponse_ReturnsError_WhenRowActionInvalid()
        {
            // Arrange
            var row = new RowObject { RowId = "1", RowAction = "INVALID" };

            // Act
            ResponseValidationResult result = row.ValidateResponse();

            // Assert
            Assert.IsFalse(result.IsValid);
            CollectionAssert.Contains(result.Errors.ToList(), "RowAction must be ADD, EDIT, DELETE, or empty.");
        }
    }

    [TestClass]
    public class FieldObjectResponseValidatorsTests
    {
        [TestMethod]
        public void ValidateResponse_ReturnsError_WhenFieldNumberMissing()
        {
            // Arrange
            var field = new FieldObject { FieldNumber = "" };

            // Act
            ResponseValidationResult result = field.ValidateResponse();

            // Assert
            Assert.IsFalse(result.IsValid);
            CollectionAssert.Contains(result.Errors.ToList(), "FieldNumber is required.");
        }

        [TestMethod]
        public void ValidateResponse_ReturnsError_WhenFlagIsInvalid()
        {
            // Arrange
            var field = new FieldObject { FieldNumber = "100", Enabled = "X" };

            // Act
            ResponseValidationResult result = field.ValidateResponse();

            // Assert
            Assert.IsFalse(result.IsValid);
            CollectionAssert.Contains(result.Errors.ToList(), "Enabled must be \"0\" or \"1\" when set.");
        }
    }
}
