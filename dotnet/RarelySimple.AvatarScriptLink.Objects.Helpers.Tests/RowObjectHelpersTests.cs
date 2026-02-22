namespace RarelySimple.AvatarScriptLink.Objects.Helpers.Tests
{

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
        public void DisableAllFieldObjects_WithNullRowAction_SetsRowActionToEdit()
        {
            // Arrange
            var row = new RowObject { RowAction = null! };
            var field = new FieldObject { FieldNumber = "100", Enabled = "1" };
            row.Fields.Add(field);

            // Act
            row.DisableAllFieldObjects();

            // Assert
            Assert.AreEqual("0", field.Enabled);
            Assert.AreEqual(RowObject.RowActions.Edit, row.RowAction);
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
        public void SetDisabledField_WithExistingField_DisablesTargetField()
        {
            // Arrange
            var row = new RowObject { RowAction = "" };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });
            row.Fields.Add(new FieldObject { FieldNumber = "101", Enabled = "1" });

            // Act
            row.SetDisabledField("101");

            // Assert
            Assert.AreEqual("1", row.Fields[0].Enabled);
            Assert.AreEqual("0", row.Fields[1].Enabled);
            Assert.AreEqual("EDIT", row.RowAction);
        }

        [TestMethod]
        public void SetDisabledField_WithNullRowAction_SetsRowActionToEdit()
        {
            // Arrange
            var row = new RowObject { RowAction = null! };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });

            // Act
            row.SetDisabledField("100");

            // Assert
            Assert.AreEqual("0", row.Fields[0].Enabled);
            Assert.AreEqual(RowObject.RowActions.Edit, row.RowAction);
        }

        [TestMethod]
        public void SetDisabledFields_WithFieldNumbers_DisablesMatchingFields()
        {
            // Arrange
            var row = new RowObject();
            row.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });
            row.Fields.Add(new FieldObject { FieldNumber = "101", Enabled = "1" });

            // Act
            row.SetDisabledFields(["100"]);

            // Assert
            Assert.AreEqual("0", row.Fields[0].Enabled);
            Assert.AreEqual("1", row.Fields[1].Enabled);
        }

        [TestMethod]
        public void SetEnabledField_WithExistingField_EnablesTargetField()
        {
            // Arrange
            var row = new RowObject { RowAction = "" };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "0" });
            row.Fields.Add(new FieldObject { FieldNumber = "101", Enabled = "0" });

            // Act
            row.SetEnabledField("100");

            // Assert
            Assert.AreEqual("1", row.Fields[0].Enabled);
            Assert.AreEqual("0", row.Fields[1].Enabled);
            Assert.AreEqual("EDIT", row.RowAction);
        }

        [TestMethod]
        public void SetEnabledField_WithNullRowAction_SetsRowActionToEdit()
        {
            // Arrange
            var row = new RowObject { RowAction = null! };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "0" });

            // Act
            row.SetEnabledField("100");

            // Assert
            Assert.AreEqual("1", row.Fields[0].Enabled);
            Assert.AreEqual(RowObject.RowActions.Edit, row.RowAction);
        }

        [TestMethod]
        public void SetDisabledField_WithAddRowAction_PreservesAdd()
        {
            // Arrange
            var row = new RowObject { RowAction = RowObject.RowActions.Add };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });

            // Act
            row.SetDisabledField("100");

            // Assert
            Assert.AreEqual("0", row.Fields[0].Enabled);
            Assert.AreEqual(RowObject.RowActions.Add, row.RowAction);
        }

        [TestMethod]
        public void SetDisabledField_WithDeleteRowAction_PreservesDelete()
        {
            // Arrange
            var row = new RowObject { RowAction = RowObject.RowActions.Delete };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });

            // Act
            row.SetDisabledField("100");

            // Assert
            Assert.AreEqual("0", row.Fields[0].Enabled);
            Assert.AreEqual(RowObject.RowActions.Delete, row.RowAction);
        }

        [TestMethod]
        public void SetEnabledFields_WithFieldNumbers_EnablesMatchingFields()
        {
            // Arrange
            var row = new RowObject();
            row.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "0" });
            row.Fields.Add(new FieldObject { FieldNumber = "101", Enabled = "0" });

            // Act
            row.SetEnabledFields(["101"]);

            // Assert
            Assert.AreEqual("0", row.Fields[0].Enabled);
            Assert.AreEqual("1", row.Fields[1].Enabled);
        }

        [TestMethod]
        public void SetEnabledFields_WithDeleteRowAction_PreservesDelete()
        {
            // Arrange
            var row = new RowObject { RowAction = RowObject.RowActions.Delete };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "0" });

            // Act
            row.SetEnabledFields(["100"]);

            // Assert
            Assert.AreEqual("1", row.Fields[0].Enabled);
            Assert.AreEqual(RowObject.RowActions.Delete, row.RowAction);
        }

        [TestMethod]
        public void SetEnabledFields_WithAddRowAction_PreservesAdd()
        {
            // Arrange
            var row = new RowObject { RowAction = RowObject.RowActions.Add };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "0" });

            // Act
            row.SetEnabledFields(["100"]);

            // Assert
            Assert.AreEqual("1", row.Fields[0].Enabled);
            Assert.AreEqual(RowObject.RowActions.Add, row.RowAction);
        }

        [TestMethod]
        public void SetDisabledField_WithMissingField_DoesNotChangeRow()
        {
            // Arrange
            var row = new RowObject { RowAction = "" };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });

            // Act
            row.SetDisabledField("999");

            // Assert
            Assert.AreEqual("1", row.Fields[0].Enabled);
            Assert.AreEqual("", row.RowAction);
        }

        [TestMethod]
        public void SetDisabledField_WhenAlreadyDisabled_DoesNotSetRowAction()
        {
            // Arrange
            var row = new RowObject { RowAction = "" };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "0" });

            // Act
            row.SetDisabledField("100");

            // Assert
            Assert.AreEqual("0", row.Fields[0].Enabled);
            Assert.AreEqual("", row.RowAction);
        }

        [TestMethod]
        public void SetDisabledFields_WhenAllAlreadyDisabled_DoesNotSetRowAction()
        {
            // Arrange
            var row = new RowObject { RowAction = "" };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "0" });
            row.Fields.Add(new FieldObject { FieldNumber = "101", Enabled = "0" });

            // Act
            row.SetDisabledFields(["100", "101"]);

            // Assert
            Assert.AreEqual("0", row.Fields[0].Enabled);
            Assert.AreEqual("0", row.Fields[1].Enabled);
            Assert.AreEqual("", row.RowAction);
        }

        [TestMethod]
        public void SetEnabledFields_WithEmptyFieldNumbers_DoesNotChangeRow()
        {
            // Arrange
            var row = new RowObject { RowAction = "" };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "0" });

            // Act
            row.SetEnabledFields(new List<string>());

            // Assert
            Assert.AreEqual("0", row.Fields[0].Enabled);
            Assert.AreEqual("", row.RowAction);
        }

        [TestMethod]
        public void SetEnabledField_WhenAlreadyEnabled_DoesNotSetRowAction()
        {
            // Arrange
            var row = new RowObject { RowAction = "" };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });

            // Act
            row.SetEnabledField("100");

            // Assert
            Assert.AreEqual("1", row.Fields[0].Enabled);
            Assert.AreEqual("", row.RowAction);
        }

        [TestMethod]
        public void SetEnabledFields_WhenAllAlreadyEnabled_DoesNotSetRowAction()
        {
            // Arrange
            var row = new RowObject { RowAction = "" };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });
            row.Fields.Add(new FieldObject { FieldNumber = "101", Enabled = "1" });

            // Act
            row.SetEnabledFields(["100", "101"]);

            // Assert
            Assert.AreEqual("1", row.Fields[0].Enabled);
            Assert.AreEqual("1", row.Fields[1].Enabled);
            Assert.AreEqual("", row.RowAction);
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
            Assert.AreEqual(RowObject.RowActions.Edit, row.RowAction);
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
            Assert.AreEqual(RowObject.RowActions.Edit, row.RowAction);
        }

        [TestMethod]
        public void EnableAllFieldObjects_WithNoFields_DoesNotSetRowAction()
        {
            // Arrange
            var row = new RowObject { RowAction = "" };

            // Act
            row.EnableAllFieldObjects();

            // Assert
            Assert.AreEqual("", row.RowAction);
        }

        [TestMethod]
        public void EnableAllFieldObjects_WithAllExcluded_DoesNotSetRowAction()
        {
            // Arrange
            var row = new RowObject { RowAction = "" };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "0" });

            // Act
            row.EnableAllFieldObjects(new List<string> { "100" });

            // Assert
            Assert.AreEqual("0", row.Fields[0].Enabled);
            Assert.AreEqual("", row.RowAction);
        }

        [TestMethod]
        public void EnableAllFieldObjects_WhenAlreadyEnabled_DoesNotSetRowAction()
        {
            // Arrange
            var row = new RowObject { RowAction = "" };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "1" });

            // Act
            row.EnableAllFieldObjects();

            // Assert
            Assert.AreEqual("1", row.Fields[0].Enabled);
            Assert.AreEqual("", row.RowAction);
        }

        [TestMethod]
        public void EnableAllFieldObjects_WithNullRowAction_AndChanges_SetsRowActionToEdit()
        {
            // Arrange
            var row = new RowObject { RowAction = null! };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Enabled = "0" });

            // Act
            row.EnableAllFieldObjects();

            // Assert
            Assert.AreEqual("1", row.Fields[0].Enabled);
            Assert.AreEqual(RowObject.RowActions.Edit, row.RowAction);
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
            Assert.AreEqual(RowObject.RowActions.Edit, row.RowAction);
        }

        [TestMethod]
        public void LockAllFieldObjects_WithNoFields_DoesNotSetRowAction()
        {
            // Arrange
            var row = new RowObject { RowAction = "" };

            // Act
            row.LockAllFieldObjects();

            // Assert
            Assert.AreEqual("", row.RowAction);
        }

        [TestMethod]
        public void LockAllFieldObjects_WithAllExcluded_DoesNotSetRowAction()
        {
            // Arrange
            var row = new RowObject { RowAction = "" };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "0" });

            // Act
            row.LockAllFieldObjects(new List<string> { "100" });

            // Assert
            Assert.AreEqual("0", row.Fields[0].Lock);
            Assert.AreEqual("", row.RowAction);
        }

        [TestMethod]
        public void LockAllFieldObjects_WhenAlreadyLocked_DoesNotSetRowAction()
        {
            // Arrange
            var row = new RowObject { RowAction = "" };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "1" });

            // Act
            row.LockAllFieldObjects();

            // Assert
            Assert.AreEqual("1", row.Fields[0].Lock);
            Assert.AreEqual("", row.RowAction);
        }

        [TestMethod]
        public void LockAllFieldObjects_WithNullRowAction_AndChanges_SetsRowActionToEdit()
        {
            // Arrange
            var row = new RowObject { RowAction = null! };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "0" });

            // Act
            row.LockAllFieldObjects();

            // Assert
            Assert.AreEqual("1", row.Fields[0].Lock);
            Assert.AreEqual(RowObject.RowActions.Edit, row.RowAction);
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
            Assert.AreEqual(RowObject.RowActions.Edit, row.RowAction);
        }

        [TestMethod]
        public void UnlockAllFieldObjects_WithNoFields_DoesNotSetRowAction()
        {
            // Arrange
            var row = new RowObject { RowAction = "" };

            // Act
            row.UnlockAllFieldObjects();

            // Assert
            Assert.AreEqual("", row.RowAction);
        }

        [TestMethod]
        public void UnlockAllFieldObjects_WithAllExcluded_DoesNotSetRowAction()
        {
            // Arrange
            var row = new RowObject { RowAction = "" };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "1" });

            // Act
            row.UnlockAllFieldObjects(new List<string> { "100" });

            // Assert
            Assert.AreEqual("1", row.Fields[0].Lock);
            Assert.AreEqual("", row.RowAction);
        }

        [TestMethod]
        public void UnlockAllFieldObjects_WhenAlreadyUnlocked_DoesNotSetRowAction()
        {
            // Arrange
            var row = new RowObject { RowAction = "" };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "0" });

            // Act
            row.UnlockAllFieldObjects();

            // Assert
            Assert.AreEqual("0", row.Fields[0].Lock);
            Assert.AreEqual("", row.RowAction);
        }

        [TestMethod]
        public void UnlockAllFieldObjects_WithNullRowAction_AndChanges_SetsRowActionToEdit()
        {
            // Arrange
            var row = new RowObject { RowAction = null! };
            row.Fields.Add(new FieldObject { FieldNumber = "100", Lock = "1" });

            // Act
            row.UnlockAllFieldObjects();

            // Assert
            Assert.AreEqual("0", row.Fields[0].Lock);
            Assert.AreEqual(RowObject.RowActions.Edit, row.RowAction);
        }
    }

}
