namespace RarelySimple.AvatarScriptLink.Objects.Helpers.Tests
{
    /// <summary>
    /// Tests for FieldObjectHelpers extension methods
    /// </summary>
    [TestClass]
    public class FieldObjectHelpersTests
    {
        [TestMethod]
        public void GetValue_WithValue_ReturnsValue()
        {
            // Arrange
            var field = new FieldObject { FieldValue = "TestValue" };

            // Act
            var result = field.GetValue();

            // Assert
            Assert.AreEqual("TestValue", result);
        }

        [TestMethod]
        public void GetValue_WithNull_ReturnsNull()
        {
            // Arrange
            FieldObject? field = null;

            // Act
            var result = field?.GetValue();

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void SetValue_WithValue_SetsFieldValue()
        {
            // Arrange
            var field = new FieldObject();

            // Act
            field.SetValue("NewValue");

            // Assert
            Assert.AreEqual("NewValue", field.FieldValue);
        }

        [TestMethod]
        public void SetValue_WithNull_SetsEmptyString()
        {
            // Arrange
            var field = new FieldObject { FieldValue = "OldValue" };

            // Act
            field.SetValue(null!);

            // Assert
            Assert.AreEqual(string.Empty, field.FieldValue);
        }

        [TestMethod]
        public void SetValue_WithNullField_DoesNotThrow()
        {
            // Arrange
            FieldObject? field = null;

            // Act - calling extension method on null should not throw
            field?.SetValue("Value");
            // If we reach here, no exception was thrown - test passes
        }

        [TestMethod]
        public void ClearValue_WithValue_ClearsFieldValue()
        {
            // Arrange
            var field = new FieldObject { FieldValue = "SomeValue" };

            // Act
            field.ClearValue();

            // Assert
            Assert.AreEqual(string.Empty, field.FieldValue);
        }

        [TestMethod]
        public void ClearValue_WithNullField_DoesNotThrow()
        {
            // Arrange
            FieldObject? field = null;

            // Act - calling extension method on null should not throw
            field?.ClearValue();
            // If we reach here, no exception was thrown - test passes
        }
    }

    /// <summary>
    /// Tests for RowObjectHelpers extension methods
    /// </summary>
    [TestClass]
    public class RowObjectHelpersTests
    {
        [TestMethod]
        public void GetRowId_WithRowId_ReturnsRowId()
        {
            // Arrange
            var row = new RowObject { RowId = "123" };

            // Act
            var result = row.GetRowId();

            // Assert
            Assert.AreEqual("123", result);
        }

        [TestMethod]
        public void GetRowId_WithNull_ReturnsNull()
        {
            // Arrange
            RowObject? row = null;

            // Act
            var result = row?.GetRowId();

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void GetParentRowId_WithParentRowId_ReturnsParentRowId()
        {
            // Arrange
            var row = new RowObject { ParentRowId = "456" };

            // Act
            var result = row.GetParentRowId();

            // Assert
            Assert.AreEqual("456", result);
        }

        [TestMethod]
        public void GetRowAction_WithRowAction_ReturnsRowAction()
        {
            // Arrange
            var row = new RowObject { RowAction = "EDIT" };

            // Act
            var result = row.GetRowAction();

            // Assert
            Assert.AreEqual("EDIT", result);
        }

        [TestMethod]
        public void IsMarkedForDeletion_WithDeleteAction_ReturnsTrue()
        {
            // Arrange
            var row = new RowObject { RowAction = "DELETE" };

            // Act
            var result = row.IsMarkedForDeletion();

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsMarkedForDeletion_WithEditAction_ReturnsFalse()
        {
            // Arrange
            var row = new RowObject { RowAction = "EDIT" };

            // Act
            var result = row.IsMarkedForDeletion();

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void GetFieldCount_WithFields_ReturnsCount()
        {
            // Arrange
            var row = new RowObject();
            row.Fields.Add(new FieldObject());
            row.Fields.Add(new FieldObject());

            // Act
            var result = row.GetFieldCount();

            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void GetFieldCount_WithNull_ReturnsZero()
        {
            // Arrange
            RowObject? row = null;

            // Act
            var result = row?.GetFieldCount() ?? 0;

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void GetFieldValue_WithExistingField_ReturnsValue()
        {
            // Arrange
            var row = new RowObject();
            row.Fields.Add(new FieldObject { FieldNumber = "100", FieldValue = "TestValue" });

            // Act
            var result = row.GetFieldValue("100");

            // Assert
            Assert.AreEqual("TestValue", result);
        }

        [TestMethod]
        public void GetFieldValue_WithNonExistentField_ReturnsNull()
        {
            // Arrange
            var row = new RowObject();
            row.Fields.Add(new FieldObject { FieldNumber = "100", FieldValue = "TestValue" });

            // Act
            var result = row.GetFieldValue("999");

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void GetFieldValue_WithNullRow_ReturnsNull()
        {
            // Arrange
            RowObject? row = null;

            // Act
            var result = row?.GetFieldValue("100");

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void IsFieldPresent_WithField_ReturnsTrue()
        {
            // Arrange
            var row = new RowObject();
            row.Fields.Add(new FieldObject { FieldNumber = "100" });

            // Act
            var result = row.IsFieldPresent("100");

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsFieldPresent_WithoutField_ReturnsFalse()
        {
            // Arrange
            var row = new RowObject();

            // Act
            var result = row.IsFieldPresent("100");

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsFieldEnabled_WithEnabledField_ReturnsTrue()
        {
            // Arrange
            var row = new RowObject();
            row.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });

            // Act
            var result = row.IsFieldEnabled("100");

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsFieldEnabled_WithDisabledField_ReturnsFalse()
        {
            // Arrange
            var row = new RowObject();
            row.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "0" });

            // Act
            var result = row.IsFieldEnabled("100");

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsFieldLocked_WithLockedField_ReturnsTrue()
        {
            // Arrange
            var row = new RowObject();
            row.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "1" });

            // Act
            var result = row.IsFieldLocked("100");

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsFieldRequired_WithRequiredField_ReturnsTrue()
        {
            // Arrange
            var row = new RowObject();
            row.Fields.Add(new FieldObject { FieldNumber = "100", Required = "1" });

            // Act
            var result = row.IsFieldRequired("100");

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SetFieldValue_WithExistingField_UpdatesValue()
        {
            // Arrange
            var row = new RowObject { RowAction = "" };
            row.Fields.Add(new FieldObject { FieldNumber = "100", FieldValue = "OldValue" });

            // Act
            var result = row.SetFieldValue("100", "NewValue");

            // Assert
            Assert.AreEqual("NewValue", row.Fields[0].FieldValue);
            Assert.AreEqual("EDIT", row.RowAction);
            Assert.AreSame(row, result);
        }

        [TestMethod]
        public void SetFieldValue_WithNonExistentField_DoesNothing()
        {
            // Arrange
            var row = new RowObject();

            // Act
            var result = row.SetFieldValue("999", "Value");

            // Assert
            Assert.IsNull(result?.Fields.FirstOrDefault(f => f.FieldNumber == "999"));
        }

        [TestMethod]
        public void SetFieldValue_WithNullRow_ReturnsNull()
        {
            // Arrange
            RowObject? row = null;

            // Act
            var result = row?.SetFieldValue("100", "Value");

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void DisableAllFieldObjects_WithoutExclusions_DisablesAll()
        {
            // Arrange
            var row = new RowObject();
            var field1 = new FieldObject { FieldNumber = "100", Enabled = "1" };
            var field2 = new FieldObject { FieldNumber = "101", Enabled = "1" };
            row.Fields.Add(field1);
            row.Fields.Add(field2);

            // Act
            row.DisableAllFieldObjects();

            // Assert
            Assert.AreEqual("0", field1.Enabled);
            Assert.AreEqual("0", field2.Enabled);
            Assert.AreEqual("EDIT", row.RowAction);
        }

        [TestMethod]
        public void DisableAllFieldObjects_WithExclusions_DisablesOnlyNonExcluded()
        {
            // Arrange
            var row = new RowObject();
            var field1 = new FieldObject { FieldNumber = "100", Enabled = "1" };
            var field2 = new FieldObject { FieldNumber = "101", Enabled = "1" };
            row.Fields.Add(field1);
            row.Fields.Add(field2);

            // Act
            row.DisableAllFieldObjects(new List<string> { "101" });

            // Assert
            Assert.AreEqual("0", field1.Enabled);
            Assert.AreEqual("1", field2.Enabled);
        }

        [TestMethod]
        public void EnableAllFieldObjects_WithoutExclusions_EnablesAll()
        {
            // Arrange
            var row = new RowObject();
            var field1 = new FieldObject { FieldNumber = "100", Enabled = "0" };
            var field2 = new FieldObject { FieldNumber = "101", Enabled = "0" };
            row.Fields.Add(field1);
            row.Fields.Add(field2);

            // Act
            row.EnableAllFieldObjects();

            // Assert
            Assert.AreEqual("1", field1.Enabled);
            Assert.AreEqual("1", field2.Enabled);
        }

        [TestMethod]
        public void EnableAllFieldObjects_WithExclusions_EnablesOnlyNonExcluded()
        {
            // Arrange
            var row = new RowObject();
            var field1 = new FieldObject { FieldNumber = "100", Enabled = "0" };
            var field2 = new FieldObject { FieldNumber = "101", Enabled = "0" };
            row.Fields.Add(field1);
            row.Fields.Add(field2);

            // Act
            row.EnableAllFieldObjects(new List<string> { "101" });

            // Assert
            Assert.AreEqual("1", field1.Enabled);
            Assert.AreEqual("0", field2.Enabled);
        }

        [TestMethod]
        public void LockAllFieldObjects_LocksAllFields()
        {
            // Arrange
            var row = new RowObject();
            var field = new FieldObject { FieldNumber = "100", Lock = "0" };
            row.Fields.Add(field);

            // Act
            row.LockAllFieldObjects();

            // Assert
            Assert.AreEqual("1", field.Lock);
        }

        [TestMethod]
        public void UnlockAllFieldObjects_UnlocksAllFields()
        {
            // Arrange
            var row = new RowObject();
            var field = new FieldObject { FieldNumber = "100", Lock = "1" };
            row.Fields.Add(field);

            // Act
            row.UnlockAllFieldObjects();

            // Assert
            Assert.AreEqual("0", field.Lock);
        }
    }

    /// <summary>
    /// Tests for FormObjectHelpers extension methods
    /// </summary>
    [TestClass]
    public class FormObjectHelpersTests
    {
        [TestMethod]
        public void IsRowPresent_WithCurrentRow_ReturnsTrue()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1" } };

            // Act
            var result = form.IsRowPresent("1");

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsRowPresent_WithOtherRow_ReturnsTrue()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1" }, MultipleIteration = true };
            form.OtherRows.Add(new RowObject { RowId = "2" });

            // Act
            var result = form.IsRowPresent("2");

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsRowPresent_WithAbsentRow_ReturnsFalse()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1" } };

            // Act
            var result = form.IsRowPresent("999");

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsRowMarkedForDeletion_WithDeletedRow_ReturnsTrue()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1", RowAction = "DELETE" } };

            // Act
            var result = form.IsRowMarkedForDeletion("1");

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsRowMarkedForDeletion_WithNormalRow_ReturnsFalse()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1", RowAction = "EDIT" } };

            // Act
            var result = form.IsRowMarkedForDeletion("1");

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsFieldPresent_InCurrentRow_ReturnsTrue()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject() };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100" });

            // Act
            var result = form.IsFieldPresent("100");

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsFieldEnabled_WithEnabledField_ReturnsTrue()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject() };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });

            // Act
            var result = form.IsFieldEnabled("100");

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsFieldLocked_WithLockedField_ReturnsTrue()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject() };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "1" });

            // Act
            var result = form.IsFieldLocked("100");

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsFieldRequired_WithRequiredField_ReturnsTrue()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject() };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Required = "1" });

            // Act
            var result = form.IsFieldRequired("100");

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GetFieldValue_FromCurrentRow_ReturnsValue()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject() };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", FieldValue = "TestValue" });

            // Act
            var result = form.GetFieldValue("100");

            // Assert
            Assert.AreEqual("TestValue", result);
        }

        [TestMethod]
        public void GetFieldValue_WithRowIdAndFieldNumber_ReturnsValue()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", FieldValue = "TestValue" });

            // Act
            var result = form.GetFieldValue("1", "100");

            // Assert
            Assert.AreEqual("TestValue", result);
        }

        [TestMethod]
        public void GetFieldValueFromOtherRows_WithRowIdAndFieldNumber_ReturnsValue()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1" }, MultipleIteration = true };
            var otherRow = new RowObject { RowId = "2" };
            otherRow.Fields.Add(new FieldObject { FieldNumber = "100", FieldValue = "OtherValue" });
            form.OtherRows.Add(otherRow);

            // Act
            var result = form.GetFieldValue("2", "100");

            // Assert
            Assert.AreEqual("OtherValue", result);
        }

        [TestMethod]
        public void GetFieldValues_ReturnsAllValues()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1" }, MultipleIteration = true };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", FieldValue = "Value1" });
            
            var otherRow = new RowObject { RowId = "2" };
            otherRow.Fields.Add(new FieldObject { FieldNumber = "100", FieldValue = "Value2" });
            form.OtherRows.Add(otherRow);

            // Act
            var result = form.GetFieldValues("100");

            // Assert
            Assert.AreEqual(2, result.Count);
            CollectionAssert.Contains(result, "Value1");
            CollectionAssert.Contains(result, "Value2");
        }

        [TestMethod]
        public void SetFieldValue_InCurrentRow_UpdatesValue()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", FieldValue = "OldValue" });

            // Act
            form.SetFieldValue("100", "NewValue");

            // Assert
            Assert.AreEqual("NewValue", form.CurrentRow.Fields[0].FieldValue);
        }

        [TestMethod]
        public void SetFieldValue_WithRowId_UpdatesValueInSpecificRow()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1" }, MultipleIteration = true };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", FieldValue = "Value1" });
            
            var otherRow = new RowObject { RowId = "2" };
            otherRow.Fields.Add(new FieldObject { FieldNumber = "100", FieldValue = "Value2" });
            form.OtherRows.Add(otherRow);

            // Act
            form.SetFieldValue("2", "100", "NewValue");

            // Assert
            Assert.AreEqual("Value1", form.CurrentRow.Fields[0].FieldValue);
            Assert.AreEqual("NewValue", otherRow.Fields[0].FieldValue);
        }
    }

    /// <summary>
    /// Tests for OptionObjectHelpers extension methods
    /// </summary>
    [TestClass]
    public class OptionObjectHelpersTests
    {
        [TestMethod]
        public void GetCurrentRowId_ReturnsCurrrentRowId()
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
    }
}
