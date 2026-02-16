namespace RarelySimple.AvatarScriptLink.Objects.Helpers.Tests
{
    [TestClass]
    public class FieldObjectManipulatorsTests
    {
        [TestMethod]
        public void Enable_EnablesField()
        {
            // Arrange
            var field = new FieldObject { Enabled = "0" };

            // Act
            FieldObject? result = field.Enable();

            // Assert
            Assert.AreSame(field, result);
            Assert.AreEqual("1", field.Enabled);
        }

        [TestMethod]
        public void Disable_DisablesField()
        {
            // Arrange
            var field = new FieldObject { Enabled = "1" };

            // Act
            FieldObject? result = field.Disable();

            // Assert
            Assert.AreSame(field, result);
            Assert.AreEqual("0", field.Enabled);
        }

        [TestMethod]
        public void Lock_LocksField()
        {
            // Arrange
            var field = new FieldObject { Lock = "0" };

            // Act
            FieldObject? result = field.Lock();

            // Assert
            Assert.AreSame(field, result);
            Assert.AreEqual("1", field.Lock);
        }

        [TestMethod]
        public void Unlock_UnlocksField()
        {
            // Arrange
            var field = new FieldObject { Lock = "1" };

            // Act
            FieldObject? result = field.Unlock();

            // Assert
            Assert.AreSame(field, result);
            Assert.AreEqual("0", field.Lock);
        }

        [TestMethod]
        public void MarkRequired_MarksFieldRequired()
        {
            // Arrange
            var field = new FieldObject { Required = "0" };

            // Act
            FieldObject? result = field.MarkRequired();

            // Assert
            Assert.AreSame(field, result);
            Assert.AreEqual("1", field.Required);
        }

        [TestMethod]
        public void MarkOptional_MarksFieldOptional()
        {
            // Arrange
            var field = new FieldObject { Required = "1" };

            // Act
            FieldObject? result = field.MarkOptional();

            // Assert
            Assert.AreSame(field, result);
            Assert.AreEqual("0", field.Required);
        }

        [TestMethod]
        public void ChainedManipulations_WorkCorrectly()
        {
            // Arrange
            var field = new FieldObject { Enabled = "0", Lock = "0", Required = "0" };

            // Act
            field.Enable().Lock().MarkRequired();

            // Assert
            Assert.AreEqual("1", field.Enabled);
            Assert.AreEqual("1", field.Lock);
            Assert.AreEqual("1", field.Required);
        }
    }

    [TestClass]
    public class RowObjectManipulatorsTests
    {
        [TestMethod]
        public void MarkForAddition_SetsRowActionToAdd()
        {
            // Arrange
            var row = new RowObject();

            // Act
            RowObject? result = row.MarkForAddition();

            // Assert
            Assert.AreSame(row, result);
            Assert.AreEqual("ADD", row.RowAction);
        }

        [TestMethod]
        public void MarkForEdit_SetsRowActionToEdit()
        {
            // Arrange
            var row = new RowObject();

            // Act
            RowObject? result = row.MarkForEdit();

            // Assert
            Assert.AreSame(row, result);
            Assert.AreEqual("EDIT", row.RowAction);
        }

        [TestMethod]
        public void MarkForDeletion_SetsRowActionToDelete()
        {
            // Arrange
            var row = new RowObject();

            // Act
            RowObject? result = row.MarkForDeletion();

            // Assert
            Assert.AreSame(row, result);
            Assert.AreEqual("DELETE", row.RowAction);
        }

        [TestMethod]
        public void ClearRowAction_ClearsRowAction()
        {
            // Arrange
            var row = new RowObject { RowAction = "ADD" };

            // Act
            RowObject? result = row.ClearRowAction();

            // Assert
            Assert.AreSame(row, result);
            Assert.AreEqual(string.Empty, row.RowAction);
        }

        [TestMethod]
        public void DisableAllFields_DisablesAllFields()
        {
            // Arrange
            var row = new RowObject();
            var field1 = new FieldObject { FieldNumber = "001", Enabled = "1" };
            var field2 = new FieldObject { FieldNumber = "002", Enabled = "1" };
            row.Fields.Add(field1);
            row.Fields.Add(field2);

            // Act
            RowObject? result = row.DisableAllFields();

            // Assert
            Assert.AreSame(row, result);
            Assert.AreEqual("0", field1.Enabled);
            Assert.AreEqual("0", field2.Enabled);
        }

        [TestMethod]
        public void DisableAllFields_WithNullFields_DoesNotThrow()
        {
            // Arrange
            var row = new RowObject();

            // Act
            RowObject? result = row.DisableAllFields();

            // Assert
            Assert.AreSame(row, result);
        }

        [TestMethod]
        public void EnableAllFields_EnablesAllFields()
        {
            // Arrange
            var row = new RowObject();
            var field1 = new FieldObject { FieldNumber = "001", Enabled = "0" };
            var field2 = new FieldObject { FieldNumber = "002", Enabled = "0" };
            row.Fields.Add(field1);
            row.Fields.Add(field2);

            // Act
            RowObject? result = row.EnableAllFields();

            // Assert
            Assert.AreSame(row, result);
            Assert.AreEqual("1", field1.Enabled);
            Assert.AreEqual("1", field2.Enabled);
        }

        [TestMethod]
        public void LockAllFields_LocksAllFields()
        {
            // Arrange
            var row = new RowObject();
            var field1 = new FieldObject { FieldNumber = "001", Lock = "0" };
            var field2 = new FieldObject { FieldNumber = "002", Lock = "0" };
            row.Fields.Add(field1);
            row.Fields.Add(field2);

            // Act
            RowObject? result = row.LockAllFields();

            // Assert
            Assert.AreSame(row, result);
            Assert.AreEqual("1", field1.Lock);
            Assert.AreEqual("1", field2.Lock);
        }

        [TestMethod]
        public void UnlockAllFields_UnlocksAllFields()
        {
            // Arrange
            var row = new RowObject();
            var field1 = new FieldObject { FieldNumber = "001", Lock = "1" };
            var field2 = new FieldObject { FieldNumber = "002", Lock = "1" };
            row.Fields.Add(field1);
            row.Fields.Add(field2);

            // Act
            RowObject? result = row.UnlockAllFields();

            // Assert
            Assert.AreSame(row, result);
            Assert.AreEqual("0", field1.Lock);
            Assert.AreEqual("0", field2.Lock);
        }
    }

    [TestClass]
    public class FieldObjectValidatorsTests
    {
        [TestMethod]
        public void HasValue_WithValue_ReturnsTrue()
        {
            // Arrange
            var field = new FieldObject { FieldValue = "Test" };

            // Act
            bool result = field.HasValue();

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void HasValue_WithEmpty_ReturnsFalse()
        {
            // Arrange
            var field = new FieldObject { FieldValue = "" };

            // Act
            bool result = field.HasValue();

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void HasValue_WithNull_ReturnsFalse()
        {
            // Arrange
            var field = new FieldObject { FieldValue = null };

            // Act
            bool result = field.HasValue();

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsEmpty_WithEmptyValue_ReturnsTrue()
        {
            // Arrange
            var field = new FieldObject { FieldValue = "" };

            // Act
            bool result = field.IsEmpty();

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsEmpty_WithValue_ReturnsFalse()
        {
            // Arrange
            var field = new FieldObject { FieldValue = "Test" };

            // Act
            bool result = field.IsEmpty();

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValueEquals_WithMatchingValue_ReturnsTrue()
        {
            // Arrange
            var field = new FieldObject { FieldValue = "Test" };

            // Act
            bool result = field.ValueEquals("Test");

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValueEquals_WithNonMatchingValue_ReturnsFalse()
        {
            // Arrange
            var field = new FieldObject { FieldValue = "Test" };

            // Act
            bool result = field.ValueEquals("Other");

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValueEqualsIgnoreCase_WithMatchingValue_ReturnsTrue()
        {
            // Arrange
            var field = new FieldObject { FieldValue = "Test" };

            // Act
            bool result = field.ValueEqualsIgnoreCase("test");

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValueContains_WithContainedSubstring_ReturnsTrue()
        {
            // Arrange
            var field = new FieldObject { FieldValue = "Test Value" };

            // Act
            bool result = field.ValueContains("Value");

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValueContains_WithNonContainedSubstring_ReturnsFalse()
        {
            // Arrange
            var field = new FieldObject { FieldValue = "Test" };

            // Act
            bool result = field.ValueContains("Other");

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValueStartsWith_WithMatchingPrefix_ReturnsTrue()
        {
            // Arrange
            var field = new FieldObject { FieldValue = "TestValue" };

            // Act
            bool result = field.ValueStartsWith("Test");

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValueEndsWith_WithMatchingSuffix_ReturnsTrue()
        {
            // Arrange
            var field = new FieldObject { FieldValue = "TestValue" };

            // Act
            bool result = field.ValueEndsWith("Value");

            // Assert
            Assert.IsTrue(result);
        }
    }

    [TestClass]
    public class FormObjectValidatorsTests
    {
        [TestMethod]
        public void HasField_WithFieldPresent_ReturnsTrue()
        {
            // Arrange
            var form = new FormObject();
            var row = new RowObject();
            var field = new FieldObject { FieldNumber = "001" };
            row.Fields.Add(field);
            form.CurrentRow = row;

            // Act
            bool result = form.HasField("001");

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void HasField_WithFieldAbsent_ReturnsFalse()
        {
            // Arrange
            var form = new FormObject();
            var row = new RowObject();
            var field = new FieldObject { FieldNumber = "001" };
            row.Fields.Add(field);
            form.CurrentRow = row;

            // Act
            bool result = form.HasField("002");

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void HasField_WithNoCurrentRow_ReturnsFalse()
        {
            // Arrange
            var form = new FormObject();

            // Act
            bool result = form.HasField("001");

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void HasAnyRows_WithCurrentRow_ReturnsTrue()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject() };

            // Act
            bool result = form.HasAnyRows();

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void HasAnyRows_WithOtherRows_ReturnsTrue()
        {
            // Arrange
            var form = new FormObject();
            form.OtherRows.Add(new RowObject());

            // Act
            bool result = form.HasAnyRows();

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void HasAnyRows_WithNoRows_ReturnsFalse()
        {
            // Arrange
            var form = new FormObject();

            // Act
            bool result = form.HasAnyRows();

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsEmpty_WithNoRows_ReturnsTrue()
        {
            // Arrange
            var form = new FormObject();

            // Act
            bool result = form.IsEmpty();

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsEmpty_WithRows_ReturnsFalse()
        {
            // Arrange
            var form = new FormObject { CurrentRow = new RowObject() };

            // Act
            bool result = form.IsEmpty();

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void GetTotalFieldCount_WithMultipleRows_ReturnsTotalCount()
        {
            // Arrange
            var form = new FormObject();
            var row1 = new RowObject();
            row1.Fields.Add(new FieldObject());
            row1.Fields.Add(new FieldObject());
            
            var row2 = new RowObject();
            row2.Fields.Add(new FieldObject());
            
            form.CurrentRow = row1;
            form.OtherRows.Add(row2);

            // Act
            int result = form.GetTotalFieldCount();

            // Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void GetTotalFieldCount_WithEmptyForm_ReturnsZero()
        {
            // Arrange
            var form = new FormObject();

            // Act
            int result = form.GetTotalFieldCount();

            // Assert
            Assert.AreEqual(0, result);
        }
    }
}
