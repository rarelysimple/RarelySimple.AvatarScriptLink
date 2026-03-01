namespace RarelySimple.AvatarScriptLink.Objects.Helpers.Tests
{

    /// <summary>
    /// Tests for OptionObject/OptionObject2/OptionObject2015 helper extension methods
    /// </summary>
    [TestClass]
    public class OptionObjectHelpersTests
    {
        [TestMethod]
        public void GetCurrentRowId_ReturnsCurrentRowId()
        {
            // Arrange
            var optionObject = new OptionObject();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "100" } };
            optionObject.Forms.Add(form);

            // Act
            var result = optionObject.GetCurrentRowId("1");

            // Assert
            Assert.AreEqual("100", result);
        }

        [TestMethod]
        public void GetCurrentRowId_WithNonExistentForm_ReturnsNull()
        {
            // Arrange
            var optionObject = new OptionObject();

            // Act
            var result = optionObject.GetCurrentRowId("999");

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void GetParentRowId_ReturnsParentRowId()
        {
            // Arrange
            var optionObject = new OptionObject();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { ParentRowId = "200" } };
            optionObject.Forms.Add(form);

            // Act
            var result = optionObject.GetParentRowId("1");

            // Assert
            Assert.AreEqual("200", result);
        }

        [TestMethod]
        public void GetFieldValue_FromAnyForm_ReturnsValue()
        {
            // Arrange
            var optionObject = new OptionObject();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject() };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", FieldValue = "TestValue" });
            optionObject.Forms.Add(form);

            // Act
            var result = optionObject.GetFieldValue("100");

            // Assert
            Assert.AreEqual("TestValue", result);
        }

        [TestMethod]
        public void GetFieldValue_WithFormIdRowIdFieldNumber_ReturnsValue()
        {
            // Arrange
            var optionObject = new OptionObject();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", FieldValue = "TestValue" });
            optionObject.Forms.Add(form);

            // Act
            var result = optionObject.GetFieldValue("1", "1", "100");

            // Assert
            Assert.AreEqual("TestValue", result);
        }

        [TestMethod]
        public void GetFieldValues_ReturnsAllValues()
        {
            // Arrange
            var optionObject = new OptionObject();
            var form1 = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1" } };
            form1.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", FieldValue = "Value1" });
            optionObject.Forms.Add(form1);
            
            var form2 = new FormObject { FormId = "2", CurrentRow = new RowObject { RowId = "2" } };
            form2.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", FieldValue = "Value2" });
            optionObject.Forms.Add(form2);

            // Act
            var result = optionObject.GetFieldValues("100");

            // Assert
            Assert.AreEqual(2, result.Count);
            CollectionAssert.Contains(result, "Value1");
            CollectionAssert.Contains(result, "Value2");
        }

        [TestMethod]
        public void GetMultipleIterationStatus_ReturnsStatus()
        {
            // Arrange
            var optionObject = new OptionObject();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject(), MultipleIteration = true };
            optionObject.Forms.Add(form);

            // Act
            var result = optionObject.GetMultipleIterationStatus("1");

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsFieldPresent_InAnyForm_ReturnsTrue()
        {
            // Arrange
            var optionObject = new OptionObject();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject() };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100" });
            optionObject.Forms.Add(form);

            // Act
            var result = optionObject.IsFieldPresent("100");

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsFieldEnabled_InAnyForm_ReturnsTrue()
        {
            // Arrange
            var optionObject = new OptionObject();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject() };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });
            optionObject.Forms.Add(form);

            // Act
            var result = optionObject.IsFieldEnabled("100");

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsFieldLocked_InAnyForm_ReturnsTrue()
        {
            // Arrange
            var optionObject = new OptionObject();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject() };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "1" });
            optionObject.Forms.Add(form);

            // Act
            var result = optionObject.IsFieldLocked("100");

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsFieldRequired_InAnyForm_ReturnsTrue()
        {
            // Arrange
            var optionObject = new OptionObject();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject() };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Required = "1" });
            optionObject.Forms.Add(form);

            // Act
            var result = optionObject.IsFieldRequired("100");

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GetErrorCode_ReturnsErrorCode()
        {
            // Arrange
            var optionObject = new OptionObject { ErrorCode = 1.0 };

            // Act
            var result = optionObject.GetErrorCode();

            // Assert
            Assert.AreEqual(1.0, result);
        }

        [TestMethod]
        public void GetErrorMessage_ReturnsErrorMessage()
        {
            // Arrange
            var optionObject = new OptionObject { ErrorMesg = "Test Error" };

            // Act
            var result = optionObject.GetErrorMessage();

            // Assert
            Assert.AreEqual("Test Error", result);
        }

        [TestMethod]
        public void GetEntityId_ReturnsEntityId()
        {
            // Arrange
            var optionObject = new OptionObject { EntityID = "12345" };

            // Act
            var result = optionObject.GetEntityId();

            // Assert
            Assert.AreEqual("12345", result);
        }

        [TestMethod]
        public void GetFormCount_ReturnsFormCount()
        {
            // Arrange
            var optionObject = new OptionObject();
            optionObject.Forms.Add(new FormObject { FormId = "1" });
            optionObject.Forms.Add(new FormObject { FormId = "2" });

            // Act
            var result = optionObject.GetFormCount();

            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void HasError_WithNonZeroErrorCode_ReturnsTrue()
        {
            // Arrange
            var optionObject = new OptionObject { ErrorCode = 1.0 };

            // Act
            var result = optionObject.HasError();

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void HasError_WithZeroErrorCode_ReturnsFalse()
        {
            // Arrange
            var optionObject = new OptionObject { ErrorCode = 0.0 };

            // Act
            var result = optionObject.HasError();

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void GetEntityId_OptionObject2_ReturnsEntityId()
        {
            var optionObject = new OptionObject2 { EntityID = "E-2" };

            var result = optionObject.GetEntityId();

            Assert.AreEqual("E-2", result);
        }

        [TestMethod]
        public void GetFormCount_OptionObject2_ReturnsFormCount()
        {
            var optionObject = new OptionObject2();
            optionObject.Forms.Add(new FormObject { FormId = "1" });
            optionObject.Forms.Add(new FormObject { FormId = "2" });

            var result = optionObject.GetFormCount();

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void HasError_OptionObject2_WithZeroErrorCode_ReturnsFalse()
        {
            var optionObject = new OptionObject2 { ErrorCode = 0 };

            var result = optionObject.HasError();

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void GetEntityId_OptionObject2015_ReturnsEntityId()
        {
            var optionObject = new OptionObject2015 { EntityID = "E-2015" };

            var result = optionObject.GetEntityId();

            Assert.AreEqual("E-2015", result);
        }

        [TestMethod]
        public void GetSessionToken_OptionObject2015_ReturnsSessionToken()
        {
            var optionObject = new OptionObject2015 { SessionToken = "token-123" };

            var result = optionObject.GetSessionToken();

            Assert.AreEqual("token-123", result);
        }

        [TestMethod]
        public void GetOptionUserId_OptionObject2015_ReturnsOptionUserId()
        {
            var optionObject = new OptionObject2015 { OptionUserId = "user-01" };

            var result = optionObject.GetOptionUserId();

            Assert.AreEqual("user-01", result);
        }

        [TestMethod]
        public void HasError_OptionObject2015_WithNonZeroErrorCode_ReturnsTrue()
        {
            var optionObject = new OptionObject2015 { ErrorCode = 1 };

            var result = optionObject.HasError();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SetDisabledField_OptionObject_DisablesTargetField()
        {
            // Arrange
            var optionObject = new OptionObject();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1", RowAction = "" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });
            optionObject.Forms.Add(form);

            // Act
            optionObject.SetDisabledField("100");

            // Assert
            Assert.AreEqual("0", optionObject.Forms[0].CurrentRow.Fields[0].Enabled);
            Assert.AreEqual("EDIT", optionObject.Forms[0].CurrentRow.RowAction);
        }

        [TestMethod]
        public void SetEnabledFields_OptionObject_EnablesMatchingFields()
        {
            // Arrange
            var optionObject = new OptionObject();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "0" });
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "101", Enabled = "0" });
            optionObject.Forms.Add(form);

            // Act
            optionObject.SetEnabledFields(new List<string> { "101" });

            // Assert
            Assert.AreEqual("0", optionObject.Forms[0].CurrentRow.Fields[0].Enabled);
            Assert.AreEqual("1", optionObject.Forms[0].CurrentRow.Fields[1].Enabled);
        }

        [TestMethod]
        public void SetDisabledField_OptionObject2_DisablesTargetField()
        {
            // Arrange
            var optionObject = new OptionObject2();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });
            optionObject.Forms.Add(form);

            // Act
            optionObject.SetDisabledField("100");

            // Assert
            Assert.AreEqual("0", optionObject.Forms[0].CurrentRow.Fields[0].Enabled);
        }

        [TestMethod]
        public void SetEnabledField_OptionObject2015_EnablesTargetField()
        {
            // Arrange
            var optionObject = new OptionObject2015();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "0" });
            optionObject.Forms.Add(form);

            // Act
            optionObject.SetEnabledField("100");

            // Assert
            Assert.AreEqual("1", optionObject.Forms[0].CurrentRow.Fields[0].Enabled);
        }

        [TestMethod]
        public void SetDisabledFields_OptionObject_WithFieldObjects_DisablesMatchingFields()
        {
            // Arrange
            var optionObject = new OptionObject();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "101", Enabled = "1" });
            optionObject.Forms.Add(form);

            var fieldsToDisable = new List<FieldObject> { new FieldObject { FieldNumber = "101" } };

            // Act
            optionObject.SetDisabledFields(fieldsToDisable);

            // Assert
            Assert.AreEqual("1", optionObject.Forms[0].CurrentRow.Fields[0].Enabled);
            Assert.AreEqual("0", optionObject.Forms[0].CurrentRow.Fields[1].Enabled);
        }

        [TestMethod]
        public void SetEnabledFields_OptionObject2_WithFieldObjects_EnablesMatchingFields()
        {
            // Arrange
            var optionObject = new OptionObject2();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "0" });
            optionObject.Forms.Add(form);

            var fieldsToEnable = new List<FieldObject> { new FieldObject { FieldNumber = "100" } };

            // Act
            optionObject.SetEnabledFields(fieldsToEnable);

            // Assert
            Assert.AreEqual("1", optionObject.Forms[0].CurrentRow.Fields[0].Enabled);
        }

        [TestMethod]
        public void SetDisabledFields_OptionObject2015_WithFieldObjects_DisablesMatchingFields()
        {
            // Arrange
            var optionObject = new OptionObject2015();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });
            optionObject.Forms.Add(form);

            var fieldsToDisable = new List<FieldObject> { new FieldObject { FieldNumber = "100" } };

            // Act
            optionObject.SetDisabledFields(fieldsToDisable);

            // Assert
            Assert.AreEqual("0", optionObject.Forms[0].CurrentRow.Fields[0].Enabled);
        }

        [TestMethod]
        public void SetDisabledField_OptionObject_WithEmptyFieldNumber_DoesNothing()
        {
            // Arrange
            var optionObject = new OptionObject();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1", RowAction = "" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });
            optionObject.Forms.Add(form);

            // Act
            optionObject.SetDisabledField(string.Empty);

            // Assert
            Assert.AreEqual("1", optionObject.Forms[0].CurrentRow.Fields[0].Enabled);
            Assert.AreEqual("", optionObject.Forms[0].CurrentRow.RowAction);
        }

        [TestMethod]
        public void SetDisabledFields_OptionObject_WithNullFieldObjects_DoesNothing()
        {
            // Arrange
            var optionObject = new OptionObject();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });
            optionObject.Forms.Add(form);

            // Act
            optionObject.SetDisabledFields((List<FieldObject>?)null);

            // Assert
            Assert.AreEqual("1", optionObject.Forms[0].CurrentRow.Fields[0].Enabled);
        }

        [TestMethod]
        public void SetDisabledField_OptionObject_WithNullOptionObject_ReturnsNull()
        {
            // Act
            var result = OptionObjectHelpers.SetDisabledField(null!, "100");

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void SetEnabledField_OptionObject_WithNullForms_ReturnsOriginalObject()
        {
            // Arrange
            var optionObject = new OptionObject { Forms = null! };

            // Act
            var result = optionObject.SetEnabledField("100");

            // Assert
            Assert.AreSame(optionObject, result);
        }

        [TestMethod]
        public void SetDisabledFields_OptionObject2_WithFieldNumbers_DisablesMatchingFields()
        {
            // Arrange
            var optionObject = new OptionObject2();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "101", Enabled = "1" });
            optionObject.Forms.Add(form);

            // Act
            optionObject.SetDisabledFields(new List<string> { "101" });

            // Assert
            Assert.AreEqual("1", optionObject.Forms[0].CurrentRow.Fields[0].Enabled);
            Assert.AreEqual("0", optionObject.Forms[0].CurrentRow.Fields[1].Enabled);
        }

        [TestMethod]
        public void SetDisabledFields_OptionObject2_WithEmptyFieldObjects_DoesNothing()
        {
            var optionObject = new OptionObject2();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });
            optionObject.Forms.Add(form);

            optionObject.SetDisabledFields(new List<FieldObject>());

            Assert.AreEqual("1", optionObject.Forms[0].CurrentRow.Fields[0].Enabled);
        }

        [TestMethod]
        public void SetEnabledField_OptionObject2_WithEmptyFieldNumber_DoesNothing()
        {
            // Arrange
            var optionObject = new OptionObject2();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1", RowAction = "" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "0" });
            optionObject.Forms.Add(form);

            // Act
            optionObject.SetEnabledField(string.Empty);

            // Assert
            Assert.AreEqual("0", optionObject.Forms[0].CurrentRow.Fields[0].Enabled);
            Assert.AreEqual("", optionObject.Forms[0].CurrentRow.RowAction);
        }

        [TestMethod]
        public void SetEnabledField_OptionObject2_WithNullOptionObject_ReturnsNull()
        {
            // Act
            var result = OptionObject2Helpers.SetEnabledField(null!, "100");

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void SetEnabledFields_OptionObject2_WithEmptyFieldNumbers_DoesNothing()
        {
            // Arrange
            var optionObject = new OptionObject2();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "0" });
            optionObject.Forms.Add(form);

            // Act
            optionObject.SetEnabledFields(new List<string>());

            // Assert
            Assert.AreEqual("0", optionObject.Forms[0].CurrentRow.Fields[0].Enabled);
        }

        [TestMethod]
        public void SetEnabledFields_OptionObject2_WithNullFieldObjects_DoesNothing()
        {
            var optionObject = new OptionObject2();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "0" });
            optionObject.Forms.Add(form);

            optionObject.SetEnabledFields((List<FieldObject>?)null);

            Assert.AreEqual("0", optionObject.Forms[0].CurrentRow.Fields[0].Enabled);
        }

        [TestMethod]
        public void SetDisabledField_OptionObject2_WithNullForms_ReturnsOriginalObject()
        {
            // Arrange
            var optionObject = new OptionObject2 { Forms = null! };

            // Act
            var result = optionObject.SetDisabledField("100");

            // Assert
            Assert.AreSame(optionObject, result);
        }

        [TestMethod]
        public void SetEnabledFields_OptionObject2015_WithFieldNumbers_EnablesMatchingFields()
        {
            // Arrange
            var optionObject = new OptionObject2015();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "0" });
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "101", Enabled = "0" });
            optionObject.Forms.Add(form);

            // Act
            optionObject.SetEnabledFields(new List<string> { "100" });

            // Assert
            Assert.AreEqual("1", optionObject.Forms[0].CurrentRow.Fields[0].Enabled);
            Assert.AreEqual("0", optionObject.Forms[0].CurrentRow.Fields[1].Enabled);
        }

        [TestMethod]
        public void SetDisabledField_OptionObject2015_WithEmptyFieldNumber_DoesNothing()
        {
            // Arrange
            var optionObject = new OptionObject2015();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1", RowAction = "" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });
            optionObject.Forms.Add(form);

            // Act
            optionObject.SetDisabledField(string.Empty);

            // Assert
            Assert.AreEqual("1", optionObject.Forms[0].CurrentRow.Fields[0].Enabled);
            Assert.AreEqual("", optionObject.Forms[0].CurrentRow.RowAction);
        }

        [TestMethod]
        public void SetEnabledFields_OptionObject2015_WithNullFieldObjects_DoesNothing()
        {
            // Arrange
            var optionObject = new OptionObject2015();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "0" });
            optionObject.Forms.Add(form);

            // Act
            optionObject.SetEnabledFields((List<FieldObject>?)null);

            // Assert
            Assert.AreEqual("0", optionObject.Forms[0].CurrentRow.Fields[0].Enabled);
        }

        [TestMethod]
        public void SetDisabledFields_OptionObject2015_WithEmptyFieldObjects_DoesNothing()
        {
            var optionObject = new OptionObject2015();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });
            optionObject.Forms.Add(form);

            optionObject.SetDisabledFields(new List<FieldObject>());

            Assert.AreEqual("1", optionObject.Forms[0].CurrentRow.Fields[0].Enabled);
        }

        [TestMethod]
        public void SetEnabledFields_OptionObject2015_WithEmptyFieldObjects_DoesNothing()
        {
            var optionObject = new OptionObject2015();
            var form = new FormObject { FormId = "1", CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "0" });
            optionObject.Forms.Add(form);

            optionObject.SetEnabledFields(new List<FieldObject>());

            Assert.AreEqual("0", optionObject.Forms[0].CurrentRow.Fields[0].Enabled);
        }

        [TestMethod]
        public void SetDisabledField_OptionObject2015_WithNullForms_ReturnsOriginalObject()
        {
            // Arrange
            var optionObject = new OptionObject2015 { Forms = null! };

            // Act
            var result = optionObject.SetDisabledField("100");

            // Assert
            Assert.AreSame(optionObject, result);
        }

        [TestMethod]
        public void SetEnabledFields_OptionObject2015_WithNullOptionObject_ReturnsNull()
        {
            // Act
            var result = OptionObject2015Helpers.SetEnabledFields(null!, new List<string> { "100" });

            // Assert
            Assert.IsNull(result);
        }

    }

}
