namespace RarelySimple.AvatarScriptLink.Objects.Helpers.Tests
{

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

        [TestMethod]
        public void SetDisabledField_WithMultipleIteration_DisablesFieldInAllRows()
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
        public void SetEnabledFields_WithMultipleIteration_EnablesMatchingFieldsInAllRows()
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
        public void SetDisabledField_WithEmptyFieldNumber_DoesNotChangeForm()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1", RowAction = "" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });

            // Act
            form.SetDisabledField(string.Empty);

            // Assert
            Assert.AreEqual("1", form.CurrentRow.Fields[0].Enabled);
            Assert.AreEqual("", form.CurrentRow.RowAction);
        }

        [TestMethod]
        public void SetEnabledFields_WithNullFieldNumbers_DoesNotChangeForm()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1", RowAction = "" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "0" });

            // Act
            form.SetEnabledFields(null);

            // Assert
            Assert.AreEqual("0", form.CurrentRow.Fields[0].Enabled);
            Assert.AreEqual("", form.CurrentRow.RowAction);
        }

        [TestMethod]
        public void SetDisabledField_WithNullCurrentRow_ReturnsOriginalForm()
        {
            // Arrange
            var form = new FormObject { CurrentRow = null! };

            // Act
            var result = form.SetDisabledField("100");

            // Assert
            Assert.AreSame(form, result);
        }

        [TestMethod]
        public void SetEnabledField_WithEmptyFieldNumber_DoesNotChangeForm()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject { RowId = "1", RowAction = "" } };
            form.CurrentRow.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "0" });

            // Act
            form.SetEnabledField(string.Empty);

            // Assert
            Assert.AreEqual("0", form.CurrentRow.Fields[0].Enabled);
            Assert.AreEqual("", form.CurrentRow.RowAction);
        }

        [TestMethod]
        public void SetDisabledFields_WithMultipleIterationFalse_DoesNotModifyOtherRows()
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
    }

}
