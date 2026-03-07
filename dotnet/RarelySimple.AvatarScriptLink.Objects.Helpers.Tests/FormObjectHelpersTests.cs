namespace RarelySimple.AvatarScriptLink.Objects.Helpers.Tests
{

    /// <summary>
    /// Tests for FormObjectHelpers extension methods
    /// </summary>
    [TestClass]
    public class FormObjectHelpersTests
    {
        [DataTestMethod]
        [DataRow("Disabled")]
        [DataRow("Enabled")]
        [DataRow("Locked")]
        [DataRow("Unlocked")]
        public void SetField_FormObject_WithNullFieldNumber_ThrowsArgumentNullException(string operation)
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1", RowAction = string.Empty } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1", Lock = "0" });

            // Act
            Action act = operation switch
            {
                "Disabled" => () => form.SetDisabledField(null!),
                "Enabled" => () => form.SetEnabledField(null!),
                "Locked" => () => form.SetLockedField(null!),
                "Unlocked" => () => form.SetUnlockedField(null!),
                _ => throw new ArgumentOutOfRangeException(nameof(operation))
            };

            // Assert
            Assert.ThrowsException<ArgumentNullException>(act);
        }

        [DataTestMethod]
        [DataRow("Disabled")]
        [DataRow("Enabled")]
        [DataRow("Locked")]
        [DataRow("Unlocked")]
        public void SetField_FormObject_WithEmptyFieldNumber_ThrowsArgumentException(string operation)
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1", RowAction = string.Empty } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1", Lock = "0" });

            // Act
            Action act = operation switch
            {
                "Disabled" => () => form.SetDisabledField(string.Empty),
                "Enabled" => () => form.SetEnabledField(string.Empty),
                "Locked" => () => form.SetLockedField(string.Empty),
                "Unlocked" => () => form.SetUnlockedField(string.Empty),
                _ => throw new ArgumentOutOfRangeException(nameof(operation))
            };

            // Assert
            Assert.ThrowsException<ArgumentException>(act);
        }

        [TestMethod]
        public void IsRowPresent_FormObject_WithCurrentRow_ReturnsTrue()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1" } };

            // Act
            var result = form.IsRowPresent("1");

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsRowPresent_FormObject_WithOtherRow_ReturnsTrue()
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
        public void IsRowPresent_FormObject_WithAbsentRow_ReturnsFalse()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1" } };

            // Act
            var result = form.IsRowPresent("999");

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsRowMarkedForDeletion_FormObject_WithDeletedRow_ReturnsTrue()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1", RowAction = "DELETE" } };

            // Act
            var result = form.IsRowMarkedForDeletion("1");

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsRowMarkedForDeletion_FormObject_WithNormalRow_ReturnsFalse()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1", RowAction = "EDIT" } };

            // Act
            var result = form.IsRowMarkedForDeletion("1");

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsFieldPresent_FormObject_InCurrentRow_ReturnsTrue()
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
        public void IsFieldEnabled_FormObject_WithEnabledField_ReturnsTrue()
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
        public void IsFieldLocked_FormObject_WithLockedField_ReturnsTrue()
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
        public void IsFieldRequired_FormObject_WithRequiredField_ReturnsTrue()
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
        public void GetFieldValue_FormObject_FromCurrentRow_ReturnsValue()
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
        public void GetFieldValue_FormObject_WithRowIdAndFieldNumber_ReturnsValue()
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
        public void GetFieldValueFromOtherRows_FormObject_WithRowIdAndFieldNumber_ReturnsValue()
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
        public void GetFieldValues_FormObject_ReturnsAllValues()
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
        public void SetFieldValue_FormObject_InCurrentRow_UpdatesValue()
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
        public void SetFieldValue_FormObject_WithRowId_UpdatesValueInSpecificRow()
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

        [TestMethod]
        public void SetDisabledField_FormObject_WithMultipleIteration_DisablesFieldInAllRows()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1", RowAction = "" }, MultipleIteration = true };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });
            var otherRow = new RowObject { RowId = "2", RowAction = "" };
            otherRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });
            form.OtherRows.Add(otherRow);

            // Act
            form.SetDisabledField("100");

            // Assert
            Assert.AreEqual("0", form.CurrentRow.Fields[0].Enabled);
            Assert.AreEqual("0", otherRow.Fields[0].Enabled);
            Assert.AreEqual("EDIT", form.CurrentRow.RowAction);
            Assert.AreEqual("EDIT", otherRow.RowAction);
        }

        [TestMethod]
        public void SetEnabledFields_FormObject_WithMultipleIteration_EnablesMatchingFieldsInAllRows()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1" }, MultipleIteration = true };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "0" });
            var otherRow = new RowObject { RowId = "2" };
            otherRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "0" });
            form.OtherRows.Add(otherRow);

            // Act
            form.SetEnabledFields(new List<string> { "100" });

            // Assert
            Assert.AreEqual("1", form.CurrentRow.Fields[0].Enabled);
            Assert.AreEqual("1", otherRow.Fields[0].Enabled);
        }

        [TestMethod]
        public void SetDisabledField_FormObject_WithEmptyFieldNumber_ThrowsArgumentException()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1", RowAction = "" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });

            // Act/Assert
            Assert.ThrowsException<ArgumentException>(() => form.SetDisabledField(string.Empty));
        }

        [TestMethod]
        public void SetEnabledFields_FormObject_WithNullFieldNumbers_ThrowsArgumentNullException()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1", RowAction = "" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "0" });

            // Act/Assert
            Assert.ThrowsException<ArgumentNullException>(() => form.SetEnabledFields(null));
        }

        [TestMethod]
        public void SetDisabledField_FormObject_WithNullCurrentRow_ReturnsOriginalForm()
        {
            // Arrange
            var form = new FormObject { CurrentRow = null! };

            // Act
            var result = form.SetDisabledField("100");

            // Assert
            Assert.AreSame(form, result);
        }

        [TestMethod]
        public void SetEnabledField_FormObject_WithEmptyFieldNumber_ThrowsArgumentException()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1", RowAction = "" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "0" });

            // Act/Assert
            Assert.ThrowsException<ArgumentException>(() => form.SetEnabledField(string.Empty));
        }

        [TestMethod]
        public void SetDisabledFields_FormObject_WithMultipleIterationFalse_DoesNotModifyOtherRows()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1" }, MultipleIteration = false };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });

            var otherRow = new RowObject { RowId = "2" };
            otherRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });
            form.OtherRows.Add(otherRow);

            // Act
            form.SetDisabledFields(["100"]);

            // Assert
            Assert.AreEqual("0", form.CurrentRow.Fields[0].Enabled);
            Assert.AreEqual("1", otherRow.Fields[0].Enabled);
        }

        [TestMethod]
        public void SetLockedField_FormObject_WithMultipleIteration_LocksFieldInAllRows()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1", RowAction = "" }, MultipleIteration = true };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "0" });
            var otherRow = new RowObject { RowId = "2", RowAction = "" };
            otherRow.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "0" });
            form.OtherRows.Add(otherRow);

            // Act
            form.SetLockedField("100");

            // Assert
            Assert.AreEqual("1", form.CurrentRow.Fields[0].Lock);
            Assert.AreEqual("1", otherRow.Fields[0].Lock);
            Assert.AreEqual("EDIT", form.CurrentRow.RowAction);
            Assert.AreEqual("EDIT", otherRow.RowAction);
        }

        [TestMethod]
        public void SetUnlockedFields_FormObject_WithMultipleIteration_UnlocksMatchingFieldsInAllRows()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1" }, MultipleIteration = true };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "1" });
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "101", Lock = "1" });
            var otherRow = new RowObject { RowId = "2" };
            otherRow.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "1" });
            otherRow.Fields.Add(new FieldObject { FieldNumber = "101", Lock = "1" });
            form.OtherRows.Add(otherRow);

            // Act
            form.SetUnlockedFields(["101"]);

            // Assert
            Assert.AreEqual("1", form.CurrentRow.Fields[0].Lock);
            Assert.AreEqual("0", form.CurrentRow.Fields[1].Lock);
            Assert.AreEqual("1", otherRow.Fields[0].Lock);
            Assert.AreEqual("0", otherRow.Fields[1].Lock);
        }

        [TestMethod]
        public void SetLockedField_FormObject_WithEmptyFieldNumber_ThrowsArgumentException()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1", RowAction = "" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "0" });

            // Act / Assert
            Assert.ThrowsException<ArgumentException>(() => form.SetLockedField(string.Empty));
        }

        [TestMethod]
        public void SetUnlockedField_FormObject_WithNullCurrentRow_ReturnsOriginalForm()
        {
            // Arrange
            var form = new FormObject { CurrentRow = null! };

            // Act
            var result = form.SetUnlockedField("100");

            // Assert
            Assert.AreSame(form, result);
        }

        [TestMethod]
        public void SetLockedFields_FormObject_WithNullFieldNumbers_ThrowsArgumentNullException()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1", RowAction = "" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "0" });

            // Act / Assert
            Assert.ThrowsException<ArgumentNullException>(() => form.SetLockedFields(null));
        }

        [TestMethod]
        public void SetUnlockedFields_FormObject_WithMultipleIterationFalse_DoesNotModifyOtherRows()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1" }, MultipleIteration = false };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "1" });

            var otherRow = new RowObject { RowId = "2" };
            otherRow.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "1" });
            form.OtherRows.Add(otherRow);

            // Act
            form.SetUnlockedFields(["100"]);

            // Assert
            Assert.AreEqual("0", form.CurrentRow.Fields[0].Lock);
            Assert.AreEqual("1", otherRow.Fields[0].Lock);
        }

        [TestMethod]
        public void SetLockedFields_FormObject_WithDuplicateFieldNumbers_LocksFieldInCurrentAndOtherRows()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1", RowAction = "" }, MultipleIteration = true };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "0" });
            var otherRow = new RowObject { RowId = "2", RowAction = "" };
            otherRow.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "0" });
            form.OtherRows.Add(otherRow);

            // Act
            form.SetLockedFields(["100", "100"]);

            // Assert
            Assert.AreEqual("1", form.CurrentRow.Fields[0].Lock);
            Assert.AreEqual("1", otherRow.Fields[0].Lock);
            Assert.AreEqual(RowObject.RowActions.Edit, form.CurrentRow.RowAction);
            Assert.AreEqual(RowObject.RowActions.Edit, otherRow.RowAction);
        }
    }

}
